using System;
using OpenQA.Selenium.Remote;

namespace RuRayLibrary.Components.Eidtor
{
    /// <summary>
    /// Defines the <see cref="Editor{THeader, ULeftMenu, VFeed}" />.
    /// </summary>
    /// <typeparam name="THeader">.</typeparam>
    /// <typeparam name="ULeftMenu">.</typeparam>
    /// <typeparam name="VFeed">.</typeparam>
    public class Editor<THeader, ULeftMenu, VFeed>
        where THeader : class, IHeaderNavigation
        where ULeftMenu : class, ILeftNavigation
        where VFeed : class, IFeedContainer
    {
        /// <summary>
        /// Defines the _pageHeader.
        /// </summary>
        private readonly Lazy<THeader> _pageHeader;

        /// <summary>
        /// Defines the _leftMenu.
        /// </summary>
        private readonly Lazy<ULeftMenu> _leftMenu;

        /// <summary>
        /// Defines the _feedContainer.
        /// </summary>
        private readonly Lazy<VFeed> _feedContainer;

        /// <summary>
        /// Initializes a new instance of the <see cref="Editor{THeader, ULeftMenu, VFeed}"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public Editor(RemoteWebDriver driver)
        {
            _pageHeader = InitiateLazyInstance<THeader>(driver);
            _leftMenu = InitiateLazyInstance<ULeftMenu>(driver);
            _feedContainer = InitiateLazyInstance<VFeed>(driver);
        }

        /// <summary>
        /// Gets the PageHeader
        /// Page header..
        /// </summary>
        public THeader PageHeader => _pageHeader.Value;

        /// <summary>
        /// Gets the LeftMenu
        /// Left menu of the page..
        /// </summary>
        public ULeftMenu LeftMenu => _leftMenu.Value;

        /// <summary>
        /// Gets the FeedContainer
        /// Feed container of the page..
        /// </summary>
        public VFeed FeedContainer => _feedContainer.Value;

        /// <summary>
        /// The InitiateLazyInstance.
        /// </summary>
        /// <typeparam name="T">.</typeparam>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <returns>The <see cref="Lazy{T}"/>.</returns>
        private static Lazy<T> InitiateLazyInstance<T>(RemoteWebDriver driver)
        {
            return new Lazy<T>(() => (T)Activator.CreateInstance(typeof(T), driver));
        }
    }
}
