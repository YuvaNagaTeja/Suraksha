using CSharpAFProject.Base;
using CSharpAFProject.ExcelReader;
using CSharpAFProject.Extensions;
using CSharpAFProject.Helpers;
using Gherkin.Ast;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SurakshaAutomation.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using Assert = NUnit.Framework.Assert;

namespace SurakshaAutomation.Pages
{
    internal class DashboardPage : BasePage
    {
        public DashboardPage(ParallelConfig parallelConfig) : base(parallelConfig) { }


        IWebElement dashBoardTitle => _parallelConfig.Driver.FindElement(By.XPath("//p[@class='h5 bold']"));
        IWebElement activeCases => _parallelConfig.Driver.FindElement(By.XPath("//div[@routerlink='total-active-cases']//span[@class='blue-accent h6 bold m-0 half-count']"));
        IWebElement OngoingMedicalCases => _parallelConfig.Driver.FindElement(By.XPath("//div[@routerlink='ongoing-medical-cases']//span[@class='blue-accent h6 bold m-0 half-count']"));
        IWebElement firstrecord => _parallelConfig.Driver.FindElement(By.XPath("//table[1]/tr[2]/td[2]/p[2]"));
        IWebElement BorrowerDetailsTab => _parallelConfig.Driver.FindElement(By.XPath("//a[contains(text(),'Borrower Details')]"));
        IWebElement BorrowerAddressTab => _parallelConfig.Driver.FindElement(By.XPath("//a[contains(text(),\"Borrower's Address\")]"));
        IWebElement NomineeDetailsTab => _parallelConfig.Driver.FindElement(By.XPath("//a[contains(text(),'Nominee Details')]"));
        IWebElement AppointeeDetailsTab => _parallelConfig.Driver.FindElement(By.XPath("//a[contains(text(),'Appointee Details')]"));
        IWebElement loanIdlbl => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='borrowers-details-content-2']/div/div[1]/p/span"));
        IWebElement BorrowerDetailsTabTitle => _parallelConfig.Driver.FindElement(By.XPath("//span[@class='h6 bolder text-dark mb-0' and contains(text(),\"Borrower's Details\")]"));
        IWebElement BorrowerAddressTabTitle => _parallelConfig.Driver.FindElement(By.XPath("//span[@class='h6 bolder text-dark mb-0' and contains(text(),\"Address Details\")]"));
        IWebElement Nominee1DetailsTabTitle => _parallelConfig.Driver.FindElement(By.XPath("//span[@class='h6 bolder text-dark mb-0' and contains(text(),\"Nominee 1 Details\")]"));
        IWebElement AppointeeDetailsTabTitle => _parallelConfig.Driver.FindElement(By.XPath("//span[@class='h6 bolder text-dark mb-0' and contains(text(),\"Appointee Details\")]"));
        IWebElement downloadExcelBtn => _parallelConfig.Driver.FindElement(By.XPath("//div[@class='h-45px export-button d-flex flex-row align-items-center' and @role='button']"));

        IWebElement TotalActiveCasesTitle => _parallelConfig.Driver.FindElement(By.XPath("//*[text()='Total Active Cases']"));
        IWebElement OnGoingMedicalRecordTitle => _parallelConfig.Driver.FindElement(By.XPath("(//*[text()='Ongoing Medical Cases'])[1]"));
        IWebElement SearchCategoryDDL => _parallelConfig.Driver.FindElement(By.Name("searchCategory"));
        IWebElement ScearchByTitle => _parallelConfig.Driver.FindElement(By.XPath("//*[text()='Search by'] "));
        IWebElement ScearchBoxTitle => _parallelConfig.Driver.FindElement(By.XPath("//*[text()=' Search ']"));
        IWebElement AddFilterTitle => _parallelConfig.Driver.FindElement(By.XPath("//*[text()='Add Filter']"));
        IWebElement ViewTitle => _parallelConfig.Driver.FindElement(By.XPath("//span[text()='View']"));
        IWebElement ExportTitle => _parallelConfig.Driver.FindElement(By.XPath("//*[text()='Export']"));


