using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RobotizeToolbox.Extensions;

namespace RobotizeToolbox.CommonControls
{
    public class BaseScroll : BaseDOMObject
    {
        public virtual int RowCount { get; }
        public int CurrentRowIndex { get; set; }

        public BaseScroll(RemoteWebDriver driver, 
            By byForElement) : base(driver, byForElement)
        {
            
        }

        /// <summary>
        /// Scroll to the last row.
        /// </summary>
        public void StartScrollingToDown(ScrollDirection scrollDirection, int scrollingDelay = 10000)
        {
            switch (scrollDirection)
            {
                case ScrollDirection.Down:
                    while (true)
                    {
                        var rowCountBeforeScroll = RowCount;
                        ScrollFeedUnit(CurrentRowIndex++);
                        var rowCountAfterScroll = RowCount;
                        if (CurrentRowIndex >= RowCount && rowCountBeforeScroll == rowCountAfterScroll) break;
                        Thread.Sleep(scrollingDelay);
                    }
                    Thread.Sleep(3000);
                    break;
                case ScrollDirection.Up:
                    break;
                default:
                    throw new ArgumentException($"Scroll direction {scrollDirection} is not supported");
            }
        }

        /// <summary>
        /// Scroll up for a given position in set
        /// </summary>
        public void ScrollFeedUnit(int positionInSet)
        {
            ScrollToElement(Driver.FindElementWithTimeSpan(By.XPath(GetRowXPath(positionInSet))));
            Driver.FindElementWithTimeSpan(By.XPath(GetRowXPath(positionInSet)));
        }

        public virtual string GetRowXPath(int positionInSet) => string.Empty;
    }
}
