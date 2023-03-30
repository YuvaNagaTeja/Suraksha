using CSharpAFProject.Base;
using CSharpAFProject.Config;
using CSharpAFProject.ExcelReader;
using CSharpAFProject.Helpers;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TWICOAppAutomation.Pages;

namespace TWFGAutomation.StepDefinitions
{
    [Binding]
    public class HomePageSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;
        private string _twicoURL;
        public TestContext TestContext { get; set; }
        string fileName = Environment.CurrentDirectory.ToString() + Settings.ExcelFileNamePath;

        public HomePageSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        [Given(@"I am in home page")]
        public void GivenIAmInHomePage()
        {
             string _twicoURL = (string)TestContext.Parameters["URL"];
            _parallelConfig.Driver.Navigate().GoToUrl(_twicoURL);
          // _parallelConfig.Driver.Navigate().GoToUrl(Settings.AUT);
            _parallelConfig.CurrentPage = new HomePage(_parallelConfig);
        }

        [When(@"I enter ""(.*)"" for ""(.*)"" from ""(.*)""  and I click on find button")]
        public void WhenIEnterForFromAndIClickOnFindButton(string address, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage.As<HomePage>().EnterAddress(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, address)));
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<HomePage>().ClickFindbutton();
        }

        [When(@"I enter ""(.*)"" for ""(.*)"" from ""(.*)"" and I click Find button")]
        public void WhenIEnterForFromAndIClickFindButton(string address, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage.As<HomePage>().EnterAddress(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, address)));
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<HomePage>().ClickFindbutton();
        }

        [When(@"I click on Agent login and Enter ""(.*)"" and ""(.*)""")]
        public void WhenIClickOnAgentLoginAndEnterAnd(string id, string password)
        {
            _parallelConfig.CurrentPage = new HomePage(_parallelConfig);
             _parallelConfig.CurrentPage.As<HomePage>().ClickAgentLogin();
            _parallelConfig.CurrentPage.As<HomePage>().EnterLoginId(id);
            _parallelConfig.CurrentPage.As<HomePage>().EnterLoginPassword(password);
        }

        [Then(@"I click on login button")]
        public void ThenIClickOnLoginButton()
        {
                _parallelConfig.CurrentPage.As<HomePage>().ClickLoginButton();
            
        }

        [Then(@"I click on OK button for login")]
        public void ThenIClickOnOKButtonForLogin()
        {
            _parallelConfig.CurrentPage.As<HomePage>().ClickOKButton();
        }


    }
}
