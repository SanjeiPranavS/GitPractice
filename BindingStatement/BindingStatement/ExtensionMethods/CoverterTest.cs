using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.ConversationalAgent;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using BindingStatement.Templates_Resources;

namespace BindingStatement.ExtensionMethods
{
    public class CoverterTest : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var visiblity = (bool)value ;

            if (visiblity) return Visibility.Visible;
            else
                return Visibility.Collapsed;
            /*
             * If there is an error in the conversion, do not throw an exception.
             * Instead, return DependencyProperty.UnsetValue, which will stop the data transfer.
             */
            //some obj =(requeredType)value; example enum to string type
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            //some obj =(requeredType)value; example enum to string type
            return "191Me215";
        }
    }
}
