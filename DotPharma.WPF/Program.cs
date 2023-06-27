using Dapplo.Microsoft.Extensions.Hosting.Wpf;
using DotPharma.WPF;
using DotPharma.WPF.Views;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureWpf(wpf =>
    {
        wpf.UseApplication<App>()
        .UseWindow<ShellView>();
    })
    .UseWpfLifetime()
    .Build();

await host.RunAsync();

