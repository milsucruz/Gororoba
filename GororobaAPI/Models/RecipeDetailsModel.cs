namespace GororobaAPI.Models
{
    public class RecipeDetailsModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

        public int ReadyInMinutes { get; set; }

        public int Servings { get; set; }

        public string Summary { get; set; } = string.Empty;

        public string Instructions { get; set; } = string.Empty;


        public List<IngredientModel> Ingredients { get; set; } = new();
    }
}
