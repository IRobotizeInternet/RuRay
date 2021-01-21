using OpenQA.Selenium;

namespace RobotizeLibrary.Extensions
{
    public class ExtendBy : By
    {
        public ExtendBy(string xPathForElement)
        {
            XPathOfElement = xPathForElement;
            XPath(xPathForElement);
        }

        public static ExtendBy By(string xPathForElement)
        {
            return new ExtendBy(xPathForElement);
        }
        public string XPathOfElement { get; set; }
    }
}
