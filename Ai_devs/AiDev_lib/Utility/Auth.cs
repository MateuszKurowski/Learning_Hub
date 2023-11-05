using Newtonsoft.Json;

using RestSharp;

using System.Net;

namespace ai_dev;

public class Auth
{
    private class Response
    {
        public string Code { get; set; }
        public string Msg { get; set; }
        public string Token { get; set; }
    }

    public string Url { get; } = "https://zadania.aidevs.pl/token/";

    public string ApiKey { get; set; }
    public string TaskName { get; init; }
    public string TaskToken { get; private set; } = string.Empty;

    public Auth(string taskName, string apiKey)
    {
        TaskName = taskName;
        ApiKey = apiKey;

        if (string.IsNullOrWhiteSpace(TaskName))
            throw new ArgumentNullException(nameof(TaskName));
        if (string.IsNullOrWhiteSpace(Url))
            throw new ArgumentNullException(nameof(Url));
        if (string.IsNullOrWhiteSpace(ApiKey))
            throw new ArgumentNullException(nameof(ApiKey));
    }

    public async Task<string> GetTaskToken()
    {
        var client = new RestClient(Url + TaskName);
        var request = new RestRequest
        {
            Method = Method.Post
        };

        var json = JsonConvert.SerializeObject(new { apikey = ApiKey });

        request.AddJsonBody(json);
        var response = await client.ExecuteAsync(request);

        if (response is null)
            throw new ResponseException("Cannot send request. Try again later.");

        if (string.IsNullOrWhiteSpace(response.Content))
            throw new ResponseException("No content in response.");

        var responseContent = JsonConvert.DeserializeObject<Response>(response.Content);

        if (responseContent is null
            || string.IsNullOrWhiteSpace(responseContent.Msg)
            || string.IsNullOrWhiteSpace(responseContent.Code))
            throw new ResponseException("Returned JSON is incomplete");

        if (response.StatusCode != HttpStatusCode.OK)
            throw new TaskException(responseContent.Code, responseContent.Msg);

        return responseContent.Token;
    }

    public class ResponseException : Exception
    {
        public ResponseException(string? message) : base(message)
        {
        }
    }

    public class TaskException : Exception
    {
        public string Code { get; }
        public string Msg { get; }

        public override string Message { get; }

        public TaskException(string code, string msg)
        {
            Code = code;
            Msg = msg;

            Message = "Task failed.";
        }
    }
}