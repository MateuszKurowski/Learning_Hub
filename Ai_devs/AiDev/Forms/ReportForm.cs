namespace AiDev;

public partial class ReportForm : Form
{
    private Point _dragStartPoint;

    public ReportForm()
    {
        InitializeComponent();
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
    {
        _dragStartPoint = new Point(e.X, e.Y);
    }

    private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            var newPoint = PointToScreen(new Point(e.X, e.Y));
            newPoint.Offset(-_dragStartPoint.X, -_dragStartPoint.Y);
            Location = newPoint;
        }
    }

    private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
    {
        _dragStartPoint = Point.Empty;
    }

    private void btnSendBug_Click_1(object sender, EventArgs e)
    {
        var reportForm = new ReportForm();
        reportForm.ShowDialog();
    }
}