using System.Windows;
using System.Windows.Media;

namespace DotPharma.WPF.Helpers
{
    public static class ImageSourceHelper
    {
        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.RegisterAttached(
                "ImageSource",
                typeof(ImageSource),
                typeof(ImageSourceHelper),
                new PropertyMetadata(null));

        public static ImageSource GetImageSource(DependencyObject obj)
        {
            return (ImageSource)obj.GetValue(ImageSourceProperty);
        }

        public static void SetImageSource(DependencyObject obj, ImageSource value)
        {
            obj.SetValue(ImageSourceProperty, value);
        }
    }
}
