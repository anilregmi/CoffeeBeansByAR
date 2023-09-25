using CoffeeBeans.ViewModel;
using System;
using System.Globalization;
using System.Windows.Data;

namespace CoffeeBeans.Convertor
{
    class NavigationSideToGridColumnConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
           var navigationSide=(NavigationSide)value;
            return navigationSide==NavigationSide.Left ? 0 : 2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
