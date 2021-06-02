using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="PopupHelpAndSupport" />.
    /// </summary>
    public class PopupHelpAndSupport : BasePopup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PopupHelpAndSupport"/> class.
        /// </summary>
        public PopupHelpAndSupport()
        {
            BaseXPath = $"//div[@aria-label='{ResAccount.Account}'][@role='dialog']//span[text()='{ResAccount.HelpCenter}']/../../../../../../../../../../..";
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath(BaseXPath);

        /// <summary>
        /// Gets the ButtonHelpCenter.
        /// </summary>
        public EventTriggerButton<PageHelp> ButtonHelpCenter =>
           new EventTriggerButton<PageHelp>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.HelpCenter}']"));

        /// <summary>
        /// Gets the ButtonSupportInbox.
        /// </summary>
        public EventTriggerButton<PageSupportInbox> ButtonSupportInbox =>
          new EventTriggerButton<PageSupportInbox>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.SupportInbox}']"));

        /// <summary>
        /// Gets the ButtonReportAProblem.
        /// </summary>
        public EventTriggerButton<PageSettings> ButtonReportAProblem =>
          new EventTriggerButton<PageSettings>(Driver, By.XPath($"{BaseXPath}//span[text()='{ResAccount.ReportAProblem}']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
