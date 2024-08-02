using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using DotPharma.Presentation.Models;
using NavigatR;

namespace DotPharma.Presentation.ViewModels.PDV;

public partial class PDVMenuTileModel : ObservableRecipient, IViewModel
{
    [ObservableProperty] private SalesType _salesType;
    [ObservableProperty] private bool _isDelivery;
    [ObservableProperty] private bool _isShipment;

    public PDVMenuTileModel()
    {
        
    }
}