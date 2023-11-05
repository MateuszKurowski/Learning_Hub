using AiDev_lib.Utility;

public class Moderation : Day_json
{
    public string Code { get; set; }
    public string Msg { get; set; }
    public string[] Input { get; set; }

    public static string TaskName { get; } = "moderation";
}