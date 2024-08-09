using CommunityToolkit.Mvvm.ComponentModel;

namespace DotPharma.Presentation.Catalog.Model;

public sealed partial class SaleItemModel : ObservableObject
{

    [ObservableProperty] 
    private string _sku;

    [ObservableProperty]
    private string _description;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Total))]
    private decimal _price;

    [ObservableProperty]
    private decimal _grossPrice;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Total))]
    private decimal _discount;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Total))]
    private int _quantity;

    public decimal Total { get; set; }

}