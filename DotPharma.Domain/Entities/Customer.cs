namespace DotPharma.Domain.Entities;

public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public string CPF { get; set; }
    public string RG { get; set; }
    public Address Address { get; set; }

}