        IWebElement SMQ => _parallelConfig.Driver.FindElement(By.XPath("(//*[@class=\"d-flex flex-row justify-content-between align-items-center\"])[2]"));
        IWebElement SMQDigitalDashboard => _parallelConfig.Driver.FindElement(By.XPath("//*[text()=' SMQ Digital Dashboard ']"));
        IWebElement SMQPhysicalDashboard => _parallelConfig.Driver.FindElement(By.XPath("//*[text()=' SMQ Physical Dashboard ']"));
        IWebElement LoanNumberLink => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='recent-customer-cases']/div/table/tr[2]/td[2]/p[2]/a"));
        public string GetTitle()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, dashBoardTitle);
            Log4NetHelper.Log("Get Title ", Log4Type.Info);
            return dashBoardTitle.Text;
        }

        public void ClickonActiveCases()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, activeCases);
            Thread.Sleep(3000);
            activeCases.Click();
            Log4NetHelper.Log("Click on Active Cases ", Log4Type.Info);
        }

        public void ClickonOnGoingMedicalCases()
        {
            Thread.Sleep(4000);
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, OngoingMedicalCases);
            OngoingMedicalCases.Click();
            Log4NetHelper.Log("Click on Ongoing Medical Cases", Log4Type.Info);
        }

        public void ClickonDownloadExcelBtn()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, downloadExcelBtn);
            downloadExcelBtn.Click();
            Log4NetHelper.Log("Click on Excel download ", Log4Type.Info);
        }

        public void ClickonFirstRecord()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, firstrecord);
            firstrecord.Click();
            Log4NetHelper.Log("Click on First Active record ", Log4Type.Info);
        }

        public void ClickonBorrowerDetailsTab()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, BorrowerDetailsTab);
            BorrowerDetailsTab.Click();
            Log4NetHelper.Log("Click on Borrower Details Tab ", Log4Type.Info);
        }

        public void ClickonBorrowerAddressTab()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, BorrowerAddressTab);
            BorrowerAddressTab.Click();
            Log4NetHelper.Log("Click on Borrower Address Tab ", Log4Type.Info);
        }
        public void ClickonNomineeDetailsTab()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, NomineeDetailsTab);
            NomineeDetailsTab.Click();
            Log4NetHelper.Log("Click on Nominee Details Tab ", Log4Type.Info);
        }

        public void ClickonAppointeeDetailsTab()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, AppointeeDetailsTab);
            AppointeeDetailsTab.Click();
            Log4NetHelper.Log("Click on Appointee Details Tab ", Log4Type.Info);
        }




        public string GetSearchLoadID()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, firstrecord);
            Log4NetHelper.Log("Get Loan Id ", Log4Type.Info);
            return firstrecord.Text;
        }
        public string GetLoadID()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, loanIdlbl);
            Log4NetHelper.Log("Get Loan Id ", Log4Type.Info);
            return loanIdlbl.Text;
        }

        public void DownloadFile()
        {
            string strError;
            FileInfo DownloadednewestFile = GetNewestFile(new DirectoryInfo(AutomationSettings.DownloadedexpectedFilePath));
            string Downloadedsheetname = AutomationSettings.Downloadedsheetname;
            string Downloadedcolumn = AutomationSettings.Downloadedcolumn;

            string MasterFilePath = AutomationSettings.BulkUploadErrorList;
            string Mastersheetname = AutomationSettings.Mastersheetname;
            string Mastercolumn = AutomationSettings.Mastercolumn;

            System.Data.DataTable DownloadedExcelData = ExcelReaderHelper.GetDataTable(DownloadednewestFile.FullName, Downloadedsheetname);

            for (int i = 1; i < DownloadedExcelData.Rows.Count; i++)
            {
                for (int j = 0; j < DownloadedExcelData.Columns.Count; j++)
                {
                    string colName = DownloadedExcelData.Rows[0][j].ToString();
                    if (colName.Equals(Downloadedcolumn))
                    {
                        strError = DownloadedExcelData.Rows[i][j].ToString();
                        Assert.IsTrue(compareErrors(MasterFilePath, Mastersheetname, Mastercolumn, strError));
                        if (strError == null)
                            throw new Exception("Value your trying to enter is empty for " + colName);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        public bool compareErrors(string filepath, string sheetname, string Downloadedcolumn, string ExpectedErr)
        {
            bool status = false;
            System.Data.DataTable MasterTbl = ExcelReaderHelper.GetDataTable(filepath, sheetname);
            for (int i = 0; i < MasterTbl.Rows.Count; i++)
            {
                for (int j = 0; j < MasterTbl.Columns.Count; j++)
                {
                    string colName = MasterTbl.Rows[0][j].ToString();
                    if (colName.Equals(Downloadedcolumn))
                    {
                        if (MasterTbl.Rows[i][j].ToString().Equals(ExpectedErr))
                        {
                            status = true;
                        };
                    }
                }
            }
            return status;
        }

        public string GetFileFullName()
        {

            FileInfo DownloadednewestFile = GetNewestFile(new DirectoryInfo(AutomationSettings.DownloadedexpectedFilePath));

            return DownloadednewestFile.FullName;
        }

        public static FileInfo GetNewestFile(DirectoryInfo directory)
        {
            return directory.GetFiles()
                .Union(directory.GetDirectories().Select(d => GetNewestFile(d)))
                .OrderByDescending(f => (f == null ? DateTime.MinValue : f.LastWriteTime))
                .FirstOrDefault();
        }


        public bool firstRecord()
        {

            return firstrecord.Displayed;
        }
        public void verifytext()
        {
            Assert.AreEqual("Total Active Cases", TotalActiveCasesTitle.Text);
            Assert.AreEqual("Ongoing Medical Cases", OnGoingMedicalRecordTitle.Text);
        }

        public bool CategoryListCheck()
        {
            var CheckList = AutomationSettings.CategoryList.Split(",");
            bool found = false; JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SearchCategoryDDL);
            SelectElement ddl = new SelectElement(SearchCategoryDDL);
            for (int i = 0; i < CheckList.Length; i++)
            {
                SearchCategoryDDL.SelectDropDownList(CheckList[i]);
                found = true;
            }
            Log4NetHelper.Log("Verrifing Region  ", Log4Type.Info);
            return found;
        }
        public void SearchbyDDL()
        {
            SelectElement option = new SelectElement(SearchCategoryDDL);
            for (int i = 1; i < option.Options.Count; i++)
            {
                option.SelectByIndex(i);
                Thread.Sleep(1000);
            }
        }


        //TC01_Nikhila 
        public void verifying_Dashboard_contents()
        {
            Assert.AreEqual("Search by", ScearchByTitle.Text);
            Assert.AreEqual("Search", ScearchBoxTitle.Text);
            Assert.AreEqual("Add Filter", AddFilterTitle.Text);
            Assert.AreEqual("View", ViewTitle.Text);
            Assert.AreEqual("Export", ExportTitle.Text);
        }


        //TC02_Nikhila

        public void verifyLoanNumbershouldBeLink()
        {
            string tagname = LoanNumberLink.TagName;
            //firstrecord.IsElementPresent();
            Assert.AreEqual("a", tagname);
        }

        public int GetDownloadedFileRowsCount()
        {
            int count = 0;
            string filepath = GetFileFullName();
            count = ExcelReaderHelper.GetTotalRows(filepath, "Sample Report");
            return count;
        }

        public int GetOngoingMedicalCount()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, OngoingMedicalCases);
            string count = OngoingMedicalCases.Text;
            return Convert.ToInt32(count);
        }



        public void clickOnSMQPhysicalDashboard()
        {
            SMQ.Click();
            SMQPhysicalDashboard.Click();
        }
        public void clickOnSMQDigitalDashboard()
        {
            Thread.Sleep(3000);
            SMQDigitalDashboard.Click();
            Thread.Sleep(2000);
        }

    }
}
