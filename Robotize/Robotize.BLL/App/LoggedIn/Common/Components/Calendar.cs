using System;
using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class Calendar : BaseDriver
    {
        private string BaseXPath = $"//div[@role='dialog'][@aria-label='{ResMiscellaneous.Calendar}']";

        public Calendar()
        {
        }

        /// <summary>
        /// This is a hack to avoid selecting incorrect date.
        /// We will check the class attribute to verify we are 
        /// selecting date of currently visible month. Since the
        /// the class name could be change we need to find it each 
        /// time we initialize the calendar. Here we are checking 
        /// mid month's date (15th) class .
        /// </summary>
        private string CurrentMonthClass =>
             new Label(Driver, By.XPath($"{BaseXPath}//div[@role='gridcell']//span[text()='15']")).GetAttribute("class");

        private string Date => $"{BaseXPath}//div[@class='{CurrentMonthClass}']//span[text()='{0}']";
        private string Month => 
            new Label(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResMiscellaneous.PreviousMonth}']/following-sibling::span/span")).GetText().Split(' ')[0];
        private string Year =>
            new Label(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResMiscellaneous.PreviousMonth}']/following-sibling::span/span")).GetText().Split(' ')[1];

        public Button ButtonPreviousMonth =>
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResMiscellaneous.PreviousMonth}']"));
        public Button ButtonNextMonth =>
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResMiscellaneous.NextMonth}']"));

        public TextBox TextBoxDate => new TextBox(Driver, By.XPath(""));

        public void SetDate(DateTime dateTime)
        {
            dateTime.ToString("MMM dd, yyyy");
        }

        public void SetDate(int year, int month, int date)
        {
            var createRoonDate = new DateTime(year, month, date);
        }

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
