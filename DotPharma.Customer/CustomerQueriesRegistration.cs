using DotPharma.Customer.Contracts;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DotPharma.Customer;

public static class CustomerQueriesRegistration
{
    public static IServiceCollection RegisterCustomerQueries(this IServiceCollection serviceCollection)
    {
        return serviceCollection
            .AddTransient(s => new GetCustomerQuery(id => s.GetRequiredService<CustomerDbContext>().FindAsync<Contracts.Customer>(id)))
            .AddTransient(s => new GetAllCustomersQuery(() => s.GetRequiredService<CustomerDbContext>().Customers.ToListAsync()));
    }
}

