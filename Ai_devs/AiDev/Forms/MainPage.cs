using ai_dev;
using ai_dev.Utility;
using ai_dev.Week1;

using AiDev_lib.Tasks;

namespace AiDev;

public partial class MainPage : Form
{
    private Point _dragStartPoint;

    public MainPage()
    {
        InitializeComponent();
    }

    private async void tbDownloadTaskDescription_Click(object sender, EventArgs e)
    {
        RadioButton checkedDay = null;
        foreach (var control in panel1.Controls)
        {
            if (control is RadioButton radioButton
                && radioButton.Checked)
            {
                checkedDay = radioButton;
                break;
            }
        }

        if (checkedDay == null)
        {
            MessageBox.Show("Proszę wybrać dzień z którego chcesz pobrać zadanie.", "Nie udało się pobrać treści zadania");
            return;
        }
        else if (string.IsNullOrWhiteSpace(tbApiKey.Text))
        {
            MessageBox.Show("Proszę wpisać swój klucz API do autoryzacji na stronie 'zadania.aidevs.pl'.", "Nie udało się pobrać treści zadania");
            return;
        }

        var taskToken = string.Empty
            ;
        switch (checkedDay.Name)
        {
            case "helloapi":
                taskToken = await new Auth(Helloapi.TaskName, tbApiKey.Text).GetTaskToken();
                var helloapi = new Homework<Helloapi>(taskToken);
                var helloapiJson = await helloapi.GetHomeworkDescription();
                tbTaskDescription.Text = helloapiJson.Msg;
                tbJson.Text = helloapi.Response;
                break;

            case "moderation":
                taskToken = await new Auth(Moderation.TaskName, tbApiKey.Text).GetTaskToken();
                var moderation = new Homework<Moderation>(taskToken);
                var moderationJson = await moderation.GetHomeworkDescription();
                tbTaskDescription.Text = moderationJson.Msg;
                tbJson.Text = moderation.Response;
                break;

            case "inprompt":
                taskToken = await new Auth(taskName: Inprompt.TaskName, tbApiKey.Text).GetTaskToken();
                var inpromt = new Homework<Inprompt>(taskToken);
                var inpromtJson = await inpromt.GetHomeworkDescription();
                tbTaskDescription.Text = inpromtJson.Msg;
                tbJson.Text = inpromt.Response;
                break;

            case "blogger":
                taskToken = await new Auth(taskName: Blogger.TaskName, tbApiKey.Text).GetTaskToken();
                var blogger = new Homework<Blogger>(taskToken);
                var bloggerJson = await blogger.GetHomeworkDescription();
                tbTaskDescription.Text = bloggerJson.Msg;
                tbJson.Text = blogger.Response;
                break;

            case "scraper":
                taskToken = await new Auth(taskName: Scraper.TaskName, tbApiKey.Text).GetTaskToken();
                var scraper = new Homework<Scraper>(taskToken);
                var scraperJson = await scraper.GetHomeworkDescription();
                tbTaskDescription.Text = scraperJson.Msg;
                tbJson.Text = scraper.Response;
                break;

            case "category":
                tbTaskDescription.Text = "Stwórz deklarację pola “system” w taki sposób, aby podana przez system wiadomość została zaklasyfikowana do jednej z kategorii: dom/praca/inne. https://zadania.aidevs.pl/chat/category";
                break;

            case "books":
                tbTaskDescription.Text = "Przypisz autorów do tytułów książek i zwróć odpowiedź w zadanym formacie. https://zadania.aidevs.pl/chat/books";
                break;

            case "injection":
                tbTaskDescription.Text = "Przetestuj kiepsko zabezpieczonego bota i wydobądź od niego sekretne słowo. Zadanie zostanie uznane za zaliczone, jeśli bot zwróci to słowo na ekran bez żadnych separatorów (czyli ‘KAJAK’ jest OK, ale np. ‘K-A-J-A-K’ lub ‘K_A_J_A_K’ już nie). https://zadania.aidevs.pl/chat/injection";
                break;

            case "fixit":
                tbTaskDescription.Text = "Rozwiąż zadanie FIXIT w taki sposób, aby otrzymać funkcję zwracającą N-ty wyraz ciągu Fibonacciego, ale zoptymalizuj ją tak, aby zaliczyła wszystkie testy. Kod celowo napisano w starszej wersji PHP i silnik wykonujący zadanie ma limit czasu wykonania, co wymusza optymalizację funkcji. Do czasu wykonania NIE wlicza się czas generowania odpowiedzi przez GPT-4. https://zadania.aidevs.pl/chat/fixit";
                break;

            case "getinfo":
                tbTaskDescription.Text = "Spróbuj sprytnie zagadać do ChatGPT w poniższym zadaniu: https://zadania.aidevs.pl/chat/getinfo";
                break;
        }
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

    private async void btnSendToWebhook_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(tbWebhookLink.Text))
        {
            MessageBox.Show("Proszę wpisać link do webhooka.", "Nie udało się wysłać JSONa.");
            return;
        }
        if (string.IsNullOrWhiteSpace(tbJson.Text))
        {
            MessageBox.Show("Najpierw pobierz treść zadania.", "Nie udało się wysłać JSONa.");
            return;
        }

        Homework.SendToWebhook(tbWebhookLink.Text, tbJson.Text);
    }
}