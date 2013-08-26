using System;
using System.Windows.Data;

namespace FunnyJokes.Converters
{
    public class DateFormatter : IValueConverter
    {
        // This converts the DateTime object to the string to display.
        public object Convert(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {

            if (value == null)
                return "unknown";
            
            DateTime date = (DateTime)value;
            object localTime = date.ToLocalTime();
            string formatString = parameter as string;

            if (formatString == "Age")
            {
                int age = 20;// FunnyJokesUtil.getAgeFromBirthday(date);
                if (age == -1)
                    return "unknow";
                else
                    return age.ToString();
            }
            else if (!string.IsNullOrEmpty(formatString))
            {
                return string.Format(culture, formatString, localTime);

            }
            // If the format string is null or empty, simply call ToString()
            // on the value.
            return value.ToString();
        }

        // No need to implement converting back on a one-way binding 
        public object ConvertBack(object value, Type targetType,
            object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
