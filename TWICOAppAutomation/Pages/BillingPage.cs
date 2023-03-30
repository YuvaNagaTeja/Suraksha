using CSharpAFProject.Base;
using CSharpAFProject.Extensions;
using CSharpAFProject.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TWICOAppAutomation.Pages
{
    public class BillingPage : BasePage
    {
        public BillingPage(ParallelConfig parallelConfig) : base(parallelConfig) { }
        public IWebElement TitleCompany => _parallelConfig.Driver.FindByXpath("(//button[contains(text(),'Title Company Bill')])");
        public IWebElement EmailAddress => _parallelConfig.Driver.FindByXpath("//*[@id='email']");
        public IWebElement MortgageeBill => _parallelConfig.Driver.FindByXpath("(//button[contains(text(),'Mortgage Bill')])");
        public IWebElement BuyPolicyAssert => _parallelConfig.Driver.FindByXpath("//button[contains(text(),'Buy My Policy')]");

        public void TitleCompanyBill()
        {
            Thread.Sleep(1500);
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, TitleCompany);
            Log4NetHelper.Log("bill mortgagee is clicked ", Log4Type.Info);
        }
        public PaymentProcessPage EnterEmailAddress(string email)
        {
            EmailAddress.SendKeys(email);
            Log4NetHelper.Log(" Entered email as "+ email, Log4Type.Info);
            return new PaymentProcessPage(_parallelConfig);
        }

        public PaymentProcessPage ClickMortgageeBill()
        {
            try
            {
                Thread.Sleep(1500);
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, MortgageeBill);
                Assert.IsTrue(BuyPolicyAssert.GetLinkText().Contains("Buy My Policy"));
                Log4NetHelper.Log("bill mortgagee is clicked ", Log4Type.Info);
            }
            catch(Exception)
            {
                WaitHelper.FluentWaitForWebElement(_parallelConfig.Driver, MortgageeBill);
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, MortgageeBill);
                Log4NetHelper.Log("bill mortgagee is clicked in catch", Log4Type.Info);
            }
            return new PaymentProcessPage(_parallelConfig);
        }
    }
}
