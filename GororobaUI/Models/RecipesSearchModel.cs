namespace GororobaUI.Models
{
    public class RecipesSearchModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

        public int UsedIngredientCount { get; set; }

        public int MissedIngredientCount { get; set; }

        public int Likes { get; set; }
    }
}
