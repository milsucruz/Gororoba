using GororobaUI.Components.Modals;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace GororobaUI.Components.Display
{
    public partial class MainCard
    {
        [Parameter]
        public string? RecipeTitle { get; set; }

        [Parameter]
        public string? ImageUrl { get; set; }

        [Parameter]
        public int RecipeId { get; set; }

        public async Task ShowRecipeDetails()
        {
            var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.Medium, FullWidth = true };

            var parameters = new DialogParameters { ["RecipeId"] = RecipeId };

            await DialogService.ShowAsync<RecipeDetailsModal>("", parameters, options);
        }
    }
}