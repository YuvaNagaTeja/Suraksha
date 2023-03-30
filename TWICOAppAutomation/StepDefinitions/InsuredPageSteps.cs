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
    public class InsuredPageSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;
        string fileName = Environment.CurrentDirectory.ToString() + Settings.ExcelFileNamePath;
        public InsuredPageSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        [Then(@"I click on  No Additional insured button")]
        public void ThenIClickOnNoAdditionalInsuredButton()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<InsuredPage>().ClickNoInsured();
        }

        [Then(@"The Additional Insureds screen should opened and I click on  Yes Additional insured button")]
        public void ThenTheAdditionalInsuredsScreenShouldOpenedAndIClickOnYesAdditionalInsuredButton()
        {
            _parallelConfig.CurrentPage = new InsuredPage(_parallelConfig);
                _parallelConfig.CurrentPage.As<InsuredPage>().ClickYesInsured();

        }

    }
}
