using System.Runtime.CompilerServices;
using Act.SignalR.Client;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using DotPharma.Client.Hub;
using DotPharma.Customer.Contracts;
using DotPharma.Presentation.Customer;
using DotPharma.Presentation.Customer.Models;
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
    [ObservableProperty] private BasicCustomerViewModel _customerViewModel;
    [ObservableProperty] private PaymentViewModel _paymentViewModel;

    public PointOfSaleViewModel(INavigator navigator, IViewModelProvider viewModelProvider)
    {
        _navigator = navigator;

        PdvMenu = viewModelProvider.GetViewModel<PDVMenuTileModel>();
        CustomerViewModel = viewModelProvider.GetViewModel<BasicCustomerViewModel>();
    }

    private void RegisterViewModelMessages()
    {
        BroadcastHubMessage.To(CustomerViewModel, customerClient)
            .ViewMessage<ValueChanged<SalesType>>(OnSalesTypeChanged)
            .HubMessage<CustomerPersonalInfoUpdated>(OnCustomerPersonalInfoUpdated)
            .HubMessage<CustomerAddressUpdated>
    }

    private static void OnSalesTypeChanged(BasicCustomerViewModel customerViewModel, ValueChanged<SalesType> salesType)
    {
        if (salesType == SalesType.Agreement)
            customerViewModel.ShowAgreement = true;
    }



   

    [RelayCommand]
    private void GoToPayment()
    {
        _navigator.NavigateTo(_paymentViewModel);
    }
}
