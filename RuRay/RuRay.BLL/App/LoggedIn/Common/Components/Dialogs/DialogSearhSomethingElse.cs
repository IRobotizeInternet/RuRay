using OpenQA.Selenium;
using RuRay.BLL.Resources;
using RuRayToolbox.Controls;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DialogSearhSomethingElse" />.
    /// </summary>
    public class DialogSearhSomethingElse : BaseDialog
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DialogSearhSomethingElse"/> class.
        /// </summary>
        public DialogSearhSomethingElse()
        {
            BaseXPath = "//div[@role='dialog']//";
        }

        /// <summary>
        /// Gets the RadioButtonIntellectualProperty.
        /// </summary>
        public RadioButton RadioButtonIntellectualProperty => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.IntellectualProperty}"));

        /// <summary>
        /// Gets the RadioButtonFraudOrScam.
        /// </summary>
        public RadioButton RadioButtonFraudOrScam => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.FraudOrScam}"));

        /// <summary>
        /// Gets the RadioButtonMockingVictims.
        /// </summary>
        public RadioButton RadioButtonMockingVictims => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.MockingVictims}"));

        /// <summary>
        /// Gets the RadioButtonBullying.
        /// </summary>
        public RadioButton RadioButtonBullying => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.Bullying}"));

        /// <summary>
        /// Gets the RadioButtonChildAbuse.
        /// </summary>
        public RadioButton RadioButtonChildAbuse => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.ChildAbuse}"));

        /// <summary>
        /// Gets the RadioButtonAnimalAbuse.
        /// </summary>
        public RadioButton RadioButtonAnimalAbuse => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.AnimalAbuse}"));

        /// <summary>
        /// Gets the RadioButtonSexualActivity.
        /// </summary>
        public RadioButton RadioButtonSexualActivity => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.SexualActivity}"));

        /// <summary>
        /// Gets the RadioButtonSuicideOrSelfInjury.
        /// </summary>
        public RadioButton RadioButtonSuicideOrSelfInjury => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.SuicideOrSelfInjury}"));

        /// <summary>
        /// Gets the RadioButtonHateSpeech.
        /// </summary>
        public RadioButton RadioButtonHateSpeech => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.HateSpeech}"));

        /// <summary>
        /// Gets the RadioButtonPromotingDrugUse.
        /// </summary>
        public RadioButton RadioButtonPromotingDrugUse => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.PromotingDrugUse}"));

        /// <summary>
        /// Gets the RadioButtonNonConsensualIntimateImages.
        /// </summary>
        public RadioButton RadioButtonNonConsensualIntimateImages => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.NonConsensualIntimateImages}"));

        /// <summary>
        /// Gets the RadioButtonSexualExploitation.
        /// </summary>
        public RadioButton RadioButtonSexualExploitation => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.SexualExploitation}"));

        /// <summary>
        /// Gets the RadioButtonHarassment.
        /// </summary>
        public RadioButton RadioButtonHarassment => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.Harassment}"));

        /// <summary>
        /// Gets the RadioButtonUnauthorizedSales.
        /// </summary>
        public RadioButton RadioButtonUnauthorizedSales => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.UnauthorizedSales}"));

        /// <summary>
        /// Gets the RadioButtonVoilence.
        /// </summary>
        public RadioButton RadioButtonVoilence => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.Voilence}"));

        /// <summary>
        /// Gets the RadioButtonSharingPrivateImages.
        /// </summary>
        public RadioButton RadioButtonSharingPrivateImages => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.SharingPrivateImages}"));

        /// <summary>
        /// Gets the EventTriggerButtonNext.
        /// </summary>
        public EventTriggerButton<DialogDone> EventTriggerButtonNext => new EventTriggerButton<DialogDone>(Driver, By.XPath($"{BaseXPath}{ResHomePage.Next}"));

        /// <summary>
        /// Gets the ByForDialog.
        /// </summary>
        protected override By ByForDialog => By.XPath($"//div[@role='dialog']//span[text()='{ResHomePage.Search}']");

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}
