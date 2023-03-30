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
    public class SignedDocumentsPage : BasePage
    {
        
        public SignedDocumentsPage(ParallelConfig parallelConfig) : base(parallelConfig) { }
        public IWebElement ProducerStatement => _parallelConfig.Driver.FindByXpath("//*[@id='coverage']//following::*[@class='custom-checkbox vertical-center']");
        public IWebElement InsuredEmailButton => _parallelConfig.Driver.FindByXpath("//*[@value='email']");
        public IWebElement InsuredEmailText => _parallelConfig.Driver.FindByXpath("//*[@id='email']");
        public IWebElement AgentPrint => _parallelConfig.Driver.FindByXpath("//*[@value='print']");
        public IWebElement ClickNextButton => _parallelConfig.Driver.FindByXpath("//*[@id='btnContinue']");
        public IWebElement SignedDocumentsPageText => _parallelConfig.Driver.FindByCss(".header-title");
        public IWebElement ConfirmButton => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Signed Documents ')]//parent::div//following::button");
        public void ClickAgentPrint()
        {
            Thread.Sleep(1500);
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, AgentPrint, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, AgentPrint);
            Log4NetHelper.Log("Clicked on AgentPrint button ", Log4Type.Info);
        }
        public void ClickProducerStatement()
        {
            Thread.Sleep(1500);
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, ProducerStatement, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, ProducerStatement);
            Log4NetHelper.Log("Clicked on ProducerStatement button ", Log4Type.Info);
        }
        public void ClickInsuredEmailButton()
        {
            Thread.Sleep(1500);
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, InsuredEmailButton, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, InsuredEmailButton);
            Log4NetHelper.Log("Clicked on InsuredEmailButton ", Log4Type.Info);
        }
        public void EnterInsuredEmailText(string putEmail)
        {
            Thread.Sleep(1500);
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, InsuredEmailText, TimeSpan.FromSeconds(10));
            InsuredEmailText.SendKeys(putEmail);
            Log4NetHelper.Log("Enter InsuredEmail Text", Log4Type.Info);
        }
        public PaymentMethodPage ClickConfirmButton()
        {
            try
            {
                Thread.Sleep(1500);
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, ConfirmButton);
                Log4NetHelper.Log("Clicked on confirm button ", Log4Type.Info);
            }
            catch (NoSuchElementException)
            {
                Thread.Sleep(2000);
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, ConfirmButton);
                Log4NetHelper.Log("Clicked on confirm button in catch", Log4Type.Info);
            }
            return new PaymentMethodPage(_parallelConfig);
        }
    }
}
