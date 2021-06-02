using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;
using RuRayToolbox.Enums;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogRoomName" />.
    /// </summary>
    public class DialogRoomName : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogRoomName"/> class.
        /// </summary>
        public DialogRoomName()
        {
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@role='dialog']//span[text()='{ResMiscellaneous.SquadHang}']");

        /// <summary>
        /// The ButtonRoomName.
        /// </summary>
        /// <param name="roomName">The roomName<see cref="EnumRoomName"/>.</param>
        /// <returns>The <see cref="Button"/>.</returns>
        public Button ButtonRoomName(EnumRoomName roomName)
        {
            if (roomName.GetDescription() == ResMiscellaneous.New)
            {
                return null;
            }

            return new Button(Driver, By.XPath($"//div[@role='dialog']//span[text()='{roomName.GetDescription()}']"));
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets the EventTriggerButtonNew.
        /// </summary>
        public EventTriggerButton<DialogNewRoomName> EventTriggerButtonNew =>
            new EventTriggerButton<DialogNewRoomName>(Driver, By.XPath($"//div[@role='dialog']//div[@role='button']//span[text()='{ResMiscellaneous.New}']"));
    }
}
