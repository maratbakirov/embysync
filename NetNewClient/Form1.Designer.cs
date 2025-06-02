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
        ListViewItem listViewItem1 = new ListViewItem("");
        ListViewItem listViewItem2 = new ListViewItem("");
        labelServerUrl = new Label();
        textBoxServerUrl = new TextBox();
        labelApiKey = new Label();
        textBoxApiKey = new TextBox();
        buttonConnect = new Button();
        splitContainer1 = new SplitContainer();
        listView1 = new ListView();
        listBox1 = new ListBox();
        textBox1 = new TextBox();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        SuspendLayout();
        // 
        // labelServerUrl
        // 
        labelServerUrl.AutoSize = true;
        labelServerUrl.Location = new Point(30, 30);
        labelServerUrl.Name = "labelServerUrl";
        labelServerUrl.Size = new Size(63, 15);
        labelServerUrl.TabIndex = 0;
        labelServerUrl.Text = "Server URL";
        // 
        // textBoxServerUrl
        // 
        textBoxServerUrl.Location = new Point(120, 27);
        textBoxServerUrl.Name = "textBoxServerUrl";
        textBoxServerUrl.Size = new Size(300, 23);
        textBoxServerUrl.TabIndex = 1;
        // 
        // labelApiKey
        // 
        labelApiKey.AutoSize = true;
        labelApiKey.Location = new Point(30, 70);
        labelApiKey.Name = "labelApiKey";
        labelApiKey.Size = new Size(47, 15);
        labelApiKey.TabIndex = 2;
        labelApiKey.Text = "API Key";
        // 
        // textBoxApiKey
        // 
        textBoxApiKey.Location = new Point(120, 67);
        textBoxApiKey.Name = "textBoxApiKey";
        textBoxApiKey.Size = new Size(300, 23);
        textBoxApiKey.TabIndex = 3;
        // 
        // buttonConnect
        // 
        buttonConnect.Location = new Point(120, 100);
        buttonConnect.Name = "buttonConnect";
        buttonConnect.Size = new Size(100, 30);
        buttonConnect.TabIndex = 4;
        buttonConnect.Text = "Connect";
        buttonConnect.UseVisualStyleBackColor = true;
        buttonConnect.Click += buttonConnect_Click;
        // 
        // splitContainer1
        // 
        splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        splitContainer1.Location = new Point(4, 146);
        splitContainer1.Name = "splitContainer1";
        splitContainer1.Orientation = Orientation.Horizontal;
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(listView1);
        splitContainer1.Panel1.Controls.Add(listBox1);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(textBox1);
        splitContainer1.Size = new Size(646, 313);
        splitContainer1.SplitterDistance = 116;
        splitContainer1.TabIndex = 5;
        // 
        // listView1
        // 
        listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
        listView1.Location = new Point(224, 14);
        listView1.Name = "listView1";
        listView1.Size = new Size(123, 64);
        listView1.TabIndex = 1;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Items.AddRange(new object[] { "1", "2", "3", "4" });
        listBox1.Location = new Point(8, 14);
        listBox1.Name = "listBox1";
        listBox1.SelectionMode = SelectionMode.MultiExtended;
        listBox1.Size = new Size(141, 64);
        listBox1.TabIndex = 0;
        listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        // 
        // textBox1
        // 
        textBox1.Dock = DockStyle.Fill;
        textBox1.Location = new Point(0, 0);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.ScrollBars = ScrollBars.Vertical;
        textBox1.Size = new Size(646, 193);
        textBox1.TabIndex = 0;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(651, 464);
        Controls.Add(splitContainer1);
        Controls.Add(labelServerUrl);
        Controls.Add(textBoxServerUrl);
        Controls.Add(labelApiKey);
        Controls.Add(textBoxApiKey);
        Controls.Add(buttonConnect);
        Name = "Form1";
        Text = "NetNewClient";
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel2.ResumeLayout(false);
        splitContainer1.Panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private SplitContainer splitContainer1;
    private ListView listView1;
    private ListBox listBox1;
    private TextBox textBox1;
}
