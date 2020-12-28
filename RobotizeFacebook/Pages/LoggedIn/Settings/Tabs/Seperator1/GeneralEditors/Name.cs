using OpenQA.Selenium;
using RobotizeLibrary.CommonControls;
using RobotizeLibrary.Controls.TriggerControls;
using RobotizeFacebook.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Pages.LoggedIn.Settings.Tabs.Seperator1.Bas
{
    public class Name : BaseEditor
    {
        public TextBox TextBoxFirstName => new TextBox(Driver, By.XPath("//input[@id='u_i_2']"));
        public TextBox TextBoxMiddleName => new TextBox(Driver, By.XPath("//input[@id='u_i_3']"));
        public TextBox TextBoxLastName => new TextBox(Driver, By.XPath("//input[@id='u_i_4']"));
        //public Hyperlink<About> LinkAddOrChangeOtherNames => new Hyperlink<About>(Driver, Wait, By.XPath($"//a[(text()='{ResMiscellaneous.AddOrChangeOtherNames}')]"));
        public Button ButtonReviewChanges => new Button(Driver, By.XPath("//button[@id='u_2_0']"));
        public TextBox ButtonCancel => new TextBox(Driver, By.XPath("//button[@class='_42ft _42fu cancel']"));
    }
}
