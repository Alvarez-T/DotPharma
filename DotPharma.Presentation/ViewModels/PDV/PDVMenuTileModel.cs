using CommunityToolkit.Mvvm.ComponentModel;
using DotPharma.Presentation.Models;
using NavigatR;

namespace DotPharma.Presentation.ViewModels.PDV;

public partial class PDVMenuTileModel : ObservableObject, IViewModel
{
    [ObservableProperty] private SalesType _salesType;
    [ObservableProperty] private bool _isDelivery;
    [ObservableProperty] private bool _isShipment;
}