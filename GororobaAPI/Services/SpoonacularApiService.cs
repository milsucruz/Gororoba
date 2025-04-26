using GororobaAPI.Models;
using System.Text.Json;

namespace GororobaAPI.Services
{
    public class SpoonacularApiService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _config;

        public SpoonacularApiService(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;
            _config = config;
        }
        public async Task<List<RecipesSearchModel>> SearchByIngredient(string ingredient)
        {
            var apiKey = _config["SpoonacularApi:ApiKey"];
            var url = $"https://api.spoonacular.com/recipes/findByIngredients?ingredients={ingredient}&apiKey={apiKey}";

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<RecipesSearchModel>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new();
            }
            else
            {
                throw new Exception("Failed to fetch data from Spoonacular API");
            }
        }
    }
}
