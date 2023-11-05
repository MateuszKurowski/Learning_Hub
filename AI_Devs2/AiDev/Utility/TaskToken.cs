using AI_Devs2.Tasks.src;
using Newtonsoft.Json.Linq;
using RestSharp;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AI_Devs2.Utility;
internal class TaskToken
{
    public static string? GetTaksToken(string name, string apiKey)
    {
        var client = new RestClient(new Uri(ITask.AuthorizeLink, name.ToLower()));
        var request = new RestRequest();
        request.Method = Method.Post;
        request.AddJsonBody(new { apikey = apiKey });
        var response = client.Execute(request);
        if (!string.IsNullOrWhiteSpace(response.Content))
        {
            var responseObject = JObject.Parse(response.Content);

            var statusCode = responseObject["code"]?.ToString();
            if (statusCode is null or not "0")
                return null;

            var token = responseObject["token"]?.ToString();
            if (string.IsNullOrWhiteSpace(token))
                return null;

            return token;
        }
        return null;
    }
}
