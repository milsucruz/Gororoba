namespace GororobaAPI.Models
{
    public class IngredientModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Amount { get; set; }

        public string Unit { get; set; } = string.Empty;
    }
}
