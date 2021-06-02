using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Components;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="ListItemMessangerChat" />.
    /// </summary>
    public class ListItemMessangerChat : BaseDiv, IListItem
    {
        /// <summary>
        /// Gets the EventTriggerButtonMenu.
        /// </summary>
        public EventTriggerButton<DialogMenu> EventTriggerButtonMenu => new EventTriggerButton<DialogMenu>(Driver, By.XPath($"{BaseXPath}/div[{XIndex}"));

        /// <summary>
        /// Gets the LabelMessage.
        /// </summary>
        public Label LabelMessage => new Label(Driver, By.XPath($"{BaseXPath}/div[{XIndex}]//div[@data-scope='messages_table']//div[@data-testid='outgoing_message']"));

        /// <summary>
        /// Gets the LabelHoverOver.
        /// </summary>
        public Label LabelHoverOver => new Label(Driver, By.XPath($"{BaseXPath}/div[{XIndex}]//div[@data-scope='messages_table']//div[@aria-label={ResHomePage.MessageActions}]"));

        /// <summary>
        /// Initializes a new instance of the <see cref="ListItemMessangerChat"/> class.
        /// </summary>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        /// <param name="xIndex">The xIndex<see cref="int"/>.</param>
        /// <param name="yIndex">The yIndex<see cref="int"/>.</param>
        public ListItemMessangerChat(string baseXPath, int xIndex = 1, int yIndex = 1)
        {
            XIndex = xIndex;
            YIndex = yIndex;
            BaseXPath = baseXPath ?? $"//div[@data-pagelet = 'ChatTab']//div[@aria-label='{ResHomePage.Messages}']";
        }

        /// <summary>
        /// Gets or sets the XIndex.
        /// </summary>
        public int XIndex { get; set; }

        /// <summary>
        /// Gets or sets the YIndex.
        /// </summary>
        public int YIndex { get; set; }
    }

    /// <summary>
    /// Defines the <see cref="PopupMessageActions" />.
    /// </summary>
    public class PopupMessageActions : BasePopup
    {
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@data-pagelet = 'ChatTab']//div[@aria-label='{ResHomePage.Messages}']//div[@aria-label='{ResHomePage.Reply}']");

        // TODO: Clicking this message should take the user to Popup new Message window and place the cursor into the textbox chat box.
        /// <summary>
        /// Gets the EventTriggerButton.
        /// </summary>
        public EventTriggerButton<PopupNewMessage> EventTriggerButton =>
            new EventTriggerButton<PopupNewMessage>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.Reply}']"));

        /// <summary>
        /// Initializes a new instance of the <see cref="PopupMessageActions"/> class.
        /// </summary>
        public PopupMessageActions()
        {
            BaseXPath = $"//div[@data-pagelet = 'ChatTab']//div[@aria-label='{ResHomePage.Messages}']";
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
