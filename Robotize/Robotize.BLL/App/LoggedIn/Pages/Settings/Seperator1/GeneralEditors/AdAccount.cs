using OpenQA.Selenium;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls.TriggerControls;
using Robotize.BLL.Resources;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class AdAccount : BaseEditor
    {
        public Label LabelAdAccountContactEmail => new Label(Driver, By.XPath("//div[@id='u_d_2']/div/div/span[1]"));
        public Hyperlink<AdAccountDialog> LinkChangeAdAccountEmail => new Hyperlink<AdAccountDialog>(Driver, By.XPath("//div[@id='u_d_2']/div/div/span[2]"));
        public Hyperlink<PageAdPreferences> LinkAdAccountSettings => new Hyperlink<PageAdPreferences>(Driver, By.XPath("//a[@class='bizOK']"));
        public Button ButtonClose => new Button(Driver, By.XPath($"//input[@value={ResMiscellaneous.Close}]"));
    }

    public class AdAccountDialog : BaseDialog
    {
        public AdAccountDialog()
        {
        }

        protected override By ByForDialog => By.XPath($"//div[text()={ResMiscellaneous.ChangeAdAccountContact}]");

        public TextBox TextBoxNewEmail => new TextBox(Driver, By.XPath($"//input[@placeholder={ResMiscellaneous.EnterNewEmail}]"));
        public Button ButtonCancel => new Button(Driver, By.XPath($"//div[text()={ResMiscellaneous.Cancel}]"));
        public Button ButtonChangeEmail => new Button(Driver, By.XPath($"//div[text()={ResMiscellaneous.ChangeEmail}]"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
