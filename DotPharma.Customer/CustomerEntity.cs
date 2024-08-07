using Act.Common.Types;
using Act.Location.Contracts;
using DotPharma.Customer.Contracts;

namespace DotPharma.Customer;

internal sealed class CustomerEntity
{
    public required CustomerId CustomerId { get; set; }
    public required string Name { get; set; }
    public CPF CPF { get; set; }
    public RG RG { get; set; }
    public string? Cellphone { get; set; }
    public string? Email { get; set; }
}