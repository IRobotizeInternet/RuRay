using OpenQA.Selenium;
using System.Collections.Generic;

namespace RobotizeToolbox.Controls
{
    internal interface IDropdownElement
    {
        void Select(string valueToSelect);
    }
}