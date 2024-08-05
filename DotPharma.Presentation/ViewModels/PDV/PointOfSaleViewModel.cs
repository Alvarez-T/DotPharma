using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using DotPharma.Presentation.Customer;
using DotPharma.Presentation.Models;
using DotPharma.Presentation.ViewModels.PDV;
using NavigatR;
using NavigatR.CommunityToolkit;
using NavigatR.Providers;

namespace DotPharma.Presentation.ViewModels.PDV;

public partial class PointOfSaleViewModel : ObservableRecipient, INavigableViewModel
{
    private readonly INavigator _navigator;
    [ObservableProperty] private PDVMenuTileModel _pdvMenu;
    [ObservableProperty] private CompactCustomerViewModel _customerViewModel;
    [ObservableProperty] private PaymentViewModel _paymentViewModel;

    public PointOfSaleViewModel(INavigator navigator, IViewModelProvider viewModelProvider)
    {
        _navigator = navigator;

        PdvMenu = viewModelProvider.GetViewModel<PDVMenuTileModel>();
        CustomerViewModel = viewModelProvider.GetViewModel<CompactCustomerViewModel>();
    }

    private void RegisterViewModelMessages()
    {
        BroadcastMessage.To(CustomerViewModel).On<ValueChanged<SalesType>>((viewModel, salesType) =>
        {
            if (salesType == SalesType.Agreement)
                viewModel.ShowAgreement = true;
        });

        WeakReferenceMessenger.Default.Register<CompactCustomerViewModel, ValueChanged<SalesType>>(_customerViewModel, (viewModel, message) =>
        {
            
        });
    }

    private void RegisterHubMessages()
    {

    }

    [RelayCommand]
    private void GoToPayment()
    {
        _navigator.NavigateTo(_paymentViewModel);
    }
}
