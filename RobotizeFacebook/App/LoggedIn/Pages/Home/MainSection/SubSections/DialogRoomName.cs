using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Dialogs;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Enums;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogRoomName : BaseDialog
    {
        public DialogRoomName(RemoteWebDriver driver) : base(driver)
        {
        }

        protected override By ByForDialog => By.XPath($"//div[@role='dialog']//span[text()='{ResMiscellaneous.SquadHang}']");

        public Button ButtonRoomName(EnumRoomName roomName)
        {
            if (roomName.GetDescription() == ResMiscellaneous.New) return null;
            return new Button(Driver, By.XPath($"//div[@role='dialog']//span[text()='{roomName.GetDescription()}']"));
        }

        public EventTriggerButton<DialogNewRoomName> EventTriggerButtonNew =>
            new EventTriggerButton<DialogNewRoomName>(Driver, By.XPath($"//div[@role='dialog']//div[@role='button']//span[text()='{ResMiscellaneous.New}']"));
    }
}
