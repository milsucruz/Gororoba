using GororobaUI.DTOs;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace GororobaUI.Components.Pages
{
    public partial class Home
    {
        [Inject]
        public IDialogService DialogService { get; set; } = default!;

        private string searchQuery = string.Empty;

        private List<RecipesSearchDto> recipes = new();

        private async Task GetRecipesByIngredient()
        {
            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                try
                {
                    var url = $"/api/gororoba/search?query={searchQuery}";

                    recipes = await Http.GetFromJsonAsync<List<RecipesSearchDto>>(url) ?? new();
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
    }
}