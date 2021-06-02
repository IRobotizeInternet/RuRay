using System;
using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogSendToGroup{TGroup}" />.
    /// </summary>
    /// <typeparam name="TGroup">.</typeparam>
    public class DialogSendToGroup<TGroup> : BaseDialog where TGroup : BaseDialog
    {
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[*/h2/span/span[text()='{ResHomePage.SendToGroup}']]");

        /// <summary>
        /// Gets the TextBoxAddMember.
        /// </summary>
        public TextBox TextBoxAddMember => new TextBox(Driver, By.XPath($"{BaseXPath}//input"));

        /// <summary>
        /// Gets the EventTriggerButtonSendToGroup.
        /// </summary>
        public EventTriggerButton<TGroup> EventTriggerButtonSendToGroup =>
            new EventTriggerButton<TGroup>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.SendToGroup}']"));

        /// <summary>
        /// Gets the ScrollControlSendToGroup.
        /// </summary>
        public ScrollControl<ListItemSendToGroup> ScrollControlSendToGroup =>
            new ScrollControl<ListItemSendToGroup>(
                Driver,
                BaseXPath,
                scrollXPath: $"//div[*/h2/span/span[text()='{ResHomePage.SendToGroup}']]//" + "ul[{0}]");

        /// <summary>
        /// Gets the EventTriggerButtonBackArrow.
        /// </summary>
        public EventTriggerButton<TGroup> EventTriggerButtonBackArrow =>
            new EventTriggerButton<TGroup>(Driver, null);

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogSendToGroup{TGroup}"/> class.
        /// </summary>
        public DialogSendToGroup()
        {
            BaseXPath = $"//div[*/h2/span/span[text()='{ResHomePage.SendToGroup}']]";
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
