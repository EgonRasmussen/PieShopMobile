using System;
using System.Globalization;
using Xamarin.Forms;

namespace BethanysPieShopMobile.Converters
{
    public class CurrencyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "$" + value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString().Replace("$", string.Empty);
        }
    }
}
