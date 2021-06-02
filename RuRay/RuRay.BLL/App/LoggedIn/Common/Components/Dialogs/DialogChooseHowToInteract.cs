using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using RuRay.BLL.Resources;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogChooseHowToInteract" />.
    /// </summary>
    public class DialogChooseHowToInteract : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogChooseHowToInteract"/> class.
        /// </summary>
        public DialogChooseHowToInteract()
        {
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@role='menuitem']//strong[text()='{ResHomePage.ChooseHowToInteract}']");

        /// <summary>
        /// Gets the AllAvailableOptiosOfHowToInteract.
        /// </summary>
        public List<IWebElement> AllAvailableOptiosOfHowToInteract => Driver.FindElements(By.XPath($"//div[@role='menuitem']//strong[text()='{ResHomePage.ChooseHowToInteract}']/parent::span/parent::div/parent::div/parent::div/parent::div/div[3]//span")).ToList();

        /// <summary>
        /// The SetHowToInteract.
        /// </summary>
        /// <param name="index">The index<see cref="int"/>.</param>
        public void SetHowToInteract(int index)
        {
            var options = AllAvailableOptiosOfHowToInteract;
            if (index > options.Count)
            {
                return;
            }

            AllAvailableOptiosOfHowToInteract[index].Click();
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
