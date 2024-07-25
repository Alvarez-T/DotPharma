using Avalonia;
using Avalonia.Controls;

namespace DotPharma.Avalonia.PDV.Views;

public partial class RootWindow : Window
{
    public RootWindow()
    {
        InitializeComponent();
        this.AttachDevTools();
    }
}