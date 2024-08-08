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

internal sealed partial class PointOfSaleViewModel : NavigableViewModel
{
    public PointOfSaleViewModel()
    {
        PdvMenu = ViewModelProvider.GetViewModel<PDVMenuTileModel>();
        CustomerSaleViewModel = ViewModelProvider.GetViewModel<CustomerSaleViewModel>();
    }
    
    [ObservableProperty] private PDVMenuTileModel _pdvMenu;
    [ObservableProperty] private CustomerSaleViewModel _customerSaleViewModel;
    [ObservableProperty] private PaymentViewModel _paymentViewModel;

    private void RegisterViewModelMessages()
    {

    }

    [RelayCommand]
    private void GoToPayment()
    {
        Navigator.NavigateTo(_paymentViewModel);
    }
}
