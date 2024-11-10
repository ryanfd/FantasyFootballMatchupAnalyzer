using System.Net.Http;
using System.Threading.Tasks;
using System;
using Newtonsoft.Json;
using FantasyFootballMatchupAnalyzer.Shared;

namespace FantasyFootballMatchupAnalyzer.Classes.Helpers
{
    public static class RequestDataHelper
    {
        public static async Task<T> RequestData<T>(string apiPath)
        {
            T result = default;

            using (var httpClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(apiPath);

                    // Ensure a successful response
                    response.EnsureSuccessStatusCode();

                    // Read and deserialize the response content
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    result = JsonConvert.DeserializeObject<T>(jsonResponse);
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Error({e.Message}): {e.Message}");
                }
            }

            return result;
        }
    }
}
