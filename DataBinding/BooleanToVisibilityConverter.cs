using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace DataBinding {
    public class BooleanToVisibilityConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            bool actualValue = (bool) value;

            Visibility result = (parameter == null || parameter.ToString() != "inverse")
                ? (actualValue ? Visibility.Visible : Visibility.Hidden)
                : (actualValue ? Visibility.Hidden : Visibility.Visible);
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            return DependencyProperty.UnsetValue;
        }
    }
}