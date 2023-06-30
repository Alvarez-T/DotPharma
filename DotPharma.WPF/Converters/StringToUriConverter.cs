using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace DotPharma.WPF.Converters;

public class StringToUriConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is string imagePath)
        {
            ImageSourceConverter converter = new ImageSourceConverter();
            ImageSource imageSource = (ImageSource)converter.ConvertFrom(imagePath);
            return imageSource;
        }

        return null!;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}
