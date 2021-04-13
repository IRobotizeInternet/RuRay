using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;

namespace RobotizeFacebook.App.LoggedIn
{
    public class FilterFactory
    {
        public static TFilter GetFilter<TFilter>(RemoteWebDriver driver) where TFilter : IFilter<IFilterOptions>
        {
            return (TFilter)Activator.CreateInstance(_concreteClassMap[typeof(TFilter)], driver);
        }

        private static readonly Dictionary<Type, Type> _concreteClassMap =
            new Dictionary<Type, Type>()
        {
            { typeof(IVehicleFilter), typeof(VehicleFilter) },
            //{ typeof(IInteriorColor), typeof(InteriorColor) },
            //{ typeof(INumericTextboxFilterPopup), typeof(NumericTextboxFilterPopup) },
            //{ typeof(IRadiobuttonFilterPopup), typeof(RadiobuttonFilterPopup) },
            //{ typeof(ITextboxFilterPopup), typeof(TextboxFilterPopup) }
        };
    }
}
