using CSharpAFProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SurakshaAutomation.Data;
using SurakshaAutomation.Pages;
using System;
using System.Threading;
using System.Xml.Linq;
using TechTalk.SpecFlow;

namespace SurakshaAutomation.StepDefinitions
{
    [Binding]
    public class DownloadSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;
        public DownloadSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }
        [When(@"Click Create application on the left side of the screen")]
        public void WhenClickCreateApplicationOnTheLeftSideOfTheScreen()
        {
            _parallelConfig.CurrentPage = new LeftMenu(_parallelConfig); _parallelConfig.CurrentPage.As<LeftMenu>().ClickonCreateApplication();
            Thread.Sleep(4000);
        }
        [When(@"Click on Download in Create Application")]
        public void WhenClickOnDownloadInCreateApplication()
        {
            _parallelConfig.CurrentPage = new LeftMenu(_parallelConfig);
            _parallelConfig.CurrentPage.As<LeftMenu>().ClickonDownloadLink();
            Thread.Sleep(4000);
        }
        [Then(@"Verify User should be able to navigate to Download screen")]
        public void ThenVerifyUserShouldBeAbleToNavigateToDownloadScreen()
        {
            _parallelConfig.CurrentPage = new DownloadPage(_parallelConfig); string ActualText = _parallelConfig.CurrentPage.As<DownloadPage>().GetDownloadTitleText();
            Assert.AreEqual(ActualText, "Download");
            Thread.Sleep(4000);
        }



        [Then(@"Enter the search details like (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*)")]
        public void DownloadSearch(string strFinancialInstitution, string strRegion, string strBranch, string strPolicyNo, string strFromDate, string strToDate, string DocumentType, string loanID)
        {
            _parallelConfig.CurrentPage = new DownloadPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<DownloadPage>().SearchDownload(strFinancialInstitution, strRegion, strBranch, strPolicyNo, strFromDate, strToDate, DocumentType);
        }

        [Then(@"click on search button")]
        public void ThenClickOnSearchButton()
        {
            _parallelConfig.CurrentPage = new DownloadPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<DownloadPage>().ClickonSearchBtn();
        }

        [Then(@"Download the file")]
        public void ThenDownloadTheFile()
        {
            _parallelConfig.CurrentPage = new DownloadPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<DownloadPage>().ClickonDownloadBtn();

            Thread.Sleep(8000);
        }

        [Then(@"User should be able to download the file of searched results in ZIP format")]
        public void ThenUserShouldBeAbleToDownloadTheFileOfSearchedResultsInZIPFormat()
        {
            _parallelConfig.CurrentPage = new DownloadPage(_parallelConfig);
            string ExpectedFileNameExtension = ".zip";
            string ActualDownloadedFileNameExtension = _parallelConfig.CurrentPage.As<DownloadPage>().GetFileNameExtension();
            Assert.AreEqual(ExpectedFileNameExtension, ActualDownloadedFileNameExtension);
        }

        [Then(@"user should click on download option in the left menu")]
        public void ThenUserShouldClickOnDownloadOptionInTheLeftMenu()
        {
            _parallelConfig.CurrentPage = new DownloadPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<DownloadPage>().ClickOnDownloadsInLeftMenu();
        }

        [Then(@"User should enter FI,region,Branch,policynumber,from-To date,Document type and click on search button")]
        public void ThenUserShouldEnterFIRegionBranchPolicynumberFrom_ToDateDocumentTypeAndClickOnSearchButton()
        {
            _parallelConfig.CurrentPage = new DownloadPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<DownloadPage>().EnterAllMandatoryFieldsInDownloadScreen();
        }

        [Then(@"validate headers of Financial Institute Data")]
        public void ThenValidateHeadersOfFinancialInstituteData()
        {
            _parallelConfig.CurrentPage = new DownloadPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<DownloadPage>().ValidateHeaders();
        }

        [Then(@"Click on download Button")]
        public void ThenClickOnDownloadButton()
        {
            _parallelConfig.CurrentPage = new DownloadPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<DownloadPage>().clickOnDownload();
        }
    }
}
