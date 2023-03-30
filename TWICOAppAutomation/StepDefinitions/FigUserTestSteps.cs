using CSharpAFProject.Base;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using CSharpAFProject.Config;
using CSharpAFProject.ExcelReader;
using CSharpAFProject.Helpers;
using NUnit.Framework;
using SurakshaAutomation.Pages;
using System.Threading;
using System.Linq;



namespace SurakshaAutomation.StepDefinitions
{
    [TestFixture]
    [Binding]
    public class FigUserTestSteps : BaseStep
    {

        private readonly ParallelConfig _parallelConfig;
        public FigUserTestSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }


        [Given(@"User should login into Suraksha using user name and password")]
        public void GivenUserShouldLoginIntoSurakshaUsingUserNameAndPassword(Table table)
        {
            string _loginURL = Settings.AUT;
            _parallelConfig.Driver.Navigate().GoToUrl(_loginURL);
            _parallelConfig.Driver.Manage().Window.Maximize();

            // _parallelConfig.Driver.Manage().Timeouts().ImplicitWait(TimeSpan.FromSeconds(5));
            _parallelConfig.CurrentPage = new LoginPage(_parallelConfig);

            foreach (TableRow rowItem in table.Rows)
            {
                _parallelConfig.CurrentPage.As<LoginPage>().EnterEmailID_EmployeeID(rowItem["UserName"]);
                _parallelConfig.CurrentPage.As<LoginPage>().EnterPassword_TextBox(rowItem["Password"]);
            }
            _parallelConfig.CurrentPage.As<LoginPage>().ClickSignIn();
        }

        [Then(@"User should click on Create application")]
        public void ThenUserShouldClickOnCreateApplication()
        {
            _parallelConfig.CurrentPage = new LeftMenu(_parallelConfig);

            _parallelConfig.CurrentPage.As<LeftMenu>().ClickonCreateApplication();
            Thread.Sleep(4000);

        }

        [Then(@"User should click on Premium Calculator")]
        public void ThenUserShouldClickOnPremiumCalculator()
        {
            _parallelConfig.CurrentPage.As<LeftMenu>().ClickonPremiumCalculator();


            Assert.AreEqual("Premium Calculator Output", _parallelConfig.CurrentPage.As<LeftMenu>().GetPremiumCalculatorTitle());
            Thread.Sleep(4000);
        }

        [Then(@"User should click on Calculate Premium")]
        public void ThenUserShouldClickOnCalculatePremium()
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickonCalculatePremium();

            Assert.IsTrue(_parallelConfig.CurrentPage.As<Premium_Calculator>().CheckMandatory());
        }

        [Then(@"User should enter/select the following fields")]
        public void ThenUserShouldEnterSelectTheFollowingFields()
        {

            Thread.Sleep(5000);

            _parallelConfig.CurrentPage.As<Premium_Calculator>().SelectRegionDDL("");
            _parallelConfig.CurrentPage.As<Premium_Calculator>().SelectBranchDDL("");
            _parallelConfig.CurrentPage.As<Premium_Calculator>().SelectPolicyNoDDL("");
            _parallelConfig.CurrentPage.As<Premium_Calculator>().SelectPolicyTypeDDL(1);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().SelectModeDDL("");
            _parallelConfig.CurrentPage.As<Premium_Calculator>().SelectTotaltenureDDL(1);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().EnterCoverAmount("");
            _parallelConfig.CurrentPage.As<Premium_Calculator>().SelectIsPremiumFundedDDL("");
            _parallelConfig.CurrentPage.As<Premium_Calculator>().SelectBorrowerStateDDL("");
            _parallelConfig.CurrentPage.As<Premium_Calculator>().SelectGenderDDL("");
            _parallelConfig.CurrentPage.As<Premium_Calculator>().EnterInsureddob("15/06/2022");
            _parallelConfig.CurrentPage.As<Premium_Calculator>().EnterLoanCoverDOC("18/06/2022");

            Thread.Sleep(5000);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickonCalculatePremium();
        }

        [Then(@"Verify FIG User able to view values after clicking on Region")]
        public void ThenVerifyFIGUserAbleToViewValuesAfterClickingOnRegion()
        {
            // Expected Regions list
            string[] ExpectedRegions = new String[] { "Select Region", "East", "West", "North", "South1", "South2" };
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            bool Actual = _parallelConfig.CurrentPage.As<Premium_Calculator>().RegionDDLOptions(ExpectedRegions);
            Assert.IsTrue(Actual);
        }

        [Then(@"Verify Years Months dropdown should display for Tenure in premium calculator screen")]
        public void ThenVerifyYearsMonthsDropdownShouldDisplayForTenureInPremiumCalculatorScreen()
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            bool Actual = _parallelConfig.CurrentPage.As<Premium_Calculator>().CheckAvail_TotaltenureDDL();
            Assert.IsTrue(Actual);
        }

        [Then(@"User should select Policy Type - Joint Life/Co-Borrower from the dropdown")]
        public void ThenUserShouldSelectPolicyType_JointLifeCo_BorrowerFromTheDropdown()
        {
            string SelectOption = "Joint Life/Co-borrower";
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().SelectPolicyTypeDDL(SelectOption);

        }

        [Then(@"Verify Date of birth of Secondary Insured field should get added on the screen")]
        public void ThenVerifyDateOfBirthOfSecondaryInsuredFieldShouldGetAddedOnTheScreen()
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            bool Actual = _parallelConfig.CurrentPage.As<Premium_Calculator>().CheckAvail_SecondInsuredDob();
            Assert.IsTrue(Actual);
        }

        [Given(@"User should login into Suraksha using username and Password ")]
        public void GivenUserShouldLoginIntoSurakshaUsingVenkatesh_YadaValuemomentum_ComAndVenky(int p0)
        {
            //_scenarioContext.Pending();
        }


        [Given(@"User should login into Suraksha using (.*) and (.*)")]
        public void GivenUserShouldLoginIntoSurakshaUsingAnd(string userName0, string password1)
        {
           // _scenarioContext.Pending();
        }
    }

}
