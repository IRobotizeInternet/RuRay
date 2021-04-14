using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeFacebook.App.LoggedIn.Enum;
using Robotize.BLL.Resources;
using RobotizeLibrary.Extensions;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Controls.TriggerControls;
using System;
using System.Linq;

namespace RobotizeFacebook.App.LoggedIn.Pages.JobsComposer.ScheduleLiveVideoEvent
{
    public class MenuItemsScheduleLiveVideoEvent : MenuItems
    {
        public MenuItemsScheduleLiveVideoEvent()
        {
            BaseXPath = $"//div[@aria-label='{ResLeftNav.ScheduleLiveSettings}']";
            MenuItemsCommon = new MenuItemsCommon(BaseXPath);
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }

        public MenuItemsCommon MenuItemsCommon;

        public TextBox TextBoxEventName => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.EventName}']"));
        public TextBox TextBoxStartDate => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.StartDate}']"));
        public TextBox TextBoxStartTime => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.StartTime}']"));
        public TextBox TextBoxDescription => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Description}']"));
        public Hyperlink<DialogEndDateAndTime> HyperlinkEndDateAndTime =>
            new Hyperlink<DialogEndDateAndTime>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.EventName}']"));

        public EventTriggerButton<DialogEndDateAndTime> EventTriggerButtonEndDateAndTime =>
         new EventTriggerButton<DialogEndDateAndTime>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Next}']"));

        public DropdownSchedulePrivacy DropdownPrivacy => 
            new DropdownSchedulePrivacy(Driver, new ExtendBy($"{BaseXPath}//span[text()='{ResLeftNav.Privacy}']"));

        public class DropdownSchedulePrivacy : DropdownWithEnum<Privacy>
        {
            public DropdownSchedulePrivacy(RemoteWebDriver driver, ExtendBy byForDropdown) : base(driver, byForDropdown)
            {
            }
        }

        public Checkbox CheckboxGuestsCanInviteFriends =>
            new Checkbox(Driver, By.XPath($"{BaseXPath}//input[@aria-label='{ResLeftNav.GuestsCanInviteFriends}']"));

        public EventTriggerButton<DialogScheduleNext> EventTriggerButtonNext =>
            new EventTriggerButton<DialogScheduleNext>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Next}']"));

        public class DialogEndDateAndTime : BaseDialog
        {
            public DialogEndDateAndTime()
            {
            }

            protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResLeftNav.ScheduleLiveSettings}']//span[text()='{ResLeftNav.EndDateAndTime}']");
            public TextBox TextBoxEndDate => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.EndDate}']"));
            public TextBox TextBoxEndTime => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.EndTime}']"));

            public override void RunConformance()
            {
                throw new NotImplementedException();
            }
        }
    }

    public class DialogScheduleNext : BaseDialog
    {
        public DialogScheduleNext()
        {
        }

        protected override By ByForDialog => throw new NotImplementedException();

        public FileUploader EventTriggerButtonUploadCoverPhoto =>
         new FileUploader(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.UploadCoverPhoto}']"));

        public EventTriggerButton<DialogChooseIllustration> EventTriggerButtonChooseIllustration =>
         new EventTriggerButton<DialogChooseIllustration>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.ChooseIllustration}']"));

        public Button ButtonEditIllustrationOrPhoto => new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResLeftNav.Edit}')]"));

        public IWebElement ButtonImageIllustration(int index)
        {
            var illustrations = Driver.FindElements(By.XPath($"//div[@aria-label='{ResLeftNav.ScheduleLiveSettings}']//img[contains(@alt,'{ResLeftNav.Seasons}') or contains(@alt,'{ResLeftNav.Holiday}') or contains(@alt,'{ResLeftNav.Family}')]"));
            if (illustrations.Count() < index) return null;
            return illustrations[index];
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }

        public EventTriggerButton<DialogEventSettings> EventTriggerButtonEventSettings =>
            new EventTriggerButton<DialogEventSettings>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.EventSettings}']"));

        public EventTriggerButton<DialogEventSettings> EventTriggerButtonScheduleWithoutCreatingEvent =>
            new EventTriggerButton<DialogEventSettings>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.ScheduleWithoutCreatingEvent}']"));

        public EventTriggerButton<DialogScheduleNext> EventTriggerButtonBack =>
            new EventTriggerButton<DialogScheduleNext>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Back}']"));

        public EventTriggerButton<DialogEventSettings> EventTriggerButtonSave =>
            new EventTriggerButton<DialogEventSettings>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.CreateEvent}']"));

        public class DialogInvalidTime : BaseDialog
        {
            public DialogInvalidTime()
            {
            }

            protected override By ByForDialog => By.XPath($"//span[text()='{ResLeftNav.InvalidTime}']");

            public Button ButtonOK => new Button(Driver, By.XPath($"//span[text()='{ResLeftNav.InvalidTime}' and //span[text()='{ResLeftNav.OK}']]"));

            public override void RunConformance()
            {
                throw new NotImplementedException();
            }
        }

        public class DialogLiveVideoEventSuccessfullyCreated : BaseDialog
        {
            public DialogLiveVideoEventSuccessfullyCreated()
            {
            }

            protected override By ByForDialog => By.XPath($"//span[text()='{ResLeftNav.LiveVideoEventSuccessfullyCreated}']");

            public EventTriggerButton<DialogScheduleNext> ButtonClose => new EventTriggerButton<DialogScheduleNext>(Driver, By.XPath($"//span[text()='{ResLeftNav.Close}' and //span[text()='{ResLeftNav.LiveVideoEventSuccessfullyCreated}']]"));

            public override void RunConformance()
            {
                throw new NotImplementedException();
            }
        }
    }
}
