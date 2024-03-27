using DotPharma.Customer.Contracts;

namespace DotPharma.Customer;

public static class RegisterCustomerHandler
{
    public static void Handle(RegisterCustomer command, CustomerDbContext customerDbContext)
    {
        var customer = new Contracts.Customer
        {
            Name = command.Name,
            CPF = command.CPF,
            RG = command.RG,
            CreationDate = DateTime.Now
        };

        customerDbContext.Customers.Add(customer);
    }
}
