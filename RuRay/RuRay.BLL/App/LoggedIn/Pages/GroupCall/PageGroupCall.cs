using System;
using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PageGroupCall" />.
    /// </summary>
    public class PageGroupCall : BasePage
    {
        /// <summary>
        /// Gets the PageUrl.
        /// </summary>
        public override string PageUrl => "/groupcall";

        /// <summary>
        /// Gets the ByForPage.
        /// </summary>
        public override By ByForPage => By.XPath($"//div[@data-testid='meetup_pre_call_root']");

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Defines the DialogCallPeopleToJoinWindow.
        /// </summary>
        public DialogCallPeopleToJoin DialogCallPeopleToJoinWindow = new DialogCallPeopleToJoin();
    }

    /// <summary>
    /// Defines the <see cref="DialogCallPeopleToJoin" />.
    /// </summary>
    public class DialogCallPeopleToJoin : BaseDialog
    {
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResCreatePost.CallPeopleToJoin}']");

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the ButtonBroadcastLive.
        /// </summary>
        public Button ButtonBroadcastLive => new Button(Driver, By.XPath("//button/i/following-sibling::span"));

        /// <summary>
        /// Gets the ButtonInvitePeople.
        /// </summary>
        public Button ButtonInvitePeople => new Button(Driver, By.XPath($"//div[@aria-label='{ResHomePage.InvitePeople}']"));

        /// <summary>
        /// Gets the ButtonCopyLink.
        /// </summary>
        public Button ButtonCopyLink => new Button(Driver, By.XPath($"//button[@aria-label='{ResHomePage.CopyLink}']"));

        /// <summary>
        /// Gets the ButtonShareScreen.
        /// </summary>
        public Button ButtonShareScreen => new Button(Driver, By.XPath($"//button[@aria-disabled='false']//span[text()='{ResCreatePost.ShareYourScreen}']"));

        /// <summary>
        /// Gets the ButtonSeeCallParticipants.
        /// </summary>
        public Button ButtonSeeCallParticipants => new Button(Driver, By.XPath($"//button[@aria-disabled='false']//span[text()='{ResCreatePost.SeeCallParticipants}']"));

        /// <summary>
        /// Gets the ButtonTurnOffVideo.
        /// </summary>
        public Button ButtonTurnOffVideo => new Button(Driver, By.XPath($"//button[@aria-disabled='false']//span[text()='{ResCreatePost.TurnOffVideo}']"));

        /// <summary>
        /// Gets the ButtonMuteMicrophone.
        /// </summary>
        public Button ButtonMuteMicrophone => new Button(Driver, By.XPath($"//button[@aria-disabled='false']//span[text()='{ResCreatePost.MuteMicrophone}']"));

        /// <summary>
        /// Gets the ButtonLeaveRoom.
        /// </summary>
        public Button ButtonLeaveRoom => new Button(Driver, By.XPath($"//button[@aria-disabled='false']//span[text()='{ResCreatePost.LeaveRoom}']"));

        /// <summary>
        /// Gets the ButtonYourVideoMicrophoneMinimize.
        /// </summary>
        public Button ButtonYourVideoMicrophoneMinimize => new Button(Driver, By.XPath($"//button[@aria-label='{ResCreatePost.YourVideoMicrophoneOnClickToMinimize}']"));

        /// <summary>
        /// Gets the ButtonYourVideoMicrophoneShow.
        /// </summary>
        public Button ButtonYourVideoMicrophoneShow => new Button(Driver, By.XPath($"//button[@aria-label='{ResCreatePost.YourVideoMicrophoneOnClickToShow}']"));

        /// <summary>
        /// Gets the ComboboxSearchForFriends.
        /// </summary>
        public ComboboxAddMembers ComboboxSearchForFriends =>
            new ComboboxAddMembers(Driver,
                $"//div[@aria-label='{ResCreatePost.CallPeopleToJoin}']",
                searchBoxXPath: $"//div[@aria-label='{ResCreatePost.CallPeopleToJoin}']//input[@aria-label='{ResCreatePost.SearchForPeople}']",
                searchItemsXPath: $"//div[@aria-label='{ResCreatePost.CallPeopleToJoin}']//div[@aria-label='{ResCreatePost.CallPeopleToJoin}']//div[@role='listitem']");

        /// <summary>
        /// Gets the ScrollControlCallPeopleToJoin.
        /// </summary>
        public ScrollControl<ListItemCallPeopleToJoin> ScrollControlCallPeopleToJoin => new ScrollControl<ListItemCallPeopleToJoin>(Driver, "");

        /// <summary>
        /// Gets the EventTriggerButtonMenuOptions.
        /// </summary>
        public EventTriggerButton<DialogMenuOptions> EventTriggerButtonMenuOptions =>
            new EventTriggerButton<DialogMenuOptions>(Driver, By.XPath($"//button[@aria-label={ResCreatePost.MenuOptions}]"));

        /// <summary>
        /// Defines the <see cref="DialogMenuOptions" />.
        /// </summary>
        public class DialogMenuOptions : BaseDialog
        {
            /// <summary>
            /// Gets the ByForDialog.
            /// </summary>
            protected override By ByForDialog => By.XPath($"//div[@data-pagelet='root']//span[text()='{ResCreatePost.DeviceSettings}']");

            /// <summary>
            /// Gets the EventTriggerButtonGroupCallSettings.
            /// </summary>
            public EventTriggerButton<DialogGroupCallSettings> EventTriggerButtonGroupCallSettings => new EventTriggerButton<DialogGroupCallSettings>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResCreatePost.DeviceSettings}']"));

            /// <summary>
            /// Gets the ButtonEnterFullScreen.
            /// </summary>
            public Button ButtonEnterFullScreen => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResCreatePost.EnterFullscreen}']"));

            /// <summary>
            /// Gets the ButtonExitFullscreen.
            /// </summary>
            public Button ButtonExitFullscreen => new Button(Driver, By.XPath($"{BaseXPath}//span[text()='{ResCreatePost.ExitFullscreen}']"));

            /// <summary>
            /// Initializes a new instance of the <see cref="DialogMenuOptions"/> class.
            /// </summary>
            public DialogMenuOptions()
            {
                BaseXPath = $"//div[@data-pagelet='root']";
            }

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
    /// Defines the <see cref="DialogGroupCallSettings" />.
    /// </summary>
    public class DialogGroupCallSettings : BaseDialog
    {
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResCreatePost.VideoAndAudioCallSettings}']");

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogGroupCallSettings"/> class.
        /// </summary>
        public DialogGroupCallSettings()
        {
            BaseXPath = $"//div[@aria-label='{ResCreatePost.VideoAndAudioCallSettings}']";
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
