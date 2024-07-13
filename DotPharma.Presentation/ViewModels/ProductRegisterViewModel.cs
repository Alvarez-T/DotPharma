using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace DotPharma.Presentation.ViewModels;

public partial class ProductRegistrationViewModel : ObservableValidator, INavigableViewModel
{
    [ObservableProperty]
    private string _description;

    [RelayCommand]
    private Task RegisterProduct()
    {
        throw new NotImplementedException();
    }
}
