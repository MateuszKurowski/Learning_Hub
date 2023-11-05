namespace AiDev;

public partial class ReportForm : Form
{
    private Point _dragStartPoint;

    public ReportForm()
    {
        InitializeComponent();
    }

    private void BtnClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void MenuStrip_MouseDown(object sender, MouseEventArgs e)
    {
        _dragStartPoint = new Point(e.X, e.Y);
    }

    private void MenuStrip_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            var newPoint = PointToScreen(new Point(e.X, e.Y));
            newPoint.Offset(-_dragStartPoint.X, -_dragStartPoint.Y);
            Location = newPoint;
        }
    }

    private void MenuStrip_MouseUp(object sender, MouseEventArgs e)
    {
        _dragStartPoint = Point.Empty;
    }

    private void BtnSendBug_Click_1(object sender, EventArgs e)
    {
        var reportForm = new ReportForm();
        reportForm.ShowDialog();
    }
}