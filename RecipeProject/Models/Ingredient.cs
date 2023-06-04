namespace RecipeProject.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string UnitOfMeasurement { get; set; } = string.Empty;
        public string? Notes { get; set; }
    }

}