namespace Coffeeuno.Shared.BuildingBlocks;

public abstract class DomainEntity
{
    private List<IDomainEvent> _domainEvents;
    public IReadOnlyList<IDomainEvent>? DomainEvents => _domainEvents.AsReadOnly();

    protected void AddEvent(IDomainEvent domainEvent)
    {
        _domainEvents ??= new List<IDomainEvent>();
        _domainEvents.Add(domainEvent);
    }
}