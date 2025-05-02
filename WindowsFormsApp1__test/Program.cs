using System;
using RestSharp;
using Newtonsoft.Json;
public class DeepSeekApiClient
{
    private readonly string _apiKey;
    private const string ApiUrl = "https://api.deepseek.com/v1/chat/completions";

    public DeepSeekApiClient(string apiKey)
    {
        _apiKey = apiKey;
    }

    public string GetChatCompletion(string prompt)
    {
        var client = new RestClient(ApiUrl);
        var request = new RestRequest(Method.POST);

        request.AddHeader("Content-Type", "application/json");
        request.AddHeader("Authorization", $"Bearer {_apiKey}");

        var requestBody = new
        {
            model = "deepseek-chat",
            messages = new[]
            {
                new { role = "user", content = prompt }
            },
            temperature = 0.7,
            max_tokens = 2000
        };

        request.AddJsonBody(JsonConvert.SerializeObject(requestBody));

        var response = client.Execute(request);

        if (!response.IsSuccessful)
        {
            throw new Exception($"API request failed: {response.StatusCode} - {response.Content}");
        }

        dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
        return jsonResponse.choices[0].message.content;
    }
}

// 使用示例
class Program
{
    static void Main(string[] args)
    {
        var apiKey = "your_api_key_here"; // 替换为你的实际 API 密钥
        var client = new DeepSeekApiClient(apiKey);

        try
        {
            string prompt = "请解释一下量子计算的基本概念";
            string response = client.GetChatCompletion(prompt);
            Console.WriteLine(response);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"发生错误: {ex.Message}");
        }
    }
}