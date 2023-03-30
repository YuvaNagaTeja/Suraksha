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
    public class PaymentProcessPage : BasePage
    {
        public PaymentProcessPage(ParallelConfig parallelConfig) : base(parallelConfig) { }
      //  public IWebElement BuyPolicy => _parallelConfig.Driver.FindByXpath("//button[contains(text(),'Buy My Policy')]");
        public IWebElement CreditCard => _parallelConfig.Driver.FindByXpath("//button[contains(text(),'Credit Card')]");
        public IWebElement ECheck => _parallelConfig.Driver.FindByXpath("//button[contains(text(),'ACH/eCheck')]");
        public IWebElement ECheckFirstName => _parallelConfig.Driver.FindByXpath("//*[@id='firstNameAch']");
        public IWebElement ECheckLastName => _parallelConfig.Driver.FindByXpath("//input[@id='lastNameAch']");
        public IWebElement ECheckRoutingNumber => _parallelConfig.Driver.FindByXpath("//input[@id='routingNumber']");
        public IWebElement ECheckAccountNumber => _parallelConfig.Driver.FindByXpath("//input[@id='accountNumber']");
        public IWebElement ECheckBankName => _parallelConfig.Driver.FindByXpath("//input[@id='bankName']");
        public IWebElement ECheckAccountType => _parallelConfig.Driver.FindByXpath("//select[@id='accountType']"); // dropdown
        public IWebElement ECheckRecurringPayment => _parallelConfig.Driver.FindByXpath("//input[@id='recurringAch']//following::*[@class='custom-checkbox vertical-center']"); //input[@id='recurringAch']                                                                                                               // public IWebElement NoticeToAgent => _parallelConfig.Driver.FindByXpath("//*[@id='termsAch']"); 
        public IWebElement BuyPolicy => _parallelConfig.Driver.FindByXpath("//button[contains(text(),'Buy My Policy')]");
        public IWebElement NoticeToAgent => _parallelConfig.Driver.FindByXpath("//*[@id='termsAch']//following::*[@class='custom-checkbox vertical-center']");
        public IWebElement PayIssue => _parallelConfig.Driver.FindByXpath("//*[@class='btn button-Payment']");
    
        public IWebElement CCNumber => _parallelConfig.Driver.FindById("cardNumber");
        public IWebElement CCFirstName => _parallelConfig.Driver.FindById("firstNameCC");
        public IWebElement CCLastName => _parallelConfig.Driver.FindById("lastNameCC");
        public IWebElement ExpirationDate => _parallelConfig.Driver.FindById("expirationDate");
        public IWebElement CVVNumber => _parallelConfig.Driver.FindById("cardCode");
        public IWebElement CCRecurringPayment => _parallelConfig.Driver.FindByXpath("//*[@id='recurringCC']//following::*[@class='custom-checkbox vertical-center']");
        public void ClickCreditCard()
        {
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, CreditCard);
            Log4NetHelper.Log("Clicked On CreditCard   ", Log4Type.Info);
        }
        public void EnterCCNumber(string ccNumber)
        {
            CCNumber.SendKeys(ccNumber);
            Log4NetHelper.Log("entered CC number   ", Log4Type.Info);
        }

        public void EnterCCFirstName(string ccFirstName)
        {
            CCFirstName.SendKeys(ccFirstName);
            Log4NetHelper.Log("entered CC FirstName   ", Log4Type.Info);
        }
        public void EnterCCLastName(string ccLastName)
        {
            CCLastName.SendKeys(ccLastName);
            Log4NetHelper.Log("entered CC LastName   ", Log4Type.Info);
        }
        
        public void EnterExpirationDate(string expirationDate)
        {
            ExpirationDate.SendKeys(expirationDate);
            Log4NetHelper.Log("entered Expiration Date   ", Log4Type.Info);
        }
        
        public void EnterCVVNumber(string cvvNumber)
        {
            CVVNumber.SendKeys(cvvNumber);
            Log4NetHelper.Log("entered CVV Number   ", Log4Type.Info);
        }
        
        public void CheckCCRecurringPayment()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, CCRecurringPayment, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, CCRecurringPayment);
            Log4NetHelper.Log("checked CC Recurring Payment ", Log4Type.Info);
        }
        public void ClickECheck()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, ECheck, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, ECheck); 
            Log4NetHelper.Log("Clicked On ECheck   ", Log4Type.Info);
        }
        public void EnterECheckFirstName(String firstName)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ECheckFirstName);
            ECheckFirstName.SendKeys(firstName);
            Log4NetHelper.Log("Entered ECheckFirstName   ", Log4Type.Info);
        }
        public void EnterECheckLastName(String lastName)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ECheckLastName);
            ECheckLastName.SendKeys(lastName);
            Log4NetHelper.Log("Entered ECheckLastName   ", Log4Type.Info);
        }
        public void EnterECheckRoutingNumber(String rollingNumber)
        {
            ECheckRoutingNumber.SendKeys(rollingNumber);
            Log4NetHelper.Log("Entered ECheckRollingNumber   ", Log4Type.Info);
        }
        public void EnterECheckAccountNumber(string accountNumber)
        {
            ECheckAccountNumber.SendKeys(accountNumber);
            Log4NetHelper.Log("Entered ECheckAccountNumber   ", Log4Type.Info);
        }
        public void EnterECheckBankName(String bankName)
        {
            ECheckBankName.SendKeys(bankName);
            Log4NetHelper.Log("Entered ECheckBankName   ", Log4Type.Info);
        }
        public void EnterECheckAccounttype(String accountType)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ECheckAccountType);
            ECheckAccountType.SelectDropDownList(accountType);
            Log4NetHelper.Log("Selected ECheckAccounttype   ", Log4Type.Info);
        }
        public void EnterECheckRecurringPayment()
        {
            Thread.Sleep(1000);
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, ECheckRecurringPayment);
            Log4NetHelper.Log("Entered ECheckRecurringPayment   ", Log4Type.Info);
        }
        
        public void ClickNoticeToAgent()
        {
         
            Thread.Sleep(1000);
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, NoticeToAgent);
            Log4NetHelper.Log("Clicked On NoticeToAgent   ", Log4Type.Info);
        }
        public PolicyIssuePage ClickBuyPolicy()
        {
            try
            {
                Thread.Sleep(1000);
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, BuyPolicy);
                BuyPolicy.Click();
            }
            catch(Exception)
            {
                Thread.Sleep(3000);
                WaitHelper.FluentWaitForWebElement(_parallelConfig.Driver, BuyPolicy);
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, BuyPolicy);
            }
            return new PolicyIssuePage(_parallelConfig);

        }
    }

}

