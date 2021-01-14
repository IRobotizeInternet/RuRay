using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeFacebook.Pages.LoggedIn.Home.HomeHeader.Left
{
    public class HeaderLeft : Header
    {
        public SearchBoxSearchFacebook ComboboxFacebookSearch =>
            new SearchBoxSearchFacebook(Driver, By.XPath($"//input[@role='combobox'][@placeholder='{ResMiscellaneous.SearchFacebook}']/../../../../.."));


    }
}
