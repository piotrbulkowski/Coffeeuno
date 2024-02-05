using Shroomie.Fungi.Domain.Enums;

namespace Shroomie.Fungi.Application.Queries.GetFungi;

public sealed class FungiDto
{
    public string Name { get; set; }
    public string LatinName { get; set; }
    public TasteEnum Taste { get; set; }
    public string PhotoUrl { get; set; }
}