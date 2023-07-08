using Microsoft.Extensions.DependencyInjection;
using DotPharma.WPF.MicrosoftDependencyInjection;
using Microsoft.Extensions.Hosting;
using DotPharma.WPF.Controls;

var host = new HostBuilder()
    
    .UseNavigatR()
    .UseDapploWpfHosting()
    .Build();

await host.RunAsync();