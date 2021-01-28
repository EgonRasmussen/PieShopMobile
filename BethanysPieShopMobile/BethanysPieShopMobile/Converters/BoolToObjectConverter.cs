
using System;
using System.Globalization;
using Xamarin.Forms;

namespace BethanysPieShopMobile.Converters
{
    public class BoolToObjectConverter<T> : IValueConverter
    {
        public T TrueValue { set; get; }

        public T FalseValue { set; get; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? TrueValue : FalseValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((T)value).Equals(TrueValue);
        }
    }
}
