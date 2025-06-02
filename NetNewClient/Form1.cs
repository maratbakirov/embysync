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

    private EmbyApiClient? embyApiClient;
    private TextBoxLogger logger;

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
            var baseUrl = textBoxServerUrl?.Text ?? string.Empty;
            var apiKey = textBoxApiKey?.Text ?? string.Empty;
            this.embyApiClient = new EmbyApiClient(baseUrl, apiKey);
            var systemInfo = embyApiClient.GetSystemInfoAsync().Result;
            logger.LogInformation("Connected to server successfully.");

            var sessions = embyApiClient.GetSessionsAsync().Result;
            logger.LogInformation("Sessions parsed successfully.");
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
