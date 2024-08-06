using AiDev_lib.Utility;

namespace AiDev_lib.Tasks;

public class Blogger : Day_json
{
    public string Code { get; set; }
    public string Msg { get; set; }
    public string[] Blog { get; set; }

    public static string TaskName { get; } = "blogger";
}