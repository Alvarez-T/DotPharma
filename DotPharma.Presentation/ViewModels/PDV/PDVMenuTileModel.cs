using System.ComponentModel;
using CommunityToolkit.Mvvm.ComponentModel;
using DotPharma.Presentation.Models;
using NavigatR;
using NavigatR.CommunityToolkit;

namespace DotPharma.Presentation.ViewModels.PDV;

public partial class PDVMenuTileModel : ObservableViewModel
{
    public PDVMenuTileModel()
    {

    }

    private SalesType _salesType;
    public SalesType SalesType
    {
        get => _salesType;
        set => SetPropertyAndBroadcast(ref _salesType, value);
    }

    [ObservableProperty] private bool _isDelivery;
    [ObservableProperty] private bool _isShipment;
}