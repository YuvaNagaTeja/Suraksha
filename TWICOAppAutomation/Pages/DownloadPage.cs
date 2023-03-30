using CSharpAFProject.Base;
using CSharpAFProject.Extensions;
using CSharpAFProject.Helpers;
using OpenQA.Selenium;
using SurakshaAutomation.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace SurakshaAutomation.Pages
{
    internal class DownloadPage : BasePage
    {
        private readonly ParallelConfig _parallelConfig;
        public DownloadPage(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }
        private IWebElement DownloadTitle => _parallelConfig.Driver.FindElement(By.XPath("//*[text()='Download']"));
        private IWebElement financialInstitutionddl => _parallelConfig.Driver.FindElement(By.Id("financial-institution"));
        private IWebElement regionddl => _parallelConfig.Driver.FindElement(By.Id("region"));
        private IWebElement branchddl => _parallelConfig.Driver.FindElement(By.Id("branch"));
        private IWebElement policyNoddl => _parallelConfig.Driver.FindElement(By.Id("policyNo"));
        private IWebElement fromDate => _parallelConfig.Driver.FindElement(By.Name("fromDate"));
        private IWebElement toDate => _parallelConfig.Driver.FindElement(By.Name("toDate"));
        private IWebElement loanidddl => _parallelConfig.Driver.FindElement(By.Id("loan-id"));
        private IWebElement docymentTypeddl => _parallelConfig.Driver.FindElement(By.Id("document-type"));
        private IWebElement searchBtn => _parallelConfig.Driver.FindElement(By.XPath("//button[contains(text(),'Search')]"));
        private IWebElement DownloadBtn => _parallelConfig.Driver.FindElement(By.XPath("//button[contains(text(),'Download')]"));



        private IWebElement Downloads => _parallelConfig.Driver.FindElement(By.XPath("//*[text()=' Downloads ']"));



        private IWebElement FI => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='financial-institution']"));
        private IWebElement Region => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='region']"));
        private IWebElement Branch => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='branch']"));
        private IWebElement PolicyNumber => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='policyNo']"));
        private IWebElement FromDate_downloadScr => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='from-date']"));
        private IWebElement ToDate_downloadScr => _parallelConfig.Driver.FindElement(By.XPath("//*[@name='toDate']"));
        private IWebElement DocumentType => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='document-type']"));
        // private IWebElement LoanIDs => _parallelConfig.Driver.FindElement(By.XPath(""));
        private IWebElement SearchButton => _parallelConfig.Driver.FindElement(By.XPath("//*[text()=' Search ']"));
        private IWebElement Name => _parallelConfig.Driver.FindElement(By.XPath("//*[text()='Name']"));
        private IWebElement LoanID => _parallelConfig.Driver.FindElement(By.XPath("//*[text()='Loan ID']"));



        private IWebElement DateOfCommencementOfLoan => _parallelConfig.Driver.FindElement(By.XPath("//*[text()=' Date of Commencement of loan ']"));
        private IWebElement DownloadButton => _parallelConfig.Driver.FindElement(By.XPath("//*[text()=' Download ']"));



        public string GetDownloadTitleText()
        {
            return DownloadTitle.Text;
        }

        public void SelectFinancialIns(string strFinInst)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, financialInstitutionddl);
            financialInstitutionddl.SelectDropDownList(strFinInst);
            Log4NetHelper.Log("Selected Financial Institution", Log4Type.Info);
        }
        public void SelectRegionDDL(string strRegion)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, regionddl);
            regionddl.SelectDropDownList(strRegion);
            Log4NetHelper.Log("Selected Region  ", Log4Type.Info);
        }

        public void SelectBranchDDL(string strBranch)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, branchddl);
            branchddl.SelectDropDownList(strBranch);
            Log4NetHelper.Log("Selected Branch   ", Log4Type.Info);
        }
        public void SelectPolicyNoDDL(string PolicyNumber)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, policyNoddl);
            policyNoddl.SelectDropDownList(PolicyNumber);
            Log4NetHelper.Log("Selected Policy No   ", Log4Type.Info);
        }

        public void FromDate(string strFromDate)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, fromDate);
            fromDate.SendKeys(strFromDate.ToString());
            Log4NetHelper.Log("Selected From Date ", Log4Type.Info);
        }
        public void ToDate(string strToDate)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, toDate);
            toDate.SendKeys(strToDate.ToString());
            Log4NetHelper.Log("Selected To Date", Log4Type.Info);
        }
        public void SelectDocumentType(string strDocumentType)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, docymentTypeddl);
            docymentTypeddl.SelectDropDownList(strDocumentType);
            Log4NetHelper.Log("Selected document type", Log4Type.Info);
        }

        public void SearchDownload(string strFinancialInstitution, string strRegion, string strBranch, string strPolicyNo, string strFromDate, string strToDate, string DocumentType)
        {

            SelectFinancialIns(strFinancialInstitution);
            SelectRegionDDL(strRegion);
            SelectBranchDDL(strBranch);
            SelectPolicyNoDDL(strPolicyNo);
            SelectPolicyNoDDL(strPolicyNo);
            FromDate(strFromDate);
            ToDate(strToDate);
            SelectDocumentType(DocumentType);

        }

        public void ClickonSearchBtn()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, searchBtn);

            Thread.Sleep(2000);
            if (searchBtn.Enabled)
            {
                searchBtn.Click();
            }
        }
        public void ClickonDownloadBtn()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, DownloadBtn);

            Thread.Sleep(2000);
            if (DownloadBtn.Enabled)
            {
                DownloadBtn.Click();
            }
        }

        public string GetFileNameExtension()
        {
            FileInfo DownloadednewestFile = DashboardPage.GetNewestFile(new DirectoryInfo(AutomationSettings.DownloadedexpectedFilePath));
            return DownloadednewestFile.Extension;
        }





        public void ClickOnDownloadsInLeftMenu()
        {
            Downloads.Click();
        }



        public void EnterAllMandatoryFieldsInDownloadScreen()
        {
            Thread.Sleep(1000);


            FI.SendKeys(DownloadScreenData.FIValue);
            Thread.Sleep(1000);
            Region.SendKeys(DownloadScreenData.RegionValue);
            Branch.SendKeys(DownloadScreenData.BranchValue);
            Thread.Sleep(1000);



            PolicyNumber.SendKeys(DownloadScreenData.PolicyNumber);
            FromDate_downloadScr.SendKeys(DownloadScreenData.FromDate);
            ToDate_downloadScr.SendKeys(DownloadScreenData.ToDate);
            Thread.Sleep(1000);



            DocumentType.SendKeys(DownloadScreenData.DocumentType);



            Thread.Sleep(1000);



            SearchButton.Click();
            Log4NetHelper.Log("Date entered in search filter in download screena and clicked on search button", Log4Type.Info);



        }
        public void ValidateHeaders()
        {
            Name.AssertElementPresent();
            LoanID.AssertElementPresent();
            DateOfCommencementOfLoan.AssertElementPresent();
            Log4NetHelper.Log("Validating Headers are present in DownloadScreen or not", Log4Type.Info);



        }
        public void clickOnDownload()
        {
            Thread.Sleep(2000);
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, DownloadButton);
            DownloadButton.Click();
            Log4NetHelper.Log("Clicked on Download Button", Log4Type.Info);
        }
    }
}


