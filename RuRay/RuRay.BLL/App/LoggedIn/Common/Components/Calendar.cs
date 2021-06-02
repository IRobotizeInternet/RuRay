using System;
using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="Calendar" />.
    /// </summary>
    public class Calendar : BaseDriver
    {
        /// <summary>
        /// Defines the BaseXPath.
        /// </summary>
        private readonly string BaseXPath = $"//div[@role='dialog'][@aria-label='{ResMiscellaneous.Calendar}']";

        /// <summary>
        /// Initializes a new instance of the <see cref="Calendar"/> class.
        /// </summary>
        public Calendar()
        {
        }

        /// <summary>
        /// Gets the CurrentMonthClass
        /// This is a hack to avoid selecting incorrect date.
        /// We will check the class attribute to verify we are 
        /// selecting date of currently visible month. Since the
        /// the class name could be change we need to find it each 
        /// time we initialize the calendar. Here we are checking 
        /// mid month's date (15th) class ..
        /// </summary>
        private string CurrentMonthClass =>
             new Label(Driver, By.XPath($"{BaseXPath}//div[@role='gridcell']//span[text()='15']")).GetAttribute("class");

        /// <summary>
        /// Gets the Date.
        /// </summary>
        private string Date => $"{BaseXPath}//div[@class='{CurrentMonthClass}']//span[text()='{0}']";

        /// <summary>
        /// Gets the Month.
        /// </summary>
        private string Month =>
            new Label(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResMiscellaneous.PreviousMonth}']/following-sibling::span/span")).GetText().Split(' ')[0];

        /// <summary>
        /// Gets the Year.
        /// </summary>
        private string Year =>
            new Label(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResMiscellaneous.PreviousMonth}']/following-sibling::span/span")).GetText().Split(' ')[1];

        /// <summary>
        /// Gets the ButtonPreviousMonth.
        /// </summary>
        public Button ButtonPreviousMonth =>
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResMiscellaneous.PreviousMonth}']"));

        /// <summary>
        /// Gets the ButtonNextMonth.
        /// </summary>
        public Button ButtonNextMonth =>
            new Button(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResMiscellaneous.NextMonth}']"));

        /// <summary>
        /// Gets the TextBoxDate.
        /// </summary>
        public TextBox TextBoxDate => new TextBox(Driver, By.XPath(""));

        /// <summary>
        /// The SetDate.
        /// </summary>
        /// <param name="dateTime">The dateTime<see cref="DateTime"/>.</param>
        public void SetDate(DateTime dateTime)
        {
            dateTime.ToString("MMM dd, yyyy");
        }

        /// <summary>
        /// The SetDate.
        /// </summary>
        /// <param name="year">The year<see cref="int"/>.</param>
        /// <param name="month">The month<see cref="int"/>.</param>
        /// <param name="date">The date<see cref="int"/>.</param>
        public void SetDate(int year, int month, int date)
        {
            var createRoonDate = new DateTime(year, month, date);
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
