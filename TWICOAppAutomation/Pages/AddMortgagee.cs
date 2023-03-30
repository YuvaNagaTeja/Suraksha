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
    public class AddMortgagee : BasePage
    {
        public AddMortgagee(ParallelConfig parallelConfig) : base(parallelConfig) { }
        public IWebElement YesButton => _parallelConfig.Driver.FindByXpath("(//button[text()='Yes'])[2]");
        public IWebElement NoButton => _parallelConfig.Driver.FindByXpath("(//button[text()='No'])[2]");
        
        public InforAddMortgageePage ClickYesBtn()
        {
            try
            {
                Thread.Sleep(2000);
                WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, YesButton, TimeSpan.FromSeconds(10));
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, YesButton);
                Log4NetHelper.Log("Clicked On yes Button ", Log4Type.Info);
            }

            catch (Exception)
            {               
                WaitHelper.FluentWaitForWebElement(_parallelConfig.Driver, YesButton);
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, YesButton);
                YesButton.Click();
                Log4NetHelper.Log("Clicked On yes Button in catch ", Log4Type.Info);
            }
            return new InforAddMortgageePage(_parallelConfig);
        }
        public InsuredPage ClickNoBtn()
        {
            try
            {
                Thread.Sleep(2000);
                WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, NoButton, TimeSpan.FromSeconds(10));
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, NoButton);
                Log4NetHelper.Log("Clicked On no Button ", Log4Type.Info);
            }
            catch (Exception)
            {              
                WaitHelper.FluentWaitForWebElement(_parallelConfig.Driver, NoButton);
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, NoButton);
                NoButton.Click();
                Log4NetHelper.Log("Clicked On no Button in catch ", Log4Type.Info);
            }
            return new InsuredPage(_parallelConfig);
        }
    }
}
