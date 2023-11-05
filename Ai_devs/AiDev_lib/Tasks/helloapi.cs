using AiDev_lib.Utility;

namespace ai_dev.Week1;

public class Helloapi : Day_json
{
    public string Code { get; set; }
    public string Msg { get; set; }
    public string Cookie { get; set; }

    public static string TaskName { get; } = "helloapi";
}