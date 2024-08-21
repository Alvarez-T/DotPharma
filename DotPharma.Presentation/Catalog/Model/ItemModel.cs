using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using DotPharma.Pricing.Contracts;
using NavigatR.Validations;

namespace DotPharma.Presentation.Catalog.Model;

public sealed partial class ItemModel : ObservableValidator
{
    [ObservableProperty] 
    private string _sku;
    
    [ObservableProperty] 
    private bool _canChangeDescription;

    [ObservableProperty]
    [Required]
    [StringLength(60)]
    private string _description;

    [ObservableProperty] 
    private ItemPrice _itemPrice;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Total))]
    private int _quantity;

    public decimal Total { get; set; }

}
