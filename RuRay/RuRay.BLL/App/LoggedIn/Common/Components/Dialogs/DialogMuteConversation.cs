using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogMuteConversation" />.
    /// </summary>
    public class DialogMuteConversation : BaseDialog
    {
        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@aria-label='{ResHomePage.Muteconversation}']");

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogMuteConversation"/> class.
        /// </summary>
        public DialogMuteConversation()
        {
            BaseXPath = $"//div[@aria-label='{ResHomePage.Muteconversation}']";
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets the ButtonFor30minutes.
        /// </summary>
        public Button ButtonFor30minutes => new Button(Driver, By.XPath($"//div[@data-pagelet='ChatTab']/following::div[@role='menu']//span[text()='{ResHomePage.For30minutes}'"));

        /// <summary>
        /// Gets the ButtonFor1Hour.
        /// </summary>
        public Button ButtonFor1Hour => new Button(Driver, By.XPath($"//div[@data-pagelet='ChatTab']/following::div[@role='menu']//span[text()='{ResHomePage.For1Hour}'"));

        /// <summary>
        /// Gets the ButtonFor8Hours.
        /// </summary>
        public Button ButtonFor8Hours => new Button(Driver, By.XPath($"//div[@data-pagelet='ChatTab']/following::div[@role='menu']//span[text()='{ResHomePage.For8Hours}'"));

        /// <summary>
        /// Gets the ButtonFor24Hours.
        /// </summary>
        public Button ButtonFor24Hours => new Button(Driver, By.XPath($"//div[@data-pagelet='ChatTab']/following::div[@role='menu']//span[text()='{ResHomePage.For24Hours}'"));

        /// <summary>
        /// Gets the ButtonUntilIturnitbackon.
        /// </summary>
        public Button ButtonUntilIturnitbackon => new Button(Driver, By.XPath($"//div[@data-pagelet='ChatTab']/following::div[@role='menu']//span[text()='{ResHomePage.UntilIturnitbackon}'"));

        /// <summary>
        /// Gets the ButtonClose.
        /// </summary>
        public EventTriggerButton<PopupMessanger> ButtonClose => new EventTriggerButton<PopupMessanger>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePageHeader.Close}']"));

        /// <summary>
        /// Gets the ButtonCancel.
        /// </summary>
        public EventTriggerButton<PopupMessanger> ButtonCancel => new EventTriggerButton<PopupMessanger>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.Cancel}'][@tabindex='0']"));

        /// <summary>
        /// Gets the ButtonMute.
        /// </summary>
        public EventTriggerButton<PopupMessanger> ButtonMute => new EventTriggerButton<PopupMessanger>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResHomePage.Mute}'][@tabindex='0']"));
    }
}
