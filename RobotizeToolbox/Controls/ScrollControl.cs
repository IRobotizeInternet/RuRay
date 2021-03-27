using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.Components;
using RobotizeToolbox.Extensions;

namespace RobotizeToolbox.CommonControls
{
    public class ScrollControl<TListItem> : BaseDOMObject 
        where TListItem : IListItem
    {
        // div[@ data-pagelet="MainFeed"]/div/div/div/div 
        // Feed Row Path --         //div[contains(@data-pagelet,'feed')]
        // Marketplace categories --//div[contains(@data-pagelet,'BrowseFeedUpsell')]
        // Group feed --            //div[contains(@data-pagelet,"GroupsFeed")]
        //      Activity Log --          //div[@data-pagelet="page"]//*[name()='svg']
        // Friends Row Path --      //div[@role="gridcell"]
        // Discover events --       //div[@role="main"]//article
        // Watch feed --            //div[@role='main' ]//video
        // Watch shows --           //div[@role='main']//a[contains(@href,'/watch/')]/img
        // Play Games --            //div[@role="main"]//img
        // Game Video Browse --     //div[@role="main"]//img
        // Choose GIF --            //input/parent::label/parent::div/parent::div/parent::div//img
        // Add Videos --            //input/parent::label/parent::div/parent::div//img
        public int CurrentRowIndex { get; set; }
        public int RowCount => Driver.FindElements(By.XPath($"{BaseXPath}")).Count;//div[contains(@data-pagelet,'Feed')]")).Count;
        public string GetRowXPath(int positionInSet) => $"{BaseXPath}{string.Format(PositionXPath, positionInSet)}";
        public string BaseXPath { get; set; }
        public string PositionXPath { get; set; }
        public TListItem ListITems { get; set; }

        public ScrollControl(RemoteWebDriver driver,
            string baseXPath = null,
            string positionXPath = null,
            int currentRowIndex = 1) : base(driver, By.XPath(baseXPath))
        {
            BaseXPath = baseXPath;
            PositionXPath = positionXPath;
            CurrentRowIndex = currentRowIndex;
        }

        /// <summary>
        /// Scroll to the last row.
        /// </summary>
        public void ScrollingDownWithAGivenInterval(
            int numberOfUnitToScroll = 3,
            bool scrollFromCurrentLocation = false, 
            int scrollingDelay = 3000)
        {
            if (scrollFromCurrentLocation) SetIndexOfElementInViewPort();
            var counter = 0;
            while (true)
            {
                var rowCountBeforeScroll = RowCount;
                ScrollFeedUnit(CurrentRowIndex++, true);
                var rowCountAfterScroll = RowCount;
                if (CurrentRowIndex >= RowCount && rowCountBeforeScroll == rowCountAfterScroll) break;
                Thread.Sleep(scrollingDelay);
                if (counter++ > numberOfUnitToScroll) break;
            }
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Scroll to the first row.
        /// </summary>
        public void ScrollingUpWithAGivenInterval(
            int numberOfUnitToScroll = 3,
            bool scrollFromCurrentLocation = false, 
            int scrollingDelay = 3000)
        {
            if (scrollFromCurrentLocation) SetIndexOfElementInViewPort();
            var counter = 0;
            while (true)
            {
                if (CurrentRowIndex <= 0) break;
                ScrollFeedUnit(CurrentRowIndex--, false);
                Thread.Sleep(scrollingDelay);
                if (counter++ > numberOfUnitToScroll) break;
            }
            Thread.Sleep(3000);
        }

        /// <summary>
        /// Scroll to left.
        /// </summary>
        public void ScrollingLeft(int scrollingDelay = 3000)
        {
        }

        /// <summary>
        /// Scroll to rigth.
        /// </summary>
        public void ScrollingRight(int scrollingDelay = 3000)
        {
           
        }

        /// <summary>
        /// Scroll up for a given position in set
        /// </summary>
        public void ScrollFeedUnit(int positionInSet, bool scrollUp = true)
        {
            ScrollToElement(Driver.FindElementWithTimeSpan(By.XPath(GetRowXPath(positionInSet))), scrollUp);
            Driver.FindElementWithTimeSpan(By.XPath(GetRowXPath(positionInSet)));
        }

        /// <summary>
        /// Scroll up for a given header text
        /// </summary>
        public void ScrollFeedUnit(string headerText)
        {
        }

        private void SetIndexOfElementInViewPort()
        {
            var elementsCount = Driver.FindElements(By.XPath(BaseXPath)).Count;
            var index = 1;
            for (; index < elementsCount; index++)
            {
                // If element not in visible view port continue searching.
                if(!JscriptExecutor.IsElementOutViewport_1(Driver, GetRowXPath(index))) continue;
                CurrentRowIndex = index;
                return;
            }
        }
    }
}
