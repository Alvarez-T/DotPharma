using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using NavigatR.Avalonia;

namespace DotPharma.Avalonia.PDV.Tiles;

public partial class PDVMenu : View
{
    public PDVMenu()
    {
        InitializeComponent();
        this.BindViewModelToTopLevelControl();
    }

}