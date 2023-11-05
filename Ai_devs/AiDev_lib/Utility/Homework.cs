using AiDev_lib.Utility;

using Newtonsoft.Json;

using RestSharp;

using static ai_dev.Auth;

namespace ai_dev.Utility;

public class Homework<T> where T : Day_json
{
    public string Url { get; } = "https://zadania.aidevs.pl/task/";
    public string AnswerUrl { get; } = "https://zadania.aidevs.pl/answer/";
    public string TaskToken { get; init; }
    public string Response { get; private set; }
    public T Result { get; private set; }

    public Homework(string taskToken)
    {
        TaskToken = taskToken;

        if (string.IsNullOrWhiteSpace(TaskToken))
            throw new ArgumentNullException(nameof(TaskToken));
        if (string.IsNullOrWhiteSpace(Url))
            throw new ArgumentNullException(nameof(Url));
    }

    public async Task<T> GetHomeworkDescription()
    {
        var client = new RestClient(Url + TaskToken);
        var request = new RestRequest
        {
            Method = Method.Get
        };
        var response = await client.ExecuteAsync(request);

        if (response is null)
            throw new ResponseException("Cannot send request. Try again later.");

        if (string.IsNullOrWhiteSpace(response.Content))
            throw new ResponseException("No content in response.");

        Result = JsonConvert.DeserializeObject<T>(response.Content);
        Result.Link = AnswerUrl + TaskToken;
        Response = JsonConvert.SerializeObject(Result, Formatting.Indented);
        return Result;
    }

    public async void SendToWebhook(string webhookLink)
    {
        var client = new RestClient(webhookLink);
        var request = new RestRequest
        {
            Method = Method.Post
        };

        request.AddJsonBody(Response);
        var response = await client.ExecuteAsync(request);
    }
}

public class Homework
{
    public static async void SendToWebhook(string webhookLink, string json)
    {
        var client = new RestClient(webhookLink);
        var request = new RestRequest
        {
            Method = Method.Post
        };

        request.AddJsonBody(json);
        var response = await client.ExecuteAsync(request);
    }
}