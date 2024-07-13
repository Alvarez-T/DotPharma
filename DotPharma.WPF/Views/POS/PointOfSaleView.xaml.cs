using System.Collections.ObjectModel;
using System.Windows.Controls;
using DotPharma.Presentation.Models;

namespace DotPharma.WPF.Views.POS
{
    /// <summary>
    /// Interaction logic for PointOfSaleView.xaml
    /// </summary>
    public partial class PointOfSaleView : UserControl
    {
        public PointOfSaleView()
        {
            InitializeComponent();
            Products = new ObservableCollection<ProductModel> { new ProductModel() { Id = 1111, Description = "Dorflex teste" }, { new ProductModel() { Id = 114134, Description = "Losartana" } } };
            DataContext = this;
        }

        public ObservableCollection<ProductModel> Products { get; set; }
    }
}
