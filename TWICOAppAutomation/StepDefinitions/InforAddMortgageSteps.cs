using CSharpAFProject.Base;
using CSharpAFProject.Config;
using CSharpAFProject.ExcelReader;
using System;
using TechTalk.SpecFlow;
using TWICOAppAutomation.Pages;

namespace TWICOAppAutomation.StepDefinitions
{
    [Binding]
    public class InforAddMortgageSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;
        string fileName = Environment.CurrentDirectory.ToString() + Settings.ExcelFileNamePath;
        public InforAddMortgageSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }
        [When(@"I enter Mortgagee details ""(.*)"",""(.*)"",""(.*)"",""(.*)"",""(.*)"",""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void WhenIEnterMortgageeDetailsForFrom(string mortgageeName, string loan, string mortgageeAddress, string mortgageeCity, string mortgageeState, string mortgageeZip, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage = new InforAddMortgageePage(_parallelConfig);
            _parallelConfig.CurrentPage.As<InforAddMortgageePage>().EnterNameOfMort(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, mortgageeName)));
            _parallelConfig.CurrentPage.As<InforAddMortgageePage>().EnterLoanMort(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, loan)));
            _parallelConfig.CurrentPage.As<InforAddMortgageePage>().EnterAddressOfMort(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, mortgageeAddress)));
            _parallelConfig.CurrentPage.As<InforAddMortgageePage>().EnterCityOfMort(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, mortgageeCity)));
            _parallelConfig.CurrentPage.As<InforAddMortgageePage>().EnterStateOfMort(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, mortgageeState)));
            _parallelConfig.CurrentPage.As<InforAddMortgageePage>().EnterZipcodeOfMort(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, mortgageeZip)));
        }
        [When(@"I click Next button for Mortgagee")]
        public void WhenIClickNextButtonForMortgagee()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<InforAddMortgageePage>().ClickMortNextBtn();
        }

        [When(@"I click Next button for AddMortgagee")]
        public void WhenIClickNextButtonForAddMortgagee()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<InforAddMortgageePage>().ClickAddMortNextBtn();
        }

        [When(@"I click on  Add an Additional Mortgagee button")]
        public void WhenIClickOnAddAnAdditionalMortgageeButton()
        {
            _parallelConfig.CurrentPage = new InforAddMortgageePage(_parallelConfig);

            _parallelConfig.CurrentPage.As<InforAddMortgageePage>().ClickAdditionalMortButton();
        }

        [When(@"I Enter name of the mortgagee as ""(.*)"", ""(.*)"",""(.*)"",""(.*)"",""(.*)"", ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void WhenIEnterNameOfTheMortgageeAsForFrom(string name, string address, string city, string state, string zipcode, string Loan, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<InforAddMortgageePage>().EnterAdditionalNameOfMort(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, name)));
            _parallelConfig.CurrentPage.As<InforAddMortgageePage>().EnterAdditionalAddressOfMort(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, address)));
            _parallelConfig.CurrentPage.As<InforAddMortgageePage>().EnterAdditionalCityOfMort(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, city)));
            _parallelConfig.CurrentPage.As<InforAddMortgageePage>().EnterAdditionalStateOfMort(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, state)));
            _parallelConfig.CurrentPage.As<InforAddMortgageePage>().EnterAdditionalZipcodeOfMort(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, zipcode)));
            _parallelConfig.CurrentPage.As<InforAddMortgageePage>().EnterAdditionalLoanMort(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, Loan)));
        }

    }
}
