using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotizeYoutubeLibrary.Pages;

namespace RobotizeYoutube.HomePageTests
{
    [TestClass]
    public class HomePageHeaderTest
    {
        [TestMethod]
        public void NavigateToLoginPage()
        {
            var page = new HomePage();
            page.ButtonSignIn.Click();
            page.ButtonCreateVideo.Click();
        }
    }
}
