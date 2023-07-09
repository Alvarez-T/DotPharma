using CommunityToolkit.Mvvm.ComponentModel;
using DotPharma.Presentation.ViewModels.POS;
using NavigatR;

namespace DotPharma.Presentation.ViewModels;

public partial class MainMenuViewModel : ObservableRecipient, IViewModel
{
    private readonly INavigator _navigator;
    public MainMenuViewModel(INavigator navigator)
    {
        _navigator = navigator;
        NavigateToCustomerRegistration = true;
    }

    private void ShouldNavigateTo<T>(bool shouldNavigate) where T : INavigable
    {
        if (shouldNavigate)
            _navigator.NavigateTo<T>();
    }
    
    private bool _navigateToDashboard;
    public bool NavigateToDashboard
    {
        get => _navigateToDashboard;
        set => SetProperty(ref _navigateToDashboard, value);
    }
     
    private bool _navigateToProductRegistration;
    public bool NavigateToProductRegistration
    {
        get => _navigateToProductRegistration;
        set => _navigateToProductRegistration = SetProperty(_navigateToProductRegistration, value, callback: ShouldNavigateTo<ProductRegistrationViewModel>);
    }

    private bool _navigateToCustomerRegistration;
    public bool NavigateToCustomerRegistration
    {
        get => _navigateToCustomerRegistration;
        set => _navigateToCustomerRegistration = SetProperty(_navigateToCustomerRegistration, value, callback: ShouldNavigateTo<CustomerRegisterViewModel>);
    }

    private bool _navigateToPointOfSale;
    public bool NavigateToPointOfSale
    {
        get => _navigateToPointOfSale;
        set => SetProperty(_navigateToPointOfSale, value, callback: ShouldNavigateTo<PointOfSaleViewModel>);
    }

    private bool _navigateToReturnSale;
    public bool NavigateToReturnSale
    {
        get => _navigateToReturnSale;
        set => SetProperty(ref _navigateToReturnSale, value);
    }

}
