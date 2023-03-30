using CSharpAFProject.Base;
using CSharpAFProject.Extensions;
using CSharpAFProject.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;
using SurakshaAutomation.Data;

namespace SurakshaAutomation.Pages
{
    internal class BulkUploadPage : BasePage
    {
        private readonly ParallelConfig _parallelConfig;
        public BulkUploadPage(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        private IWebElement BulkUploadTitle => _parallelConfig.Driver.FindElement(By.XPath("//p[contains(text(),'Bulk Upload')]"));
        private IWebElement financialinstitutionDDL => _parallelConfig.Driver.FindElement(By.Id("financial-institution"));
        private IWebElement ImportDataBtn => _parallelConfig.Driver.FindElement(By.XPath("//button[contains(text(),'Import Data')]"));
        private IWebElement FileUpload => _parallelConfig.Driver.FindElement(By.Id("bulk-upload"));
        private IWebElement uploadExcelFileBtn => _parallelConfig.Driver.FindElement(By.Id("drop-area"));
        private IWebElement FUSuccessmgs => _parallelConfig.Driver.FindElement(By.XPath("//p[contains(text(),'File Upload Successful')]"));
        private IWebElement Fileuploadmsg => _parallelConfig.Driver.FindElement(By.XPath("//p[contains(text(),'Your file has been uploaded successfully.')]"));
        private IWebElement OkayButton => _parallelConfig.Driver.FindElement(By.XPath("//button[contains(text(),'Okay')]"));

        private IWebElement FI_Disabled => _parallelConfig.Driver.FindElement(By.XPath("//*[@class='form-control select-dropdown ng-untouched ng-pristine' and @disabled]"));
        public void CheckitisDisabled()
        {
            FI_Disabled.Click();
        }
        public string GetBulkUploadTitle()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, BulkUploadTitle);
            Log4NetHelper.Log("Clicked on Bulk Upload", Log4Type.Info);
            return BulkUploadTitle.Text;
        }


        public void SelectFIDDL(string strFinancialInstitution)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, financialinstitutionDDL);
            financialinstitutionDDL.SelectDropDownList(strFinancialInstitution);
            Log4NetHelper.Log("Selected Financial Institution", Log4Type.Info);
        }

        public void ClickOnImportDataBtn()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ImportDataBtn);
            ImportDataBtn.Click();
            Log4NetHelper.Log("Clicked on Bulk Upload", Log4Type.Info);
        }

        public void ClickOnuploadExcelFileBtn()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, uploadExcelFileBtn);
            FileUpload.SendKeys(BulkUploadData.BulkUploadFilePath);
            Log4NetHelper.Log("Clicked on upload Excel File ", Log4Type.Info);

        }
        public string FileUploadSuccessMsg() {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, FUSuccessmgs);
            Log4NetHelper.Log("Getting the succesfull message ", Log4Type.Info);
            return FUSuccessmgs.Text;
        }

        public string FileUploadStatusMsg()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Fileuploadmsg);
            Log4NetHelper.Log("Getting the succesfull message ", Log4Type.Info);
            return Fileuploadmsg.Text;
        }

        public void ClickOnOkayButton()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, OkayButton);
            OkayButton.Click();
            Log4NetHelper.Log("Click on Okay button", Log4Type.Info);
        }

    }
}
