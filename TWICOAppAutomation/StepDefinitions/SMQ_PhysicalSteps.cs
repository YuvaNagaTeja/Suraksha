using CSharpAFProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SurakshaAutomation.Data;
using SurakshaAutomation.Pages;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SurakshaAutomation.StepDefinitions
{
    [Binding]
    public class SMQ_PhysicalSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;
        public SMQ_PhysicalSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }
        [When(@"Clik on SMQ Dropdown")]
        public void WhenClikOnSMQDropdown()
        {
            Thread.Sleep(2000);
            _parallelConfig.CurrentPage = new LeftMenu(_parallelConfig);
            _parallelConfig.CurrentPage.As<LeftMenu>().ClickonSMQLink();
            Thread.Sleep(1000);
            

        }

        [When(@"click on SMQ Physical DashBoard")]
        public void WhenClickOnSMQPhysicalDashBoard()
        {
            _parallelConfig.CurrentPage = new LeftMenu(_parallelConfig);
            _parallelConfig.CurrentPage.As<LeftMenu>().ClickonSMQPhysicalLink();
        }

        [Then(@"Click on upload Data")]
        public void ThenClickOnUploadData()
        {
            _parallelConfig.CurrentPage = new SMQ_Physical_Page(_parallelConfig);
            _parallelConfig.CurrentPage.As<SMQ_Physical_Page>().ClickOnUploadData();

        }

        [Then(@"Upload zip file")]
        public void ThenUploadZipFile()
        {
            Thread.Sleep(1000);
            _parallelConfig.CurrentPage = new SMQ_Physical_Page(_parallelConfig);
            _parallelConfig.CurrentPage.As<SMQ_Physical_Page>().UploadFile();
            Thread.Sleep(1000);
        }

        [Then(@"click on import data button")]
        public void ThenClickOnImportDataButton()
        {
            _parallelConfig.CurrentPage = new SMQ_Physical_Page(_parallelConfig);
            _parallelConfig.CurrentPage.As<SMQ_Physical_Page>().ClickonImportBtn();
            Thread.Sleep(1000);
        }

        [Then(@"User should be able to see the success message as SMQ has been uploaded successfully")]
        public void ThenUserShouldBeAbleToSeeTheSuccessMessageAsSMQHasBeenUploadedSuccessfully()
        {
            _parallelConfig.CurrentPage = new SMQ_Physical_Page(_parallelConfig);
            string actualmsg = _parallelConfig.CurrentPage.As<SMQ_Physical_Page>().GetSuccessfulMessage();
            Assert.AreEqual(AutomationSettings.SMQSuccessfulMsg, actualmsg);
            Thread.Sleep(1000);
        }

        [Then(@"User should be able to see the All data and SMQ Pending tabs on the Physical upload screen with the count")]
        public void ThenUserShouldBeAbleToSeeTheAllDataAndSMQPendingTabsOnThePhysicalUploadScreenWithTheCount()
        {
            _parallelConfig.CurrentPage = new SMQ_Physical_Page(_parallelConfig);
            Assert.IsTrue(_parallelConfig.CurrentPage.As<SMQ_Physical_Page>().CheckPendingRecords());
        }

        [When(@"Click on SMQ Digital DashBoard")]
        public void WhenClickOnSMQDigitalDashBoard()
        {
            _parallelConfig.CurrentPage = new LeftMenu(_parallelConfig);
            _parallelConfig.CurrentPage.As<LeftMenu>().ClickonSMQDigitalLink();
        }

        [Then(@"Verify User should be able to Navigate to Digital SMQ Dashboard screen successfully")]
        public void ThenVerifyUserShouldBeAbleToNavigateToDigitalSMQDashboardScreenSuccessfully()
        {
            _parallelConfig.CurrentPage = new SMQ_Physical_Page(_parallelConfig);
            string actualTitle = _parallelConfig.CurrentPage.As<SMQ_Physical_Page>().GetDigitalSMQTitle();
            Assert.AreEqual(AutomationSettings.SMQDigitalText,actualTitle);
            Thread.Sleep(1000);
        }
        [Then(@"User should be able to enter Height in Feet and Inches")]
        public void ThenUserShouldBeAbleToEnterHeightInFeetAndInches()
        {
            _parallelConfig.CurrentPage = new FillPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<FillPage>().ChkHeight();
            _parallelConfig.CurrentPage.As<FillPage>().ChkInches();
        }
        
        [Then(@"User should be able to select Primary Borrower or Co-borrower from the Primary Borrower or Co-borrower dropdown in the first review page")]
        public void ThenUserShouldBeAbleToSelectPrimaryBorrowerOrCo_BorrowerFromThePrimaryBorrowerOrCo_BorrowerDropdownInTheFirstReviewPage()
        {
            _parallelConfig.CurrentPage = new FillPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<FillPage>().ChkPrimaryBorrower();
        }

        [Then(@"Verify User should be able to see Life Assured details and Nominee assured details and click on Continue to Medical Details button")]
        public void ThenVerifyUserShouldBeAbleToSeeLifeAssuredDetailsAndNomineeAssuredDetailsAndClickOnContinueToMedicalDetailsButton()
        {
            _parallelConfig.CurrentPage = new FillPage(_parallelConfig);
            string actualFullNameTxt = _parallelConfig.CurrentPage.As<FillPage>().GetFullNameText();
            Assert.AreEqual(AutomationSettings.String1, actualFullNameTxt);
            Assert.IsTrue(_parallelConfig.CurrentPage.As<FillPage>().IsFullNameText());



            string ActualSumAssuredtxt = _parallelConfig.CurrentPage.As<FillPage>().GetSumAssuredTitle();
            Assert.AreEqual(AutomationSettings.String2, ActualSumAssuredtxt);
            Assert.IsTrue(_parallelConfig.CurrentPage.As<FillPage>().iSActualSumAssuredTitle());



            string AcutalTenureTxt = _parallelConfig.CurrentPage.As<FillPage>().GetTennure();
            Assert.AreEqual(AutomationSettings.String3, AcutalTenureTxt);
            Assert.IsTrue(_parallelConfig.CurrentPage.As<FillPage>().IsActualTenureTitle());



            string ActualPremiumTxt = _parallelConfig.CurrentPage.As<FillPage>().GetPremiumTitle();
            Assert.AreEqual(AutomationSettings.String4, ActualPremiumTxt);
            Assert.IsTrue(_parallelConfig.CurrentPage.As<FillPage>().IsActualPremiumTitle());



            string ActualNomineeTAssuredxt = _parallelConfig.CurrentPage.As<FillPage>().GetNomineeAssuredTitle();
            Assert.AreEqual(AutomationSettings.String5, ActualNomineeTAssuredxt);
            Assert.IsTrue(_parallelConfig.CurrentPage.As<FillPage>().IsActualNomineeAssuredDetailsTitle());



            string ActualNomineeFullnameTxt = _parallelConfig.CurrentPage.As<FillPage>().GetNomineeFullNameTitle();
            Assert.AreEqual(AutomationSettings.String6, ActualNomineeFullnameTxt);
            Assert.IsTrue(_parallelConfig.CurrentPage.As<FillPage>().IsActualNomineeFullNameTitle());



            string ActualNomineePercentageTxt = _parallelConfig.CurrentPage.As<FillPage>().GetNomineePercentageShare();
            Assert.AreEqual(AutomationSettings.String7, ActualNomineePercentageTxt);
            Assert.IsTrue(_parallelConfig.CurrentPage.As<FillPage>().IsActualNomineePercentofShareTitle());



            string ActualRelationshipInsuredTxt = _parallelConfig.CurrentPage.As<FillPage>().GetRelationshipwithInsured();
            Assert.AreEqual(AutomationSettings.String8, ActualRelationshipInsuredTxt);
            Assert.IsTrue(_parallelConfig.CurrentPage.As<FillPage>().IsActualRelationshipwithlifeinsuredTitle());




        }

    }
}
