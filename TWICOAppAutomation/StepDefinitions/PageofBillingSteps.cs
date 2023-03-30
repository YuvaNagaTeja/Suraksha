using CSharpAFProject.Base;
using CSharpAFProject.Config;
using CSharpAFProject.ExcelReader;
using System;
using TechTalk.SpecFlow;
using TWICOAppAutomation.Pages;

namespace TWICOAppAutomation.StepDefinitions
{
    [Binding]
    public class PageOfBillingSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;
        string fileName = Environment.CurrentDirectory.ToString() + Settings.ExcelFileNamePath;

        public PageOfBillingSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }

        [Then(@"I Select Title Company Bill and Enter ""(.*)"" for ""(.*)"" from excel sheet ""(.*)""")]
        public void ThenISelectTitleCompanyBillAndEnterForFromExcelSheet(string email, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage = new BillingPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<BillingPage>().TitleCompanyBill();
            _parallelConfig.CurrentPage.As<BillingPage>().EnterEmailAddress(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, email)));        
        }

        [When(@"I click on Mortgage bill")]
        public void WhenIClickOnMortgageBill()
        {
            _parallelConfig.CurrentPage = new BillingPage(_parallelConfig);
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<BillingPage>().ClickMortgageeBill();
        }

    }
}
