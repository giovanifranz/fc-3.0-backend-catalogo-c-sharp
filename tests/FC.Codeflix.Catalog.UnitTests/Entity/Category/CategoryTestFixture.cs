using Xunit;

namespace FC.Codeflix.Catalog.UnitTests.Entity.Category;

using DomainEntity = Domain.Entity;

public class CategoryTestFixture
{
    public DomainEntity.Category GetValidCategory()
    {
        return new DomainEntity.Category("Category name", "Category description");
    }
}

[CollectionDefinition(nameof(CategoryTestFixture))]
public class CategoryTestFixtureCollection : ICollectionFixture<CategoryTestFixture>
{
}