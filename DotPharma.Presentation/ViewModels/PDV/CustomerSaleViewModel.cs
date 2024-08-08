using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging.Messages;
using DotPharma.Presentation.Customer;
using DotPharma.Presentation.Models;
using NavigatR.CommunityToolkit;
using NavigatR.Providers;

namespace DotPharma.Presentation.ViewModels.PDV;

internal sealed partial class CustomerSaleViewModel : NavigableViewModel
{
    public CustomerSaleViewModel()
    {
        CustomerViewModel = ViewModelProvider.GetViewModel<BasicCustomerViewModel>();
        CustomerLimitsViewModel = ViewModelProvider.GetViewModel<CustomerLimitsViewModel>();
        CustomerHistoryViewModel = ViewModelProvider.GetViewModel<CustomerHistoryViewModel>();

        BroadcastMessage.To(CustomerViewModel)
            .OnViewMessage<ValueChanged<SalesType>>(OnSalesTypeChanged);
    }

    [ObservableProperty] private BasicCustomerViewModel _customerViewModel;
    [ObservableProperty] private CustomerLimitsViewModel _customerLimitsViewModel;
    [ObservableProperty] private CustomerHistoryViewModel _customerHistoryViewModel;

    private static void OnSalesTypeChanged(BasicCustomerViewModel customerViewModel, ValueChanged<SalesType> salesType)
    {
        customerViewModel.ShowAgreement = salesType == SalesType.Agreement;
    }
}

internal sealed partial class CustomerLimitsViewModel : ObservableViewModel
{

}

internal sealed partial class CustomerHistoryViewModel : ObservableViewModel
{

}

