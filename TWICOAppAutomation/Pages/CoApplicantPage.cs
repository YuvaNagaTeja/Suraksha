using CSharpAFProject.Base;
using CSharpAFProject.Extensions;
using CSharpAFProject.Helpers;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TWICOAppAutomation.Pages
{
   public class CoApplicantPage : BasePage
    {
        public CoApplicantPage(ParallelConfig parallelConfig) : base(parallelConfig) { }

        public IWebElement NoButton => _parallelConfig.Driver.FindByXpath("//button[contains(text(),'No')]");
        public IWebElement YesButton => _parallelConfig.Driver.FindByXpath("//button[contains(text(),'Yes')]");
        public IWebElement SpouseFirstName => _parallelConfig.Driver.FindByXpath("//input[@id='coappfirstname']");
        public IWebElement SpouseLastName => _parallelConfig.Driver.FindByXpath("//input[@id='coapplastname']");
        public IWebElement SpouseDob => _parallelConfig.Driver.FindByXpath("//input[@id='coappdob']");
        public IWebElement SpouseNext => _parallelConfig.Driver.FindByXpath("//button[@class='button']");
        public IWebElement CoapplicantPageText => _parallelConfig.Driver.FindByCss(".header-title");
        public IWebElement pointer => _parallelConfig.Driver.FindByXpath("//*[@class='pointer hamburger-wrapper']");
        public IWebElement Previous => _parallelConfig.Driver.FindByXpath("(//*[@class='hamburger-pane-item'])[1]");

        public string VerifyCoapplicantPage()
        {
            return CoapplicantPageText.GetLinkText();
        }
        public MailingAddressPage ClickNoBtn()
        {
            try
            {
                Thread.Sleep(2000);
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, NoButton);
                Log4NetHelper.Log("Clicked On NoButton button", Log4Type.Info);
            }
            catch(ElementNotVisibleException)
            {
                WaitHelper.FluentWaitForWebElement(_parallelConfig.Driver, NoButton);
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, NoButton);
                NoButton.Click();
                Log4NetHelper.Log("Clicked On NoButton button in catch", Log4Type.Info);
            }

            return new MailingAddressPage(_parallelConfig);
        }
        public void ClickYesButton()
        {
            try
            {
                Thread.Sleep(1500);
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, YesButton);
                Log4NetHelper.Log("Clicked On YesButton button", Log4Type.Info);

            }
            catch (ElementClickInterceptedException)
            {
                WaitHelper.FluentWaitForWebElement(_parallelConfig.Driver, YesButton);
                YesButton.Click();
                Log4NetHelper.Log("Clicked On YesButton button in Catch", Log4Type.Info);
            }
        }
        public void EnterSpouseFirstName(String fName)
        {
            SpouseFirstName.SendKeys(fName);
            Log4NetHelper.Log("Entered SpouseFirstName ", Log4Type.Info);
        }
        public void EnterSpouseLastname(String lName)
        {
            SpouseLastName.SendKeys(lName);
            Log4NetHelper.Log("Entered SpouseLastname ", Log4Type.Info);
        }
        public void EnterSpouseDOB(String dob)
        {
            SpouseDob.SendKeys(dob);
            Log4NetHelper.Log("Entered SpouseDOB ", Log4Type.Info);
        }
        public MailingAddressPage ClickSpouseButton()
        {
            try
            {
                Thread.Sleep(1000);
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, SpouseNext);
                Log4NetHelper.Log("Clicked On SpouseButton Button ", Log4Type.Info);
            }
            catch (ElementClickInterceptedException)
            {
                WaitHelper.FluentWaitForWebElement(_parallelConfig.Driver, SpouseNext);
                SpouseNext.Click();
                Log4NetHelper.Log("Clicked On SpouseButton Button in Catch ", Log4Type.Info);
            } 
            return new MailingAddressPage(_parallelConfig);
        }
        public IWebElement CustomizeVerification => _parallelConfig.Driver.FindByXpath("//*[contains(text(),'Customize Your Quote')]");
        // public IWebElement Previous => _parallelConfig.Driver.FindByXpath("//*[@class='nav-previous']");
        public CustomizeQuotePage PreviousButton()
        {
            try
            {
                Thread.Sleep(1500);
                if (pointer.Displayed)
                {
                    pointer.Click();
                    Previous.Click();
                }
                else
                {
                    Thread.Sleep(1500);
                    pointer.Click();
                    Previous.Click();
                    Thread.Sleep(1500);
                    Assert.IsTrue(CustomizeVerification.GetLinkText().Contains("Customize Your Quote"));
                }
                Log4NetHelper.Log("Clicked On PreviousButton Button ", Log4Type.Info);
            }
            catch (Exception)
            {
                Thread.Sleep(1000);
                pointer.Click();
                Thread.Sleep(1000);
                Previous.Click();
                Log4NetHelper.Log("Clicked On PreviousButton Button in Catch ", Log4Type.Info);
            }
            return new CustomizeQuotePage(_parallelConfig);
        }
    }
}