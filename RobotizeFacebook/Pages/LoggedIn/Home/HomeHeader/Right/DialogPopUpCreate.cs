using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeLibrary.Controls.TriggerControls;
using RobotizeLibrary.Dialogs;

namespace RobotizeFacebook.Pages.LoggedIn.HomeHeader
{
    public class DialogPopUpCreate : DialogBase
    {
        public DialogPopUpCreate(RemoteWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        protected override By ByForDialog => By.XPath("//div[@data-testid='Keycommand_wrapper_ModalLayer']");

        public EventTriggerDiv<DialogCreatePost> TriggerDivCreatePost => new EventTriggerDiv<DialogCreatePost>(Driver, Wait, By.XPath("//div[@class='dbpd2lw6 l9j0dhe7 stjgntxs ni8dbmo4 lzcic4wl idiwt2bm']"));
        
    }
}
