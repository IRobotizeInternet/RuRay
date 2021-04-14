using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using System.Collections.Generic;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogMoreBackgroundOptions : BaseDialog
    {
        public DialogMoreBackgroundOptions()
        {
            var list = new List<List<string>>();
            var webElements = Driver.FindElements(By.XPath("//div[@class='oh7imozk idiwt2bm'][1]//div[contains(@aria-label,'background')]"));
            var list1 = new List<string>();
            foreach(var webElement in webElements)
            {
                list1.Add(webElement.GetAttribute("aria-label"));
            }
            var list2 = new List<string>();
            var webElements2 = Driver.FindElements(By.XPath("//div[@class='oh7imozk idiwt2bm'][2]//div[contains(@aria-label,'background')]"));
            foreach (var webElement in webElements2)
            {
                list2.Add(webElement.GetAttribute("aria-label"));
            }
            var list3 = new List<string>();
            var webElements3 = Driver.FindElements(By.XPath("//div[@class='oh7imozk idiwt2bm'][3]//div[contains(@aria-label,'background')]"));
            foreach (var webElement in webElements3)
            {
                list3.Add(webElement.GetAttribute("aria-label"));
            }
        }

        private readonly string Basepath = $"//span[text()='{ResPostBackGroundColor.ChooseBackground}']";
        protected override By ByForDialog => By.XPath(Basepath);


        // TODO: Add Popular, New and More background colors to the enums.
        public Button GetPopularBackground(PostBackgroundcolor background) => new Button(Driver, By.XPath($"{Basepath}//div[@aria-label='{background}']"));
        public Button GetNewBackground(PostBackgroundcolor background) => new Button(Driver, By.XPath($"{Basepath}//div[@aria-label='{background}']"));
        public Button GetMoreBackground(PostBackgroundcolor background) => new Button(Driver, By.XPath($"{Basepath}//div[@aria-label='{background}']"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
