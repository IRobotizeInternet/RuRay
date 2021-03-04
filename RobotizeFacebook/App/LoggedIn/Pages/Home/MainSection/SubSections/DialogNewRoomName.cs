using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Dialogs;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogNewRoomName : BaseDialog
    {
        public DialogNewRoomName(RemoteWebDriver driver) : base(driver)
        {
            //var a = "🌴";
            BaseXPath = $"//div[@role='dialog']//span[text()='{ResMiscellaneous.NewRoomName}']/parent::span/parent::h2/parent::div/following-sibling::div[3]";
        }

        protected override By ByForDialog => By.XPath($"//div[@role='dialog']//span[text()='{ResMiscellaneous.NewRoomName}']");

        // TODO: Creating room with by name is not supported for now.
        //public Button ButtonChooseAnImageByName(EnumNewRoomName imageName)
        //{
        //    return new Button(Driver, By.XPath(imageName.GetDescription()));
        //}

        public TextBox TextBoxRoomName => new TextBox(Driver, By.XPath($"{BaseXPath}//input"));

        public Button ButtonChooseAnImageByIndex(int index)
            =>new Button(Driver, By.XPath($"{BaseXPath}/div/div/div[{index}]//img"));

        public EventTriggerButton<CreateRoom> ButtonSave =>
            new EventTriggerButton<CreateRoom>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResLeftNav.Save}']"));
    }
}
