using CSharpAFProject.Base;
using CSharpAFProject.Config;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    internal class DashboardSteps : BaseStep
    {
        string LoanID;
        int ExpectedRowCnt;
        private readonly ParallelConfig _parallelConfig;
        public DashboardSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }


        [When(@"Navigated to Dashboard page")]
        public void WhenNavigatedToDashboardPage()
        {
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            string Expected = "Welcome";
            Thread.Sleep(5000);
            string Actual = _parallelConfig.CurrentPage.As<DashboardPage>().GetTitle();
            Assert.IsTrue(Actual.Contains(Expected));
        }



        [When(@"User clicked on first record")]
        public void WhenUserClickedOnFirstRecord()
        {
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<DashboardPage>().ClickonFirstRecord();
        }

        [Then(@"User should navigate to details page and get loan id")]
        public void ThenUserShouldNavigateToDetailsPageAndGetLoanId()
        {
            Thread.Sleep(3000);
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<DashboardPage>().ClickonBorrowerDetailsTab();
            LoanID = _parallelConfig.CurrentPage.As<DashboardPage>().GetLoadID();
        }

        [Then(@"User should navigate to dashboard page again")]
        public void ThenUserShouldNavigateToDashboardPageAgain()
        {
            _parallelConfig.CurrentPage = new LeftMenu(_parallelConfig);
            _parallelConfig.CurrentPage.As<LeftMenu>().ClickonDashboardlink();
        }

        [Then(@"User should select a category as loan number and give loan id in search box and click on search")]
        public void ThenUserShouldSelectACategoryAsLoanNumberAndGiveLoanIdInSearchBoxAndClickOnSearch()
        {
            _parallelConfig.CurrentPage = new ActiveCasesPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<ActiveCasesPage>().SearchCategoryDDL(AutomationSettings.SelectCategory);
            _parallelConfig.CurrentPage.As<ActiveCasesPage>().LoanNumberTxt(LoanID);
            _parallelConfig.CurrentPage.As<ActiveCasesPage>().ClickSearchButton();
            Thread.Sleep(3000);
        }

        [Then(@"Verify loan id details with result page")]
        public void ThenVerifyLoanIdDetailsWithResultPage()
        {
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            string ResultLoanId = _parallelConfig.CurrentPage.As<DashboardPage>().GetSearchLoadID();
            Assert.AreEqual(LoanID, ResultLoanId);
        }

        [Then(@"Click on result first record it should navigate to details page")]
        public void ThenClickOnResultFirstRecordItShouldNavigateToDetailsPage()
        {
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<DashboardPage>().ClickonFirstRecord();
            Thread.Sleep(2000);
        }

        [Then(@"Verify user able to click on each tabs")]
        public void ThenVerifyUserAbleToClickOnEachTabs()
        {
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<DashboardPage>().ClickonBorrowerDetailsTab();
            Thread.Sleep(1000);
            _parallelConfig.CurrentPage.As<DashboardPage>().ClickonBorrowerAddressTab();
            Thread.Sleep(1000);
            _parallelConfig.CurrentPage.As<DashboardPage>().ClickonNomineeDetailsTab();
            Thread.Sleep(1000);
            //_parallelConfig.CurrentPage.As<DashboardPage>().ClickonAppointeeDetailsTab();
            //Thread.Sleep(1000);

        }

        [Then(@"Click on Export button")]
        public void ThenClickOnExportButton()
        {
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<DashboardPage>().ClickonDownloadExcelBtn();
            Thread.Sleep(14000);

        }

        [Then(@"Verify excel sheet is downloaded")]
        public void ThenVerifyExcelSheetIsDownloaded()
        {
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            string ExpectedFileName = AutomationSettings.ExpectedDownloadedMedicalFileName_Dashboard;
            string ActualDownloadedFileName = _parallelConfig.CurrentPage.As<DashboardPage>().GetFileFullName();
            Assert.IsTrue(ActualDownloadedFileName.Contains(ExpectedFileName));
        }

        [Then(@"Click on Ongoing Medical Cases")]
        public void ThenClickOnOngoingMedicalCases()
        {
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            Thread.Sleep(3000);
            ExpectedRowCnt = _parallelConfig.CurrentPage.As<DashboardPage>().GetOngoingMedicalCount();
            _parallelConfig.CurrentPage.As<DashboardPage>().ClickonOnGoingMedicalCases();
        }


        [Given(@"Enter Suraksha Portal URL in the browser")]
        public void GivenEnterSurakshaPortalURLInTheBrowser()
        {
            string _loginURL = Settings.AUT;
            _parallelConfig.Driver.Navigate().GoToUrl(_loginURL);
            _parallelConfig.Driver.Manage().Window.Maximize();
            _parallelConfig.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        [When(@"Enter Emaild ID and Password")]
        public void WhenEnterEmaildIDAndPassword()
        {
            _parallelConfig.CurrentPage = new LoginPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<LoginPage>().EnterEmailID_EmployeeID(AutomationSettings.ADFSLogin);
            _parallelConfig.CurrentPage.As<LoginPage>().ClickADFSLoginButton();
        }

        [Then(@"Click on Sign In button")]
        public void ThenClickOnSignInButton()
        {
            _parallelConfig.CurrentPage.As<LoginPage>().ClickADFSUserName(AutomationSettings.ADFSLogin);
            _parallelConfig.CurrentPage.As<LoginPage>().ClickADFSPassword(AutomationSettings.ADFPassword);
            _parallelConfig.CurrentPage.As<LoginPage>().ClickSignInButton();
        }

        [Then(@"Verify User should land on the dashboard Screen")]
        public void ThenVerifyUserShouldLandOnTheDashboardScreen()
        {
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            string Expected = "Welcome";
            Thread.Sleep(3000);
            string Actual = _parallelConfig.CurrentPage.As<DashboardPage>().GetTitle();
            Assert.IsTrue(Actual.Contains(Expected));
        }


        [Then(@"Verify user should click on the Export to Excel option from the dashboard")]
        public void ThenVerifyUserShouldClickOnTheExportToExcelOptionFromTheDashboard()
        {
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            Thread.Sleep(2000);
            _parallelConfig.CurrentPage.As<DashboardPage>().ClickonDownloadExcelBtn();
            Thread.Sleep(10000);
            string ExpectedFileName = AutomationSettings.ExpectedDownloadedFileName_Dashboard;

            string ActualDownloadedFileName = _parallelConfig.CurrentPage.As<DashboardPage>().GetFileFullName();
            Assert.IsTrue(ActualDownloadedFileName.Contains(ExpectedFileName));

        }


        [Then(@"User should click on the Customer ID from the  dropdown of Searchby option")]
        public void ThenUserShouldClickOnTheCustomerIDFromTheDropdownOfSearchbyOption()
        {
            _parallelConfig.CurrentPage = new ActiveCasesPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<ActiveCasesPage>().SearchCategoryDDL(AutomationSettings.SelectCustomerId);
        }
        [Then(@"User should provide the customer id in the search box")]
        public void ThenUserShouldProvideTheCustomerIdInTheSearchBox()
        {
            _parallelConfig.CurrentPage = new ActiveCasesPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<ActiveCasesPage>().CustomerIDTxt(AutomationSettings.SearchedCustomerId);
        }
        [Then(@"user should click on search")]
        public void ThenUserShouldClickOnSearch()
        {
            _parallelConfig.CurrentPage.As<ActiveCasesPage>().ClickSearchButton();
        }
        [Then(@"Verify policy record with respect to the customer id should display on the resultant grid")]
        public void ThenVerifyPolicyRecordWithRespectToTheCustomerIdShouldDisplayOnTheResultantGrid()
        {
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            Assert.IsTrue(_parallelConfig.CurrentPage.As<DashboardPage>().firstRecord());
            Thread.Sleep(2000);
        }

        [Then(@"User should land on the Dashboard page after successful login")]
        public void ThenUserShouldLandOnTheDashboardPageAfterSuccessfulLogin()
        {
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            string Expected = "Welcome";
            Thread.Sleep(5000);
            string Actual = _parallelConfig.CurrentPage.As<DashboardPage>().GetTitle();
            Assert.IsTrue(Actual.Contains(Expected));
        }
        //teja1
        [Then(@"user should validate respective tabs display on Dashboard")]
        public void ThenUserShouldValidateRespectiveTabsDisplayOnDashboard()
        {
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<DashboardPage>().verifytext();
        }

        [Then(@"User should click on the dropdown of Searchby option")]
        public void ThenUserShouldClickOnTheDropdownOfSearchbyOption()
        {
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<DashboardPage>().SearchbyDDL();
        }
        //teja2
        [Then(@"verify the dropdown values")]
        public void ThenVerifyTheDropdownValues()
        {
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            bool status = _parallelConfig.CurrentPage.As<DashboardPage>().CategoryListCheck(); Assert.IsTrue(status);
        }

        [Then(@"Group Ops user able to view the respective fields searchby \(dropdown\), searchbox, add filter, view and export to excel in the Dashboard")]
        public void ThenGroupOpsUserAbleToViewTheRespectiveFieldsSearchbyDropdownSearchboxAddFilterViewAndExportToExcelInTheDashboard()
        {
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<DashboardPage>().verifying_Dashboard_contents();
            Thread.Sleep(1000);
        }
        [Then(@"validate the Loan number in the resultant grid, Loan number should be a link")]
        public void ThenValidateTheLoanNumberInTheResultantGridLoanNumberShouldBeALink()
        {
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<DashboardPage>().verifyLoanNumbershouldBeLink();
        }

        [Then(@"Verify No of Medical Cases displayin in the dashboard should match with the number downloaded into excel")]
        public void ThenVerifyNoOfMedicalCasesDisplayinInTheDashboardShouldMatchWithTheNumberDownloadedIntoExcel()
        {
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            int ActualRowCnt = _parallelConfig.CurrentPage.As<DashboardPage>().GetDownloadedFileRowsCount();

            Assert.AreEqual(ExpectedRowCnt, ActualRowCnt);
        }

    }
}
