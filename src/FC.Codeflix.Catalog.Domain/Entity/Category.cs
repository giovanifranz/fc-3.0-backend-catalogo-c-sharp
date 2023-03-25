using FC.Codeflix.Catalog.Domain.Exceptions;

namespace FC.Codeflix.Catalog.Domain.Entity;

public class Category
{
    public Category(string name, string description, bool isActive = true)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        IsActive = isActive;
        CreatedAt = DateTime.Now;
        Validate();
    }

    public Guid Id { get; }

    public bool IsActive { get; }

    public DateTime CreatedAt { get; }

    public string Name { get; }

    public string Description { get; }

    private void Validate()
    {
        if (string.IsNullOrWhiteSpace(Name))
            throw new EntityValidationException($"{nameof(Name)} should not be empty or null");

        if (Description == null)
            throw new EntityValidationException($"{nameof(Description)} should not be empty or null");
    }
}