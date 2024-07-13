using DotPharma.WPF.MicrosoftDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    
    .UseNavigatR()
    .UseDapploWpfHosting()
    .Build();

await host.RunAsync();