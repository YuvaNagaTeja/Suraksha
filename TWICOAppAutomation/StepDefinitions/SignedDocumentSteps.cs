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
    public class SignedDocumentSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;
        string fileName = Environment.CurrentDirectory.ToString() + Settings.ExcelFileNamePath;

        public SignedDocumentSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        [Then(@"I Click on Confirm Button for signed documents")]
        public void ThenIClickOnConfirmButtonForSignedDocuments()
        {
            _parallelConfig.CurrentPage = new SignedDocumentsPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<SignedDocumentsPage>().ClickConfirmButton();

        }

        [Then(@"I select Agentprint")]
        public void ThenISelectAgentprint()
        {
            _parallelConfig.CurrentPage = new SignedDocumentsPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<SignedDocumentsPage>().ClickAgentPrint();
        }
        [Then(@"I click on  producersstatement")]
        public void ThenIClickOnProducersstatement()
        {
            _parallelConfig.CurrentPage = new SignedDocumentsPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<SignedDocumentsPage>().ClickProducerStatement();
        }
        [Then(@"I select insured email and Enter ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenISelectInsuredEmailAndEnterForFrom(string putEmail, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage = new SignedDocumentsPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<SignedDocumentsPage>().ClickInsuredEmailButton();
            _parallelConfig.CurrentPage.As<SignedDocumentsPage>().EnterInsuredEmailText(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, putEmail)));
        }
    }
}
