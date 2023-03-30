using CSharpAFProject.Base;
using CSharpAFProject.Config;
using CSharpAFProject.ExcelReader;
using System;
using TechTalk.SpecFlow;
using TWICOAppAutomation.Pages;

namespace TWICOAppAutomation.StepDefinitions
{
    [Binding]
    public class ValidatePageSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;
        string fileName = Environment.CurrentDirectory.ToString() + Settings.ExcelFileNamePath;

        public ValidatePageSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        [Then(@"I click on Ok button Validate Welcome to the Twico Family!")]
        public void ThenIClickOnOkButtonValidateWelcomeToTheTwicoFamily()
        {
            _parallelConfig.CurrentPage = new ValidatePage(_parallelConfig);
            _parallelConfig.CurrentPage.As<ValidatePage>().OKButton();
            _parallelConfig.CurrentPage.As<ValidatePage>().VerifyPolicyIssued();
           
        }

        [Then(@"I Click on Download Policy packet And I verify ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIClickOnDownloadPolicyPacketAndIVerifyForFrom(string validation, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ValidatePage>().policypdf1(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, validation)));

        }


    }
}
