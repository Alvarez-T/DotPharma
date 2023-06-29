using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;

namespace DotPharma.WPF.Controls;

public class DropDownMenu : ItemsControl
{
    public DropDownMenu()
    {
        this.DefaultStyleKey = typeof(DropDownMenu);
    }

    public string Header
    {
        get { return (string)GetValue(HeaderProperty); }
        set { SetValue(HeaderProperty, value); }
    }

    public static readonly DependencyProperty HeaderProperty =
        DependencyProperty.Register("Header", typeof(string), typeof(DropDownMenu), new PropertyMetadata(string.Empty));

    protected override bool IsItemItsOwnContainerOverride(object item)
    {
        return item is RadioButton;
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new StackPanel();
    }

}
