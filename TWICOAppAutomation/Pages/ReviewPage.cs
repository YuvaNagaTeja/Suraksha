using CSharpAFProject.Base;
using CSharpAFProject.Extensions;
using CSharpAFProject.Helpers;
using OpenQA.Selenium;
using SurakshaAutomation.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SurakshaAutomation.Pages
{
    internal class ReviewPage : BasePage
    {
        private readonly ParallelConfig _parallelConfig;
        public ReviewPage(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        private IWebElement startBtn => _parallelConfig.Driver.FindElement(By.XPath("//button[contains(text(),'Start')]"));
        private IWebElement MsgTxt => _parallelConfig.Driver.FindElement(By.XPath("//span[contains(text(),'timed-out')]"));
        private IWebElement CtnMedicalDetailsbtn => _parallelConfig.Driver.FindElement(By.XPath("//button[contains(text(),' Continue to Medical Details ')]"));

        private IWebElement CtnSMQBtn => _parallelConfig.Driver.FindElement(By.XPath("//button[contains(text(),' Continue to SMQ ')]"));
        private IWebElement sumAssured => _parallelConfig.Driver.FindElement(By.XPath("(//p[text()='Sum Assured']/following-sibling::p)[1]"));

        public double GetSumAssured()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, sumAssured);
            Log4NetHelper.Log("Getting Sum Assured Amount", Log4Type.Info);
            return Convert.ToDouble(sumAssured.Text.Replace("₹",""));
        }


        public string CheckMsgTxt()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, MsgTxt, TimeSpan.FromSeconds(Convert.ToInt16(AutomationSettings.ExplicitWait)));
            return MsgTxt.Text;
        }

        public void ClickOnStartBtn()
        {

            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, startBtn, TimeSpan.FromSeconds(Convert.ToInt16(AutomationSettings.ExplicitWait)));
            if (startBtn.Displayed)
            {
                startBtn.Click();
            }
        }

        public void ClickOnCtnSMQBtn()
        {
            if (CtnSMQBtn.Displayed)
            {
                CtnSMQBtn.Click();
            }
        }
        public void ClickOnCtnMedicalDetailsbtn()
        {
            if (CtnMedicalDetailsbtn.Displayed)
            {
                CtnMedicalDetailsbtn.Click();
            }
        }



    }
}
