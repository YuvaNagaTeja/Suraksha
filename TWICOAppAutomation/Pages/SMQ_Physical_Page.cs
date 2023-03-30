using CSharpAFProject.Base;
using CSharpAFProject.Helpers;
using OpenQA.Selenium;
using SurakshaAutomation.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SurakshaAutomation.Pages
{
    internal class SMQ_Physical_Page: BasePage
    {
        public SMQ_Physical_Page(ParallelConfig parallelConfig) : base(parallelConfig) { }


        private IWebElement SMQPhysicalHeading => _parallelConfig.Driver.FindElement(By.XPath("//*[text()='Physical SMQ']"));
        private IWebElement SMQDigitalHeading => _parallelConfig.Driver.FindElement(By.XPath("//*[text()='Digital SMQ']"));
        private IWebElement TotalNumberOfRecordsText => _parallelConfig.Driver.FindElement(By.XPath("//*[text()='Total number of SMQ Records']"));
        private IWebElement TotalNumberOfRecordsNumebr => _parallelConfig.Driver.FindElement(By.XPath("//*[text()='Total number of SMQ Records']/following-sibling::*"));
        private IWebElement PendingSMQRecordsText => _parallelConfig.Driver.FindElement(By.XPath("//*[text()='Pending SMQ Records']"));
        private IWebElement PendingSMQRecordsNumebr => _parallelConfig.Driver.FindElement(By.XPath("//*[text()='Pending SMQ Records']/following-sibling::*"));
        private IWebElement UploadBtn => _parallelConfig.Driver.FindElement(By.XPath("//*[text()='Pending SMQ Records']/following::div[@role='button'][1]"));
        private IWebElement AddFilterBtn => _parallelConfig.Driver.FindElement(By.XPath("//*[text()='Pending SMQ Records']/following::div[@role='button'][2]"));
        private IWebElement ExportToExcelBtn => _parallelConfig.Driver.FindElement(By.XPath("//*[text()='Pending SMQ Records']/following::div[@role='button'][3]"));
        private IWebElement UploadBoxInput => _parallelConfig.Driver.FindElement(By.Id("bulk-upload"));
        private IWebElement ImportBtn => _parallelConfig.Driver.FindElement(By.XPath("//*[text()=' Import ']"));
        private IWebElement SuccessfulMsg => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='drop-area']/following-sibling::div/child::span[1]"));


        public string GetPhysicalSMQTitle()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SMQPhysicalHeading);
            Log4NetHelper.Log("Getting Title for PhysicalSMQ", Log4Type.Info);
            return SMQPhysicalHeading.Text;
        }
        public string GetDigitalSMQTitle()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SMQDigitalHeading);
            Log4NetHelper.Log("Getting Title for DigitalSMQ", Log4Type.Info);
            return SMQDigitalHeading.Text;
        }

        public bool ValidateTotalNumberOfSMQRecords()
        {
            return TotalNumberOfRecordsNumebr.Displayed;
        }
        public bool ValidatePendingSMQRecords()
        {
            return PendingSMQRecordsNumebr.Displayed;
        }

        public void ClickOnUploadData()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, UploadBtn);
            UploadBtn.Click();
            Log4NetHelper.Log("Clicked on Upload Button", Log4Type.Info);
        }

        public void UploadFile()
        {
           // JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, UploadBoxInput);
            UploadBoxInput.SendKeys(AutomationSettings.SMQPhysicalDataPath);
            Log4NetHelper.Log("Clicked on upload zip File ", Log4Type.Info);
        }

        public void ClickonImportBtn()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ImportBtn);
            ImportBtn.Click();
            Log4NetHelper.Log("Clicked on import Button", Log4Type.Info);
        }

        public string GetSuccessfulMessage()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SuccessfulMsg);
            return SuccessfulMsg.Text;
        }

        public bool CheckPendingRecords()
        {
            return PendingSMQRecordsNumebr.Displayed;
        }


    }
}
