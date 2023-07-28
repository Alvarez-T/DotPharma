namespace DotPharma.Customer.Contracts;

public delegate ValueTask<CustomerModel?> GetCustomerQuery(int customerId);

public delegate Task<List<CustomerModel>> GetAllCustomersQuery();

