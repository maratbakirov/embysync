using Microsoft.Extensions.Logging;
using System.Net.WebSockets;

namespace NetNewClient;

public partial class Form1 : Form
{
    private System.Windows.Forms.Label? labelServerUrl;
    private System.Windows.Forms.TextBox? textBoxServerUrl;
    private System.Windows.Forms.Label? labelApiKey;
    private System.Windows.Forms.TextBox? textBoxApiKey;
    private System.Windows.Forms.Button? buttonConnect;
    private System.Windows.Forms.ListBox? listBoxStrings;

    private EmbyApiClient? _embyApiClient = null;
    private TextBoxLogger logger;
    private ClientWebSocket _webSocket;
    private CancellationTokenSource _webSocketCts;

    private EmbyApiClient EmbyApiClient
    {
        get
        {
            if (_embyApiClient == null)
            {
                var baseUrl = textBoxServerUrl?.Text ?? string.Empty;
                var apiKey = textBoxApiKey?.Text ?? string.Empty;
                this._embyApiClient = new EmbyApiClient(baseUrl, apiKey);

                this.textBoxServerUrl.Enabled = false;
                this.textBoxApiKey.Enabled = false;
            }
            return this._embyApiClient;
        }
    }

    public Form1()
    {
        InitializeComponent();
        logger = new TextBoxLogger(textBox1, "Form1");
        // Load last used Server URL from temp file
        var tempPath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "NetNewClient_LastServerUrl.txt");
        if (System.IO.File.Exists(tempPath))
        {
            var lastUrl = System.IO.File.ReadAllText(tempPath);
            if (!string.IsNullOrWhiteSpace(lastUrl) && textBoxServerUrl != null)
                textBoxServerUrl.Text = lastUrl;
        }
    }

    private void buttonConnect_Click(object sender, EventArgs e)
    {
        try
        {
            // Save last used Server URL to temp file
            if (textBoxServerUrl != null)
            {
                var tempPath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "NetNewClient_LastServerUrl.txt");
                System.IO.File.WriteAllText(tempPath, textBoxServerUrl.Text ?? "");
            }

            // Build WebSocket URL
            var host = textBoxServerUrl?.Text?.TrimEnd('/') ?? string.Empty;
            host = host.Replace("http://", "ws://");
            host = host.Replace("https://", "wss://");
            var apiKey = textBoxApiKey?.Text ?? string.Empty;
            var deviceId = "1";
            var wsUrl = $"{host}?api_key={apiKey}&deviceId={deviceId}";

            logger.LogInformation($"Connecting to WebSocket: {host}");

            // Connect to WebSocket and add event handler
            this._webSocket = new System.Net.WebSockets.ClientWebSocket();
            var uri = new Uri(wsUrl);
            
            // Start a background task to handle incoming WebSocket messages
            this._webSocketCts = new CancellationTokenSource();
            Task.Run(async () => {
                var buffer = new byte[4096];
                try {
                    await _webSocket.ConnectAsync(uri, _webSocketCts.Token);
                    logger.LogInformation("WebSocket connection established.");
                    
                    while (_webSocket.State == System.Net.WebSockets.WebSocketState.Open && !_webSocketCts.Token.IsCancellationRequested)
                    {
                        var receiveBuffer = new ArraySegment<byte>(buffer);
                        var result = await _webSocket.ReceiveAsync(receiveBuffer, _webSocketCts.Token).ConfigureAwait(false);
                        
                        if (result.MessageType == System.Net.WebSockets.WebSocketMessageType.Close)
                        {
                            _webSocket
                            .CloseAsync(System.Net.WebSockets.WebSocketCloseStatus.NormalClosure, 
                                "Connection closed by the server", _webSocketCts.Token);
                            logger.LogInformation("WebSocket connection closed.");
                        }
                        else
                        {
                            var message = System.Text.Encoding.UTF8.GetString(buffer, 0, result.Count);
                            logger.LogInformation($"WebSocket message received: {message}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    logger.LogError($"WebSocket error: {ex.Message}");
                }
            }, _webSocketCts.Token);


            var systemInfo = EmbyApiClient.GetSystemInfoAsync().Result;
            logger.LogInformation("Connected to server successfully.");

            var sessions = EmbyApiClient.GetSessionsAsync2().Result;
            logger.LogInformation("Sessions parsed successfully.");

            listBox1.DataSource = sessions;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error connecting to server");
        }
    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
