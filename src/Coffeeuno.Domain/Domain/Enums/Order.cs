namespace Coffeeuno.Fungi.Domain.Enums;

/// <summary>
/// Fungi order enumeration based on a linnaean taxonomy classification system
/// </summary>
public sealed class Order
{
    public static Order Agaricomycetidae { get; } = new Order(0, nameof(Agaricomycetidae));
    public static Order Phallomycetidae { get; } = new Order(1, nameof(Phallomycetidae));
    public static Order Problematica { get; } = new Order(2, nameof(Problematica));
    public static IEnumerable<Order> List()
        => new[] { Agaricomycetidae, Phallomycetidae, Problematica };
    
    public string Name { get; private set; }
    public int Value { get; private set; }
    
    private Order(int val, string name) 
    {
        Value = val;
        Name = name;
    }
    
    public static Order FromValue(int value)
        => List().Single(o => o.Value == value);
}