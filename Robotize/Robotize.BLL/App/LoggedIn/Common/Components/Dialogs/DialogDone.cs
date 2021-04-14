using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogDone : BaseDialog
    {
        public DialogDone()
        {
            BaseXPath = "//div[@role='dialog']//";
        }

        public Button ButtonBlockUser =>
            new Button(Driver, By.XPath($"{BaseXPath}span[contains(text(), {ResHomePage.BlockWithSpace}"));
        public Button ButtonHidePostsFromUser =>
            new Button(Driver, By.XPath($"{BaseXPath}span[contains(text(), {ResHomePage.HidePostsFrom}"));
        public Button ButtonBlockConfirm =>
           new Button(Driver, By.XPath($"{BaseXPath}span[contains(text(),'{ResHomePage.BlockWithSpace}')]/parent::div/parent::div/parent::div/parent::div/div[2]/div/div/div[1]"));
        public Button ButtonBlockCancel =>
          new Button(Driver, By.XPath($"{BaseXPath}span[contains(text(),'{ResHomePage.BlockWithSpace}')]/parent::div/parent::div/parent::div/parent::div/div[2]/div/div/div[2]"));

        public Button ButtonHidePostConfirm =>
           new Button(Driver, By.XPath($"{BaseXPath}span[contains(text(),'{ResHomePage.HideWithSpace}')]/parent::div/parent::div/parent::div/parent::div/div[2]/div/div/div[1]"));
        public Button ButtonHidePostCancel =>
          new Button(Driver, By.XPath($"{BaseXPath}span[contains(text(),'{ResHomePage.HideWithSpace}')]/parent::div/parent::div/parent::div/parent::div/div[2]/div/div/div[2]"));

        public Button ButtonLearn => new Button(Driver, By.XPath($"{BaseXPath}span[contains(text(), {ResHomePage.LearnAbout}"));

        public EventTriggerButton<PageHome> EventTriggerButtonDone =>
            new EventTriggerButton<PageHome>(Driver, By.XPath($"{BaseXPath}span[contains(text(),'{ResHomePage.Done}')]"));

        protected override By ByForDialog => By.XPath($"//div[@role='dialog']//span[text()='{ResHomePage.YouSelected}']");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}