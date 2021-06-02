using System.Diagnostics;
using OpenQA.Selenium;

namespace RuRayToolbox.Extensions
{
    /// <summary>
    /// Defines the <see cref="WebElements" />.
    /// </summary>
    public static class WebElements
    {
        /// <summary>
        /// Retrieves the web element matching the selector if it exists.
        /// </summary>
        /// <param name="searchContext">The searchContext<see cref="ISearchContext"/>.</param>
        /// <param name="by">The by<see cref="By"/>.</param>
        /// <param name="element">The element<see cref="IWebElement"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
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
