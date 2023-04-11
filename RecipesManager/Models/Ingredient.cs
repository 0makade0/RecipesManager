namespace RecipesManager.Models;

public class Ingredient
{
    public Guid Id { get; private init; }
    public string Title { get; private set; }
    public double Amount { get; private set; }
    public double Calories { get; private set; }
    public double Proteins { get; private set; }
    public double Fats { get; private set; }
    public double Carbohydrate { get; private set; }

    public Ingredient(Guid id, string title, double amount, double calories, double proteins, double fats, double carbohydrate)
    {
        if (id == Guid.Empty)
        {
            throw new ArgumentOutOfRangeException(nameof(id));
        }
        ArgumentNullException.ThrowIfNull(title);
        
        Id = id;
        Title = title;
        Amount = amount;
        Calories = calories;
        Proteins = proteins;
        Fats = fats;
        Carbohydrate = carbohydrate;
    }
}