using CommunityToolkit.Mvvm.ComponentModel;

namespace DotPharma.Presentation.ViewModels.POS;

public partial class PointOfSaleViewModel : ObservableObject, INavigableViewModel
{
    [ObservableProperty]
    private SaleMode _saleMode;

    [ObservableProperty]
    private bool _isDelivery;

    [ObservableProperty]
    private bool _isOrder;
}
