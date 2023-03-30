using CSharpAFProject.Base;
using CSharpAFProject.Config;
using NUnit.Framework;
using SurakshaAutomation.Data;
using SurakshaAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace SurakshaAutomation.StepDefinitions
{
    [Binding]
    internal class BulkUploadSteps : BaseStep
    {

        private readonly ParallelConfig _parallelConfig;
        public BulkUploadSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        [Then(@"Click Create application on the left side of the screen")]
        public void ThenUserShouldClickOnCreateApplication()
        {
            _parallelConfig.CurrentPage = new LeftMenu(_parallelConfig);

            _parallelConfig.CurrentPage.As<LeftMenu>().ClickonCreateApplication();
            Thread.Sleep(4000);

        }
        [Then(@"Click on Bulk Upload in Create application")]
        public void ThenClickOnBulkUploadInCreateApplication()
        {
            _parallelConfig.CurrentPage.As<LeftMenu>().ClickonBulkUploadLink();
        }
        [Then(@"Click on View Bulk Upload in Create application")]
        public void ThenClickOnViewBulkUploadInCreateApplication()
        {
            _parallelConfig.CurrentPage.As<LeftMenu>().ClickonViewBulkUploadLink();
        }

        [Then(@"User should be able to navigate to Bulk upload screen successfully")]
        public void ThenUserShouldBeAbleToNavigateToBulkUploadScreenSuccessfully()
        {
            _parallelConfig.CurrentPage = new BulkUploadPage(_parallelConfig);
            Assert.AreEqual(BulkUploadData.BulkUploadTitle, _parallelConfig.CurrentPage.As<BulkUploadPage>().GetBulkUploadTitle());
        }

        [Then(@"User should be able to see FI field is auto populated and disabled")]
        public void ThenUserShouldBeAbleToSeeFIFieldIsAutoPopulatedAndDisabled()
        {
            _parallelConfig.CurrentPage = new BulkUploadPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<BulkUploadPage>().SelectFIDDL(BulkUploadData.FinancialInstitution);
        }


        [Then(@"User should select the file and upload")]
        public void ThenUserShouldSelectTheFileAndUpload()
        {
            _parallelConfig.CurrentPage = new BulkUploadPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<BulkUploadPage>().ClickOnuploadExcelFileBtn();

            Thread.Sleep(4000);
        }

        [Then(@"Verify the successfull messages and click okay button")]
        public void ThenVerifyTheSuccessfullMessagesAndClickOkayButton()
        {

            Thread.Sleep(4000);
            string ActualSuccessMsg = _parallelConfig.CurrentPage.As<BulkUploadPage>().FileUploadSuccessMsg();
            string ExpectedSuccessMsg = BulkUploadData.FileUploadSuccessMsg;
            Assert.AreEqual(ExpectedSuccessMsg, ActualSuccessMsg);

            string ActualFileUploadStatusMsg = _parallelConfig.CurrentPage.As<BulkUploadPage>().FileUploadStatusMsg();
            string ExpectedFileUploadStatusMsg = BulkUploadData.FileUploadStatusMsg;
            Assert.AreEqual(ExpectedFileUploadStatusMsg, ActualFileUploadStatusMsg);

            _parallelConfig.CurrentPage.As<BulkUploadPage>().ClickOnOkayButton();
            Thread.Sleep(1000);
        }


        [Then(@"Verify View Bulk Upload page loaded successfully")]
        public void ThenVerifyViewBulkUploadPageLoadedSuccessfully()
        {
            _parallelConfig.CurrentPage = new ViewBulkUploadPage(_parallelConfig);
            string ActualViewBulkUploadTitle = _parallelConfig.CurrentPage.As<ViewBulkUploadPage>().GetViewBulkUploadTitle();
            string ExpectedViewBulkUploadTitle = ViewBulkUpload.ViewBulkUploadTitle;
            Assert.AreEqual(ExpectedViewBulkUploadTitle, ActualViewBulkUploadTitle);
        }

        [Then(@"Give necessary data and click on Load Data button")]
        public void ThenGiveNecessaryDataAndClickOnLoadDataButton()
        {
            _parallelConfig.CurrentPage = new ViewBulkUploadPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<ViewBulkUploadPage>().SelectFIDDL(ViewBulkUpload.FinancialInstitution);
            _parallelConfig.CurrentPage.As<ViewBulkUploadPage>().EnterJobID(ViewBulkUpload.JobID);
            _parallelConfig.CurrentPage.As<ViewBulkUploadPage>().FromDate(ViewBulkUpload.From_Upload_Date);
            _parallelConfig.CurrentPage.As<ViewBulkUploadPage>().ToDate(ViewBulkUpload.To_Upload_Date);

            _parallelConfig.CurrentPage.As<ViewBulkUploadPage>().ClickOnLoadDataBtn();
            _parallelConfig.CurrentPage.As<ViewBulkUploadPage>().ClickOnDownloadMedical();
            _parallelConfig.CurrentPage.As<ViewBulkUploadPage>().ClickOnDownloadNonMedical();
            _parallelConfig.CurrentPage.As<ViewBulkUploadPage>().ClickOnDownloadFailed();
            Thread.Sleep(10000);

        }

        [Then(@"Give necessary data and click on failed cases link")]
        public void ThenGiveNecessaryDataAndClickOnFailedCasesLink()
        {

            _parallelConfig.CurrentPage = new ViewBulkUploadPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<ViewBulkUploadPage>().SelectFIDDL(ViewBulkUpload.FinancialInstitution);
            _parallelConfig.CurrentPage.As<ViewBulkUploadPage>().EnterJobID(ViewBulkUpload.JobID);
            _parallelConfig.CurrentPage.As<ViewBulkUploadPage>().FromDate(ViewBulkUpload.From_Upload_Date);
            _parallelConfig.CurrentPage.As<ViewBulkUploadPage>().ToDate(ViewBulkUpload.To_Upload_Date);
            _parallelConfig.CurrentPage.As<ViewBulkUploadPage>().ClickOnLoadDataBtn();
            _parallelConfig.CurrentPage.As<ViewBulkUploadPage>().ClickOnDownloadFailed();
            Thread.Sleep(5000);

            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<DashboardPage>().DownloadFile();
        }
        [Then(@"User should be able to download the success number of records")]
        public void ThenUserShouldBeAbleToDownloadTheSuccessNumberOfRecords()
        {
            _parallelConfig.CurrentPage = new ViewBulkUploadPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<ViewBulkUploadPage>().ClickOnDownloadMedical();
            _parallelConfig.CurrentPage.As<ViewBulkUploadPage>().ClickOnDownloadNonMedical();
            Thread.Sleep(5000);

            string ViewBulkUpload = AutomationSettings.ViewBulkUploadReportFileName;
            string ActualDownloadedFileName = _parallelConfig.CurrentPage.As<DashboardPage>().GetFileFullName();
            Assert.IsTrue(ActualDownloadedFileName.Contains(ViewBulkUpload));

        }

        [Given(@"Login into Suraksha Portal as ExternalUser")]
        public void GivenLoginIntoSurakshaPortalAsExternalUser()
        {
            string _loginURL = Settings.AUT;
            _parallelConfig.Driver.Navigate().GoToUrl(_loginURL);
            _parallelConfig.Driver.Manage().Window.Maximize();
            _parallelConfig.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15); _parallelConfig.CurrentPage = new LoginPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<LoginPage>().EnterEmailID_EmployeeID(AutomationSettings.UserName); //External LOGIN
            _parallelConfig.CurrentPage.As<LoginPage>().EnterPassword_TextBox(AutomationSettings.Password); //External Login            
            _parallelConfig.CurrentPage.As<LoginPage>().ClickSignIn();
        }

        [Then(@"Observe the FI field")]
        public void ThenObserveTheFIField()
        {
            _parallelConfig.CurrentPage = new BulkUploadPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<BulkUploadPage>().CheckitisDisabled();
        }

        [Then(@"Click on Failed number Hyperlink and download""")]
        public void ThenClickOnFailedNumberHyperlinkAndDownload()
        {
            _parallelConfig.CurrentPage = new ViewBulkUploadPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<ViewBulkUploadPage>().ClickOnDownloadFailed();
            Thread.Sleep(3000);
        }
    }
}
