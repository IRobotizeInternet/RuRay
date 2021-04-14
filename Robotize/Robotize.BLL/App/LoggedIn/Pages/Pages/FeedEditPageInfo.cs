using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;
using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class FeedEditPageInfo : Feed
    {
        public override string FeedUrl => throw new NotImplementedException();
        
        public FeedEditPageInfo()
        {
            BaseXPath = "//div[@role='main']";
        }

        public TextBox TextboxName => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.Name}']/parent::div/input"));
        public TextBox TextboxUsername => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.Username}']/parent::div/input"));
        public TextBox TextboxDescription => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.Description}']/parent::div/textarea"));
        public ComboBoxCategories ComboboxDescription => new ComboBoxCategories(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.Categories}']/parent::div/input"));

        public TextBox TextboxPhoneNumber => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.PhoneNumber}']/parent::div/input"));
        public ComboBoxCategories ComboboxCountryCode => new ComboBoxCategories(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.Categories}']/parent::div/input"));
        public RadioButton RadioButtonPageDoesntHaveAPhoneNumber => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.MyPageDoesntHaveAPhoneNumber}')]/parent::div//input"));
        public TextBox TextboxEmail => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.Email}']/parent::div/input"));
        public RadioButton RadioButtonMyPageDoesntHaveAnEmail => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.MyPageDoesntHaveAnEmail}')]/parent::div//input"));
        public TextBox TextboxWebsite => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.Website}']/parent::div/input"));
        public RadioButton RadioButtonWebsite => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.MyPageDoesntHaveAWebsite}')]/parent::div//input"));

        public TextBox TextboxAddress => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.Address}']/parent::div/input"));
        public TextBox TextboxZipCode => new TextBox(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.ZIPCode}']/parent::div/input"));
        public ComboBoxCategories ComboboxCity => new ComboBoxCategories(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.City}']/parent::div/input"));

        public RadioButton RadioButtonMyPageDoesntHaveALocation => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.MyPageDoesntHaveALocation}')]/parent::div//input"));
        public Checkbox CheckboxCustomersVisitMyBusinessAtSyStreetAddress => new Checkbox(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.CustomersVisitMyBusinessAtSyStreetAddress}')]/parent::div//input"));

        public ComboBoxCategories ComboboxServiceArea => new ComboBoxCategories(Driver, By.XPath($"{BaseXPath}//span[text()='{ResPageSettings.ServiceArea}']/parent::div/input"));

        public RadioButton RadioButtonNoHoursAvailable => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.NoHoursAvailable}')]/parent::div//input"));
        public RadioButton RadioButtonAlwaysOpen => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.AlwaysOpen}')]/parent::div//input"));
        public RadioButton RadioButtonPermanentlyClosed => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.PermanentlyClosed}')]/parent::div//input"));
        public RadioButton RadioButtonOpenOnSelectedHours => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.OpenOnSelectedHours}')]/parent::div//input"));

        public RadioButton RadioButtonOpenWithServiceChanges => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.OpenWithServiceChanges}')]/parent::div//input"));
        public RadioButton RadioButtonTemporarilyClosed => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.TemporarilyClosed}')]/parent::div//input"));
        public RadioButton RadioButtonOperatingAsUsual => new RadioButton(Driver, By.XPath($"{BaseXPath}//div[contains(text(),'{ResPageSettings.OperatingAsUsual}')]/parent::div//input"));

        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
