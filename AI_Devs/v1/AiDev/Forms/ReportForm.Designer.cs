using System.Windows.Forms;

namespace AiDev;

partial class ReportForm
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
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
        label1 = new Label();
        menuStrip1 = new MenuStrip();
        btnClose = new Button();
        textBox1 = new TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.BackColor = Color.Transparent;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label1.ForeColor = Color.White;
        label1.Location = new Point(22, 24);
        label1.Name = "label1";
        label1.Size = new Size(343, 87);
        label1.TabIndex = 3;
        label1.Text = "Widzisz błąd? Zgłoś go bezpośrednie do mnie\r\n korzystając z jednego z dostępnych kanałów informacji:\r\n";
        // 
        // menuStrip1
        // 
        menuStrip1.BackgroundImage = Properties.Resources.bgc;
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(427, 24);
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
        btnClose.Location = new Point(395, 0);
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(32, 39);
        btnClose.TabIndex = 13;
        btnClose.Text = "❌";
        btnClose.UseVisualStyleBackColor = false;
        btnClose.Click += btnClose_Click;
        // 
        // textBox1
        // 
        textBox1.BackColor = Color.Silver;
        textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        textBox1.Location = new Point(22, 105);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.Size = new Size(367, 161);
        textBox1.TabIndex = 15;
        textBox1.Text = "➖ PV na Ahoy do użytkownika Mateusz Kurowski\r\n\r\n➖ Na kurowskimateusz04@gmail.com\r\n\r\n➖ Pod postem o aplikacji na circle (LINK)\r\n\r\n\r\n";
        // 
        // ReportForm
        // 
        AutoScaleMode = AutoScaleMode.None;
        BackColor = Color.FromArgb(9, 9, 9);
        BackgroundImage = Properties.Resources.bgc;
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(427, 300);
        ControlBox = false;
        Controls.Add(textBox1);
        Controls.Add(btnClose);
        Controls.Add(label1);
        Controls.Add(menuStrip1);
        ForeColor = Color.White;
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MainMenuStrip = menuStrip1;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ReportForm";
        StartPosition = FormStartPosition.CenterScreen;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label label1;
    private MenuStrip menuStrip1;
    private Button btnClose;
    private TextBox textBox1;
}