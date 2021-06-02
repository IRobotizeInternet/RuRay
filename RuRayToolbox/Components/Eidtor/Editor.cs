using System;
using OpenQA.Selenium.Remote;

namespace RuRayLibrary.Components.Eidtor
{
    public class Editor<THeader, ULeftMenu, VFeed>
        where THeader : class, IHeaderNavigation
        where ULeftMenu : class, ILeftNavigation
        where VFeed : class, IFeedContainer
    {
        private readonly Lazy<THeader> _pageHeader;
        private readonly Lazy<ULeftMenu> _leftMenu;
        private readonly Lazy<VFeed> _feedContainer;

        public Editor(RemoteWebDriver driver)
        {
            _pageHeader = InitiateLazyInstance<THeader>(driver);
            _leftMenu = InitiateLazyInstance<ULeftMenu>(driver);
            _feedContainer = InitiateLazyInstance<VFeed>(driver);
        }

        /// <summary>
        /// Page header.
        /// </summary>
        public THeader PageHeader => _pageHeader.Value;

        /// <summary>
        /// Left menu of the page.
        /// </summary>
        public ULeftMenu LeftMenu => _leftMenu.Value;

        /// <summary>
        /// Feed container of the page.
        /// </summary>
        public VFeed FeedContainer => _feedContainer.Value;

        private static Lazy<T> InitiateLazyInstance<T>(RemoteWebDriver driver)
        {
            return new Lazy<T>(() => (T)Activator.CreateInstance(typeof(T), driver));
        }
    }
}
