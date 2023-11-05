using AiDev_lib.Utility;

namespace AiDev_lib.Tasks;

public class Scraper : Day_json
{
    public string Code { get; set; }
    public string Msg { get; set; }
    public string Input { get; set; }
    public string Question { get; set; }

    public static string TaskName { get; } = "scraper";
}