using Coffeeuno.Domain.ValueObjects;
using Coffeeuno.Shared.BuildingBlocks;

namespace Coffeeuno.Domain;

public class Product : DomainEntity
{
    public int Id { get; private set; }
    private MoneyValueObject _price;

    internal static Product CreateNew(int Id, MoneyValueObject price)
    {
        throw new NotImplementedException();
    }
}