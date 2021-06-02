using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls.TriggerControls;

namespace RuRayFacebook.App.LoggedIn.Pages.SecurityEditors
{
    /// <summary>
    /// Defines the <see cref="WhereYouAreLoggedIn" />.
    /// </summary>
    public class WhereYouAreLoggedIn : BaseEditor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WhereYouAreLoggedIn"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public WhereYouAreLoggedIn(RemoteWebDriver driver) : base()
        {
        }

        /// <summary>
        /// Gets the LinkSeeMore.
        /// </summary>
        public Hyperlink<DialogSeeMore> LinkSeeMore => new Hyperlink<DialogSeeMore>(Driver, By.XPath($"//span[text()={ResMiscellaneous.SeeMore}]"));

        /// <summary>
        /// Gets the LabelLogOutOfAllSessions.
        /// </summary>
        public Label LabelLogOutOfAllSessions => new Label(Driver, By.XPath($"//span[text()={ResMiscellaneous.LogOutOfAllSessions}]"));
    }

    /// <summary>
    /// Defines the <see cref="DialogSeeMore" />.
    /// </summary>
    public class DialogSeeMore : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogSeeMore"/> class.
        /// </summary>
        public DialogSeeMore()
        {
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => throw new NotImplementedException();

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
