using CaliburnMicroApp_Practice3.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CaliburnMicroApp_Practice3
{
    [ValueConversion(typeof(CharacterModel), typeof(string))]
    public class ImagePathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            CharacterModel characterModel = (CharacterModel)value;
            if (characterModel == null)
                return "";
            return string.Format("/CaliburnMicroApp_Practice3;component/Images/Characters/{0}.png", characterModel.Name.ToLower());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
