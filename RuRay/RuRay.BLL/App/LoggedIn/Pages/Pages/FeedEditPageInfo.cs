using System;
using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="FeedEditPageInfo" />.
    /// </summary>
    public class FeedEditPageInfo : Feed
    {
        /// <summary>
        /// Gets the FeedUrl.
        /// </summary>
        public override string FeedUrl => throw new NotImplementedException();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedEditPageInfo"/> class.
        /// </summary>
        public FeedEditPageInfo()
        {
            BaseXPath = "//div[@role='main']";
        }

        /// <summary>
        /// Gets the TextboxName.
        /// </summary>
        public TextBox TextboxName => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.Name}']/parent::div/input"));

        /// <summary>
        /// Gets the TextboxUsername.
        /// </summary>
        public TextBox TextboxUsername => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.Username}']/parent::div/input"));

        /// <summary>
        /// Gets the TextboxDescription.
        /// </summary>
        public TextBox TextboxDescription => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.Description}']/parent::div/textarea"));

        /// <summary>
        /// Gets the ComboboxDescription.
        /// </summary>
        public ComboBoxCategories ComboboxDescription => new ComboBoxCategories(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.Categories}']/parent::div/input"));

        /// <summary>
        /// Gets the TextboxPhoneNumber.
        /// </summary>
        public TextBox TextboxPhoneNumber => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.PhoneNumber}']/parent::div/input"));

        /// <summary>
        /// Gets the ComboboxCountryCode.
        /// </summary>
        public ComboBoxCategories ComboboxCountryCode => new ComboBoxCategories(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.Categories}']/parent::div/input"));

        /// <summary>
        /// Gets the RadioButtonPageDoesntHaveAPhoneNumber.
        /// </summary>
        public RadioButton RadioButtonPageDoesntHaveAPhoneNumber => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.MyPageDoesntHaveAPhoneNumber}')]/parent::div//input"));

        /// <summary>
        /// Gets the TextboxEmail.
        /// </summary>
        public TextBox TextboxEmail => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.Email}']/parent::div/input"));

        /// <summary>
        /// Gets the RadioButtonMyPageDoesntHaveAnEmail.
        /// </summary>
        public RadioButton RadioButtonMyPageDoesntHaveAnEmail => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.MyPageDoesntHaveAnEmail}')]/parent::div//input"));

        /// <summary>
        /// Gets the TextboxWebsite.
        /// </summary>
        public TextBox TextboxWebsite => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.Website}']/parent::div/input"));

        /// <summary>
        /// Gets the RadioButtonWebsite.
        /// </summary>
        public RadioButton RadioButtonWebsite => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.MyPageDoesntHaveAWebsite}')]/parent::div//input"));

        /// <summary>
        /// Gets the TextboxAddress.
        /// </summary>
        public TextBox TextboxAddress => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.Address}']/parent::div/input"));

        /// <summary>
        /// Gets the TextboxZipCode.
        /// </summary>
        public TextBox TextboxZipCode => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.ZIPCode}']/parent::div/input"));

        /// <summary>
        /// Gets the ComboboxCity.
        /// </summary>
        public ComboBoxCategories ComboboxCity => new ComboBoxCategories(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.City}']/parent::div/input"));

        /// <summary>
        /// Gets the RadioButtonMyPageDoesntHaveALocation.
        /// </summary>
        public RadioButton RadioButtonMyPageDoesntHaveALocation => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.MyPageDoesntHaveALocation}')]/parent::div//input"));

        /// <summary>
        /// Gets the CheckboxCustomersVisitMyBusinessAtSyStreetAddress.
        /// </summary>
        public Checkbox CheckboxCustomersVisitMyBusinessAtSyStreetAddress => new Checkbox(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.CustomersVisitMyBusinessAtSyStreetAddress}')]/parent::div//input"));

        /// <summary>
        /// Gets the ComboboxServiceArea.
        /// </summary>
        public ComboBoxCategories ComboboxServiceArea => new ComboBoxCategories(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.ServiceArea}']/parent::div/input"));

        /// <summary>
        /// Gets the RadioButtonNoHoursAvailable.
        /// </summary>
        public RadioButton RadioButtonNoHoursAvailable => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.NoHoursAvailable}')]/parent::div//input"));

        /// <summary>
        /// Gets the RadioButtonAlwaysOpen.
        /// </summary>
        public RadioButton RadioButtonAlwaysOpen => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.AlwaysOpen}')]/parent::div//input"));

        /// <summary>
        /// Gets the RadioButtonPermanentlyClosed.
        /// </summary>
        public RadioButton RadioButtonPermanentlyClosed => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.PermanentlyClosed}')]/parent::div//input"));

        /// <summary>
        /// Gets the RadioButtonOpenOnSelectedHours.
        /// </summary>
        public RadioButton RadioButtonOpenOnSelectedHours => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.OpenOnSelectedHours}')]/parent::div//input"));

        /// <summary>
        /// Gets the RadioButtonOpenWithServiceChanges.
        /// </summary>
        public RadioButton RadioButtonOpenWithServiceChanges => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.OpenWithServiceChanges}')]/parent::div//input"));

        /// <summary>
        /// Gets the RadioButtonTemporarilyClosed.
        /// </summary>
        public RadioButton RadioButtonTemporarilyClosed => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.TemporarilyClosed}')]/parent::div//input"));

        /// <summary>
        /// Gets the RadioButtonOperatingAsUsual.
        /// </summary>
        public RadioButton RadioButtonOperatingAsUsual => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.OperatingAsUsual}')]/parent::div//input"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
