using OpenQA.Selenium;
using System.Collections.Generic;

namespace RobotizeToolbox.Controls
{
    internal interface IDropdownElement
    {
        bool Select(string valueToSelect, out IEnumerable<IWebElement> friends);
    }
}