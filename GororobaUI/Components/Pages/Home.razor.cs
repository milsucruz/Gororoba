using GororobaUI.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace GororobaUI.Components.Pages
{
    public partial class Home
    {
        [Inject]
        private IConfiguration _config { get; set; }

        [Inject] 
        public IDialogService DialogService { get; set; } = default!;

        private string searchQuery = string.Empty;

        private List<RecipesSearchModel> recipes = new();

        private async Task SearchRecipes()
        {
            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                try
                {
                    var apiKey = _config["SpoonacularApi:ApiKey"];
                    var url = $"https://api.spoonacular.com/recipes/complexSearch?apiKey={apiKey}&query={searchQuery}&number=9";

                    var result = await Http.GetFromJsonAsync<RecipesSearchResult>(url);

                    recipes = result?.Results ?? new List<RecipesSearchModel>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error when searching for recipes: {ex.Message}");
                }
            }
            else
            {
                recipes.Clear();
                Console.WriteLine("Type in something to search for.");
            }
        }

        public class RecipesSearchResult
        {
            public List<RecipesSearchModel> Results { get; set; } = new();
        }
    }
}
