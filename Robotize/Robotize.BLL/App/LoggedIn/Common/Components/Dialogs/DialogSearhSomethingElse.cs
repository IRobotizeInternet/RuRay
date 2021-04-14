using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogSearhSomethingElse : BaseDialog
    {
        public DialogSearhSomethingElse()
        {
            BaseXPath = "//div[@role='dialog']//";
        }

        public RadioButton RadioButtonIntellectualProperty => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.IntellectualProperty}"));
        public RadioButton RadioButtonFraudOrScam => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.FraudOrScam}"));
        public RadioButton RadioButtonMockingVictims => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.MockingVictims}"));
        public RadioButton RadioButtonBullying => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.Bullying}"));
        public RadioButton RadioButtonChildAbuse => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.ChildAbuse}"));
        public RadioButton RadioButtonAnimalAbuse => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.AnimalAbuse}"));
        public RadioButton RadioButtonSexualActivity => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.SexualActivity}"));
        public RadioButton RadioButtonSuicideOrSelfInjury => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.SuicideOrSelfInjury}"));
        public RadioButton RadioButtonHateSpeech => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.HateSpeech}"));

        public RadioButton RadioButtonPromotingDrugUse => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.PromotingDrugUse}"));
        public RadioButton RadioButtonNonConsensualIntimateImages => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.NonConsensualIntimateImages}"));
        public RadioButton RadioButtonSexualExploitation => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.SexualExploitation}"));
        public RadioButton RadioButtonHarassment => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.Harassment}"));
        public RadioButton RadioButtonUnauthorizedSales => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.UnauthorizedSales}"));
        public RadioButton RadioButtonVoilence => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.Voilence}"));
        public RadioButton RadioButtonSharingPrivateImages => new RadioButton(Driver, By.XPath($"{BaseXPath}{ResHomePage.SharingPrivateImages}"));
        public EventTriggerButton<DialogDone> EventTriggerButtonNext => new EventTriggerButton<DialogDone>(Driver, By.XPath($"{BaseXPath}{ResHomePage.Next}"));

        protected override By ByForDialog => By.XPath($"//div[@role='dialog']//span[text()='{ResHomePage.Search}']");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}