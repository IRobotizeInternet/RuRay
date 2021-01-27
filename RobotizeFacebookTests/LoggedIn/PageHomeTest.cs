using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotizeFacebook.App.NotLoggedIn;

namespace RobotizeFacebookTests.LoggedIn
{
    [TestClass]
    public class PageHomeTest
    {
        [TestMethod]
        public void PageConformance()
        {
            var page = new PageLogin();
            page.Login();
            //PageHome d = new PageHome();
            //d.HeaderSection.RunConformance();
        }
    }
}
