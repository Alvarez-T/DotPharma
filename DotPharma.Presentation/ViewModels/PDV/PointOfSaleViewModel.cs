using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DotPharma.Presentation.ViewModels.PDV;
using NavigatR;
using NavigatR.Providers;

namespace DotPharma.Presentation.ViewModels.PDV;

public partial class PointOfSaleViewModel : ObservableObject, INavigableViewModel
{
    private readonly INavigator _navigator;

    [ObservableProperty] private PDVMenuTileModel _pdvMenu;
    [ObservableProperty] private PaymentViewModel _paymentViewModel;

    public PointOfSaleViewModel(INavigator navigator, IViewModelProvider viewModelProvider)
    {
        _navigator = navigator;

        PdvMenu = viewModelProvider.GetViewModel<PDVMenuTileModel>();
        PaymentViewModel = viewModelProvider.GetViewModel<PaymentViewModel>();
    }

    [RelayCommand]
    public void GoToPayment()
    {
        _navigator.NavigateTo(_paymentViewModel);
    }

}
