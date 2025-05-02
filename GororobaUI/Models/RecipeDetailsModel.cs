namespace GororobaUI.Models
{
    public class RecipeDetailsModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public int ReadyInMinutes { get; set; }
        public int Servings { get; set; }
        public string Summary { get; set; }

        public string Instructions { get; set; }

        public List<Ingredient> ExtendedIngredients { get; set; }

        public class Ingredient
        {
            public string Name { get; set; }
            public string Original { get; set; }
        }
    }
}