using OpenQA.Selenium;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using RobotizeToolbox.Controls.TriggerControls;
using Robotize.BLL.Resources;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class Contact : BaseEditor
    {
        public Label LabelPrimaryEmail => new Label(Driver, By.XPath("(//div[@class='pbm fbSettingsEditorFields']//div/span)[2]"));
        public Checkbox CheckboxAllowFriendsToIncludeMyEmailAddressIn => new Checkbox(Driver, By.XPath("//input[@id='js_0']"));
        public Hyperlink<AddAnotherEmailDialog> LinkAddAnotherEmailOrMobile => 
            new Hyperlink<AddAnotherEmailDialog>(Driver, By.XPath($"//a[text()={ResMiscellaneous.AddAnotherEmailOrMobileNumber}]"));
    }
}
