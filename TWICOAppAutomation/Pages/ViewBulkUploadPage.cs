using CSharpAFProject.Base;
using CSharpAFProject.Extensions;
using CSharpAFProject.Helpers;
using iTextSharp.text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SurakshaAutomation.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SurakshaAutomation.Pages
{
    internal class ViewBulkUploadPage : BasePage
    {
        private readonly ParallelConfig _parallelConfig;
        public ViewBulkUploadPage(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        private IWebElement ViewBulkUploadTitle => _parallelConfig.Driver.FindElement(By.XPath("//p[contains(text(),'View Bulk Upload')]"));
        private IWebElement FinancialInstDDL => _parallelConfig.Driver.FindElement(By.Id("financial-institution"));
        private IWebElement jobIDTxt => _parallelConfig.Driver.FindElement(By.Id("jobID"));
        private IWebElement FromUploadDate => _parallelConfig.Driver.FindElement(By.Id("fromdate"));
        private IWebElement ToUploadDate => _parallelConfig.Driver.FindElement(By.Id("toDate"));
        private IWebElement LoadDataBtn => _parallelConfig.Driver.FindElement(By.XPath("//button[contains(text(),'Load Data')]"));
        private IWebElement downloadMedical => _parallelConfig.Driver.FindElement(By.XPath("//table[1]/tr[3]/td[4]"));
        private IWebElement downloadNonMedical => _parallelConfig.Driver.FindElement(By.XPath("//table[1]/tr[3]/td[5]"));
        private IWebElement downloadFailed => _parallelConfig.Driver.FindElement(By.XPath("//table[1]/tr[3]/td[6]"));
        private IWebElement hyperdownloadFailed => _parallelConfig.Driver.FindElement(By.XPath("//td[@class='failed text-decoration-line hover-pointer']"));
        private IWebElement hyperdownloadNonMedical => _parallelConfig.Driver.FindElement(By.XPath("//td[@class='success text-decoration-line hover-pointer']"));
        private IWebElement hyperdownloadMedical => _parallelConfig.Driver.FindElement(By.XPath("//td[@class='success text-decoration-line hover-pointer']"));
        public void ClickOnDownloadFailed()
        {
            int FailedCNT = 0;
            Thread.Sleep(3000);
            
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, downloadFailed);
            Thread.Sleep(3000);
            if (Convert.ToBoolean(ViewBulkUpload.DownloadFailed))
            {
                FailedCNT = Convert.ToInt16(downloadFailed.Text);
            }
            if (FailedCNT > 0)
            {
                downloadFailed.Click();
                Thread.Sleep(20000);
            }
            Log4NetHelper.Log("Download Failed", Log4Type.Info);
        }

        public void ClickOnDownloadMedical()
        {
            int MedicalCNT = 0;
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, downloadMedical);
            if (Convert.ToBoolean(ViewBulkUpload.DownloadMedical))
            {
                MedicalCNT = Convert.ToInt16(downloadMedical.Text);
            }
            if (MedicalCNT > 0)
            {
                downloadMedical.Click();
                Thread.Sleep(20000);

            }
            Log4NetHelper.Log("Download Medical", Log4Type.Info);
        }

        public void ClickOnDownloadNonMedical()
        {
            int NonMedicalCNT = 0;
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, downloadNonMedical);
            if (Convert.ToBoolean(ViewBulkUpload.DownloadNonMedical))
            {
                NonMedicalCNT = Convert.ToInt16(downloadNonMedical.Text);
            }
            if (NonMedicalCNT > 0)
            {
                downloadNonMedical.Click();
                Thread.Sleep(20000);
            }
            Log4NetHelper.Log("Download Non Medical", Log4Type.Info);


        }

        public string GetViewBulkUploadTitle()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ViewBulkUploadTitle);
            Log4NetHelper.Log("Clicked on Bulk Upload", Log4Type.Info);
            return ViewBulkUploadTitle.Text;
        }

        public void SelectFIDDL(string strFinancialInstitution)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, FinancialInstDDL);
            FinancialInstDDL.SelectDropDownList(strFinancialInstitution);
            Log4NetHelper.Log("Selected Financial Institution", Log4Type.Info);
        }

        public void FromDate(string fDate)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, FromUploadDate);
            FromUploadDate.SendKeys(fDate);
            Log4NetHelper.Log("Entered From Date", Log4Type.Info);
        }

        public void ToDate(string tDate)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ToUploadDate);
            ToUploadDate.SendKeys(tDate);
            Log4NetHelper.Log("Entered To Date", Log4Type.Info);
        }
        public void ClickOnLoadDataBtn()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, LoadDataBtn);
            LoadDataBtn.Click();
            Log4NetHelper.Log("Clicked on Load data button", Log4Type.Info);
        }

        public void EnterJobID(string JobId)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, jobIDTxt);
            jobIDTxt.SendKeys(JobId);
            Log4NetHelper.Log("Entered Job ID ", Log4Type.Info);

        }


    }
}
