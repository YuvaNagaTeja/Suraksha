using CSharpAFProject.Base;
using CSharpAFProject.Config;
using CSharpAFProject.ExcelReader;
using CSharpAFProject.Helpers;
using System;
using TechTalk.SpecFlow;
using TWICOAppAutomation.Pages;

namespace TWICOAppAutomation.StepDefinitions
{
    [Binding]
    public class ClientPageSteps : BaseStep
    {

        private readonly ParallelConfig _parallelConfig;
        string fileName = Environment.CurrentDirectory.ToString() + Settings.ExcelFileNamePath;
        public ClientPageSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        [Then(@"I verify clients page")]
        public void ThenIVerifyClientsPage()
        {
            _parallelConfig.CurrentPage.As<ClientPage>().VerifyClientPage();
            Log4NetHelper.Log("Verified Client Page sucessfully!!", Log4Type.Info);
        }

        [When(@"I enter details like ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void WhenIEnterDetailsLikeForFrom(string fName, string lName, string date, string email, string phone, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ClientPage>().EnterClientFirstName(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, fName)));
            _parallelConfig.CurrentPage.As<ClientPage>().EnterClientLastName(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, lName)));
            _parallelConfig.CurrentPage.As<ClientPage>().EnterClientDate(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, date)));
            _parallelConfig.CurrentPage.As<ClientPage>().EnterClientEmail(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, email)));
            _parallelConfig.CurrentPage.As<ClientPage>().EnterClientPhone(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, phone)));
        }
        [Then(@"I click Next button for client page")]
        public void ThenIClickNextButtonForClientPage()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ClientPage>().ClickNextButton();
        }
        [When(@"I select Electronic button")]
        public void WhenISelectElectronicButton()
        {
            
            _parallelConfig.CurrentPage.As<ClientPage>().ClickElectronicButton();
        }
        [When(@"I select Mail button")]
        public void WhenISelectMailButton()
        {
            _parallelConfig.CurrentPage.As<ClientPage>().ClickMailButton();
        }

    }
}
