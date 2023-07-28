namespace DotPharma.Catalog
{
    public class Product
    {
        public int Guid { get; set; }
        public string Name { get; set; }
        public ProductGroup Group { get; set; }
        public List<Barcode> Barcodes { get; set; }
    }
}