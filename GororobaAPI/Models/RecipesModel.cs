namespace GororobaAPI.Models
{
    public class RecipesModel
    {
        public int Id { get; set; }

        public string RecipeName { get; set; } = string.Empty;

        public string RecipeDescription { get; set; } = string.Empty;

        public string RecipeImage { get; set; } = string.Empty;

        public int RecipeTime { get; set; }
    }
}
