namespace DotPharma.Location;

public abstract class Address
{
    public int Id { get; set; }
    public string Road { get; set; }
    public string Number { get; set; }
    public string District { get; set; }
    public City City { get; set; }
    public State State { get; set; }
    public ZipCode ZipCode { get; set; }
}

public class CustomerAddress : Address
{
    public int CustomerId { get; set; }
}



public readonly struct ZipCode
{
    public readonly string Value;

    public ZipCode(string zipCode)
    {
        Value = zipCode;
    }
}