using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DivContacts : BaseDiv
    {
        public DivContacts()
        {
            
        }

        public ScrollControl<ListItemContact> ScrollControlContacts =>
            new ScrollControl<ListItemContact>(Driver,
                "//div[@data-pagelet='RightRail']/div[2]//ul/div/li",
                scrollXPath: "//div[@role='complementary']/div/div");

        public ScrollControl<ListItemContact> ScrollControlContactsGroupConversations =>
            new ScrollControl<ListItemContact>(Driver,
                "//div[@data-pagelet='RightRail']/div[2]//ul/div/li",
                scrollXPath: "//div[@role='complementary']/div/div");

        public EventTriggerButton<DialogCreateGroup> EventTriggerButtonCreateNewGroup =>
            new EventTriggerButton<DialogCreateGroup>(Driver, By.XPath($"//div[@data-pagelet='RightRail']//span[text()='{ResHomePage.CreateNewGroup}']"));

        //public EventTriggerButton<> EventTriggerButtonCreateRoom => 
        //    new EventTriggerButton<EventResult>(Driver, By.XPath($"//div[@aria-label='{ResCreatePost.NewRoom}']"));
    }
}
