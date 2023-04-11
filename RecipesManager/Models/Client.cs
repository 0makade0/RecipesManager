namespace RecipesManager.Models;

public class Client
{
    public Guid Id { get; private init; }
    public string Name { get; private set; }
    public string SecondName { get; private set; }
    public List<Recipe> SelfRecipes { get; private set; }
    public List<Recipe> LikeRecipes { get; private set; }

    public Client(Guid id, string name, string secondName)
    {
        if (id == Guid.Empty)
        {
            throw new ArgumentOutOfRangeException(nameof(id));
        }
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(secondName);
        
        Id = id;
        Name = name;
        SecondName = secondName;
        SelfRecipes = new List<Recipe>();
        LikeRecipes = new List<Recipe>();
    }
    
    public void UpdateName(string name)
    {
        ArgumentNullException.ThrowIfNull(name);

        Name = name;
    } 
    
    public void UpdateSecondName(string secondName)
    {
        ArgumentNullException.ThrowIfNull(secondName);

        SecondName = secondName;
    }
}