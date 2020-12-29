using OpenQA.Selenium;

namespace RobotizeLibrary.Extensions
{
    public class ExtendBy : By
    {
        public ExtendBy(string xPathForElement)
        {
            XPath(xPathForElement);
        }

        public static By By(string xPathForElement)
        {
            return new ExtendBy(xPathForElement);
        }
        public string GetDescription() 
        {
            return Description;      
        }
    }
}
