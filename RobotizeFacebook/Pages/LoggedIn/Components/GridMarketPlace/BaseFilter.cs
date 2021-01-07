using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace RobotizeFacebook.Pages.LoggedIn
{
    public abstract class BaseFilter : IApplyFilter
    {
        protected readonly RemoteWebDriver Driver;
        protected readonly WebDriverWait Wait;
       
        public BaseFilter(RemoteWebDriver driver, WebDriverWait wait)
        {
            Driver = driver;
            Wait = wait;
        }

        public virtual void ApplyFilter()
        {
            //Actions.WaitForBusyIndicatorsToDisappearRepeatedly(Driver);
            //WaitUntilFilterPopupIsNotDisplayed();
        }

        protected abstract void SetFilterCriteria();
        protected abstract void ClickFilterButton();

        public void ClearFilter()
        {
        }
    }
}
