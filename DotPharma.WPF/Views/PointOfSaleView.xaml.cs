using DotPharma.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DotPharma.WPF.Views
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
