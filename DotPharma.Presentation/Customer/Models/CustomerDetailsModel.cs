using Act.Common.Types;
using CommunityToolkit.Mvvm.ComponentModel;
using DotPharma.Abstract;
using DotPharma.Customer.Contracts;

namespace DotPharma.Presentation.Customer.Models;

public sealed partial class CustomerDetailsModel : ObservableObject
{
    [ObservableProperty] private CustomerId? _id;
    [ObservableProperty] private string _name;
    [ObservableProperty] private string _agreement;
    [ObservableProperty] private string _cpf;
    [ObservableProperty] private string _rg;
    [ObservableProperty] private string _cellphone;
    [ObservableProperty] private string _address;

    public bool HasSameCPF(CPF cpf) => cpf == new CPF(_cpf);

    internal void Apply(CustomerPersonalInfoUpdated customerInfoUpdated)
    {
        Name = customerInfoUpdated.Name;
        Cpf = customerInfoUpdated.CPF;
        Rg = customerInfoUpdated.RG;
        Cellphone = customerInfoUpdated.Cellphone;
    }

    internal void Apply(CustomerAddressUpdated customerAddressUpdated)
    {

    }
}