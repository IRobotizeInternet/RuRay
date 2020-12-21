using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace RobotizeLibrary.Controls.Grid
{
    public class FilterFactory
    {
        public static TFilter GetFilter<TFilter>(RemoteWebDriver driver, WebDriverWait wait) where TFilter : IFilter<IFilterOptions>
        {
            return (TFilter)Activator.CreateInstance(_concreteClassMap[typeof(TFilter)], driver, wait);
        }

        private static readonly Dictionary<Type, Type> _concreteClassMap =
            new Dictionary<Type, Type>()
        {
            { typeof(ICheckboxFilter), typeof(CheckboxFilter) },
            { typeof(IInteriorColor), typeof(InteriorColor) },
            { typeof(INumericTextboxFilterPopup), typeof(NumericTextboxFilterPopup) },
            { typeof(IRadiobuttonFilterPopup), typeof(RadiobuttonFilterPopup) },
            { typeof(ITextboxFilterPopup), typeof(TextboxFilterPopup) }
        };
    }
}
