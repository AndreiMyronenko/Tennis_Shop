using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace FinalProject.Infra
{
    public class BoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value == true)
            {
                if (CultureInfo.CurrentUICulture.Name == "ru-RU")
                    return "В наличии";
                else if (CultureInfo.CurrentUICulture.Name == "uk-UA")
                    return "В наявності";
                else
                    return "In stock";
            }
            else
            {
                if (CultureInfo.CurrentUICulture.Name == "ru-RU")
                    return "Нет в наличии";
                else if (CultureInfo.CurrentUICulture.Name == "uk-UA")
                    return "Немає в наявності";
                else
                    return "Out of stock";
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
