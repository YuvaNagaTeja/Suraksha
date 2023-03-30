using CSharpAFProject.Base;
using CSharpAFProject.Config;
using CSharpAFProject.ExcelReader;
using CSharpAFProject.Extensions;
using CSharpAFProject.Helpers;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TWICOAppAutomation.Pages
{
    public class ValidatePage : BasePage
    {
        public ValidatePage(ParallelConfig parallelConfig) : base(parallelConfig) { }
        public IWebElement OkButton => _parallelConfig.Driver.FindByXpath("//button[text()='Okay']");//button[text()='Okay']
        public IWebElement ValidationPageHeaderText => _parallelConfig.Driver.FindByXpath("//div[@class='title']");
        public IWebElement DownLoadPolicyPacket => _parallelConfig.Driver.FindByXpath("(//div/div/img)[1]");
        string fileName = Environment.CurrentDirectory.ToString() + Settings.ExcelFileNamePath;
        public void OKButton()
        {
                try
                {
                    Thread.Sleep(30000);
                    if (OkButton.Displayed)
                        JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, OkButton);
                        OkButton.Click();
                }
                catch (ElementNotVisibleException)
                {
                    Thread.Sleep(10000);
                    JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, OkButton);
                OkButton.Click();
            }
        }
        

        internal void VerifyPolicyIssued()
        {
            WaitHelper.WaitForWebElement(_parallelConfig.Driver, ValidationPageHeaderText, TimeSpan.FromSeconds(60));
            Assert.IsTrue(ValidationPageHeaderText.GetLinkText().Contains("Welcome to The Twico Family!"));
        }

        public void policypdf1(string text)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, DownLoadPolicyPacket);
            WaitHelper.WaitForWebElement(_parallelConfig.Driver, DownLoadPolicyPacket, TimeSpan.FromSeconds(70));
            Thread.Sleep(2000);
            PDFHelper.Extractor(DownLoadPolicyPacket, text, "PolicyPacket");
            Log4NetHelper.Log("Is verified sucessfully", Log4Type.Info);
        }

    }
}
