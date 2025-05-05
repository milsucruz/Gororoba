using GororobaUI.DTOs.Requests;
using GororobaUI.Models;

namespace GororobaUI.Services
{
    public class RecipesService
    {
        private readonly HttpClient _http;

        public RecipesService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<RecipesSearchDto>> SearchRecipes(string ingredients)
        {
            var response = await _http.GetFromJsonAsync<List<RecipesSearchDto>>($"api/recipes/search?ingredients={ingredients}");
            return response ?? new List<RecipesSearchDto>();
        }
    }

}
