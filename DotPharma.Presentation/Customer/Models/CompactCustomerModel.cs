using CommunityToolkit.Mvvm.ComponentModel;

namespace DotPharma.Presentation.Customer.Models;

public sealed partial class CompactCustomerModel : ObservableObject
{
    [ObservableProperty] private int? _id;
    [ObservableProperty] private string _name;
    [ObservableProperty] private string _agreement;
    [ObservableProperty] private string _cpf;
    [ObservableProperty] private string _cellphone;
    [ObservableProperty] private string _address;
}