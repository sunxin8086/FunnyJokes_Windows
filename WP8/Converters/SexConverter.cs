using System;
using System.Globalization;
using System.Windows.Data;

namespace FunnyJokes.Converters
{
    public class SexConverter : IValueConverter
    {
        public object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            bool sex = (bool)value;
            return sex ? "Male" : "Female";
        }

        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            string sex = (string)value;
            bool profileSex = true;
            if(sex == "Female")
                profileSex = false;
            return profileSex;
        }
    }
}
