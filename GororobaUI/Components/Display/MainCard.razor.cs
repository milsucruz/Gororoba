using Microsoft.AspNetCore.Components;

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
    }
}
