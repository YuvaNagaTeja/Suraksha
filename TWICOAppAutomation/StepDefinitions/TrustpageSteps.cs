using CSharpAFProject.Base;
using CSharpAFProject.Config;
using CSharpAFProject.ExcelReader;
using System;
using TechTalk.SpecFlow;
using TWICOAppAutomation.Pages;

namespace TWICOAppAutomation.StepDefinitions
{
    [Binding]
    public class TrustpageSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;

        string fileName = Environment.CurrentDirectory.ToString() + Settings.ExcelFileNamePath;

        public TrustpageSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        [Then(@"I click Next button for Insured")]
        public void ThenIClickNextButtonForInsured()
        {
            _parallelConfig.CurrentPage = new TrustPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<TrustPage>().ClickInsuredNext();

        }
        [When(@"I enter insured details like ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void WhenIEnterInsuredDetailsLikeForFrom(string fName, string lName, string address, string city, string state, string zip, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage = new TrustPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<TrustPage>().EnterPersonFirstName(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, fName)));
            _parallelConfig.CurrentPage.As<TrustPage>().EnterPersonLastName(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, lName)));
            _parallelConfig.CurrentPage.As<TrustPage>().EnterPersonAddress(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, address)));
            _parallelConfig.CurrentPage.As<TrustPage>().EnterPersonCity(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, city)));
            _parallelConfig.CurrentPage.As<TrustPage>().EnterPersonState(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, state)));
            _parallelConfig.CurrentPage.As<TrustPage>().EnterPersonZip(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, zip)));

        }

        [When(@"I Click on Trustee Button")]
        public void WhenIClickOnTrusteeButton()
        {
            _parallelConfig.CurrentPage = new TrustPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<TrustPage>().ClickTrustButton();
        }
        [When(@"I enter Trustee details like ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void WhenIEnterTrusteeDetailsLikeForFrom(string name, string address, string city, string state, string zip, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<TrustPage>().EnterTrustName(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, name)));
            _parallelConfig.CurrentPage.As<TrustPage>().EnterTrustAddress(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, address)));
            _parallelConfig.CurrentPage.As<TrustPage>().EnterTrustCity(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, city)));
            _parallelConfig.CurrentPage.As<TrustPage>().EnterTrustState(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, state)));
            _parallelConfig.CurrentPage.As<TrustPage>().EnterTrustZip(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, zip)));

        }

        [When(@"I select Additional insured type person")]
        public void WhenISelectAdditionalInsuredTypePerson()
        {
            _parallelConfig.CurrentPage.As<TrustPage>().AnotherInsuredButtonClick();
        }

        [When(@"I  click person button Enter details ""(.*)"", ""(.*)"", ""(.*)"",""(.*)"",""(.*)"", ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void WhenIClickPersonButtonEnterDetailsForFrom(string fname, string lname, string address, string city, string state, string zip, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage = new TrustPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<TrustPage>().EnterAddPersonFirstName(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, fname)));
            _parallelConfig.CurrentPage.As<TrustPage>().EnterAddPersonLastName(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, lname)));
            _parallelConfig.CurrentPage.As<TrustPage>().EnterAddPersonAddress(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, address)));
            _parallelConfig.CurrentPage.As<TrustPage>().EnterAddPersonCity(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, city)));
            _parallelConfig.CurrentPage.As<TrustPage>().EnterAddPersonState(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, state)));
            _parallelConfig.CurrentPage.As<TrustPage>().EnterAddPersonZip(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, zip)));
        }

        [Then(@"I click Next button for additional Insured")]
        public void ThenIClickNextButtonForAdditionalInsured()
        {
            _parallelConfig.CurrentPage = new TrustPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<TrustPage>().AddClickInsuredNext();
        }

    }
}
