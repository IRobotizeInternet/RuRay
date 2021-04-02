using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotizeFacebook.App.LoggedIn.Pages;

namespace RobotizeFacebookTests.LoggedIn
{
    [TestClass]
    public class PageHomeTest
    {
        [TestMethod]
        public void PageConformance()
        {
            //var page = new PageLogin();
            //page.Login();
            PageHome l = new PageHome();
            l.RunConformance();

            //l.Header.MiddleMenu.VerifyNotifications();
            //d.Header.RunConformance();
        }
    }
}
