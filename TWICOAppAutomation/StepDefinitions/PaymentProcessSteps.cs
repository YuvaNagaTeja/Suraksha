using CSharpAFProject.Base;
using CSharpAFProject.Config;
using CSharpAFProject.ExcelReader;
using System;
using TechTalk.SpecFlow;
using TWICOAppAutomation.Pages;

namespace TWICOAppAutomation.StepDefinitions
{
    [Binding]
    public class PaymentProcessSteps :BaseStep
    {
        private readonly ParallelConfig _parallelConfig;
        string fileName = Environment.CurrentDirectory.ToString() + Settings.ExcelFileNamePath;
        public PaymentProcessSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        [When(@"I Click on Credit Card")]
        public void WhenIClickOnCreditCard()
        {
            _parallelConfig.CurrentPage = new PaymentProcessPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<PaymentProcessPage>().ClickCreditCard();
        }

        [When(@"I enter details of Credit Card ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void WhenIEnterDetailsOfCreditCardForFrom(string CCNUM, string CCFirstName, string CCLastName, string ExpDate, string Cvv, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<PaymentProcessPage>().EnterCCNumber(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, CCNUM)));
            _parallelConfig.CurrentPage.As<PaymentProcessPage>().EnterCCFirstName(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, CCFirstName)));
            _parallelConfig.CurrentPage.As<PaymentProcessPage>().EnterCCLastName(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, CCLastName)));
            _parallelConfig.CurrentPage.As<PaymentProcessPage>().EnterExpirationDate(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, ExpDate)));
            _parallelConfig.CurrentPage.As<PaymentProcessPage>().EnterCVVNumber(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, Cvv)));

        }

        [When(@"I Select Review")]
        public void WhenISelectReview()
        {
            _parallelConfig.CurrentPage.As<PaymentProcessPage>().CheckCCRecurringPayment();
        }

        [When(@"I click on Buy my poilcy")]
        public void WhenIClickOnBuyMyPoilcy()
        {
            _parallelConfig.CurrentPage = new PaymentProcessPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<PaymentProcessPage>().ClickBuyPolicy();
        }

        [When(@"I Click on ACH")]
        public void WhenIClickOnACH()
        {
            _parallelConfig.CurrentPage = new PaymentProcessPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<PaymentProcessPage>().ClickECheck();
        }
        [Then(@"I enter echeck/ACH details  ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"",""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIEnterEcheckACHDetailsForFrom(string firstname, string lastname, string rollingnumber, string accountnumber, string bankname, string accounttype, string testcase, string sheetname)
        {
            //
            _parallelConfig.CurrentPage = new PaymentProcessPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<PaymentProcessPage>().EnterECheckFirstName(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, firstname)));
            _parallelConfig.CurrentPage.As<PaymentProcessPage>().EnterECheckLastName(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, lastname)));
            _parallelConfig.CurrentPage.As<PaymentProcessPage>().EnterECheckRoutingNumber(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, rollingnumber)));
            _parallelConfig.CurrentPage.As<PaymentProcessPage>().EnterECheckAccountNumber(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, accountnumber)));
            _parallelConfig.CurrentPage.As<PaymentProcessPage>().EnterECheckBankName(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, bankname)));
            _parallelConfig.CurrentPage.As<PaymentProcessPage>().EnterECheckAccounttype(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, accounttype)));
        }

        [Then(@"I Select Review for echeck")]
        public void ThenISelectReviewForEcheck()
        {
            _parallelConfig.CurrentPage = new PaymentProcessPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<PaymentProcessPage>().EnterECheckRecurringPayment();
        }

        [Then(@"I Select Notice to Agent for echeck")]
        public void ThenISelectNoticeToAgentForEcheck()
        {
            _parallelConfig.CurrentPage = new PaymentProcessPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<PaymentProcessPage>().ClickNoticeToAgent();
        }


    }
}
