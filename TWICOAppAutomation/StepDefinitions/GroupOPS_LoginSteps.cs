using CSharpAFProject.Base;
using CSharpAFProject.Config;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;
using SurakshaAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace SurakshaAutomation.StepDefinitions
{
    [Binding]
    internal class GroupOPS_LoginSteps : BaseStep
    {

        private readonly ParallelConfig _parallelConfig;
        public GroupOPS_LoginSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        [Then(@"User should be able to login to application as Group Ops")]
        public void ThenUserShouldBeAbleToLoginToApplicationAsGroupOps()
        {
            _parallelConfig.CurrentPage = new LeftMenu(_parallelConfig);
            Assert.IsFalse(_parallelConfig.CurrentPage.As<LeftMenu>().MasterSetupChk());

        }

        [Then(@"Launch the browser and enter the Suraksha Portal url\.")]
        public void ThenLaunchTheBrowserAndEnterTheSurakshaPortalUrl_()
        {
            _parallelConfig.CurrentPage = new LoginPage(_parallelConfig);
            string _loginURL = (string)Settings.AUT;
            _parallelConfig.Driver.Navigate().GoToUrl(_loginURL);
        }
        //teja1.2
        [Then(@"Enter Email ID\.")]
        public void ThenEnterEmailID_()
        {
            _parallelConfig.CurrentPage = new LoginPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<LoginPage>().EnterEmailID_EmployeeID("Venkatesh.yada@valuemomentum.com");
        }
        //teja1.3
        [Then(@"Observe the screen")]
        public void ThenObserveTheScreen()
        {
            _parallelConfig.CurrentPage = new LoginPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<LoginPage>().loginTxtVerify();
            Thread.Sleep(3000);
        }

       

    }
}
