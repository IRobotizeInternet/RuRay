using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;

namespace RobotizeLibrary.Components.Eidtor
{
    public class Editor<THeader, ULeftMenu>
        where THeader : IHeaderNavigation
        where ULeftMenu : ILeftNavigation
    {
        private Lazy<THeader> _pageHeader;
        private Lazy<ULeftMenu> _leftMenu;

        public Editor(RemoteWebDriver driver, WebDriverWait wait)
        {
            _pageHeader = InitiateLazyInstance<THeader>(driver, wait);
            _leftMenu = InitiateLazyInstance<ULeftMenu>(driver, wait);
        }

        /// <summary>
        /// Page header.
        /// </summary>
        public THeader PageHeader => _pageHeader.Value;

        /// <summary>
        /// Left menu of the page.
        /// </summary>
        public ULeftMenu LeftMenu => _leftMenu.Value;

        private static Lazy<T> InitiateLazyInstance<T>(RemoteWebDriver driver, WebDriverWait wait)
        {
            return new Lazy<T>(() => (T)Activator.CreateInstance(typeof(T), driver, wait));
        }
    }
}
