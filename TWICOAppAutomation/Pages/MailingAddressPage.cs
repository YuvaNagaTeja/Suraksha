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
   public class MailingAddressPage : BasePage
    {
        public MailingAddressPage(ParallelConfig parallelConfig) : base(parallelConfig) { }
        public IWebElement SameAddress => _parallelConfig.Driver.FindByXpath("//button[contains(text(),'Same')]");
        public IWebElement DifferentAddress => _parallelConfig.Driver.FindByXpath("//button[contains(text(),'Different')]");
        public IWebElement EnterMailAddress => _parallelConfig.Driver.FindByXpath("//input[@id='mailingAddress1']");
        public IWebElement EnterCity => _parallelConfig.Driver.FindByXpath("//input[@id='mailingcity']");
        public IWebElement EnterState => _parallelConfig.Driver.FindByXpath("//select[@id='mailingstate']");
        public IWebElement EnterZip => _parallelConfig.Driver.FindByXpath("//input[@id='mailingzipcode']");
        public IWebElement EnterReason => _parallelConfig.Driver.FindByXpath("//input[@id='diffmailingadd']");
        public IWebElement MailAddressButton => _parallelConfig.Driver.FindByXpath("//button[text()='Confirm']");
        public IWebElement MailingAddressPageText => _parallelConfig.Driver.FindByCss(".header-title");

        public string VerifyMailingAddressPage()
        {
            return MailingAddressPageText.GetLinkText();
        }
        public AddMortgagee ClickSameAddress()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, SameAddress, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, SameAddress);
              Log4NetHelper.Log("Clicked on SameAddress button", Log4Type.Info);
            return new AddMortgagee(_parallelConfig);
        }
        public void ClickDifferentAddress()
        {
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, DifferentAddress);
            Log4NetHelper.Log("Clicked on DifferentAddress button", Log4Type.Info);
        }
        public void EnterMailAddressForMail(String mailAddress)
        {
            EnterMailAddress.SendKeys(mailAddress);
            Log4NetHelper.Log("Entered MailAddressForMail ", Log4Type.Info);
        }
        public void EnterCityForMail(String city)
        {
            EnterCity.SendKeys(city);
            Log4NetHelper.Log("Entered CityForMail ", Log4Type.Info);
        }
        public void EnterStateForMail(String state)
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, EnterState, TimeSpan.FromSeconds(10));
            EnterState.SelectDropDownList(state);
            Log4NetHelper.Log("Entered DropDownList ", Log4Type.Info);
        }
        public void EnterZipForMail(String zip)
        {
            EnterZip.SendKeys(zip);
            Log4NetHelper.Log("Entered ZipForMail ", Log4Type.Info);
        }
        public void EnterReasonForMail(String reason)
        {
            EnterReason.SendKeys(reason);
            Log4NetHelper.Log("Entered ReasonForMail ", Log4Type.Info);
        }
        public AddMortgagee ClickMailAddress()
        {
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, MailAddressButton);
            Log4NetHelper.Log("Clicked MailAddress button ", Log4Type.Info);
            return new AddMortgagee(_parallelConfig);
        }

    }
}