using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Data;

namespace FunnyJokes.Converters
{
    public class ThemeImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool isDarkTheme = (Application.Current.Resources.Contains("PhoneDarkThemeVisibility") && ((Visibility)Application.Current.Resources["PhoneDarkThemeVisibility"]) == Visibility.Visible);
            string path = null;

            string str = null;
            if (parameter != null)
                str = parameter as string;
            else
                str = value as string;
            // Path to the icon image
            if (str != null)
            {
                // Path to the icon image
                path = string.Format(str, isDarkTheme ? "light" : "dark");
            }
            return path;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
