using Act.Common.Types;
using Act.SignalR.Client;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DotPharma.Client.Hub;
using DotPharma.Customer.Contracts;
using DotPharma.Presentation.Customer.Models;
using NavigatR;
using NavigatR.CommunityToolkit;

namespace DotPharma.Presentation.Customer;


public sealed partial class BasicCustomerViewModel : ObservableObject, IViewModel
{
    [ObservableProperty] private bool _showAgreement;
    [ObservableProperty] private bool _isNewCustomer;
    [ObservableProperty] private bool _canRegisterNewCustomer;
    [ObservableProperty] private bool _canSearch;
    [ObservableProperty] private CustomerDetailsModel _customerDetailsModel = new();

    public BasicCustomerViewModel(ICustomerClient customerClient)
    {
        BroadcastMessage.To(this)
            .RegisterHub(customerClient)
            .OnHubMessage<CustomerPersonalInfoUpdated>(OnCustomerPersonalInfoUpdated)
            .OnHubMessage<CustomerAddressUpdated>(OnCustomerAddressUpdated);
    }

    private static void OnCustomerPersonalInfoUpdated(BasicCustomerViewModel customerViewModel, CustomerPersonalInfoUpdated message)
    {
        CustomerDetailsModel customerDetails = customerViewModel.CustomerDetailsModel;

        if (customerViewModel.CustomerDetailsModel.HasSameCPF(message.CPF))
        {
            //TODO: Aparecer um alerta que os dados do cliente foram atualizados.
            customerDetails.Apply(message);
        }
    }

    private static void OnCustomerAddressUpdated(BasicCustomerViewModel customerViewModel, CustomerAddressUpdated message)
    {
        //TODO: Implement this method
    }

    [RelayCommand]
    private Task RegisterCustomer()
    {
        throw new NotImplementedException();
    }

}