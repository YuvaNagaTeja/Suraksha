using CSharpAFProject.Base;
using CSharpAFProject.Extensions;
using CSharpAFProject.Helpers;
using OpenQA.Selenium;
using SurakshaAutomation.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SurakshaAutomation.Pages
{
    internal class ActiveCasesPage : BasePage
    {
        public ActiveCasesPage(ParallelConfig parallelConfig) : base(parallelConfig) { }

        private IWebElement searchCategoryDDL => _parallelConfig.Driver.FindElement(By.Name("searchCategory"));
        private IWebElement loanNumberTxt => _parallelConfig.Driver.FindElement(By.Name("loanNumber"));
        private IWebElement searchBtn => _parallelConfig.Driver.FindElement(By.XPath("//button[@class='btn no-hover bold blue-accent']"));
        private IWebElement loanNumber => _parallelConfig.Driver.FindElement(By.XPath("//p[@class='mt-0 table-link']"));
        private IWebElement dateofBirthPrimaryInsuredlbl => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='insurer-details-content-1']/div[1]/div[1]/p/span"));
        private IWebElement dateofbirthTxt => _parallelConfig.Driver.FindElement(By.Name("date-of-birth"));
        private IWebElement authenticateBtn => _parallelConfig.Driver.FindElement(By.XPath("//button[@class='btn primary-button'][1]"));
        private IWebElement searchResultSMQStatus => _parallelConfig.Driver.FindElement(By.XPath("//tr[2]/td[13]"));
        private IWebElement searchResultUnderWritingDecision => _parallelConfig.Driver.FindElement(By.XPath("//tr[2]/td[9]"));
        private IWebElement CustomerIdTextBox => _parallelConfig.Driver.FindElement(By.XPath("(//input[@name='customerId'][@type='text'])[1]"));
        public string GetResultUnderWritingDecision()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, searchResultUnderWritingDecision);
            return searchResultUnderWritingDecision.Text;
        }

        public string GetResultSMQStatus()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, searchResultSMQStatus);
            return searchResultSMQStatus.Text;
        }

        public void SearchCategoryDDL(string Category)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, searchCategoryDDL);
            searchCategoryDDL.SelectDropDownList(Category);
            Log4NetHelper.Log("Selected Category  ", Log4Type.Info);
        }

        public void LoanNumberTxt(string loanNumber)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, loanNumberTxt);
            loanNumberTxt.SendKeys(loanNumber);
            Log4NetHelper.Log("Selected LoanNumber  ", Log4Type.Info);
        }

        public void ClickSearchButton()
        {
            searchBtn.Click();
        }
        public void ClickloanNumberSearchResult()
        {
            Thread.Sleep(2000);
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, loanNumber);
            Thread.Sleep(2000);
            if (loanNumber.Displayed)
            {
                loanNumber.Click();
            }
        }
        public string GetdateofBirthPrimaryInsuredlbl()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, dateofBirthPrimaryInsuredlbl, TimeSpan.FromSeconds(Convert.ToInt16(AutomationSettings.ExplicitWait)));
            return dateofBirthPrimaryInsuredlbl.Text;
        }

        public void EnterDateofBirth(string dateofbirth)
        {
            dateofbirthTxt.SendKeys(dateofbirth.Replace("/", "-"));
            Thread.Sleep(10000);
        }
        public void ClickAuthenticateButton()
        {
            authenticateBtn.Click();
        }

        public void CustomerIDTxt(string CustomerId)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, CustomerIdTextBox);
            CustomerIdTextBox.SendKeys(CustomerId);
            Log4NetHelper.Log("Selected CustomerId  ", Log4Type.Info);
        }

    }
}
