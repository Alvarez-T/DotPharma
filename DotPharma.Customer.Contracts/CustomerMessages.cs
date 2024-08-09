using Act.Common.Types;
using Act.Location.Contracts;
using DotPharma.Abstract;

namespace DotPharma.Customer.Contracts;

public record CustomerPersonalInfoUpdated(CustomerId CustomerId, string Name, CPF CPF, RG RG, string Cellphone, string Email);
public record CustomerAddressUpdated(CustomerId CustomerId, Address Address);