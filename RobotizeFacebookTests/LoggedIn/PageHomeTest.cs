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
            var page = new PageLogin();
            PageHome d = new PageHome();
            d.GenerateAllElements();
            //d.HeaderSection.RunConformance();
        }
    }
}
