namespace FC.Codeflix.Catalog.Application.UseCases.Category.CreateCategory;

public class CreateCategoryOutput
{
    public CreateCategoryOutput(
        Guid id,
        string name,
        string description,
        bool isActive,
        DateTime createdAt
    )
    {
        Id = id;
        Name = name;
        Description = description;
        IsActive = isActive;
        CreatedAt = createdAt;
    }

    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; }
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
}