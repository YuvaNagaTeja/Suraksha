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
    public class CoApplicantPageSteps : BaseStep

    {
        private readonly ParallelConfig _parallelConfig;
        string fileName = Environment.CurrentDirectory.ToString() + Settings.ExcelFileNamePath;

        public CoApplicantPageSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        [Then(@"The Coapplicant screen should be opened and I click on No, I dont have a co-applicant button")]
        public void ThenTheCoapplicantScreenShouldBeOpenedAndIClickOnNoIDontHaveACo_ApplicantButton()
        {
            _parallelConfig.CurrentPage = new CoApplicantPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<CoApplicantPage>().ClickNoBtn();
           
        }

        [Then(@"The Coapplicant screen should be opened and I click on Yes, I have a co-applicant button")]
        public void ThenTheCoapplicantScreenShouldBeOpenedAndIClickOnYesIHaveACo_ApplicantButton()
        {
            _parallelConfig.CurrentPage = new CoApplicantPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<CoApplicantPage>().ClickYesButton();
        }

        [Then(@"I Enter ""(.*)"", ""(.*)"", ""(.*)"" for ""(.*)"" from ""(.*)"" and I click next button")]
        public void ThenIEnterForFromAndIClickNextButton(string fname, string lname, string dob, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<CoApplicantPage>().EnterSpouseFirstName(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, fname)));
            _parallelConfig.CurrentPage.As<CoApplicantPage>().EnterSpouseLastname(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, lname)));
            _parallelConfig.CurrentPage.As<CoApplicantPage>().EnterSpouseDOB(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, dob)));
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<CoApplicantPage>().ClickSpouseButton();
        }
        [Then(@"I click previous button in co-applicant page")]
        public void ThenIClickPreviousButtonInCo_ApplicantPage()
        {
            _parallelConfig.CurrentPage = new CoApplicantPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<CoApplicantPage>().PreviousButton();
        }


    }
}


