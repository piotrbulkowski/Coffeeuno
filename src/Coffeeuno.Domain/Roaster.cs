using Coffeeuno.Shared.BuildingBlocks;

namespace Coffeeuno.Domain;

public class Roaster : DomainEntity
{
    public int Id { get; private set; }
    public string NameShort { get; }
}