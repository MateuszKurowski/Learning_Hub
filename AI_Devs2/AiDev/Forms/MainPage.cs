using AI_Devs2.Tasks.src;
using AI_Devs2.Utility;

namespace AiDev;

public partial class MainPage : Form
{
    private Point _dragStartPoint;

    public MainPage()
    {
        InitializeComponent();
        var apiKey = ApiKey.GetKey();
        if (!string.IsNullOrWhiteSpace(apiKey))
            tbApiKey.Text = apiKey;

        cbTaskList.Items.Clear();
        cbTaskList.DataSource = TasksList.Tasks;
        cbTaskList.DisplayMember = "Name";
        if (TasksList.Tasks.Any())
            cbTaskList.SelectedIndex = 0;
    }

    private void CbSaveKey_CheckedChanged(object sender, EventArgs e)
    {
        if (cbSaveKey.Checked && !string.IsNullOrWhiteSpace(tbApiKey.Text))
        {
            ApiKey.SaveKey(tbApiKey.Text);
        }
        else if (cbSaveKey.Checked == false)
        {
            ApiKey.RemoveKey();
        }
    }

    private void BtnClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void BtnSendBug_Click(object sender, EventArgs e)
    {
        var reportForm = new ReportForm();
        reportForm.ShowDialog();
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

    private void btnGetTaskDescription_Click(object sender, EventArgs e)
    {
        if (cbTaskList.SelectedItem is null)
            MessageBox.Show("Aby pobrać opis zadania najpierw wybierz je z listy.", "Wybierz zadanie!");

        var task = cbTaskList.SelectedItem as ITask;
        var taskDescription = task.GetTaskDescription(tbApiKey.Text);

        txtTaskDescription.Text = taskDescription;
    }

    private void btnExecute_Click(object sender, EventArgs e)
    {
        if (cbTaskList.SelectedItem is null)
            MessageBox.Show("Aby wykonać zadanie najpierw wybierz je z listy.", "Wybierz zadanie!");

        var task = cbTaskList.SelectedItem as ITask;
        if(task.Execute())
            MessageBox.Show($"Gratuluacje!\r\nUdało Ci się wykonać zadanie {task.Name}", "Zadanie wykonane!");
        else
            MessageBox.Show($"Niestety nie udało się wykonać zadania {task.Name}.", "Zadanie niezaliczone!");
    }
}