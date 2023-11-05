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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.books = new System.Windows.Forms.RadioButton();
            this.injection = new System.Windows.Forms.RadioButton();
            this.fixit = new System.Windows.Forms.RadioButton();
            this.getinfo = new System.Windows.Forms.RadioButton();
            this.category = new System.Windows.Forms.RadioButton();
            this.helloapi = new System.Windows.Forms.RadioButton();
            this.scraper = new System.Windows.Forms.RadioButton();
            this.blogger = new System.Windows.Forms.RadioButton();
            this.inprompt = new System.Windows.Forms.RadioButton();
            this.moderation = new System.Windows.Forms.RadioButton();
            this.tbApiKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbJson = new System.Windows.Forms.TextBox();
            this.tbTaskDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWebhookLink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDownloadTaskDescription = new System.Windows.Forms.Button();
            this.btnSendToWebhook = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSendBug = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.books);
            this.panel1.Controls.Add(this.injection);
            this.panel1.Controls.Add(this.fixit);
            this.panel1.Controls.Add(this.getinfo);
            this.panel1.Controls.Add(this.category);
            this.panel1.Controls.Add(this.helloapi);
            this.panel1.Controls.Add(this.scraper);
            this.panel1.Controls.Add(this.blogger);
            this.panel1.Controls.Add(this.inprompt);
            this.panel1.Controls.Add(this.moderation);
            this.panel1.Location = new System.Drawing.Point(467, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 262);
            this.panel1.TabIndex = 0;
            // 
            // books
            // 
            this.books.AutoSize = true;
            this.books.BackColor = System.Drawing.Color.Transparent;
            this.books.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.books.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.books.Location = new System.Drawing.Point(3, 79);
            this.books.Name = "books";
            this.books.Size = new System.Drawing.Size(111, 19);
            this.books.TabIndex = 10;
            this.books.Text = "Dzień 2 (books)";
            this.books.UseVisualStyleBackColor = false;
            // 
            // injection
            // 
            this.injection.AutoSize = true;
            this.injection.BackColor = System.Drawing.Color.Transparent;
            this.injection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.injection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.injection.Location = new System.Drawing.Point(3, 154);
            this.injection.Name = "injection";
            this.injection.Size = new System.Drawing.Size(126, 19);
            this.injection.TabIndex = 9;
            this.injection.Text = "Dzień 4 (injection)";
            this.injection.UseVisualStyleBackColor = false;
            // 
            // fixit
            // 
            this.fixit.AutoSize = true;
            this.fixit.BackColor = System.Drawing.Color.Transparent;
            this.fixit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fixit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.fixit.Location = new System.Drawing.Point(3, 229);
            this.fixit.Name = "fixit";
            this.fixit.Size = new System.Drawing.Size(101, 19);
            this.fixit.TabIndex = 8;
            this.fixit.Text = "Dzień 7 (fixit)";
            this.fixit.UseVisualStyleBackColor = false;
            // 
            // getinfo
            // 
            this.getinfo.AutoSize = true;
            this.getinfo.BackColor = System.Drawing.Color.Transparent;
            this.getinfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.getinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.getinfo.Location = new System.Drawing.Point(3, 29);
            this.getinfo.Name = "getinfo";
            this.getinfo.Size = new System.Drawing.Size(122, 19);
            this.getinfo.TabIndex = 7;
            this.getinfo.Text = "Dzień 1 (getinfo) ";
            this.getinfo.UseVisualStyleBackColor = false;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.BackColor = System.Drawing.Color.Transparent;
            this.category.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.category.Location = new System.Drawing.Point(3, 54);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(127, 19);
            this.category.TabIndex = 6;
            this.category.Text = "Dzień 2 (category)";
            this.category.UseVisualStyleBackColor = false;
            // 
            // helloapi
            // 
            this.helloapi.AutoSize = true;
            this.helloapi.BackColor = System.Drawing.Color.Transparent;
            this.helloapi.Checked = true;
            this.helloapi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.helloapi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.helloapi.Location = new System.Drawing.Point(3, 4);
            this.helloapi.Name = "helloapi";
            this.helloapi.Size = new System.Drawing.Size(121, 19);
            this.helloapi.TabIndex = 5;
            this.helloapi.TabStop = true;
            this.helloapi.Text = "Dzień 1 (helloapi)";
            this.helloapi.UseVisualStyleBackColor = false;
            // 
            // scraper
            // 
            this.scraper.AutoSize = true;
            this.scraper.BackColor = System.Drawing.Color.Transparent;
            this.scraper.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scraper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.scraper.Location = new System.Drawing.Point(3, 204);
            this.scraper.Name = "scraper";
            this.scraper.Size = new System.Drawing.Size(119, 19);
            this.scraper.TabIndex = 4;
            this.scraper.Text = "Dzień 6 (scraper)";
            this.scraper.UseVisualStyleBackColor = false;
            // 
            // blogger
            // 
            this.blogger.AutoSize = true;
            this.blogger.BackColor = System.Drawing.Color.Transparent;
            this.blogger.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.blogger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.blogger.Location = new System.Drawing.Point(3, 179);
            this.blogger.Name = "blogger";
            this.blogger.Size = new System.Drawing.Size(121, 19);
            this.blogger.TabIndex = 3;
            this.blogger.Text = "Dzień 5 (blogger)";
            this.blogger.UseVisualStyleBackColor = false;
            // 
            // inprompt
            // 
            this.inprompt.AutoSize = true;
            this.inprompt.BackColor = System.Drawing.Color.Transparent;
            this.inprompt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inprompt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.inprompt.Location = new System.Drawing.Point(3, 104);
            this.inprompt.Name = "inprompt";
            this.inprompt.Size = new System.Drawing.Size(130, 19);
            this.inprompt.TabIndex = 2;
            this.inprompt.Text = "Dzień 3 (inprompt)";
            this.inprompt.UseVisualStyleBackColor = false;
            // 
            // moderation
            // 
            this.moderation.AutoSize = true;
            this.moderation.BackColor = System.Drawing.Color.Transparent;
            this.moderation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.moderation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.moderation.Location = new System.Drawing.Point(3, 129);
            this.moderation.Name = "moderation";
            this.moderation.Size = new System.Drawing.Size(143, 19);
            this.moderation.TabIndex = 1;
            this.moderation.Text = "Dzień 3 (moderation)";
            this.moderation.UseVisualStyleBackColor = false;
            // 
            // tbApiKey
            // 
            this.tbApiKey.Location = new System.Drawing.Point(22, 54);
            this.tbApiKey.Name = "tbApiKey";
            this.tbApiKey.Size = new System.Drawing.Size(378, 23);
            this.tbApiKey.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Klucz API do AI Devs:";
            // 
            // tbJson
            // 
            this.tbJson.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbJson.Location = new System.Drawing.Point(22, 496);
            this.tbJson.Multiline = true;
            this.tbJson.Name = "tbJson";
            this.tbJson.ReadOnly = true;
            this.tbJson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbJson.Size = new System.Drawing.Size(623, 209);
            this.tbJson.TabIndex = 4;
            // 
            // tbTaskDescription
            // 
            this.tbTaskDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTaskDescription.Location = new System.Drawing.Point(22, 331);
            this.tbTaskDescription.Multiline = true;
            this.tbTaskDescription.Name = "tbTaskDescription";
            this.tbTaskDescription.ReadOnly = true;
            this.tbTaskDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTaskDescription.Size = new System.Drawing.Size(623, 112);
            this.tbTaskDescription.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adres webhooka:";
            // 
            // tbWebhookLink
            // 
            this.tbWebhookLink.Location = new System.Drawing.Point(22, 141);
            this.tbWebhookLink.Name = "tbWebhookLink";
            this.tbWebhookLink.Size = new System.Drawing.Size(378, 23);
            this.tbWebhookLink.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Opis zadania:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "JSON:";
            // 
            // btnDownloadTaskDescription
            // 
            this.btnDownloadTaskDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(255)))), ((int)(((byte)(108)))));
            this.btnDownloadTaskDescription.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(255)))), ((int)(((byte)(107)))));
            this.btnDownloadTaskDescription.FlatAppearance.BorderSize = 2;
            this.btnDownloadTaskDescription.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDownloadTaskDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.btnDownloadTaskDescription.Location = new System.Drawing.Point(22, 196);
            this.btnDownloadTaskDescription.Name = "btnDownloadTaskDescription";
            this.btnDownloadTaskDescription.Size = new System.Drawing.Size(144, 31);
            this.btnDownloadTaskDescription.TabIndex = 10;
            this.btnDownloadTaskDescription.Text = "Pobierz treść zadania";
            this.btnDownloadTaskDescription.UseVisualStyleBackColor = false;
            this.btnDownloadTaskDescription.Click += new System.EventHandler(this.tbDownloadTaskDescription_Click);
            // 
            // btnSendToWebhook
            // 
            this.btnSendToWebhook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(255)))), ((int)(((byte)(107)))));
            this.btnSendToWebhook.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(255)))), ((int)(((byte)(107)))));
            this.btnSendToWebhook.FlatAppearance.BorderSize = 2;
            this.btnSendToWebhook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendToWebhook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.btnSendToWebhook.Location = new System.Drawing.Point(188, 196);
            this.btnSendToWebhook.Name = "btnSendToWebhook";
            this.btnSendToWebhook.Size = new System.Drawing.Size(144, 31);
            this.btnSendToWebhook.TabIndex = 11;
            this.btnSendToWebhook.Text = "Wyślij do webhooka";
            this.btnSendToWebhook.UseVisualStyleBackColor = false;
            this.btnSendToWebhook.Click += new System.EventHandler(this.btnSendToWebhook_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::AiDev.Properties.Resources.bgc;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(666, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 39);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "❌";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSendBug
            // 
            this.btnSendBug.BackColor = System.Drawing.Color.Transparent;
            this.btnSendBug.FlatAppearance.BorderSize = 0;
            this.btnSendBug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendBug.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSendBug.ForeColor = System.Drawing.Color.Black;
            this.btnSendBug.Location = new System.Drawing.Point(628, 0);
            this.btnSendBug.Name = "btnSendBug";
            this.btnSendBug.Size = new System.Drawing.Size(32, 39);
            this.btnSendBug.TabIndex = 14;
            this.btnSendBug.Text = "🪲";
            this.btnSendBug.UseVisualStyleBackColor = false;
            this.btnSendBug.Click += new System.EventHandler(this.btnSendBug_Click_1);
            // 
            // MainPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9)))));
            this.BackgroundImage = global::AiDev.Properties.Resources.bgc;
            this.ClientSize = new System.Drawing.Size(698, 748);
            this.ControlBox = false;
            this.Controls.Add(this.btnSendBug);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSendToWebhook);
            this.Controls.Add(this.btnDownloadTaskDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbWebhookLink);
            this.Controls.Add(this.tbTaskDescription);
            this.Controls.Add(this.tbJson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbApiKey);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 750);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 750);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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