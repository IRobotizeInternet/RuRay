using OpenQA.Selenium;
using RobotizeFacebook.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Controls;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class DialogHideOrReport : BaseDialog
    {
        public DialogHideOrReport()
        {
        }

        public Button ButtonHideComment => new Button(Driver, By.XPath($"//span[text()='{ResHomePage.HideComment}'])"));
        public Button ButtonReportCommentToGroupAdmins => new Button(Driver, By.XPath($"//span[text()='{ResHomePage.ReportCommentToGroupAdmins}'])"));
        public Button ButtonGiveFeedbackOrReportThisComment => new Button(Driver, By.XPath($"//span[text()='{ResHomePage.GiveFeedbackOrReportThisComment}'])"));
        protected override By ByForDialog => throw new System.NotImplementedException();

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }

    public class DialogReportCommentToGroupAdmin : BaseDialog
    {
        protected override By ByForDialog => By.XPath($"//span[text()='{ResHomePage.ReportCommentToAdmins}']");
        public DialogReportCommentToGroupAdmin()
        {
        }

        public Button ButtonBreaksGroupRule => new Button(Driver, By.XPath($"{ResHomePage.BreaksGroupRule}"));
        public Button ButtonSpam => new Button(Driver, By.XPath($"{ResHomePage.Spam}"));
        public Button ButtonMemberConflict => new Button(Driver, By.XPath($"{ResHomePage.MemberConflict}"));
        public Button ButtonHarassment => new Button(Driver, By.XPath($"{ResHomePage.Harassment}"));
        public Button ButtonHateSpeech => new Button(Driver, By.XPath($"{ResHomePage.HateSpeech}"));
        public Button ButtonNudityOrSexualActivity => new Button(Driver, By.XPath($"{ResHomePage.NudityOrSexualActivity}"));
        public Button ButtonVoilence => new Button(Driver, By.XPath($"{ResHomePage.Voilence}"));
        public Button ButtonOther => new Button(Driver, By.XPath($"{ResHomePage.Other}"));
        public EventTriggerButton<PageHome> EventTriggerButtonSendToAdmin =>
            new EventTriggerButton<PageHome>(Driver, By.XPath($"{ResHomePage.SendToAdmins}"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }

    public class DialogGiveFeedbackOrReportThisComment : BaseDialog
    {
        protected override By ByForDialog => By.XPath($"//span[text()='{ResHomePage.ReportCommentToAdmins}']");
        public DialogGiveFeedbackOrReportThisComment()
        {
        }

        public Button ButtonNudity => new Button(Driver, By.XPath($"{ResHomePage.Nudity}"));
        public Button ButtonVoilence => new Button(Driver, By.XPath($"{ResHomePage.Voilence}"));
        public Button ButtonHarassment => new Button(Driver, By.XPath($"{ResHomePage.Harassment}"));
        public Button ButtonSuicideOrSelfInjury => new Button(Driver, By.XPath($"{ResHomePage.SuicideOrSelfInjury}"));
        public Button ButtonFalseInformation => new Button(Driver, By.XPath($"{ResHomePage.FalseInformation}"));
        public Button ButtonSpam => new Button(Driver, By.XPath($"{ResHomePage.Spam}"));
        public Button ButtonUnauthorizedSales => new Button(Driver, By.XPath($"{ResHomePage.UnauthorizedSales}"));
        public Button ButtonHateSpeech => new Button(Driver, By.XPath($"{ResHomePage.HateSpeech}"));
        public Button ButtonTerrorism => new Button(Driver, By.XPath($"{ResHomePage.Terrorism}"));
        public EventTriggerButton<DialogSearhSomethingElse> EventTriggerButtonSomethingElse => 
            new EventTriggerButton<DialogSearhSomethingElse>(Driver, By.XPath($"{ResHomePage.SomethingElse}"));
        public EventTriggerButton<PageHome> EventTriggerButtonNext =>
            new EventTriggerButton<PageHome>(Driver, By.XPath($"{ResHomePage.Next}"));

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }

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

    public class DialogDone : BaseDialog
    {
        public DialogDone()
        {
            BaseXPath = "//div[@role='dialog']//";
        }

        public Button ButtonBlockUser =>
            new Button(Driver, By.XPath($"{BaseXPath}span[contains(text(), {ResHomePage.BlockWithSpace}"));
        public Button ButtonHidePostsFromUser =>
            new Button(Driver, By.XPath($"{BaseXPath}span[contains(text(), {ResHomePage.HidePostsFrom}"));
        public Button ButtonBlockConfirm =>
           new Button(Driver, By.XPath($"{BaseXPath}span[contains(text(),'{ResHomePage.BlockWithSpace}')]/parent::div/parent::div/parent::div/parent::div/div[2]/div/div/div[1]"));
        public Button ButtonBlockCancel =>
          new Button(Driver, By.XPath($"{BaseXPath}span[contains(text(),'{ResHomePage.BlockWithSpace}')]/parent::div/parent::div/parent::div/parent::div/div[2]/div/div/div[2]"));

        public Button ButtonHidePostConfirm =>
           new Button(Driver, By.XPath($"{BaseXPath}span[contains(text(),'{ResHomePage.HideWithSpace}')]/parent::div/parent::div/parent::div/parent::div/div[2]/div/div/div[1]"));
        public Button ButtonHidePostCancel =>
          new Button(Driver, By.XPath($"{BaseXPath}span[contains(text(),'{ResHomePage.HideWithSpace}')]/parent::div/parent::div/parent::div/parent::div/div[2]/div/div/div[2]"));

        public Button ButtonLearn => new Button(Driver, By.XPath($"{BaseXPath}span[contains(text(), {ResHomePage.LearnAbout}"));

        public EventTriggerButton<PageHome> EventTriggerButtonDone =>
            new EventTriggerButton<PageHome>(Driver, By.XPath($"{BaseXPath}span[contains(text(),'{ResHomePage.Done}')]"));

        protected override By ByForDialog => By.XPath($"//div[@role='dialog']//span[text()='{ResHomePage.YouSelected}']");

        public override void RunConformance()
        {
            throw new System.NotImplementedException();
        }
    }
}