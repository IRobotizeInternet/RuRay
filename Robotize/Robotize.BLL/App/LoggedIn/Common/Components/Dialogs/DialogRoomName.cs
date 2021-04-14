using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Enums;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogRoomName : BaseDialog
    {
        public DialogRoomName()
        {
        }

        protected override By ByForDialog => By.XPath($"//div[@role='dialog']//span[text()='{ResMiscellaneous.SquadHang}']");

        public Button ButtonRoomName(EnumRoomName roomName)
        {
            if (roomName.GetDescription() == ResMiscellaneous.New) return null;
            return new Button(Driver, By.XPath($"//div[@role='dialog']//span[text()='{roomName.GetDescription()}']"));
        }

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        public EventTriggerButton<DialogNewRoomName> EventTriggerButtonNew =>
            new EventTriggerButton<DialogNewRoomName>(Driver, By.XPath($"//div[@role='dialog']//div[@role='button']//span[text()='{ResMiscellaneous.New}']"));
    }
}
