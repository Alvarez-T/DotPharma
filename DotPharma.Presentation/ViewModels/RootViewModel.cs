using CommunityToolkit.Mvvm.ComponentModel;
using DotPharma.Presentation.ViewModels.PDV;
using NavigatR;
using NavigatR.Providers;

namespace DotPharma.Presentation.ViewModels;

public partial class RootViewModel : ObservableObject, IViewModel
{
    [ObservableProperty] private PointOfSaleViewModel _pointOfSale;
    [ObservableProperty] private INavigator _navigator;

    public RootViewModel(IViewModelProvider viewModelProvider, INavigator navigator)
    {
        PointOfSale = viewModelProvider.GetViewModel<PointOfSaleViewModel>();
        Navigator = navigator;
    }
}