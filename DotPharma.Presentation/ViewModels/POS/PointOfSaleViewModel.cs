using CommunityToolkit.Mvvm.ComponentModel;
using DotPharma.Domain.Entities.Enums;
using NavigatR;

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
