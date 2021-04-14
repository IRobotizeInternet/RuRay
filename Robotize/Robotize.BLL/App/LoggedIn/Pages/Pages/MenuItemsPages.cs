using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class MenuItemsPages : MenuItems
    {
        public EventTriggerButton<PagePages> EventTriggerButtonYourPages =>
            new EventTriggerButton<PagePages>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.YourPages}')]"));
        public EventTriggerButton<PagePages> EventTriggerButtonCreateNewPage =>
            new EventTriggerButton<PagePages>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.CreateNewPage}')]"));
        public EventTriggerButton<PagePages> EventTriggerButtonDiscover =>
            new EventTriggerButton<PagePages>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Discover}')]"));
        public EventTriggerButton<PagePages> EventTriggerButtonLikedPages =>
            new EventTriggerButton<PagePages>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.LikedPages}')]"));
        public EventTriggerButton<PagePages> EventTriggerButtonInvites =>
            new EventTriggerButton<PagePages>(Driver, By.XPath($"{BaseXPath}//span[contains(text(), '{ResLeftNav.Invites}')]"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
