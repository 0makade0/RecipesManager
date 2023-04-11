namespace RecipesManager.Models;

public class Recipe
{
    public Guid Id { get; private init; }
    public string Title { get; private set; }
    public DishType Type { get; private set; }
    public string Description { get; private set; }
    public DateTime PublicationDate { get; private set; }
    public Uri Photo { get; private set; }
    public int NumberOfServing { get; private set; }
    public Complexity Complexity { get; private set; }

    public Recipe(Guid id, string title, DishType type, string description, DateTime publicationDate, Uri photo,
        int numberOfServing, Complexity complexity)
    {
        if (id == Guid.Empty)
        {
            throw new ArgumentNullException(nameof(id));
        }

        ArgumentNullException.ThrowIfNull(title);
        ArgumentNullException.ThrowIfNull(description);
        ArgumentNullException.ThrowIfNull(publicationDate);

        Id = id;
        Title = title;
        Type = type;
        Description = description;
        PublicationDate = DateTime.Now;
        Photo = photo;
        NumberOfServing = numberOfServing;
        Complexity = complexity;
    }

    public void UpdateTitle(string title)
    {
        ArgumentNullException.ThrowIfNull(title);

        Title = title;
    }

    public void UpdateDescription(string description)
    {
        ArgumentNullException.ThrowIfNull(description);

        Description = description;
    }

    public void UpdatePhoto(Uri photo)
    {
        ArgumentNullException.ThrowIfNull(photo);

        Photo = photo;
    }

    public void UpdateNumberOfServing(int numberOfServing)
    {
        ArgumentNullException.ThrowIfNull(numberOfServing);

        NumberOfServing = numberOfServing;
    }
}