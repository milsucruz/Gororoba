using GororobaAPI.DTOs.Requests;
using GororobaAPI.DTOs.Responses;
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

        public async Task<List<RecipesSearchDto>> GetRecipesByIngredient(string ingredient)
        {
            var apiKey = _config["SpoonacularApi:ApiKey"];
            var url = $"https://api.spoonacular.com/recipes/complexSearch?apiKey={apiKey}&query={ingredient}&number=2";

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonSerializer.Deserialize<RecipesSearchResultDto>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return result?.Results ?? new();
            }
            else
            {
                throw new Exception("Failed to fetch data from Spoonacular API");
            }
        }

        public async Task<RecipeDetailsDto> GetRecipeDetails(int recipeId)
        {
            var apiKey = _config["SpoonacularApi:ApiKey"];

            var url = $"https://api.spoonacular.com/recipes/{recipeId}/information?apiKey={apiKey}";

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                var result = JsonSerializer.Deserialize<RecipeDetailsDto>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return result;
            }
            else
            {
                throw new Exception("Failed to fetch data from Spoonacular API");
            }
        }
    }
}
