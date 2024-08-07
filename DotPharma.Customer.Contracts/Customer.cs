using Act.Common.Types;
using Act.Location.Contracts;
using DotPharma.Abstract;

namespace DotPharma.Customer.Contracts;

public record Customer
{
    public required string Name { get; init; }
    public CPF? CPF { get; init; }
    public RG? RG { get; init; }
    public string? Cellphone { get; init; }
    public string? Email { get; init; }
    public Address? Address { get; init; }
}


