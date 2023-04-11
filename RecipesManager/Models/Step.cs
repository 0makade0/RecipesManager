namespace RecipesManager.Models;

public class Step
{
    public Guid Id { get; private init; }
    public TimeOnly CookingTime { get; private set; }
    public string Description { get; private set; }

    public Step(Guid id, TimeOnly cookingTime, string description)
    {
        if (id == Guid.Empty)
        {
            throw new ArgumentOutOfRangeException(nameof(id));
        }

        ArgumentNullException.ThrowIfNull(cookingTime);
        ArgumentException.ThrowIfNullOrEmpty(description);
        
        Id = id;
        CookingTime = cookingTime;
        Description = description;
    }

    public void UpdateCookingTime(TimeOnly cookingTime)
    {
        ArgumentNullException.ThrowIfNull(cookingTime);
        
        CookingTime = cookingTime;
    } 
    
    public void UpdateDescription(string description)
    {
        ArgumentException.ThrowIfNullOrEmpty(description);
        
        Description = description;
    }
}