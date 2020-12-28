using OpenQA.Selenium;
using RobotizeLibrary.CommonControls;
using RobotizeFacebook.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Pages.LoggedIn.Settings.Tabs.Seperator1
{
    public class DialogChangePassword : BaseEditor
    {
        public TextBox TextBoxCurrent => new TextBox(Driver, By.XPath("//input[@id='password_old']"));
        public TextBox TextBoxNew => new TextBox(Driver, By.XPath("//input[@id='password_new']"));
        public TextBox TextBoxReTypeNew => new TextBox(Driver, By.XPath("//input[@id='password_confirm']"));
        //public Hyperlink<> LinkForgotYourPassword => new Hyperlink<EventResult>(Driver, Wait, By.XPath($"//a[text()='{ResMiscellaneous.ForgotYourPassword}']"));
        public Button ButtonSaveChanges => new Button(Driver, By.XPath($"//div[@id='password']//input[@value={ResMiscellaneous.SaveChanges}]"));
        public Button ButtonClose => new Button(Driver, By.XPath($"//button[text()={ResMiscellaneous.Close}]"));
    }
}
