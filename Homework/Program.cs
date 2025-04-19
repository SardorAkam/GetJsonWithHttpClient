using Homework;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
namespace HomeWork
{
    class Program
    {
        static async Task Main()
        {
            HttpClient httpClient = new HttpClient();

            var data = await httpClient.GetFromJsonAsync<IList<Customer>>(@"https://microsoftedge.github.io/Demos/json-dummy-data/64KB.json");
            var option = new JsonSerializerOptions();
            option.WriteIndented = true;
            var jsonData = JsonSerializer.Serialize(data, option);
            Console.WriteLine(jsonData);
        }
    }
} 