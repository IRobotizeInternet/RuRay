using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class DialogCreateYourRoom : BaseDialog
    {
        protected override By ByForDialog => By.XPath($"//div[@role='dialog']//span[text()='{ResMiscellaneous.CreateYourRoom}']");

        public DialogCreateYourRoom()
        {
            
        }

        public EventTriggerButton<DialogRoomName> EventTriggerButtonRoomName =>
            new EventTriggerButton<DialogRoomName>(Driver, By.XPath($"//div[@role='dialog']//span[text()='{ResMiscellaneous.RoomName}']"));
        public EventTriggerButton<DialogStartTime> EventTriggerButtonStartTime =>
            new EventTriggerButton<DialogStartTime>(Driver, By.XPath($"//div[@role='dialog']//span[text()='{ResMiscellaneous.StartTime}']"));
        public Checkbox CheckboxVisibleToAllFriends => 
            new Checkbox(Driver, By.XPath("//div[@role='dialog']//input"));
        public EventTriggerButton<DialogJoinRoom> EventTriggerButtonCreateRoom =>
            new EventTriggerButton<DialogJoinRoom>(Driver, By.XPath($"//div[@role='dialog']//span[text()='{ResMiscellaneous.CreateRoom}']"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
