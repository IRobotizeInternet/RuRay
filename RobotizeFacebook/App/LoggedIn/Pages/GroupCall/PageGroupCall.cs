using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;

namespace RobotizeFacebook.App.LoggedIn.Pages.GroupCall
{
    public class PageGroupCall : BasePage
    {
        public override string PageUrl => "/groupcall";

        public override By ByForPage => By.XPath($"//div[@data-testid='meetup_pre_call_root']");

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }

        public DialogCallPeopleToJoin DialogCallPeopleToJoinWindow = new DialogCallPeopleToJoin();
    }

    public class DialogCallPeopleToJoin : BaseDialog
    {
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResCreatePost.CallPeopleToJoin}']");

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }

        public Button ButtonBroadcastLive => new Button(Driver, By.XPath("//button/i/following-sibling::span"));

        public Button ButtonInvitePeople => new Button(Driver, By.XPath($"//div[@aria-label='{ResHomePage.InvitePeople}']"));

        public Button ButtonCopyLink => new Button(Driver, By.XPath($"//button[@aria-label='{ResHomePage.CopyLink}']"));

        public Button ButtonShareScreen => new Button(Driver, By.XPath($"//button[@aria-disabled='false']//span[text()='{ResCreatePost.ShareYourScreen}']"));

        public Button ButtonSeeCallParticipants => new Button(Driver, By.XPath($"//button[@aria-disabled='false']//span[text()='{ResCreatePost.SeeCallParticipants}']"));

        public Button ButtonTurnOffVideo => new Button(Driver, By.XPath($"//button[@aria-disabled='false']//span[text()='{ResCreatePost.TurnOffVideo}']"));

        public Button ButtonMuteMicrophone => new Button(Driver, By.XPath($"//button[@aria-disabled='false']//span[text()='{ResCreatePost.MuteMicrophone}']"));

        public Button ButtonLeaveRoom => new Button(Driver, By.XPath($"//button[@aria-disabled='false']//span[text()='{ResCreatePost.LeaveRoom}']"));

        public Button ButtonYourVideoMicrophoneMinimize => new Button(Driver, By.XPath($"//button[@aria-label='{ResCreatePost.YourVideoMicrophoneOnClickToMinimize}']"));

        public Button ButtonYourVideoMicrophoneShow => new Button(Driver, By.XPath($"//button[@aria-label='{ResCreatePost.YourVideoMicrophoneOnClickToShow}']"));

        public ComboboxAddMembers ComboboxSearchForFriends => 
            new ComboboxAddMembers(Driver, 
                $"//div[@aria-label='{ResCreatePost.CallPeopleToJoin}']", 
                searchBoxXPath: $"//div[@aria-label='{ResCreatePost.CallPeopleToJoin}']//input[@aria-label='{ResCreatePost.SearchForPeople}']",
                searchItemsXPath: $"//div[@aria-label='{ResCreatePost.CallPeopleToJoin}']//div[@aria-label='{ResCreatePost.CallPeopleToJoin}']//div[@role='listitem']");

        public ScrollControl<ListItemCallPeopleToJoin> ScrollControlCallPeopleToJoin
            => new ScrollControl<ListItemCallPeopleToJoin>(Driver, "");
    }
}
