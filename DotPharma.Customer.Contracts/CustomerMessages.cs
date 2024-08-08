using Act.Common.Types;
using Act.Location.Contracts;
using DotPharma.Abstract;

namespace DotPharma.Customer.Contracts;

public sealed record CustomerPersonalInfoUpdated(CustomerId CustomerId, string Name, CPF CPF, RG RG, string Cellphone, string Email);
public sealed record CustomerAddressUpdated(CustomerId CustomerId, Address Address);