using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayFacebook.App.LoggedIn.Enum;
using RuRayLibrary.Extensions;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;
using RuRayToolbox.Controls.TriggerControls;

namespace RuRayFacebook.App.LoggedIn.Pages.JobsComposer.ScheduleLiveVideoEvent
{
    /// <summary>
    /// Defines the <see cref="MenuItemsScheduleLiveVideoEvent" />.
    /// </summary>
    public class MenuItemsScheduleLiveVideoEvent : MenuItems
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuItemsScheduleLiveVideoEvent"/> class.
        /// </summary>
        public MenuItemsScheduleLiveVideoEvent()
        {
            BaseXPath = $"//div[@aria-label='{ResLeftNav.ScheduleLiveSettings}']";
            MenuItemsCommon = new MenuItemsCommon(BaseXPath);
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Defines the MenuItemsCommon.
        /// </summary>
        public MenuItemsCommon MenuItemsCommon;

        /// <summary>
        /// Gets the TextBoxEventName.
        /// </summary>
        public TextBox TextBoxEventName => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.EventName}']"));

        /// <summary>
        /// Gets the TextBoxStartDate.
        /// </summary>
        public TextBox TextBoxStartDate => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.StartDate}']"));

        /// <summary>
        /// Gets the TextBoxStartTime.
        /// </summary>
        public TextBox TextBoxStartTime => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.StartTime}']"));

        /// <summary>
        /// Gets the TextBoxDescription.
        /// </summary>
        public TextBox TextBoxDescription => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Description}']"));

        /// <summary>
        /// Gets the HyperlinkEndDateAndTime.
        /// </summary>
        public Hyperlink<DialogEndDateAndTime> HyperlinkEndDateAndTime =>
            new Hyperlink<DialogEndDateAndTime>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.EventName}']"));

        /// <summary>
        /// Gets the EventTriggerButtonEndDateAndTime.
        /// </summary>
        public EventTriggerButton<DialogEndDateAndTime> EventTriggerButtonEndDateAndTime =>
         new EventTriggerButton<DialogEndDateAndTime>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Next}']"));

        /// <summary>
        /// Gets the DropdownPrivacy.
        /// </summary>
        public DropdownSchedulePrivacy DropdownPrivacy =>
            new DropdownSchedulePrivacy(Driver, new ExtendBy($"{BaseXPath}//span[text()='{ResLeftNav.Privacy}']"));

        /// <summary>
        /// Defines the <see cref="DropdownSchedulePrivacy" />.
        /// </summary>
        public class DropdownSchedulePrivacy : DropdownWithEnum<Privacy>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="DropdownSchedulePrivacy"/> class.
            /// </summary>
            /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
            /// <param name="byForDropdown">The byForDropdown<see cref="ExtendBy"/>.</param>
            public DropdownSchedulePrivacy(RemoteWebDriver driver, ExtendBy byForDropdown) : base(driver, byForDropdown)
            {
            }
        }

        /// <summary>
        /// Gets the CheckboxGuestsCanInviteFriends.
        /// </summary>
        public Checkbox CheckboxGuestsCanInviteFriends =>
            new Checkbox(Driver, By.XPath($"{BaseXPath}//input[@aria-label='{ResLeftNav.GuestsCanInviteFriends}']"));

        /// <summary>
        /// Gets the EventTriggerButtonNext.
        /// </summary>
        public EventTriggerButton<DialogScheduleNext> EventTriggerButtonNext =>
            new EventTriggerButton<DialogScheduleNext>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Next}']"));

        /// <summary>
        /// Defines the <see cref="DialogEndDateAndTime" />.
        /// </summary>
        public class DialogEndDateAndTime : BaseDialog
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="DialogEndDateAndTime"/> class.
            /// </summary>
            public DialogEndDateAndTime()
            {
            }

            /// <summary>
            /// Gets the ByForDialog.
            /// </summary>
            protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResLeftNav.ScheduleLiveSettings}']//span[text()='{ResLeftNav.EndDateAndTime}']");

            /// <summary>
            /// Gets the TextBoxEndDate.
            /// </summary>
            public TextBox TextBoxEndDate => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.EndDate}']"));

            /// <summary>
            /// Gets the TextBoxEndTime.
            /// </summary>
            public TextBox TextBoxEndTime => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.EndTime}']"));

            /// <summary>
            /// The RunConformance.
            /// </summary>
            public override void RunConformance()
            {
                throw new NotImplementedException();
            }
        }
    }

    /// <summary>
    /// Defines the <see cref="DialogScheduleNext" />.
    /// </summary>
    public class DialogScheduleNext : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogScheduleNext"/> class.
        /// </summary>
        public DialogScheduleNext()
        {
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => throw new NotImplementedException();

        /// <summary>
        /// Gets the EventTriggerButtonUploadCoverPhoto.
        /// </summary>
        public FileUploader EventTriggerButtonUploadCoverPhoto =>
         new FileUploader(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.UploadCoverPhoto}']"));

        /// <summary>
        /// Gets the EventTriggerButtonChooseIllustration.
        /// </summary>
        public EventTriggerButton<DialogChooseIllustration> EventTriggerButtonChooseIllustration =>
         new EventTriggerButton<DialogChooseIllustration>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.ChooseIllustration}']"));

        /// <summary>
        /// Gets the ButtonEditIllustrationOrPhoto.
        /// </summary>
        public Button ButtonEditIllustrationOrPhoto => new Button(Driver, By.XPath($"{BaseXPath}//span[contains(text(),'{ResLeftNav.Edit}')]"));

        /// <summary>
        /// The ButtonImageIllustration.
        /// </summary>
        /// <param name="index">The index<see cref="int"/>.</param>
        /// <returns>The <see cref="IWebElement"/>.</returns>
        public IWebElement ButtonImageIllustration(int index)
        {
            var illustrations = Driver.FindElements(By.XPath($"//div[@aria-label='{ResLeftNav.ScheduleLiveSettings}']//img[contains(@alt,'{ResLeftNav.Seasons}') or contains(@alt,'{ResLeftNav.Holiday}') or contains(@alt,'{ResLeftNav.Family}')]"));
            if (illustrations.Count() < index)
            {
                return null;
            }

            return illustrations[index];
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the EventTriggerButtonEventSettings.
        /// </summary>
        public EventTriggerButton<DialogEventSettings> EventTriggerButtonEventSettings =>
            new EventTriggerButton<DialogEventSettings>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.EventSettings}']"));

        /// <summary>
        /// Gets the EventTriggerButtonScheduleWithoutCreatingEvent.
        /// </summary>
        public EventTriggerButton<DialogEventSettings> EventTriggerButtonScheduleWithoutCreatingEvent =>
            new EventTriggerButton<DialogEventSettings>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.ScheduleWithoutCreatingEvent}']"));

        /// <summary>
        /// Gets the EventTriggerButtonBack.
        /// </summary>
        public EventTriggerButton<DialogScheduleNext> EventTriggerButtonBack =>
            new EventTriggerButton<DialogScheduleNext>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.Back}']"));

        /// <summary>
        /// Gets the EventTriggerButtonSave.
        /// </summary>
        public EventTriggerButton<DialogEventSettings> EventTriggerButtonSave =>
            new EventTriggerButton<DialogEventSettings>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResLeftNav.CreateEvent}']"));

        /// <summary>
        /// Defines the <see cref="DialogInvalidTime" />.
        /// </summary>
        public class DialogInvalidTime : BaseDialog
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="DialogInvalidTime"/> class.
            /// </summary>
            public DialogInvalidTime()
            {
            }

            /// <summary>
            /// Gets the ByForDialog.
            /// </summary>
            protected override By ByForDialog => By.XPath($"//span[text()='{ResLeftNav.InvalidTime}']");

            /// <summary>
            /// Gets the ButtonOK.
            /// </summary>
            public Button ButtonOK => new Button(Driver, By.XPath($"//span[text()='{ResLeftNav.InvalidTime}' and //span[text()='{ResLeftNav.OK}']]"));

            /// <summary>
            /// The RunConformance.
            /// </summary>
            public override void RunConformance()
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Defines the <see cref="DialogLiveVideoEventSuccessfullyCreated" />.
        /// </summary>
        public class DialogLiveVideoEventSuccessfullyCreated : BaseDialog
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="DialogLiveVideoEventSuccessfullyCreated"/> class.
            /// </summary>
            public DialogLiveVideoEventSuccessfullyCreated()
            {
            }

            /// <summary>
            /// Gets the ByForDialog.
            /// </summary>
            protected override By ByForDialog => By.XPath($"//span[text()='{ResLeftNav.LiveVideoEventSuccessfullyCreated}']");

            /// <summary>
            /// Gets the ButtonClose.
            /// </summary>
            public EventTriggerButton<DialogScheduleNext> ButtonClose => new EventTriggerButton<DialogScheduleNext>(Driver, By.XPath($"//span[text()='{ResLeftNav.Close}' and //span[text()='{ResLeftNav.LiveVideoEventSuccessfullyCreated}']]"));

            /// <summary>
            /// The RunConformance.
            /// </summary>
            public override void RunConformance()
            {
                throw new NotImplementedException();
            }
        }
    }
}
