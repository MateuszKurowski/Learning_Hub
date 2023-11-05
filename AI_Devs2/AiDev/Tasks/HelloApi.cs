using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using AI_Devs2.Tasks.src;
using AI_Devs2.Utility;

using Newtonsoft.Json.Linq;

using RestSharp;

namespace AI_Devs2.Tasks;
internal class HelloApi : ITask
{
    public string Name { get; set; } = "HelloApi";

    public string? TaskToken { get; set; }

    public JObject TaskJson { get; set; }

    string? ITask.GetTaskDescription(string apiKey)
    {
        TaskToken = Utility.TaskToken.GetTaksToken(Name, apiKey);

        var client = new RestClient(new Uri(ITask.TaskLink, TaskToken));
        var request = new RestRequest();
        request.Method = Method.Get;
        var response = client.Execute(request);
        if (!string.IsNullOrWhiteSpace(response.Content))
        {
            var responseObject = JObject.Parse(response.Content);
            TaskJson = responseObject;

            var statusCode = responseObject["code"]?.ToString();
            if (statusCode is null or not "0")
                return null;

            var taskDescription = responseObject["msg"]?.ToString();
            if (string.IsNullOrWhiteSpace(taskDescription))
                return null;

            return taskDescription;
        }
        return null;

    }

    bool ITask.Execute()
    {
        var answer = TaskJson["cookie"]?.ToString();
        if (string.IsNullOrWhiteSpace(answer))
            MessageBox.Show("Wystąpił błąd z zadaniem, nie znaleziono parametru 'cookie'.", "Nie można wykonać zadnia");

        var client = new RestClient(new Uri(ITask.AnswerLink, TaskToken));
        var request = new RestRequest
        {
            Method = Method.Post
        };

        request.AddJsonBody(new { answer });
        var response = client.Execute(request);
        if (!string.IsNullOrWhiteSpace(response.Content))
        {
            var responseObject = JObject.Parse(response.Content);

            var statusCode = responseObject["code"]?.ToString();
            if (statusCode == "0")
                return true;
            else
                return false;
        }
        return false;
    }

}
