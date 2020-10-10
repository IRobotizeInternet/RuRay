using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotizeFacebook.Pages;

namespace RobotizeFacebookTests.LoggedIn
{
    [TestClass]
    public class PageHomeTest
    {
        [TestMethod]
        public void PageConformance()
        {
            var logInPage = new PageLogin();
            var loggedInHomePage = logInPage.Login();
            loggedInHomePage.HeaderSection.RunConformance();
        }
    }
}
