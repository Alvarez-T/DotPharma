using Dapplo.Microsoft.Extensions.Hosting.Wpf;
using DotPharma.Presentation.ViewModels;
using DotPharma.Presentation.ViewModels.POS;
using DotPharma.Presentation.ViewModels.Tiles;
using DotPharma.WPF.Views;
using DotPharma.WPF.Views.Registration;
using DotPharma.WPF.Views.Registration.Tiles;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DotPharma.WPF.MicrosoftDependencyInjection;

public static class DotPharmaServicesRegister
{
    public static IHostBuilder UseNavigatR(this IHostBuilder hostBuilder) => hostBuilder.ConfigureServices(services =>
    {
        services.UseNavigatR(configuration =>
        {
            configuration
                .UseWpfNavigationWrapper()
                .ConfigureViewToViewModel<RegisterProductDetailsTile, RegisterProductDetailsViewModel>()
                .ConfigureViewToViewModel<RegisterMedicationTile, RegisterMedicationViewModel>()
                .ConfigureViewToViewModel<ProductRegisterView, ProductRegistrationViewModel>()
                .ConfigureViewToViewModel<CustomerRegisterView, CustomerRegisterViewModel>()
                .ConfigureViewToViewModel<PointOfSaleView, PointOfSaleViewModel>()
                .ConfigureViewToViewModel<MainMenuView, MainMenuViewModel>();

        });
    });

    public static IHostBuilder UseDapploWpfHosting(this IHostBuilder hostBuilder) => hostBuilder.ConfigureWpf(wpf =>
    {
        wpf.UseApplication<App>()
        .UseWindow<ShellView>();
    }).UseWpfLifetime();
}
