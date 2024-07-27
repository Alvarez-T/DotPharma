using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using NavigatR.Avalonia;

namespace DotPharma.Avalonia.PDV.Views
{
    public partial class MainView : View
    {
        public MainView()
        {
            InitializeComponent();
            this.BindViewModelToTopLevelControl();
        }
    }
}
