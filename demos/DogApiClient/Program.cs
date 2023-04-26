// Retrieves all breeds from https://dog.ceo/dog-api/
// Then asks the user to select a breed
// Then retrieves a random image of the selected breed
// And downloads the image to the downloads folder

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace DogApiClient
{
    class Program
    {
        private static readonly JsonSerializerOptions JsonSerializerOptions = new(JsonSerializerDefaults.Web)
        {
            DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
        };

        static async Task Main(string[] args)
        {
            var breeds = await GetBreedsAsync();
            var breed = SelectBreed(breeds);
            var imageUrl = await GetRandomImageAsync(breed);
            Console.WriteLine($"Downloading {imageUrl}");

            Directory.CreateDirectory("downloads");
            var fileName = Path.GetFileName(imageUrl);
            var filePath = Path.Combine("downloads", fileName);
            filePath = Path.GetFullPath(filePath);
            await DownloadImageAsync(imageUrl, filePath);

            Console.WriteLine($"Downloaded {fileName} to {filePath}");
        }

        private static async Task DownloadImageAsync(string imageUrl, string filePath)
        {
            using var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(imageUrl);
            var buffer = await response.Content.ReadAsByteArrayAsync();
            await File.WriteAllBytesAsync(filePath, buffer);
        }

        private static async Task<string> GetRandomImageAsync(string breed)
        {
            using var httpClient = new HttpClient();
            var url = $"https://dog.ceo/api/breed/{breed}/images/random";
            var response = await httpClient.GetFromJsonAsync<RandomImageResponse>(url, JsonSerializerOptions);
            return response.Message;
        }

        private static string SelectBreed(List<string> breeds)
        {
            while (true)
            {
                Console.WriteLine("Select a breed:");
                for (var i = 0; i < breeds.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {breeds[i]}");
                }

                Console.Write($"Please enter a number between 1 and {breeds.Count}: ");
                var selection = Console.ReadLine();
                if (int.TryParse(selection, out var index) && index > 0 && index <= breeds.Count)
                {
                    Console.WriteLine("Selected " + breeds[index - 1]);
                    return breeds[index - 1];
                }

                Console.WriteLine("Invalid selection");
            }
        }

        private static async Task<List<string>> GetBreedsAsync()
        {
            using var httpClient = new HttpClient();
            var url = "https://dog.ceo/api/breeds/list/all";
            var response = await httpClient.GetFromJsonAsync<BreedsResponse>(url, JsonSerializerOptions);
            var breeds = new List<string>();
            foreach (var mainBreed in response.Message.Keys)
            {
                foreach (var subBreed in response.Message[mainBreed])
                {
                    breeds.Add(mainBreed + "/" + subBreed);
                }
            }

            return breeds;
        }
    }

    public class BreedsResponse
    {
        public Dictionary<string, string[]> Message { get; set; }
    }

    public class RandomImageResponse
    {
        public string Message { get; set; }
    }
}