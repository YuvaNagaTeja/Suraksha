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
    public class MaillingAddressSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;
        string fileName = Environment.CurrentDirectory.ToString() + Settings.ExcelFileNamePath;

        public MaillingAddressSteps(ParallelConfig parallelConfig) : base(parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }

        [Then(@"The Mailing Address screen should be opened and I click on mailing address is the same button")]
        public void ThenTheMailingAddressScreenShouldBeOpenedAndIClickOnMailingAddressIsTheSameButton()
        {
            _parallelConfig.CurrentPage= new MailingAddressPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<MailingAddressPage>().ClickSameAddress();
        }

        [Then(@"The Mailing Address screen should be opened and I click on mailing address is the diffrent button")]
        public void ThenTheMailingAddressScreenShouldBeOpenedAndIClickOnMailingAddressIsTheDiffrentButton()
        {
             _parallelConfig.CurrentPage = new MailingAddressPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<MailingAddressPage>().ClickDifferentAddress();
        }

        [Then(@"I Enter ""(.*)"" ,""(.*)"",""(.*)"" ,""(.*)"" , ""(.*)"" for ""(.*)"" from ""(.*)"" and  click on the confirm button")]
        public void ThenIEnterForFromAndClickOnTheConfirmButton(string mailadress, string city, string state, string zip, string reason, string testcase, string sheetname)
            {
                _parallelConfig.CurrentPage.As<MailingAddressPage>().EnterReasonForMail(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, reason)));
                _parallelConfig.CurrentPage.As<MailingAddressPage>().EnterMailAddressForMail(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, mailadress)));
                _parallelConfig.CurrentPage.As<MailingAddressPage>().EnterCityForMail(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, city)));
                _parallelConfig.CurrentPage.As<MailingAddressPage>().EnterStateForMail(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, state)));
                _parallelConfig.CurrentPage.As<MailingAddressPage>().EnterZipForMail(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, zip)));
                _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<MailingAddressPage>().ClickMailAddress();
            }
    }
}
