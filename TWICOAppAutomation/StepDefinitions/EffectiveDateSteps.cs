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
    public class EffectiveDateSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;

        string fileName = Environment.CurrentDirectory.ToString() + Settings.ExcelFileNamePath;

        public EffectiveDateSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }
        [When(@"I click choose button for effective date")]
        public void WhenIClickChooseButtonForEffectiveDate()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<EffectiveDatePage>().ClickChooseButton();
        }

        [When(@"a popup apprears and I enter ""(.*)"", ""(.*)"",""(.*)"", ""(.*)"", ""(.*)"" for ""(.*)"" from ""(.*)"" and I click Find button")]
        public void WhenAPopupApprearsAndIEnterForFromAndIClickFindButton(string address, string city, string state, string zip, string country, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<EffectiveDatePage>().EnterPopupAddress(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, address)));
            _parallelConfig.CurrentPage.As<EffectiveDatePage>().EnterPopupCity(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, city)));
            _parallelConfig.CurrentPage.As<EffectiveDatePage>().EnterPopupState(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, state)));
            _parallelConfig.CurrentPage.As<EffectiveDatePage>().EnterPopupZip(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, zip)));
            _parallelConfig.CurrentPage.As<EffectiveDatePage>().EnterPopupCountry(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, country)));
             _parallelConfig.CurrentPage.As<EffectiveDatePage>().ClickPopupFind();

        }


        [Then(@"I verify a pop window for PPC/WindZone Questions")]
        public void ThenIVerifyAPopWindowForPPCWindZoneQuestions()
        {
            _parallelConfig.CurrentPage.As<EffectiveDatePage>().VerifyPPCPopup();

        }


    }

}
