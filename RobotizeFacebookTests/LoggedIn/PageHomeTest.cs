using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotizeFacebook.Pages;
using RobotizeFacebook.Pages.LoggedUser;

namespace RobotizeFacebookTests.LoggedIn
{
    [TestClass]
    public class PageHomeTest
    {
        [TestMethod]
        public void PageConformance()
        {
            //var logInPage = new PageLogin();
            //var loggedInHomePage = logInPage.Login();
            var page = new PageLogin();
            page.Login();
            PageHome d = new PageHome();
            d.HeaderSection.RunConformance();
        }
    }
}
