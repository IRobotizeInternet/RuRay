using System.Collections.Generic;
using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogMoreBackgroundOptions" />.
    /// </summary>
    public class DialogMoreBackgroundOptions : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogMoreBackgroundOptions"/> class.
        /// </summary>
        public DialogMoreBackgroundOptions()
        {
            var list = new List<List<string>>();
            var webElements = Driver.FindElements(By.XPath("//div[@class='oh7imozk idiwt2bm'][1]//div[contains(@aria-label,'background')]"));
            var list1 = new List<string>();
            foreach (var webElement in webElements)
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

        /// <summary>
        /// Defines the Basepath.
        /// </summary>
        private readonly string Basepath = $"//span[text()='{ResPostBackGroundColor.ChooseBackground}']";

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath(Basepath);

        // TODO: Add Popular, New and More background colors to the enums.
        /// <summary>
        /// The GetPopularBackground.
        /// </summary>
        /// <param name="background">The background<see cref="PostBackgroundcolor"/>.</param>
        /// <returns>The <see cref="Button"/>.</returns>
        public Button GetPopularBackground(PostBackgroundcolor background) => new Button(Driver, By.XPath($"{Basepath}//div[@aria-label='{background}']"));

        /// <summary>
        /// The GetNewBackground.
        /// </summary>
        /// <param name="background">The background<see cref="PostBackgroundcolor"/>.</param>
        /// <returns>The <see cref="Button"/>.</returns>
        public Button GetNewBackground(PostBackgroundcolor background) => new Button(Driver, By.XPath($"{Basepath}//div[@aria-label='{background}']"));

        /// <summary>
        /// The GetMoreBackground.
        /// </summary>
        /// <param name="background">The background<see cref="PostBackgroundcolor"/>.</param>
        /// <returns>The <see cref="Button"/>.</returns>
        public Button GetMoreBackground(PostBackgroundcolor background) => new Button(Driver, By.XPath($"{Basepath}//div[@aria-label='{background}']"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
