using AiDev_lib.Utility;

public class Inprompt : Day_json
{
    public string Code { get; set; }
    public string Msg { get; set; }
    public string[] Input { get; set; }
    public string Question { get; set; }

    public static string TaskName { get; } = "inprompt";
}