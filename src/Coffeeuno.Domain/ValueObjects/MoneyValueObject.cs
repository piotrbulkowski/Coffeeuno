using Coffeeuno.Domain.Enums;
using Coffeeuno.Shared.BuildingBlocks;

namespace Coffeeuno.Domain.ValueObjects;

public class MoneyValueObject : ValueObject
{
    public decimal Value { get; }
    public CurrencyEnum Currency { get; }

    public static MoneyValueObject CreateNew(decimal value, CurrencyEnum currency)
    {
        return new MoneyValueObject(value, currency);
    }
    private MoneyValueObject(decimal value, CurrencyEnum currency)
    {
        Value = value;
        Currency = currency;
    }
}