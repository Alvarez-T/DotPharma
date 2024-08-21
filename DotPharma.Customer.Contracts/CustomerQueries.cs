namespace DotPharma.Customer.Contracts;

public delegate ValueTask<Customer?> GetCustomerQuery(int customerId);

public delegate Task<List<Customer>> GetAllCustomersQuery();

 