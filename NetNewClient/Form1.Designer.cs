namespace NetNewClient;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.labelServerUrl = new System.Windows.Forms.Label();
        this.textBoxServerUrl = new System.Windows.Forms.TextBox();
        this.labelApiKey = new System.Windows.Forms.Label();
        this.textBoxApiKey = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // labelServerUrl
        // 
        this.labelServerUrl.AutoSize = true;
        this.labelServerUrl.Location = new System.Drawing.Point(30, 30);
        this.labelServerUrl.Name = "labelServerUrl";
        this.labelServerUrl.Size = new System.Drawing.Size(70, 15);
        this.labelServerUrl.TabIndex = 0;
        this.labelServerUrl.Text = "Server URL";
        // 
        // textBoxServerUrl
        // 
        this.textBoxServerUrl.Location = new System.Drawing.Point(120, 27);
        this.textBoxServerUrl.Name = "textBoxServerUrl";
        this.textBoxServerUrl.Size = new System.Drawing.Size(300, 23);
        this.textBoxServerUrl.TabIndex = 1;
        // 
        // labelApiKey
        // 
        this.labelApiKey.AutoSize = true;
        this.labelApiKey.Location = new System.Drawing.Point(30, 70);
        this.labelApiKey.Name = "labelApiKey";
        this.labelApiKey.Size = new System.Drawing.Size(50, 15);
        this.labelApiKey.TabIndex = 2;
        this.labelApiKey.Text = "API Key";
        // 
        // textBoxApiKey
        // 
        this.textBoxApiKey.Location = new System.Drawing.Point(120, 67);
        this.textBoxApiKey.Name = "textBoxApiKey";
        this.textBoxApiKey.Size = new System.Drawing.Size(300, 23);
        this.textBoxApiKey.TabIndex = 3;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(480, 130);
        this.Controls.Add(this.labelServerUrl);
        this.Controls.Add(this.textBoxServerUrl);
        this.Controls.Add(this.labelApiKey);
        this.Controls.Add(this.textBoxApiKey);
        this.Name = "Form1";
        this.Text = "NetNewClient";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
}
