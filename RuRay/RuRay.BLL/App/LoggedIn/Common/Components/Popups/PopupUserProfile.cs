using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class PopupUserProfile : BasePopup
    {
        public PopupUserProfile()
        {
        }

        protected override By ByForDialog => throw new System.NotImplementedException();

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}