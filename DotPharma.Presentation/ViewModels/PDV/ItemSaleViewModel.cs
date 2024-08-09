using System.Collections.ObjectModel;
using Act.SignalR.Client;
using CommunityToolkit.Mvvm.ComponentModel;
using DotPharma.Client.Hub;
using DotPharma.Presentation.Catalog.Model;
using DotPharma.Pricing.Contracts;
using NavigatR.CommunityToolkit;

namespace DotPharma.Presentation.ViewModels.PDV;

public sealed partial class ItemSaleViewModel : ObservableViewModel
{
    public ItemSaleViewModel(IPricingClient pricingClient)
    {
        BroadcastMessage.To(this)
            .RegisterHub(pricingClient)
            .OnHubMessage<PriceChanged>(OnPriceChangedMessage);
    }

    private static void OnPriceChangedMessage(ItemSaleViewModel viewModel, PriceChanged message)
    {
        SaleItemModel? item = viewModel.Items.FirstOrDefault(i => i.Sku == message.Sku);

        if (item is null)
            return;
    }

    [ObservableProperty] private ObservableCollection<SaleItemModel> _items;
    
}