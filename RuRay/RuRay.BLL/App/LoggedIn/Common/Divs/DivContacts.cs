using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DivContacts" />.
    /// </summary>
    public class DivContacts : BaseDiv
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DivContacts"/> class.
        /// </summary>
        public DivContacts()
        {
        }

        /// <summary>
        /// Gets the ScrollControlContacts.
        /// </summary>
        public ScrollControl<ListItemContact> ScrollControlContacts =>
            new ScrollControl<ListItemContact>(Driver,
                "//div[@data-pagelet='RightRail']/div[2]//ul/div/li",
                scrollXPath: "//div[@role='complementary']/div/div");

        /// <summary>
        /// Gets the ScrollControlContactsGroupConversations.
        /// </summary>
        public ScrollControl<ListItemContact> ScrollControlContactsGroupConversations =>
            new ScrollControl<ListItemContact>(Driver,
                "//div[@data-pagelet='RightRail']/div[2]//ul/div/li",
                scrollXPath: "//div[@role='complementary']/div/div");

        /// <summary>
        /// Gets the EventTriggerButtonCreateNewGroup.
        /// </summary>
        public EventTriggerButton<DialogCreateGroup> EventTriggerButtonCreateNewGroup =>
            new EventTriggerButton<DialogCreateGroup>(Driver, By.XPath($"//div[@data-pagelet='RightRail']//span[text()='{ResHomePage.CreateNewGroup}']"));
    }
}
