using CommunityToolkit.Mvvm.ComponentModel;

namespace DotPharma.Presentation.ViewModels.POS;

public partial class ProductsToSellViewModel : ObservableValidator, IViewModelTile
{
    [ObservableProperty]
    private string _productSearched;
}
