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
    public class PaymentMethodPage : BasePage
    {
        public PaymentMethodPage(ParallelConfig parallelConfig) : base(parallelConfig) { }

       // public IWebElement AnnualPay => _parallelConfig.Driver.FindByXpath("//*[@id='annualPay']");
      //  public IWebElement FourPay => _parallelConfig.Driver.FindByXpath("//*[@id='fourInstallments']");
      //  public IWebElement PaymentNextButton => _parallelConfig.Driver.FindByCss(".col-sm-2 > .button");
    //    public IWebElement TenPay => _parallelConfig.Driver.FindByXpath("//*[@id='tenInstallments']");
        public IWebElement BillMe => _parallelConfig.Driver.FindByXpath("(//button[contains(text(),'Bill Me')])");
        public IWebElement BillInsured => _parallelConfig.Driver.FindByXpath("(//button[contains(text(),'Bill Insured')])");
        public IWebElement BillSomeone => _parallelConfig.Driver.FindByXpath("(//button[contains(text(),'Bill Someone Else')])");
        public IWebElement PaymentMethodPageText => _parallelConfig.Driver.FindByCss(".header-title");
        public IWebElement AnnualPay => _parallelConfig.Driver.FindByXpath("//*[@id='annualPay']//following::*[@class='custom-checkbox vertical-center']");//*[@id='annualPay']
        public IWebElement FourPay => _parallelConfig.Driver.FindByXpath("//*[@id='fourInstallments']//following::*[@class='custom-checkbox vertical-center']");//*[@id='fourInstallments']
        public IWebElement PaymentNextButton => _parallelConfig.Driver.FindByXpath("(//button[contains(text(),'Next')])"); //.col-sm-2 > .button
        public IWebElement TenPay => _parallelConfig.Driver.FindByXpath("//*[@id='tenInstallments']//following::*[@class='custom-checkbox vertical-center']");//*[@id='tenInstallments']

        public string VerifyPaymentMethodPage()
        {
            return PaymentMethodPageText.GetLinkText();
        }
        public void ClickBillMe()
        {
            Thread.Sleep(2000);
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, BillMe, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, BillMe);
            Log4NetHelper.Log("Clicked On Bill me Button  ", Log4Type.Info);
        }
        public void ClickBillInsured()
        {
            Thread.Sleep(2000);
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, BillInsured, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, BillInsured);
            Log4NetHelper.Log("Clicked On BillInsured Button  ", Log4Type.Info);
        }
        public BillingPage ClickBillSomeone()
        {
            Thread.Sleep(2000);
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, BillSomeone, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, BillSomeone);
            Log4NetHelper.Log("Clicked On BillSomeone Button  ", Log4Type.Info);
            return new BillingPage(_parallelConfig);
        }
        public void ClickAnnualPay()
        {        
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, AnnualPay, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, AnnualPay);
            Log4NetHelper.Log("Clicked On AnnualPay   ", Log4Type.Info);
        }
        public void ClickFourPay()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, FourPay, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, FourPay);
            Log4NetHelper.Log("Clicked On FourPay   ", Log4Type.Info);
        }
        public void ClickTenPay()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, TenPay, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, TenPay);
            Log4NetHelper.Log("Clicked On ten Pay   ", Log4Type.Info);
        }
        public PaymentProcessPage ClickPaymentNextButton()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, PaymentNextButton, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, PaymentNextButton);
            Log4NetHelper.Log("Clicked On PaymentNext Button   ", Log4Type.Info);
            return new PaymentProcessPage(_parallelConfig);
        }
    }
}
