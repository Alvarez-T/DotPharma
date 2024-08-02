

using Dotfy.Location.Contracts;

namespace DotPharma.Customer;

internal sealed class AddressEntity
{
    public required PostalCode PostalCode { get; set; }
    public required string Street { get; set; }
    public required string Number { get; set; }
    public required string District { get; set; }
    public required City City { get; set; }
    public required State State { get; set; }
    public string? Complement { get; set; }
}