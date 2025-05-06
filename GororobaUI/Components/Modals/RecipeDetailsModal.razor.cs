using GororobaUI.DTOs;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace GororobaUI.Components.Modals
{
    public partial class RecipeDetailsModal
    {
        [CascadingParameter]
        IMudDialogInstance? MudDialog { get; set; }

        [Parameter]
        public int recipeId { get; set; }

        private RecipeDetailsDto? recipe;

        protected override async Task OnInitializedAsync()
        {
            var url = $"/api/gororoba/details/{recipeId}";

            recipe = await Http.GetFromJsonAsync<RecipeDetailsDto>(url) ?? new();

            if (recipe == null)
            {
                Console.WriteLine("Recipe not found");
                MudDialog?.Cancel();
            }
        }
    }
}