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
        tbApiKey = new TextBox();
        label1 = new Label();
        btnClose = new Button();
        btnSendBug = new Button();
        cbSaveKey = new CheckBox();
        cbTaskList = new ComboBox();
        menuStrip = new MenuStrip();
        label2 = new Label();
        btnGetTaskDescription = new Button();
        btnExecute = new Button();
        cbAutomaticExecute = new CheckBox();
        txtTaskDescription = new TextBox();
        label3 = new Label();
        lblTaskToken = new Label();
        SuspendLayout();
        // 
        // tbApiKey
        // 
        tbApiKey.Location = new Point(22, 74);
        tbApiKey.Name = "tbApiKey";
        tbApiKey.Size = new Size(378, 23);
        tbApiKey.TabIndex = 2;
        // 
        // label1
        // 
        label1.BackColor = Color.Transparent;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label1.ForeColor = Color.White;
        label1.Location = new Point(22, 43);
        label1.Name = "label1";
        label1.Size = new Size(159, 28);
        label1.TabIndex = 3;
        label1.Text = "Klucz API do AI Devs:";
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
        btnClose.Click += BtnClose_Click;
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
        btnSendBug.Click += BtnSendBug_Click;
        // 
        // cbSaveKey
        // 
        cbSaveKey.AutoSize = true;
        cbSaveKey.BackColor = Color.Transparent;
        cbSaveKey.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        cbSaveKey.ForeColor = Color.White;
        cbSaveKey.Location = new Point(22, 103);
        cbSaveKey.Name = "cbSaveKey";
        cbSaveKey.Size = new Size(141, 24);
        cbSaveKey.TabIndex = 15;
        cbSaveKey.Text = "Zapamiętaj klucz";
        cbSaveKey.UseVisualStyleBackColor = false;
        cbSaveKey.CheckedChanged += CbSaveKey_CheckedChanged;
        cbSaveKey.Enter += CbSaveKey_CheckedChanged;
        cbSaveKey.Leave += CbSaveKey_CheckedChanged;
        // 
        // cbTaskList
        // 
        cbTaskList.FormattingEnabled = true;
        cbTaskList.Location = new Point(22, 181);
        cbTaskList.Name = "cbTaskList";
        cbTaskList.Size = new Size(219, 23);
        cbTaskList.TabIndex = 16;
        // 
        // menuStrip
        // 
        menuStrip.BackgroundImage = AI_Devs2.Properties.Resources.bgc;
        menuStrip.Location = new Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Size = new Size(698, 24);
        menuStrip.TabIndex = 17;
        menuStrip.MouseDown += MenuStrip_MouseDown;
        menuStrip.MouseMove += MenuStrip_MouseMove;
        menuStrip.MouseUp += MenuStrip_MouseUp;
        // 
        // label2
        // 
        label2.BackColor = Color.Transparent;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label2.ForeColor = Color.White;
        label2.Location = new Point(22, 150);
        label2.Name = "label2";
        label2.Size = new Size(159, 28);
        label2.TabIndex = 18;
        label2.Text = "Wybierz zadanie:";
        // 
        // btnGetTaskDescription
        // 
        btnGetTaskDescription.BackColor = Color.FromArgb(94, 207, 87);
        btnGetTaskDescription.ForeColor = Color.FromArgb(9, 9, 9);
        btnGetTaskDescription.Location = new Point(498, 74);
        btnGetTaskDescription.Name = "btnGetTaskDescription";
        btnGetTaskDescription.Size = new Size(144, 31);
        btnGetTaskDescription.TabIndex = 10;
        btnGetTaskDescription.Text = "Pobierz treść zadania";
        btnGetTaskDescription.UseVisualStyleBackColor = false;
        btnGetTaskDescription.Click += btnGetTaskDescription_Click;
        // 
        // btnExecute
        // 
        btnExecute.BackColor = Color.FromArgb(94, 207, 87);
        btnExecute.ForeColor = Color.FromArgb(9, 9, 9);
        btnExecute.Location = new Point(498, 173);
        btnExecute.Name = "btnExecute";
        btnExecute.Size = new Size(144, 31);
        btnExecute.TabIndex = 19;
        btnExecute.Text = "Wykonaj zadanie";
        btnExecute.UseVisualStyleBackColor = false;
        btnExecute.Click += btnExecute_Click;
        // 
        // cbAutomaticExecute
        // 
        cbAutomaticExecute.AutoSize = true;
        cbAutomaticExecute.BackColor = Color.Transparent;
        cbAutomaticExecute.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        cbAutomaticExecute.ForeColor = Color.White;
        cbAutomaticExecute.Location = new Point(501, 111);
        cbAutomaticExecute.Name = "cbAutomaticExecute";
        cbAutomaticExecute.Size = new Size(142, 44);
        cbAutomaticExecute.TabIndex = 21;
        cbAutomaticExecute.Text = "Automatycznie\r\n wykonaj zadanie";
        cbAutomaticExecute.UseVisualStyleBackColor = false;
        // 
        // txtTaskDescription
        // 
        txtTaskDescription.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        txtTaskDescription.Location = new Point(34, 303);
        txtTaskDescription.Multiline = true;
        txtTaskDescription.Name = "txtTaskDescription";
        txtTaskDescription.ReadOnly = true;
        txtTaskDescription.Size = new Size(626, 145);
        txtTaskDescription.TabIndex = 22;
        // 
        // label3
        // 
        label3.BackColor = Color.Transparent;
        label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label3.ForeColor = Color.White;
        label3.Location = new Point(34, 272);
        label3.Name = "label3";
        label3.Size = new Size(159, 28);
        label3.TabIndex = 23;
        label3.Text = "Treść zadania:";
        // 
        // lblTaskToken
        // 
        lblTaskToken.AutoSize = true;
        lblTaskToken.Location = new Point(34, 245);
        lblTaskToken.Name = "lblTaskToken";
        lblTaskToken.Size = new Size(38, 15);
        lblTaskToken.TabIndex = 24;
        lblTaskToken.Text = "label4";
        lblTaskToken.Visible = false;
        // 
        // MainPage
        // 
        AutoScaleMode = AutoScaleMode.None;
        BackColor = Color.FromArgb(9, 9, 9);
        BackgroundImage = AI_Devs2.Properties.Resources.bgc;
        ClientSize = new Size(698, 748);
        ControlBox = false;
        Controls.Add(lblTaskToken);
        Controls.Add(label3);
        Controls.Add(txtTaskDescription);
        Controls.Add(cbAutomaticExecute);
        Controls.Add(btnExecute);
        Controls.Add(btnGetTaskDescription);
        Controls.Add(label2);
        Controls.Add(cbTaskList);
        Controls.Add(cbSaveKey);
        Controls.Add(btnSendBug);
        Controls.Add(btnClose);
        Controls.Add(label1);
        Controls.Add(tbApiKey);
        Controls.Add(menuStrip);
        ForeColor = Color.White;
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MainMenuStrip = menuStrip;
        MaximizeBox = false;
        MaximumSize = new Size(700, 750);
        MinimizeBox = false;
        MinimumSize = new Size(700, 750);
        Name = "MainPage";
        StartPosition = FormStartPosition.CenterScreen;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TextBox tbApiKey;
    private Label label1;
    private Button btnClose;
    private Button btnSendBug;
    private CheckBox cbSaveKey;
    private ComboBox cbTaskList;
    private MenuStrip menuStrip;
    private Label label2;
    private Button btnGetTaskDescription;
    private Button btnExecute;
    private CheckBox cbAutomaticExecute;
    private TextBox txtTaskDescription;
    private Label label3;
    private Label lblTaskToken;
}