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

        if (Name.Length < 3)
            throw new EntityValidationException($"{nameof(Name)} should have at least 3 characters long");

        if (Name.Length > 255)
            throw new EntityValidationException($"{nameof(Name)} should be less or equal 255 characters long");

        if (Description == null)
            throw new EntityValidationException($"{nameof(Description)} should not be empty or null");

        if (Description.Length > 10_000)
            throw new EntityValidationException(
                $"{nameof(Description)} should be less or equal 10.000 characters long");
    }
}