using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace DotPharma.WPF.Controls;

public class ImageButton : Button
{
    public static readonly DependencyProperty ImageSourceProperty =
        DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(ImageButton), new PropertyMetadata(null));

    public ImageSource ImageSource
    {
        get { return (ImageSource)GetValue(ImageSourceProperty); }
        set { SetValue(ImageSourceProperty, value); }
    }
}
