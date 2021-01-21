using OpenQA.Selenium.Remote;
using System;

namespace RobotizeLibrary.Components.Eidtor
{
    public class Editor<THeader, ULeftMenu, VFeedContainer>
        where THeader : IHeaderNavigation
        where ULeftMenu : ILeftNavigation
        where VFeedContainer : IFeedContainer

    {
        private readonly Lazy<THeader> _pageHeader;
        private readonly Lazy<ULeftMenu> _leftMenu;
        private readonly Lazy<VFeedContainer> _feedContainer;

        public Editor(RemoteWebDriver driver)
        {
            _pageHeader = InitiateLazyInstance<THeader>(driver);
            _leftMenu = InitiateLazyInstance<ULeftMenu>(driver);
            _feedContainer = InitiateLazyInstance<VFeedContainer>(driver);
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
        public VFeedContainer FeedContainer => _feedContainer.Value;

        private static Lazy<T> InitiateLazyInstance<T>(RemoteWebDriver driver)
        {
            return new Lazy<T>(() => (T)Activator.CreateInstance(typeof(T), driver));
        }
    }
}
