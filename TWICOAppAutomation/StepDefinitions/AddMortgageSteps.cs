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
    public class AddMortgageSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;
        string fileName = Environment.CurrentDirectory.ToString() + Settings.ExcelFileNamePath;
        public AddMortgageSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
           
        }
       

        [Then(@"I Click on Yes mortgagee Button")]
        public void ThenIClickOnYesMortgageeButton()
        {
            _parallelConfig.CurrentPage = new AddMortgagee(_parallelConfig);
                _parallelConfig.CurrentPage.As<AddMortgagee>().ClickYesBtn();

        }

        [Then(@"I Click on No mortgagee Button")]
        public void ThenIClickOnNoMortgageeButton()
        {
            _parallelConfig.CurrentPage = new AddMortgagee(_parallelConfig);
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<AddMortgagee>().ClickNoBtn();
        }


        [Then(@"The Mortgagee screen should be opened and I Click on  Yes I have a mortgagee Button")]
        public void ThenTheMortgageeScreenShouldBeOpenedAndIClickOnYesIHaveAMortgageeButton()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<AddMortgagee>().ClickYesBtn();
        }


    }
}
