using OpenQA.Selenium.Remote;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="BaseFilter" />.
    /// </summary>
    public abstract class BaseFilter : IApplyFilter
    {
        /// <summary>
        /// Defines the Driver.
        /// </summary>
        protected readonly RemoteWebDriver Driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseFilter"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public BaseFilter(RemoteWebDriver driver)
        {
            Driver = driver;
        }

        /// <summary>
        /// The ApplyFilter.
        /// </summary>
        public virtual void ApplyFilter()
        {
        }

        /// <summary>
        /// The SetFilterCriteria.
        /// </summary>
        protected abstract void SetFilterCriteria();

        /// <summary>
        /// The ClickFilterButton.
        /// </summary>
        protected abstract void ClickFilterButton();

        /// <summary>
        /// The ClearFilter.
        /// </summary>
        public void ClearFilter()
        {
        }
    }
}
