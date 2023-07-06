using CommunityToolkit.Mvvm.ComponentModel;
using NavigatR;

namespace DotPharma.Presentation.ViewModels.Tiles;

public partial class RegisterProductDetailsViewModel : ObservableValidator, IViewModelTile
{
    [ObservableProperty]
    private string _labNameSearched;

    [ObservableProperty]
    private string _groupNameSearched;

    [ObservableProperty]
    private string _ean;
}
