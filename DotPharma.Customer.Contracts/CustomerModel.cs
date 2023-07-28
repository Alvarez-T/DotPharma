using DotPharma.Abstract;

namespace DotPharma.Customer.Contracts;

public class CustomerModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public CPF CPF { get; set; }
    public RG RG { get; set; }
    public DateTime CreationDate { get; set; }
}


