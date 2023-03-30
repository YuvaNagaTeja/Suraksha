using CSharpAFProject.Base;
using CSharpAFProject.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SurakshaAutomation.Pages
{
    internal class LeftMenu : BasePage
    {
        private readonly ParallelConfig _parallelConfig;
        public LeftMenu(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }
        //public LeftMenu(ParallelConfig parallelConfig) : base(parallelConfig) { _parallelConfig = parellelConfig; }
        protected IWebElement Dashboardlink => _parallelConfig.Driver.FindElement(By.XPath("//*[text()='Dashboard']"));
        protected IWebElement CreateApplication => _parallelConfig.Driver.FindElement(By.XPath("//span[contains(text(),'Create application')]"));
        protected IWebElement PremiumCalculator => _parallelConfig.Driver.FindElement(By.XPath("//li[contains(text(),'Premium Calculator')]"));
        protected IWebElement MasterSetup => _parallelConfig.Driver.FindElement(By.XPath("//span[contains(text(),'Master Setup')]"));

        protected IWebElement PremiumCalculatorTitle => _parallelConfig.Driver.FindElement(By.XPath("//p[@class='h4 bolder text-muted mb-4']"));

        protected IWebElement BulkUploadLink => _parallelConfig.Driver.FindElement(By.XPath("//ul//*[@id='create-application']/div/ul/li[2]"));
        protected IWebElement ViewBulkUploadLink => _parallelConfig.Driver.FindElement(By.XPath("//ul//*[@id='create-application']/div/ul/li[3]"));
        protected IWebElement DownloadLink => _parallelConfig.Driver.FindElement(By.XPath("//ul//*[@id='create-application']/div/ul/li[4]"));
        protected IWebElement SMQLink => _parallelConfig.Driver.FindElement(By.XPath("//ul//*[@id='create-application']/following::*[6]"));
        protected IWebElement SMQDigital => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='smq']//ul//li[1]"));
        protected IWebElement SMQPhysical => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='smq']//ul//li[2]"));

        public void ClickonBulkUploadLink()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, BulkUploadLink);
            BulkUploadLink.Click();
            Log4NetHelper.Log("Clicked on Bulk Upload", Log4Type.Info);
        }
        public bool MasterSetupChk()
        {
            bool display = false;
            try
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, MasterSetup);
                if (MasterSetup.Displayed)
                {
                    display = true;
                }
            }
            catch (Exception)
            {

                
            }
          
            Log4NetHelper.Log(" Upload", Log4Type.Info);
            return display;
        }

        public void ClickonViewBulkUploadLink()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ViewBulkUploadLink);
            ViewBulkUploadLink.Click();
            Log4NetHelper.Log("Clicked on View Bulk Upload", Log4Type.Info);
        }

        public void ClickonDownloadLink()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, DownloadLink);
            DownloadLink.Click();
            Log4NetHelper.Log("Clicked on Download", Log4Type.Info);
        }

        public string GetPremiumCalculatorTitle()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PremiumCalculatorTitle);
            Log4NetHelper.Log("Getting the Premium calculator title", Log4Type.Info);
            return PremiumCalculatorTitle.Text;
        }


        public void ClickonCreateApplication()
        {
            CreateApplication.Click();
        }

        public void ClickonPremiumCalculator()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PremiumCalculator);
            PremiumCalculator.Click();
            Log4NetHelper.Log("Clicked on premium calculator", Log4Type.Info);
        }

        public void ClickonDashboardlink()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Dashboardlink);
            Dashboardlink.Click();
            Log4NetHelper.Log("Clicked on Dashboard link", Log4Type.Info);
        }

        public void ClickonSMQLink()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SMQLink);
            SMQLink.Click();
            Log4NetHelper.Log("Clicked on SMQ Drop Down Link", Log4Type.Info);
        }
        public void ClickonSMQPhysicalLink()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SMQPhysical);
            SMQPhysical.Click();
            Log4NetHelper.Log("Clicked on SMQ Physical Link", Log4Type.Info);
        }



        public void ClickonSMQDigitalLink()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SMQDigital);
            SMQDigital.Click();
            Log4NetHelper.Log("Clicked on SMQ Digital ink", Log4Type.Info);
        }

    }
}
