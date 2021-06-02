using System;
using OpenQA.Selenium;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="FeedPageSettings" />.
    /// </summary>
    public class FeedPageSettings : Feed
    {
        /// <summary>
        /// Gets the FeedUrl.
        /// </summary>
        public override string FeedUrl => throw new NotImplementedException();

        /// <summary>
        /// Gets the RadioButtonGeneralSettings.
        /// </summary>
        public RadioButton RadioButtonGeneralSettings => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[text()='General Settings']/parent::div/parent::div//div[text()='Off']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
