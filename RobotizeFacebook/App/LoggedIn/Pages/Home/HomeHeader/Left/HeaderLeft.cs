using OpenQA.Selenium;
using RobotizeFacebook.Resources;

namespace RobotizeFacebook.App.LoggedIn.Home.HomeHeader.Left
{
    public class HeaderLeft : Header
    {
        public SearchBoxSearchFacebook ComboboxFacebookSearch =>
            new SearchBoxSearchFacebook(Driver, By.XPath($"//input[@role='combobox'][@placeholder='{ResMiscellaneous.SearchFacebook}']/../../../../.."));

        public override string PageUrl => throw new System.NotImplementedException();

        public override By ByForPage => throw new System.NotImplementedException();
    }
}
