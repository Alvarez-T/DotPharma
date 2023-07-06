using DotPharma.Presentation.ViewModels;
using NavigatR;
using System.Windows;
using System.Windows.Controls;

namespace DotPharma.WPF.Views
{
    /// <summary>
    /// Interaction logic for MainMenuView.xaml
    /// </summary>
    public partial class MainMenuView : UserControl
    {
        public MainMenuView()
        {
            InitializeComponent();
        }

        private void MainMenu_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = ViewModelLocator.LocateViewModel<MainMenuViewModel>();
        }
    }
}
