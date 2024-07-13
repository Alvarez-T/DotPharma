using System.Collections.ObjectModel;
using System.Dynamic;

namespace DotPharma.Avalonia.PDV.FakeData;

internal static class DesignTime
{
    public static DesignTimeProductsProvider ProductsProvider { get; } = new DesignTimeProductsProvider();
}

internal class DesignTimeProductsProvider
{
    public ObservableCollection<DesignProduct> Products { get; set; }

    public DesignTimeProductsProvider()
    {
        Products = new ObservableCollection<DesignProduct>
        {
            new DesignProduct { Codigo = "1", Produto = "Produto A", PrecoB = 10.0m, PrecoL = 12.0m, Desconto = 1.0m, Quantidade = 5 },
            new DesignProduct { Codigo = "2", Produto = "Produto B", PrecoB = 15.0m, PrecoL = 18.0m, Desconto = 1.5m, Quantidade = 3 },
            new DesignProduct { Codigo = "3", Produto = "Produto C", PrecoB = 20.0m, PrecoL = 24.0m, Desconto = 2.0m, Quantidade = 2 },
            new DesignProduct { Codigo = "4", Produto = "Produto D", PrecoB = 25.0m, PrecoL = 30.0m, Desconto = 2.5m, Quantidade = 4 },
            new DesignProduct { Codigo = "5", Produto = "Produto E", PrecoB = 30.0m, PrecoL = 36.0m, Desconto = 3.0m, Quantidade = 1 },
            new DesignProduct { Codigo = "6", Produto = "Produto F", PrecoB = 35.0m, PrecoL = 42.0m, Desconto = 3.5m, Quantidade = 7 },
            new DesignProduct { Codigo = "7", Produto = "Produto G", PrecoB = 40.0m, PrecoL = 48.0m, Desconto = 4.0m, Quantidade = 6 },
            new DesignProduct { Codigo = "8", Produto = "Produto H", PrecoB = 45.0m, PrecoL = 54.0m, Desconto = 4.5m, Quantidade = 8 },
            new DesignProduct { Codigo = "9", Produto = "Produto I", PrecoB = 50.0m, PrecoL = 60.0m, Desconto = 5.0m, Quantidade = 9 },
            new DesignProduct { Codigo = "10", Produto = "Produto J", PrecoB = 55.0m, PrecoL = 66.0m, Desconto = 5.5m, Quantidade = 10 }
        };
    }
}

internal class DesignProduct
{
    public string Codigo { get; set; }
    public string Produto { get; set; }
    public decimal PrecoB { get; set; }
    public decimal PrecoL { get; set; }
    public decimal Desconto { get; set; }
    public int Quantidade { get; set; }
    public decimal Total => (PrecoB - Desconto) * Quantidade;
}