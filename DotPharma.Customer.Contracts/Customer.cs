using DotPharma.Abstract;

namespace DotPharma.Customer.Contracts;

public class Customer
{
    public string Name { get; set; }
    public CPF CPF { get; set; }
    public RG RG { get; set; }
    public DateTime CreationDate { get; set; }
}


