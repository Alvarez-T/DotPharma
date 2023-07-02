using Dapplo.Microsoft.Extensions.Hosting.Wpf;
using DotPharma.WPF.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DotPharma.WPF.MicrosoftDependencyInjection;

public static class DotPharmaServicesRegister
{
    public static IHostBuilder UseNavigatR(this IHostBuilder hostBuilder)
    {
        return hostBuilder.ConfigureServices(services =>
        {
            services.UseNavigatR(configuration =>
            {
                configuration.UseWpfNavigationWrapper();
            });
        });
    }

    public static IHostBuilder UseDapploWpfHosting(this IHostBuilder hostBuilder)
    {
        return hostBuilder.ConfigureWpf(wpf =>
        {
            wpf.UseApplication<App>()
            .UseWindow<ShellView>();
        }).UseWpfLifetime();
    }
}
