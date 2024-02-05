using Coffeeuno.Fungi.Domain.Enums;

namespace Coffeeuno.Domain.Application.Queries.GetRoaster;

public sealed class RoasterDto
{
    public string Name { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
    public TasteEnum Taste { get; set; }
    public string PhotoUrl { get; set; }
}