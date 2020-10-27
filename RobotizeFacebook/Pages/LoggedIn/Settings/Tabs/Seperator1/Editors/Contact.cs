using OpenQA.Selenium;
using RobotizeLibrary.CommonControls;
using RobotizeLibrary.Controls;
using RobotizeLibrary.Controls.TriggerControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Pages.LoggedIn.Settings.Tabs.Seperator1
{
    public class Contact : BaseEditor
    {
        public Label LabelPrimaryEmail => new Label(Driver, By.XPath("(//div[@class='pbm fbSettingsEditorFields']//div/span)[2]"));
        public Checkbox CheckboxAllowFriendsToIncludeMyEmailAddressIn => new Checkbox(Driver, By.XPath("//input[@id='js_0']"));
        public Hyperlink<AddAnotherEmailDialog> LinkAddAnotherEmailOrMobile => new Hyperlink<AddAnotherEmailDialog>(Driver, Wait, By.XPath("//a[text()='+ Add another email or mobile number']"));
    }
}
