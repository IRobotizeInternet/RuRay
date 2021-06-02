using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.CommonControls;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogNewRoomName" />.
    /// </summary>
    public class DialogNewRoomName : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogNewRoomName"/> class.
        /// </summary>
        public DialogNewRoomName()
        {
            //var a = "🌴";
            BaseXPath = $"//div[@role='dialog']//span[text()='{ResMiscellaneous.NewRoomName}']/parent::span/parent::h2/parent::div/following-sibling::div[3]";
        }

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@role='dialog']//span[text()='{ResMiscellaneous.NewRoomName}']");

        // TODO: Creating room with by name is not supported for now.
        //public Button ButtonChooseAnImageByName(EnumNewRoomName imageName)
        //{
        //    return new Button(Driver, By.XPath(imageName.GetDescription()));
        //}
        /// <summary>
        /// Gets the TextBoxRoomName.
        /// </summary>
        public TextBox TextBoxRoomName => new TextBox(Driver, By.XPath($"{BaseXPath}//input"));

        /// <summary>
        /// The ButtonChooseAnImageByIndex.
        /// </summary>
        /// <param name="index">The index<see cref="int"/>.</param>
        /// <returns>The <see cref="Button"/>.</returns>
        public Button ButtonChooseAnImageByIndex(int index)
            => new Button(Driver, By.XPath($"{BaseXPath}/div/div/div[{index}]//img"));

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets the ButtonSave.
        /// </summary>
        public EventTriggerButton<CreateRoom> ButtonSave =>
            new EventTriggerButton<CreateRoom>(Driver, By.XPath($"{BaseXPath}//div[@aria-label='{ResLeftNav.Save}']"));
    }
}
