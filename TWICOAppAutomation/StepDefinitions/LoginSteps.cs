using CSharpAFProject.Base;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using CSharpAFProject.Config;
using CSharpAFProject.ExcelReader;
using CSharpAFProject.Helpers;
using NUnit.Framework;
using SurakshaAutomation.Pages;
 
namespace SurakshaAutomation.StepDefinitions
{

    [TestFixture]
    [Binding]
    public class LoginSteps : BaseStep
    {

        private readonly ParallelConfig _parallelConfig;

        private string _loginURL;
        string fileName = Environment.CurrentDirectory.ToString() + Settings.ExcelFileNamePath;

        public LoginSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        [Given(@"Open the browser")]
        public void GivenIAmInHomePage()
        {
            string _loginURL = (string)Settings.AUT;
            _parallelConfig.Driver.Navigate().GoToUrl(_loginURL);
            _parallelConfig.CurrentPage = new LoginPage(_parallelConfig);
        }
        [When(@"Input invalid UserName and Password")]
        public void EnterUserNamePassword()
        {
            _parallelConfig.CurrentPage = new LoginPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<LoginPage>().EnterEmailID_EmployeeID("test@valuemomentum.com ");
            _parallelConfig.CurrentPage.As<LoginPage>().EnterPassword_TextBox("test3444@123");
            _parallelConfig.CurrentPage.As<LoginPage>().ClickSignIn();
        }
        [Then(@"User should not login to application")]
        public void VerifyInvalidLogin()
        {
            _parallelConfig.CurrentPage = new LoginPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<LoginPage>().ChkLoginFailed("Your Email ID is not registered with us. Kindly connect with your NRM");
        }

        [When(@"UserName and Password given")]
        public void EnterValidUserNamePassWord()
        {
            _parallelConfig.CurrentPage = new LoginPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<LoginPage>().EnterEmailID_EmployeeID("Venkatesh.yada@valuemomentum.com ");
            _parallelConfig.CurrentPage.As<LoginPage>().EnterPassword_TextBox("Venky@123");
            _parallelConfig.CurrentPage.As<LoginPage>().ClickSignIn();
        }

        



        [Given(@"User should be able to login into SP successfully")]
        public void GivenUserShouldBeAbleToLoginIntoSPSuccessfully()
        {
            string _loginURL = (string)Settings.AUT;
            _parallelConfig.Driver.Navigate().GoToUrl(_loginURL);
            _parallelConfig.CurrentPage = new LoginPage(_parallelConfig);

            _parallelConfig.CurrentPage.As<LoginPage>().EnterEmailID_EmployeeID("Venkatesh.yada@valuemomentum.com ");
            _parallelConfig.CurrentPage.As<LoginPage>().EnterPassword_TextBox("Venky@123");
            _parallelConfig.CurrentPage.As<LoginPage>().ClickSignIn();
        }

        [When(@"User should land on the Dashboard page after successful login")]
        public void WhenUserShouldLandOnTheDashboardPageAfterSuccessfulLogin()
        {
            _parallelConfig.CurrentPage = new LoginPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<LoginPage>().ChkDashboardTxt("Financial Institution Groups");
        }

        [Then(@"User should able to view the left navigation bar")]
        public void ThenUserShouldAbleToViewTheLeftNavigationBar()
        {
           _parallelConfig.CurrentPage=new LoginPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<LoginPage>().VerifyDashboardLeftLinks();

        }

        [Then(@"User should login to application succesfully")]
        public void ThenUserShouldLoginToApplicationSuccesfully()
        {
            _parallelConfig.CurrentPage = new LoginPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<LoginPage>().ChkDashboardTxt("Financial Institution Groups");
        }

    }
}
