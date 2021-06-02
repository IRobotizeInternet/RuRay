using OpenQA.Selenium;

namespace RuRayLibrary.Extensions
{
    /// <summary>
    /// Defines the <see cref="ExtendBy" />.
    /// </summary>
    public class ExtendBy : By
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendBy"/> class.
        /// </summary>
        /// <param name="xPathForElement">The xPathForElement<see cref="string"/>.</param>
        public ExtendBy(string xPathForElement)
        {
            XPathOfElement = xPathForElement;
            XPath(xPathForElement);
        }

        /// <summary>
        /// The By.
        /// </summary>
        /// <param name="xPathForElement">The xPathForElement<see cref="string"/>.</param>
        /// <returns>The <see cref="ExtendBy"/>.</returns>
        public static ExtendBy By(string xPathForElement)
        {
            return new ExtendBy(xPathForElement);
        }

        /// <summary>
        /// Gets or sets the XPathOfElement.
        /// </summary>
        public string XPathOfElement { get; set; }
    }
}
