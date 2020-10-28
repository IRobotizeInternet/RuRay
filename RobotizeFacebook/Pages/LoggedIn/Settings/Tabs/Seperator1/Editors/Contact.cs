using OpenQA.Selenium;
using RobotizeLibrary.CommonControls;
using RobotizeLibrary.Controls;
using RobotizeLibrary.Controls.TriggerControls;
using RobotizeLibrary.Resources;

namespace RobotizeFacebook.Pages.LoggedIn.Settings.Tabs.Seperator1
{
    public class Contact : BaseEditor
    {
        public Label LabelPrimaryEmail => new Label(Driver, By.XPath("(//div[@class='pbm fbSettingsEditorFields']//div/span)[2]"));
        public Checkbox CheckboxAllowFriendsToIncludeMyEmailAddressIn => new Checkbox(Driver, By.XPath("//input[@id='js_0']"));
        public Hyperlink<AddAnotherEmailDialog> LinkAddAnotherEmailOrMobile => 
            new Hyperlink<AddAnotherEmailDialog>(Driver, Wait, By.XPath($"//a[text()={ResMiscellaneous.AddAnotherEmailOrMobileNumber}]"));
    }
}
