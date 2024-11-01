using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace fall24_assn3_zjrowell.Services
{
	public class OpenAIService
	{
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;

        public OpenAIService(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;
            _apiKey = config["OpenAI:ApiKey"];
        }

        public async Task<string> GetAiReviewAsync(string prompt)
        {
            var requestContent = new
            {
                prompt = prompt,
                max_tokens = 100
            };

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://api.openai.com/v1/completions"),
                Content = new StringContent(JsonSerializer.Serialize(requestContent), Encoding.UTF8, "application/json")
            };

            request.Headers.Add("Authorization", $"Bearer {_apiKey}");

            var response = await _httpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}

