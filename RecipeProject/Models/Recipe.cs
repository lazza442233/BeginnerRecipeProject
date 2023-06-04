namespace RecipeProject.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public List<Ingredient> Ingredients { get; set; } 
        public List<Instruction> Instructions { get; set; }
        public DifficultyLevel DifficultyLevel { get; set; }

    }

    public enum DifficultyLevel
    {
        None,
        Easy,
        Intermediate,
        Advanced
    }
}
