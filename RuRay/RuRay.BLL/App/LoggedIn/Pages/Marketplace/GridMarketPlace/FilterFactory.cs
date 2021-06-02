using System;
using System.Collections.Generic;
using OpenQA.Selenium.Remote;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="FilterFactory" />.
    /// </summary>
    public class FilterFactory
    {
        /// <summary>
        /// The GetFilter.
        /// </summary>
        /// <typeparam name="TFilter">.</typeparam>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <returns>The <see cref="TFilter"/>.</returns>
        public static TFilter GetFilter<TFilter>(RemoteWebDriver driver) where TFilter : IFilter<IFilterOptions>
        {
            return (TFilter)Activator.CreateInstance(_concreteClassMap[typeof(TFilter)], driver);
        }

        /// <summary>
        /// Defines the _concreteClassMap.
        /// </summary>
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
