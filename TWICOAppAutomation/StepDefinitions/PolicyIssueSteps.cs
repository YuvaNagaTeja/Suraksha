using CSharpAFProject.Base;
using System;
using TechTalk.SpecFlow;
using TWICOAppAutomation.Pages;

namespace TWICOAppAutomation.StepDefinitions
{
    [Binding]
    public class PolicyIssueSteps: BaseStep
    {
        private readonly ParallelConfig _parallelConfig;
        public PolicyIssueSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        [When(@"I click on confirm button to issue policy")]
        public void WhenIClickOnConfirmButtonToIssuePolicy()
        {
            _parallelConfig.CurrentPage = new PolicyIssuePage(_parallelConfig);
                _parallelConfig.CurrentPage.As<PolicyIssuePage>().PolicySubmitButton();

        }
    }
}
