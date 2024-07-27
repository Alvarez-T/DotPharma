using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using DotPharma.Presentation.ViewModels;
using NavigatR.Providers;

namespace DotPharma.Avalonia.PDV.Views;

public partial class RootWindow : Window
{
    public RootWindow()
    {
        InitializeComponent();
        this.DataContext = ViewModelLocator.LocateViewModel<RootViewModel>();
        this.AttachDevTools();
        
    }
}