using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

class Program
{
    static async Task Main(string[] args)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        var productId = config["MaytapiSettings:ProductId"];
        var phoneId = config["MaytapiSettings:PhoneId"];
        var apiKey = config["MaytapiSettings:ApiKey"];

        var client = new HttpClient();
        var url = $"https://api.maytapi.com/api/{productId}/{phoneId}/sendMessage";

        client.DefaultRequestHeaders.Add("x-maytapi-key", apiKey);

        var payload = new
        {
            to_number = "905301234567",
            type = "text",
            message = "Hello World"
        };

        var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

        var response = await client.PostAsync(url, content);
        var responseContent = await response.Content.ReadAsStringAsync();

        Console.WriteLine($"Response: {responseContent}");
    }
}