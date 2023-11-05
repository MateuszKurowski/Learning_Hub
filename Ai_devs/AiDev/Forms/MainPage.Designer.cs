using System.Windows.Forms;

namespace AiDev;

partial class MainPage
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
        panel1 = new Panel();
        books = new RadioButton();
        injection = new RadioButton();
        fixit = new RadioButton();
        getinfo = new RadioButton();
        category = new RadioButton();
        helloapi = new RadioButton();
        scraper = new RadioButton();
        blogger = new RadioButton();
        inprompt = new RadioButton();
        moderation = new RadioButton();
        tbApiKey = new TextBox();
        label1 = new Label();
        tbJson = new TextBox();
        tbTaskDescription = new TextBox();
        label2 = new Label();
        tbWebhookLink = new TextBox();
        label3 = new Label();
        label4 = new Label();
        btnDownloadTaskDescription = new Button();
        btnSendToWebhook = new Button();
        menuStrip1 = new MenuStrip();
        btnClose = new Button();
        btnSendBug = new Button();
        pageSetupDialog1 = new PageSetupDialog();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.Transparent;
        panel1.Controls.Add(books);
        panel1.Controls.Add(injection);
        panel1.Controls.Add(fixit);
        panel1.Controls.Add(getinfo);
        panel1.Controls.Add(category);
        panel1.Controls.Add(helloapi);
        panel1.Controls.Add(scraper);
        panel1.Controls.Add(blogger);
        panel1.Controls.Add(inprompt);
        panel1.Controls.Add(moderation);
        panel1.Location = new Point(467, 54);
        panel1.Name = "panel1";
        panel1.Size = new Size(178, 262);
        panel1.TabIndex = 0;
        // 
        // books
        // 
        books.AutoSize = true;
        books.BackColor = Color.Transparent;
        books.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        books.ForeColor = Color.FromArgb(9, 9, 9);
        books.Location = new Point(3, 79);
        books.Name = "books";
        books.Size = new Size(111, 19);
        books.TabIndex = 10;
        books.Text = "Dzień 2 (books)";
        books.UseVisualStyleBackColor = false;
        // 
        // injection
        // 
        injection.AutoSize = true;
        injection.BackColor = Color.Transparent;
        injection.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        injection.ForeColor = Color.FromArgb(9, 9, 9);
        injection.Location = new Point(3, 154);
        injection.Name = "injection";
        injection.Size = new Size(126, 19);
        injection.TabIndex = 9;
        injection.Text = "Dzień 4 (injection)";
        injection.UseVisualStyleBackColor = false;
        // 
        // fixit
        // 
        fixit.AutoSize = true;
        fixit.BackColor = Color.Transparent;
        fixit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        fixit.ForeColor = Color.FromArgb(9, 9, 9);
        fixit.Location = new Point(3, 229);
        fixit.Name = "fixit";
        fixit.Size = new Size(101, 19);
        fixit.TabIndex = 8;
        fixit.Text = "Dzień 7 (fixit)";
        fixit.UseVisualStyleBackColor = false;
        // 
        // getinfo
        // 
        getinfo.AutoSize = true;
        getinfo.BackColor = Color.Transparent;
        getinfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        getinfo.ForeColor = Color.FromArgb(9, 9, 9);
        getinfo.Location = new Point(3, 29);
        getinfo.Name = "getinfo";
        getinfo.Size = new Size(122, 19);
        getinfo.TabIndex = 7;
        getinfo.Text = "Dzień 1 (getinfo) ";
        getinfo.UseVisualStyleBackColor = false;
        // 
        // category
        // 
        category.AutoSize = true;
        category.BackColor = Color.Transparent;
        category.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        category.ForeColor = Color.FromArgb(9, 9, 9);
        category.Location = new Point(3, 54);
        category.Name = "category";
        category.Size = new Size(127, 19);
        category.TabIndex = 6;
        category.Text = "Dzień 2 (category)";
        category.UseVisualStyleBackColor = false;
        // 
        // helloapi
        // 
        helloapi.AutoSize = true;
        helloapi.BackColor = Color.Transparent;
        helloapi.Checked = true;
        helloapi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        helloapi.ForeColor = Color.FromArgb(9, 9, 9);
        helloapi.Location = new Point(3, 4);
        helloapi.Name = "helloapi";
        helloapi.Size = new Size(121, 19);
        helloapi.TabIndex = 5;
        helloapi.TabStop = true;
        helloapi.Text = "Dzień 1 (helloapi)";
        helloapi.UseVisualStyleBackColor = false;
        // 
        // scraper
        // 
        scraper.AutoSize = true;
        scraper.BackColor = Color.Transparent;
        scraper.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        scraper.ForeColor = Color.FromArgb(9, 9, 9);
        scraper.Location = new Point(3, 204);
        scraper.Name = "scraper";
        scraper.Size = new Size(119, 19);
        scraper.TabIndex = 4;
        scraper.Text = "Dzień 6 (scraper)";
        scraper.UseVisualStyleBackColor = false;
        // 
        // blogger
        // 
        blogger.AutoSize = true;
        blogger.BackColor = Color.Transparent;
        blogger.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        blogger.ForeColor = Color.FromArgb(9, 9, 9);
        blogger.Location = new Point(3, 179);
        blogger.Name = "blogger";
        blogger.Size = new Size(121, 19);
        blogger.TabIndex = 3;
        blogger.Text = "Dzień 5 (blogger)";
        blogger.UseVisualStyleBackColor = false;
        // 
        // inprompt
        // 
        inprompt.AutoSize = true;
        inprompt.BackColor = Color.Transparent;
        inprompt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        inprompt.ForeColor = Color.FromArgb(9, 9, 9);
        inprompt.Location = new Point(3, 104);
        inprompt.Name = "inprompt";
        inprompt.Size = new Size(130, 19);
        inprompt.TabIndex = 2;
        inprompt.Text = "Dzień 3 (inprompt)";
        inprompt.UseVisualStyleBackColor = false;
        // 
        // moderation
        // 
        moderation.AutoSize = true;
        moderation.BackColor = Color.Transparent;
        moderation.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        moderation.ForeColor = Color.FromArgb(9, 9, 9);
        moderation.Location = new Point(3, 129);
        moderation.Name = "moderation";
        moderation.Size = new Size(143, 19);
        moderation.TabIndex = 1;
        moderation.Text = "Dzień 3 (moderation)";
        moderation.UseVisualStyleBackColor = false;
        // 
        // tbApiKey
        // 
        tbApiKey.Location = new Point(22, 54);
        tbApiKey.Name = "tbApiKey";
        tbApiKey.Size = new Size(378, 23);
        tbApiKey.TabIndex = 2;
        // 
        // label1
        // 
        label1.BackColor = Color.Transparent;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label1.ForeColor = Color.White;
        label1.Location = new Point(22, 23);
        label1.Name = "label1";
        label1.Size = new Size(159, 28);
        label1.TabIndex = 3;
        label1.Text = "Klucz API do AI Devs:";
        // 
        // tbJson
        // 
        tbJson.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        tbJson.Location = new Point(22, 496);
        tbJson.Multiline = true;
        tbJson.Name = "tbJson";
        tbJson.ReadOnly = true;
        tbJson.ScrollBars = ScrollBars.Vertical;
        tbJson.Size = new Size(623, 209);
        tbJson.TabIndex = 4;
        // 
        // tbTaskDescription
        // 
        tbTaskDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        tbTaskDescription.Location = new Point(22, 331);
        tbTaskDescription.Multiline = true;
        tbTaskDescription.Name = "tbTaskDescription";
        tbTaskDescription.ReadOnly = true;
        tbTaskDescription.ScrollBars = ScrollBars.Vertical;
        tbTaskDescription.Size = new Size(623, 112);
        tbTaskDescription.TabIndex = 5;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.BackColor = Color.Transparent;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label2.ForeColor = Color.White;
        label2.Location = new Point(22, 110);
        label2.Name = "label2";
        label2.Size = new Size(129, 21);
        label2.TabIndex = 7;
        label2.Text = "Adres webhooka:";
        // 
        // tbWebhookLink
        // 
        tbWebhookLink.Location = new Point(22, 141);
        tbWebhookLink.Name = "tbWebhookLink";
        tbWebhookLink.Size = new Size(378, 23);
        tbWebhookLink.TabIndex = 6;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.BackColor = Color.Transparent;
        label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label3.ForeColor = Color.White;
        label3.Location = new Point(22, 295);
        label3.Name = "label3";
        label3.Size = new Size(102, 21);
        label3.TabIndex = 8;
        label3.Text = "Opis zadania:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.BackColor = Color.Transparent;
        label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label4.ForeColor = Color.White;
        label4.Location = new Point(22, 457);
        label4.Name = "label4";
        label4.Size = new Size(52, 21);
        label4.TabIndex = 9;
        label4.Text = "JSON:";
        // 
        // btnDownloadTaskDescription
        // 
        btnDownloadTaskDescription.BackColor = Color.FromArgb(116, 255, 108);
        btnDownloadTaskDescription.FlatAppearance.BorderColor = Color.FromArgb(116, 255, 107);
        btnDownloadTaskDescription.FlatAppearance.BorderSize = 2;
        btnDownloadTaskDescription.FlatStyle = FlatStyle.Popup;
        btnDownloadTaskDescription.ForeColor = Color.FromArgb(9, 9, 9);
        btnDownloadTaskDescription.Location = new Point(22, 196);
        btnDownloadTaskDescription.Name = "btnDownloadTaskDescription";
        btnDownloadTaskDescription.Size = new Size(144, 31);
        btnDownloadTaskDescription.TabIndex = 10;
        btnDownloadTaskDescription.Text = "Pobierz treść zadania";
        btnDownloadTaskDescription.UseVisualStyleBackColor = false;
        btnDownloadTaskDescription.Click += tbDownloadTaskDescription_Click;
        // 
        // btnSendToWebhook
        // 
        btnSendToWebhook.BackColor = Color.FromArgb(116, 255, 107);
        btnSendToWebhook.FlatAppearance.BorderColor = Color.FromArgb(116, 255, 107);
        btnSendToWebhook.FlatAppearance.BorderSize = 2;
        btnSendToWebhook.FlatStyle = FlatStyle.Popup;
        btnSendToWebhook.ForeColor = Color.FromArgb(9, 9, 9);
        btnSendToWebhook.Location = new Point(188, 196);
        btnSendToWebhook.Name = "btnSendToWebhook";
        btnSendToWebhook.Size = new Size(144, 31);
        btnSendToWebhook.TabIndex = 11;
        btnSendToWebhook.Text = "Wyślij do webhooka";
        btnSendToWebhook.UseVisualStyleBackColor = false;
        btnSendToWebhook.Click += btnSendToWebhook_Click;
        // 
        // menuStrip1
        // 
        menuStrip1.BackgroundImage = Properties.Resources.bgc;
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(698, 24);
        menuStrip1.TabIndex = 12;
        menuStrip1.MouseDown += menuStrip1_MouseDown;
        menuStrip1.MouseMove += menuStrip1_MouseMove;
        menuStrip1.MouseUp += menuStrip1_MouseUp;
        // 
        // btnClose
        // 
        btnClose.BackColor = Color.Transparent;
        btnClose.FlatAppearance.BorderSize = 0;
        btnClose.FlatStyle = FlatStyle.Flat;
        btnClose.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        btnClose.ForeColor = Color.Black;
        btnClose.Location = new Point(666, 0);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(32, 39);
        btnClose.TabIndex = 13;
        btnClose.Text = "❌";
        btnClose.UseVisualStyleBackColor = false;
        btnClose.Click += btnClose_Click;
        // 
        // btnSendBug
        // 
        btnSendBug.BackColor = Color.Transparent;
        btnSendBug.FlatAppearance.BorderSize = 0;
        btnSendBug.FlatStyle = FlatStyle.Flat;
        btnSendBug.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        btnSendBug.ForeColor = Color.Black;
        btnSendBug.Location = new Point(628, 0);
        btnSendBug.Name = "btnSendBug";
        btnSendBug.Size = new Size(32, 39);
        btnSendBug.TabIndex = 14;
        btnSendBug.Text = "\U0001fab2";
        btnSendBug.UseVisualStyleBackColor = false;
        btnSendBug.Click += btnSendBug_Click_1;
        // 
        // MainPage
        // 
        AutoScaleMode = AutoScaleMode.None;
        BackColor = Color.FromArgb(9, 9, 9);
        BackgroundImage = Properties.Resources.bgc;
        ClientSize = new Size(698, 748);
        ControlBox = false;
        Controls.Add(btnSendBug);
        Controls.Add(btnClose);
        Controls.Add(btnSendToWebhook);
        Controls.Add(btnDownloadTaskDescription);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(tbWebhookLink);
        Controls.Add(tbTaskDescription);
        Controls.Add(tbJson);
        Controls.Add(label1);
        Controls.Add(tbApiKey);
        Controls.Add(panel1);
        Controls.Add(menuStrip1);
        ForeColor = Color.White;
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MainMenuStrip = menuStrip1;
        MaximizeBox = false;
        MaximumSize = new Size(700, 750);
        MinimizeBox = false;
        MinimumSize = new Size(700, 750);
        Name = "MainPage";
        StartPosition = FormStartPosition.CenterScreen;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private TextBox tbApiKey;
    private Label label1;
    private TextBox tbJson;
    private TextBox tbTaskDescription;
    private Label label2;
    private TextBox tbWebhookLink;
    private RadioButton moderation;
    private Label label3;
    private Label label4;
    private Button tbDownloadTaskDescription;
    private Button button1;
    private MenuStrip menuStrip1;
    private Button btnClose;
    private RadioButton scraper;
    private RadioButton blogger;
    private RadioButton inprompt;
    private Button btnSendBug;
    private Button btnDownloadTaskDescription;
    private Button btnSendToWebhook;
    private RadioButton helloapi;
    private PageSetupDialog pageSetupDialog1;
    private RadioButton category;
    private RadioButton getinfo;
    private RadioButton fixit;
    private RadioButton injection;
    private RadioButton books;
}