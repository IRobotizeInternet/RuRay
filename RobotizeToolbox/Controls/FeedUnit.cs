using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.Extensions;
using System;
using System.Threading;

namespace RobotizeToolbox.CommonControls
{
    public class FeedUnit : BaseDOMProperty
    {
        public int RowCount => Driver.FindElements(By.XPath($"{BaseXPath}//div[contains(@data-pagelet,'FeedUnit')]")).Count;
        public string BaseXPath { get; set; }
        public FeedUnit(RemoteWebDriver driver, 
            By byForElement,
            string baseXPath) : base(driver, byForElement)
        {
            BaseXPath = baseXPath;
        }

        /// <summary>
        /// Scroll to the last feed.
        /// </summary>
        public void StartScrollingToDown(ScrollPosition scrollPosition, int scrollingDelay = 10000)
        {
            switch (scrollPosition)
            {
                case ScrollPosition.Down:
                    while (true)
                    {
                        var rowCountBeforeScroll = RowCount;
                        ScrollFeedUnit(rowCountBeforeScroll);
                        var rowCountAfterScroll = RowCount;
                        if (rowCountBeforeScroll == rowCountAfterScroll) break;
                        Thread.Sleep(scrollingDelay);
                    }
                    Thread.Sleep(3000);
                    break;
                case ScrollPosition.Up:
                    break;
                default:
                    throw new ArgumentException($"Scroll direction{scrollPosition} is not supported");
            }
        }

        /// <summary>
        /// Scroll up for a given position in set
        /// </summary>
        public void ScrollFeedUnit(int positionInSet)
        {
            ScrollToElement();
            Driver.FindElementWithTimeSpan(By.XPath(GetRowXPath(positionInSet)));
        }

        private string GetRowXPath(int positionInSet)
        {
            return $"{BaseXPath}//div[@aria-posinset='{positionInSet}']";
        }

    }
}
