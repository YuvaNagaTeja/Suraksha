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
    public class InsuredPage : BasePage
    {
        public InsuredPage(ParallelConfig parallelConfig) : base(parallelConfig) { }
        public IWebElement NoInsured => _parallelConfig.Driver.FindByXpath("(//button[contains(text(),'No')])[3]");
        public IWebElement YesInsured => _parallelConfig.Driver.FindByXpath("(//button[contains(text(),'Yes')])[3]");
        public SignedDocumentsPage ClickNoInsured()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, NoInsured, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, NoInsured);
            Log4NetHelper.Log("Clicked On  NoInsured Button ", Log4Type.Info);
            return new SignedDocumentsPage(_parallelConfig);
        }
        public TrustPage ClickYesInsured()
        {
            try
            {
                Thread.Sleep(1500);
                WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, YesInsured, TimeSpan.FromSeconds(10));
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, YesInsured);
                Log4NetHelper.Log("Clicked On  yes Insured Button ", Log4Type.Info);
            }catch(ElementNotVisibleException)
            {
                WaitHelper.FluentWaitForWebElement(_parallelConfig.Driver, YesInsured);
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, YesInsured);
                YesInsured.Click();
                Log4NetHelper.Log("Clicked On  yes Insured Button in catch ", Log4Type.Info);
            }
            return new TrustPage(_parallelConfig);
        }
    }
}