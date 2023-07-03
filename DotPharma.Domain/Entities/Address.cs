namespace DotPharma.Domain.Entities;

public class Address
{
    public int Id { get; set; }
    public string Road { get; set; }
    public string Number { get; set; }
    public string District { get; set; }
    public int CityId { get; set; }
}