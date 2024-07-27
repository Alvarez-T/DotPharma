using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using DotPharma.Avalonia.PDV.Views;
using DotPharma.Presentation.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using NavigatR.Providers;

namespace DotPharma.Avalonia.PDV;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        RemoveAvaloniaDataValidation();

        IServiceCollection services = new ServiceCollection();
        services.RegisterViewModels();

        IServiceProvider provider = services.BuildServiceProvider();
        provider.ConfigureLocators();

        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new RootWindow();
        }
         
        base.OnFrameworkInitializationCompleted();
    }

    /// <summary>
    /// Because this project uses CommunityToolkit, its necessary to remove the default Avalonia data validation.
    /// </summary>
    void RemoveAvaloniaDataValidation()
        => BindingPlugins.DataValidators.RemoveAt(0);

}