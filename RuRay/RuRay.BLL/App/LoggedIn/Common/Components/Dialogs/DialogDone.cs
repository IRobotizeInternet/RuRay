using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogDone" />.
    /// </summary>
    public class DialogDone : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogDone"/> class.
        /// </summary>
        public DialogDone()
        {
            BaseXPath = "//div[@role='dialog']//";
        }

        /// <summary>
        /// Gets the ButtonBlockUser.
        /// </summary>
        public Button ButtonBlockUser =>
            new Button(Driver, By.XPath($"{BaseXPath}span[contains(text(), {ResHomePage.BlockWithSpace}"));

        /// <summary>
        /// Gets the ButtonHidePostsFromUser.
        /// </summary>
        public Button ButtonHidePostsFromUser =>
            new Button(Driver, By.XPath($"{BaseXPath}span[contains(text(), {ResHomePage.HidePostsFrom}"));

        /// <summary>
        /// Gets the ButtonBlockConfirm.
        /// </summary>
        public Button ButtonBlockConfirm =>
           new Button(Driver, By.XPath($"{BaseXPath}span[contains(text(),'{ResHomePage.BlockWithSpace}')]/parent::div/parent::div/parent::div/parent::div/div[2]/div/div/div[1]"));

        /// <summary>
        /// Gets the ButtonBlockCancel.
        /// </summary>
        public Button ButtonBlockCancel =>
          new Button(Driver, By.XPath($"{BaseXPath}span[contains(text(),'{ResHomePage.BlockWithSpace}')]/parent::div/parent::div/parent::div/parent::div/div[2]/div/div/div[2]"));

        /// <summary>
        /// Gets the ButtonHidePostConfirm.
        /// </summary>
        public Button ButtonHidePostConfirm =>
           new Button(Driver, By.XPath($"{BaseXPath}span[contains(text(),'{ResHomePage.HideWithSpace}')]/parent::div/parent::div/parent::div/parent::div/div[2]/div/div/div[1]"));

        /// <summary>
        /// Gets the ButtonHidePostCancel.
        /// </summary>
        public Button ButtonHidePostCancel =>
          new Button(Driver, By.XPath($"{BaseXPath}span[contains(text(),'{ResHomePage.HideWithSpace}')]/parent::div/parent::div/parent::div/parent::div/div[2]/div/div/div[2]"));

        /// <summary>
        /// Gets the ButtonLearn.
        /// </summary>
        public Button ButtonLearn => new Button(Driver, By.XPath($"{BaseXPath}span[contains(text(), {ResHomePage.LearnAbout}"));

        /// <summary>
        /// Gets the EventTriggerButtonDone.
        /// </summary>
        public EventTriggerButton<PageHome> EventTriggerButtonDone =>
            new EventTriggerButton<PageHome>(Driver, By.XPath($"{BaseXPath}span[contains(text(),'{ResHomePage.Done}')]"));

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@role='dialog']//span[text()='{ResHomePage.YouSelected}']");

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
