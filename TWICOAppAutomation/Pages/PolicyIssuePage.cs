using CSharpAFProject.Base;
using CSharpAFProject.Extensions;
using CSharpAFProject.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TWICOAppAutomation.Pages
{
    public class PolicyIssuePage : BasePage
    {
        public PolicyIssuePage(ParallelConfig parallelConfig) : base(parallelConfig) { }

        public IWebElement ConfirmButton => _parallelConfig.Driver.FindByXpath("(//button[contains(text(),'Confirm')])");
        public ValidatePage PolicySubmitButton()
        {
            try
            {
                Thread.Sleep(2000);
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ConfirmButton);
                ConfirmButton.Click();
                Log4NetHelper.Log("Clicked on Submit");
            }
            catch (Exception)
            {
                Thread.Sleep(2000);
                WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, ConfirmButton, TimeSpan.FromSeconds(10));
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, ConfirmButton);
                Log4NetHelper.Log("Clicked on Submit in catch");
            }
           
            return new ValidatePage(_parallelConfig);
        }
    }
}
