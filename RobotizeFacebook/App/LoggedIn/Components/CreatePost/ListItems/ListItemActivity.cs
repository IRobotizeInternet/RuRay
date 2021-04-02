using OpenQA.Selenium;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ListItemActivity : BaseDiv
    {
        public EventTriggerButton<DialogMenu> EventTriggerButtonMenu
            => new EventTriggerButton<DialogMenu>(Driver, By.XPath(""));
        public Label LabelActivity(int index) => new Label(Driver, By.XPath($"{BaseXPath}"));
        public ListItemActivity(string baseXPath)
        {
            BaseXPath = baseXPath;
        }
    }

    public class DialogMenu : BaseDialog
    {
        public DialogMenu()
        {
        }

        protected override By ByForDialog => By.XPath("//span[text()='Delete']");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
