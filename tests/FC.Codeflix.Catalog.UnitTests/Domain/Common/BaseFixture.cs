using Bogus;

namespace FC.Codeflix.Catalog.UnitTests.Domain.Common;

public abstract class BaseFixture
{
    protected BaseFixture()
    {
        Faker = new Faker("pt_BR");
    }

    public Faker Faker { get; set; }
}