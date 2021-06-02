using System.Diagnostics;
using OpenQA.Selenium;

namespace RuRayToolbox.Extensions
{
    public static class WebElements
    {
        /// <summary>
        /// Retrieves the web element matching the selector if it exists.
        /// </summary>
        public static bool TryFindElement(this ISearchContext searchContext, By by, out IWebElement element)
        {
            try
            {
                element = by.FindElement(searchContext);
                return true;
            }
            catch (NoSuchElementException ex)
            {
                Debug.WriteLine($"No such element exception occured: {ex.Message} \n {ex.InnerException}");
                element = null;
                return false;
            }
        }
    }
}
