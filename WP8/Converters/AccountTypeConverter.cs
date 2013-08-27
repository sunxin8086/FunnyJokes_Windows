using System;
using System.Globalization;
using System.Windows.Data;

namespace FunnyJokes.Converters
{
    public class AccountTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string AccountType = (string)value;
            string retVal = "Unknown";
            switch (AccountType)
            {
                case "R": retVal = "Read Only"; break;
                case "W": retVal = "Read & Write"; break;
                case "M": retVal = "Moderator"; break;
                case "A": retVal = "Administrator"; break;
            }
            return retVal;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
