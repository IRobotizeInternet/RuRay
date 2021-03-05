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
            PageHome d = new PageHome();
            var count = d.Header.MiddleMenu.GetNotificationOfGroups();
            //d.Header.RunConformance();
        }
    }
}
