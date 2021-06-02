using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls.TriggerControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="AdAccount" />.
    /// </summary>
    public class AdAccount : BaseEditor
    {
        /// <summary>
        /// Gets the LabelAdAccountContactEmail.
        /// </summary>
        public Label LabelAdAccountContactEmail => new Label(Driver, By.XPath("//div[@id='u_d_2']/div/div/span[1]"));

        /// <summary>
        /// Gets the LinkChangeAdAccountEmail.
        /// </summary>
        public Hyperlink<AdAccountDialog> LinkChangeAdAccountEmail => new Hyperlink<AdAccountDialog>(Driver, By.XPath("//div[@id='u_d_2']/div/div/span[2]"));

        /// <summary>
        /// Gets the LinkAdAccountSettings.
        /// </summary>
        public Hyperlink<PageAdPreferences> LinkAdAccountSettings => new Hyperlink<PageAdPreferences>(Driver, By.XPath("//a[@class='bizOK']"));

        /// <summary>
        /// Gets the ButtonClose.
        /// </summary>
        public Button ButtonClose => new Button(Driver, By.XPath($"//input[@value={ResMiscellaneous.Close}]"));
    }

    /// <summary>
    /// Defines the <see cref="AdAccountDialog" />.
    /// </summary>
    public class AdAccountDialog : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdAccountDialog"/> class.
        /// </summary>
        public AdAccountDialog()
        {
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[text()={ResMiscellaneous.ChangeAdAccountContact}]");

        /// <summary>
        /// Gets the TextBoxNewEmail.
        /// </summary>
        public TextBox TextBoxNewEmail => new TextBox(Driver, By.XPath($"//input[@placeholder={ResMiscellaneous.EnterNewEmail}]"));

        /// <summary>
        /// Gets the ButtonCancel.
        /// </summary>
        public Button ButtonCancel => new Button(Driver, By.XPath($"//div[text()={ResMiscellaneous.Cancel}]"));

        /// <summary>
        /// Gets the ButtonChangeEmail.
        /// </summary>
        public Button ButtonChangeEmail => new Button(Driver, By.XPath($"//div[text()={ResMiscellaneous.ChangeEmail}]"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
