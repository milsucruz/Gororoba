using GororobaUI.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace GororobaUI.Components.Modals
{
    public partial class RecipeDetailsModal
    {
        [Inject]
        private IConfiguration _config { get; set; }

        [CascadingParameter]
        IMudDialogInstance? MudDialog { get; set; }

        [Parameter]
        public int RecipeId { get; set; }

        private RecipeDetailsModel? recipe;

        protected override async Task OnInitializedAsync()
        {
            var apiKey = _config["SpoonacularApi:ApiKey"];

            recipe = await Http.GetFromJsonAsync<RecipeDetailsModel>($"https://api.spoonacular.com/recipes/{RecipeId}/information?apiKey={apiKey}");

            if (recipe == null)
            {
                Console.WriteLine("Recipe not found");
                MudDialog?.Cancel();
            }
            else
            {
                Console.WriteLine("Recipe not found");
            }
        }
    }
}