using Microsoft.Extensions.Logging;

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

            // Connect to WebSocket (basic example)
            using (var ws = new System.Net.WebSockets.ClientWebSocket())
            {
                var uri = new Uri(wsUrl);
                var connectTask = ws.ConnectAsync(uri, System.Threading.CancellationToken.None);
                connectTask.Wait();
                if (ws.State == System.Net.WebSockets.WebSocketState.Open)
                {
                    logger.LogInformation("WebSocket connection established.");
                }
                else
                {
                    logger.LogError($"WebSocket connection failed. State: {ws.State}");
                }
            }

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
