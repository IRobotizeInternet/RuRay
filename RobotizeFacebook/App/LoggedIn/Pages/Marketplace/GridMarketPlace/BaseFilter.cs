using OpenQA.Selenium.Remote;


namespace RobotizeFacebook.App.LoggedIn
{
    public abstract class BaseFilter : IApplyFilter
    {
        protected readonly RemoteWebDriver Driver;
       
        public BaseFilter(RemoteWebDriver driver)
        {
            Driver = driver;
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
