namespace DotPharma.Presentation.Models;

public class ProductModel
{
    public int Id { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public decimal RealPrice { get; set; }
    public decimal LiquidPrice { get; set; }
    public int Quantity { get; set; }
}
