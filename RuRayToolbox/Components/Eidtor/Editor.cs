using OpenQA.Selenium.Remote;
using System;

namespace RuRayLibrary.Components.Eidtor
{
    public class Editor<THeader, ULeftMenu, VFeed, WPage>
        where THeader : IHeaderNavigation
        where ULeftMenu : ILeftNavigation
        where VFeed : IFeedContainer
        where WPage : IPage
    {
        private readonly Lazy<THeader> _pageHeader;
        private readonly Lazy<ULeftMenu> _leftMenu;
        private readonly Lazy<VFeed> _feedContainer;
        private readonly Lazy<WPage> _page;

        public Editor(RemoteWebDriver driver)
        {
            _pageHeader = InitiateLazyInstance<THeader>(driver);
            _leftMenu = InitiateLazyInstance<ULeftMenu>(driver);
            _feedContainer = InitiateLazyInstance<VFeed>(driver);
            _page = InitiateLazyInstance<WPage>(driver);
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

        /// <summary>
        /// Page.
        /// </summary>
        public WPage Page => _page.Value;

        private static Lazy<T> InitiateLazyInstance<T>(RemoteWebDriver driver)
        {
            return new Lazy<T>(() => (T)Activator.CreateInstance(typeof(T), driver));
        }
    }
}
