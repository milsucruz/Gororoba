namespace GororobaUI.DTOs
{
    public class RecipeDetailsDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Image { get; set; }

        public int ReadyInMinutes { get; set; }

        public int? CookingMinutes { get; set; }

        public int Servings { get; set; }

        public string Summary { get; set; }

        public string Instructions { get; set; }

        public List<IngredientsDto> ExtendedIngredients { get; set; } = new();
    }
}
