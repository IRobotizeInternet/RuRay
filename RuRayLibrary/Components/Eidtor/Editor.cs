using OpenQA.Selenium.Remote;
using System;

namespace RuRayLibrary.Components.Eidtor
{
    public class Editor<THeader, ULeftMenu>
        where THeader : IHeaderNavigation
        where ULeftMenu : ILeftNavigation
    {
        private readonly Lazy<THeader> _pageHeader;
        private readonly Lazy<ULeftMenu> _leftMenu;

        public Editor(RemoteWebDriver driver)
        {
            _pageHeader = InitiateLazyInstance<THeader>(driver);
            _leftMenu = InitiateLazyInstance<ULeftMenu>(driver);
        }

        /// <summary>
        /// Page header.
        /// </summary>
        public THeader PageHeader => _pageHeader.Value;

        /// <summary>
        /// Left menu of the page.
        /// </summary>
        public ULeftMenu LeftMenu => _leftMenu.Value;

        private static Lazy<T> InitiateLazyInstance<T>(RemoteWebDriver driver)
        {
            return new Lazy<T>(() => (T)Activator.CreateInstance(typeof(T), driver));
        }
    }
}
