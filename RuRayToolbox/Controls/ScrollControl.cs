using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRayToolbox.Components;
using RuRayToolbox.Extensions;

namespace RuRayToolbox.CommonControls
{
    /// <summary>
    /// Defines the <see cref="ScrollControl{TListItem}" />.
    /// </summary>
    /// <typeparam name="TListItem">.</typeparam>
    public class ScrollControl<TListItem> : BaseDOMObject
        where TListItem : IListItem
    {
        /// <summary>
        /// Gets or sets the CurrentRowIndex.
        /// </summary>
        public static int CurrentRowIndex { get; set; }

        /// <summary>
        /// Gets the RowCount.
        /// </summary>
        public int RowCount => Driver.FindElements(By.XPath($"{BaseXPath}")).Count;//div[contains(@data-pagelet,'Feed')]")).Count;

        /// <summary>
        /// Gets or sets the ScrollXPath.
        /// </summary>
        public string ScrollXPath { get; set; }

        /// <summary>
        /// The GetRowXPath.
        /// </summary>
        /// <param name="positionInSet">The positionInSet<see cref="int"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public string GetRowXPath(int positionInSet)
        {
            return PositionXPath == null
                ? $"{BaseXPath}[{positionInSet}]"
                : $"{BaseXPath}{string.Format(PositionXPath, positionInSet)}";
        }

        /// <summary>
        /// Gets or sets the BaseXPath.
        /// </summary>
        public string BaseXPath { get; set; }

        /// <summary>
        /// Gets or sets the PositionXPath.
        /// </summary>
        public string PositionXPath { get; set; }

        /// <summary>
        /// Defines the _listItem.
        /// </summary>
        private TListItem _listItem;

        /// <summary>
        /// Gets the ListITem.
        /// </summary>
        public TListItem ListITem
        {
            get
            {
                if (_listItem == null)
                {
                    _listItem = (TListItem)Activator.CreateInstance(typeof(TListItem), BaseXPath, CurrentRowIndex == 0 ? 1 : CurrentRowIndex);
                }

                return _listItem;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrollControl{TListItem}"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        /// <param name="baseXPath">The baseXPath<see cref="string"/>.</param>
        /// <param name="positionXPath">The positionXPath<see cref="string"/>.</param>
        /// <param name="currentRowIndex">The currentRowIndex<see cref="int"/>.</param>
        /// <param name="scrollXPath">The scrollXPath<see cref="string"/>.</param>
        public ScrollControl(RemoteWebDriver driver,
            string baseXPath = null,
            string positionXPath = null,
            int currentRowIndex = 1,
            string scrollXPath = null) : base(driver, By.XPath(baseXPath))
        {
            BaseXPath = baseXPath;
            PositionXPath = positionXPath;
            CurrentRowIndex = currentRowIndex;
            ScrollXPath = scrollXPath;
        }

        /// <summary>
        /// Scroll to the last row.
        /// </summary>
        /// <param name="numberOfUnitToScroll">The numberOfUnitToScroll<see cref="int"/>.</param>
        /// <param name="scrollFromCurrentLocation">The scrollFromCurrentLocation<see cref="bool"/>.</param>
        /// <param name="scrollingDelay">The scrollingDelay<see cref="int"/>.</param>
        public void ScrollingDownWithAGivenInterval(
            int numberOfUnitToScroll = 3,
            bool scrollFromCurrentLocation = true,
            int scrollingDelay = 3000)
        {
            if (scrollFromCurrentLocation)
            {
                SetIndexOfElementInViewPort();
            }

            var counter = 0;
            while (true)
            {
                var rowCountBeforeScroll = RowCount;
                ScrollItem(CurrentRowIndex++, true);
                var rowCountAfterScroll = RowCount;
                if (CurrentRowIndex >= RowCount && rowCountBeforeScroll == rowCountAfterScroll)
                {
                    break;
                }

                Thread.Sleep(scrollingDelay);
                if (++counter >= numberOfUnitToScroll)
                {
                    break;
                }
            }
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Scroll to the first row.
        /// </summary>
        /// <param name="numberOfUnitToScroll">The numberOfUnitToScroll<see cref="int"/>.</param>
        /// <param name="scrollFromCurrentLocation">The scrollFromCurrentLocation<see cref="bool"/>.</param>
        /// <param name="scrollingDelay">The scrollingDelay<see cref="int"/>.</param>
        public void ScrollingUpWithAGivenInterval(
            int numberOfUnitToScroll = 3,
            bool scrollFromCurrentLocation = true,
            int scrollingDelay = 3000)
        {
            if (scrollFromCurrentLocation)
            {
                SetIndexOfElementInViewPort();
            }

            var counter = 0;
            while (true)
            {
                if (CurrentRowIndex <= 0)
                {
                    break;
                }

                ScrollItem(CurrentRowIndex, false);
                Thread.Sleep(scrollingDelay);
                if (++counter >= numberOfUnitToScroll)
                {
                    break;
                }

                CurrentRowIndex--;
            }
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Scroll to left.
        /// </summary>
        /// <param name="scrollingDelay">The scrollingDelay<see cref="int"/>.</param>
        public void ScrollingLeft(int scrollingDelay = 3000)
        {
        }

        /// <summary>
        /// Scroll to rigth.
        /// </summary>
        /// <param name="scrollingDelay">The scrollingDelay<see cref="int"/>.</param>
        public void ScrollingRight(int scrollingDelay = 3000)
        {
        }

        /// <summary>
        /// Scroll up for a given position in set.
        /// </summary>
        /// <param name="positionInSet">The positionInSet<see cref="int"/>.</param>
        /// <param name="scrollUp">The scrollUp<see cref="bool"/>.</param>
        public void ScrollItem(int positionInSet, bool scrollUp = true)
        {
            ScrollToElement(GetRowXPath(positionInSet), scrollUp);
            Driver.FindElementWithTimeSpan(By.XPath(GetRowXPath(positionInSet)));
        }

        /// <summary>
        /// The ScrollUpMore.
        /// </summary>
        /// <param name="scrollingLengthXAxis">The scrollingLengthXAxis<see cref="double"/>.</param>
        /// <param name="scrollingLengthYAxis">The scrollingLengthYAxis<see cref="double"/>.</param>
        public void ScrollUpMore(
             double scrollingLengthXAxis = 0,
            double scrollingLengthYAxis = 10)
        {
            ScrollMore(ScrollXPath, scrollingLengthXAxis, scrollingLengthYAxis, scrollDown: 1);
        }

        /// <summary>
        /// The ScrollDownMore.
        /// </summary>
        /// <param name="scrollingLengthXAxis">The scrollingLengthXAxis<see cref="double"/>.</param>
        /// <param name="scrollingLengthYAxis">The scrollingLengthYAxis<see cref="double"/>.</param>
        public void ScrollDownMore(
            double scrollingLengthXAxis = 0,
            double scrollingLengthYAxis = -10)
        {
            ScrollMore(ScrollXPath, scrollingLengthXAxis, scrollingLengthYAxis);
        }

        /// <summary>
        /// Scroll up for a given header text.
        /// </summary>
        /// <param name="headerText">The headerText<see cref="string"/>.</param>
        public void ScrollFeedUnit(string headerText)
        {
        }

        /// <summary>
        /// The SetIndexOfElementInViewPort.
        /// </summary>
        private void SetIndexOfElementInViewPort()
        {
            var elementsCount = Driver.FindElements(By.XPath(BaseXPath)).Count;
            var index = 1;
            for (; index < elementsCount; index++)
            {
                // If element not in visible view port continue searching.
                if (!JscriptExecutor.IsElementOutViewport(Driver, GetRowXPath(index)))
                {
                    continue;
                }

                CurrentRowIndex = index;
                return;
            }
        }
    }
}
