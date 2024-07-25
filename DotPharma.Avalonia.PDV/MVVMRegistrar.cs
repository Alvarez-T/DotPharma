using DotPharma.Avalonia.PDV.Tiles;
using DotPharma.Avalonia.PDV.Views;
using DotPharma.Presentation.ViewModels.PDV;

namespace Microsoft.Extensions.DependencyInjection;

public static class MVVMRegistrar
{
    public static IServiceCollection RegisterViewModels(this IServiceCollection serviceCollection) =>
        serviceCollection.UseNavigatR(config => config
            .RegisterViewToViewModel<MainView, PointOfSaleViewModel>()
            .RegisterViewToViewModel<PDVMenu, PDVMenuTileModel>());

}