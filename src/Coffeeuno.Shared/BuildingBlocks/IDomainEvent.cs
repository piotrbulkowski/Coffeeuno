namespace Coffeeuno.Shared.BuildingBlocks;

public interface IDomainEvent
{
    Guid Id { get; }
}