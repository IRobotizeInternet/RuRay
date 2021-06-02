using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogCreateYourRoom" />.
    /// </summary>
    public class DialogCreateYourRoom : BaseDialog
    {
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@role='dialog']//span[text()='{ResMiscellaneous.CreateYourRoom}']");

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogCreateYourRoom"/> class.
        /// </summary>
        public DialogCreateYourRoom()
        {
        }

        /// <summary>
        /// Gets the EventTriggerButtonRoomName.
        /// </summary>
        public EventTriggerButton<DialogRoomName> EventTriggerButtonRoomName =>
            new EventTriggerButton<DialogRoomName>(Driver, By.XPath($"//div[@role='dialog']//span[text()='{ResMiscellaneous.RoomName}']"));

        /// <summary>
        /// Gets the EventTriggerButtonStartTime.
        /// </summary>
        public EventTriggerButton<DialogStartTime> EventTriggerButtonStartTime =>
            new EventTriggerButton<DialogStartTime>(Driver, By.XPath($"//div[@role='dialog']//span[text()='{ResMiscellaneous.StartTime}']"));

        /// <summary>
        /// Gets the CheckboxVisibleToAllFriends.
        /// </summary>
        public Checkbox CheckboxVisibleToAllFriends =>
            new Checkbox(Driver, By.XPath("//div[@role='dialog']//input"));

        /// <summary>
        /// Gets the EventTriggerButtonCreateRoom.
        /// </summary>
        public EventTriggerButton<DialogJoinRoom> EventTriggerButtonCreateRoom =>
            new EventTriggerButton<DialogJoinRoom>(Driver, By.XPath($"//div[@role='dialog']//span[text()='{ResMiscellaneous.CreateRoom}']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
