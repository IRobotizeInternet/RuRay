using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotizeFacebookLibrary.Pages;

namespace RobotizeFacebookTests.HomePage
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void TestLogInTotheHomePage()
        {
            var page = new PageLogin();
            page.TextBoxUserName.SetData("amhussain7@gmail.com");
            page.TextBoxPassword.SetData("9876543");
            page.ButtonLogin.Click();
        }
    }
}
