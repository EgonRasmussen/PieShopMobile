using System;
using System.Globalization;
using Xamarin.Forms;

namespace BethanysPieShopMobile.Converters
{
    public class DoubleToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double p = 13; //default value

            if (parameter != null)
                p = double.Parse(parameter.ToString());

            switch (value)
            {
                case double v when v > p:
                    return Color.Gold;
                default:
                    return Color.Red;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
