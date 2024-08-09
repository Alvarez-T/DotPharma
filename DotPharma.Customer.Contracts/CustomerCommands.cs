using Act.Common.Types;
using DotPharma.Abstract;

namespace DotPharma.Customer.Contracts
{
    public record RegisterCustomer(string Name, RG RG, CPF CPF);
}