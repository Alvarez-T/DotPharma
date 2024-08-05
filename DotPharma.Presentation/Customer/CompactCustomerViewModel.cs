using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using DotPharma.Client.Hub;
using DotPharma.Customer.Contracts;
using DotPharma.Presentation.Customer.Models;
using DotPharma.Presentation.Models;
using Microsoft.AspNetCore.SignalR.Client;
using NavigatR;

namespace DotPharma.Presentation.Customer;

public sealed partial class CompactCustomerViewModel : ObservableObject, IViewModel
{
    [ObservableProperty] private bool _showAgreement;
    [ObservableProperty] private bool _isNewCustomer;
    [ObservableProperty] private bool _canSearch;
    [ObservableProperty] private CompactCustomerModel _customerModel = new();

    [RelayCommand]
    private Task RegisterCustomer()
    {
        throw new NotImplementedException();
    }
}



public class CustomerClient : ICustomerClient
{
    public CustomerClient()
    {
        //var t = new HubConnectionBuilder()
        //    .WithUrl().Build();
        //t.On()


    }

    public Task OnPersonalInfoUpdated(CustomerPersonalInfoUpdated @event)
    {
        throw new NotImplementedException();
    }

    public Task OnAddressUpdated(CustomerAddressUpdated @event)
    {
        throw new NotImplementedException();
    }
}



public static class PDVCustomerMessageHandler
{
    public static void RegisterMessages()
    {
        WeakReferenceMessenger.Default.Register<CompactCustomerViewModel, ValueChanged<SalesType>>((viewModel, message) =>
        {
            if (message.Value == SalesType.Agreement)
                viewModel.ShowAgreement = true;
        });
    }
}