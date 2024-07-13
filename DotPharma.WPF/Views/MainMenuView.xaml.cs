using System.Windows;
using System.Windows.Controls;
using DotPharma.Presentation.ViewModels;

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
