using CSharpAFProject.Base;
using CSharpAFProject.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SurakshaAutomation.Pages
{
    internal class SummaryPage : BasePage
    {
        private readonly ParallelConfig _parallelConfig;
        public SummaryPage(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }


        IWebElement declarationChkBox => _parallelConfig.Driver.FindElement(By.XPath("//input[@name='delaration']"));
        IWebElement GetOTP_VerifyviaAADHAARBtn => _parallelConfig.Driver.FindElement(By.XPath("//button[contains(text(),' Get OTP / Verify via AADHAAR ')]"));

        IWebElement ModalPopup => _parallelConfig.Driver.FindElement(By.XPath("//p[contains(text(),'Verify OTP')]"));
        IWebElement OTPTextBox1 => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='otpVerification-popup']/div/div/form/div/div/input[1]"));
        IWebElement OTPTextBox2 => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='otpVerification-popup']/div/div/form/div/div/input[2]"));
        IWebElement OTPTextBox3 => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='otpVerification-popup']/div/div/form/div/div/input[3]"));
        IWebElement OTPTextBox4 => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='otpVerification-popup']/div/div/form/div/div/input[4]"));
        IWebElement OTPTextBox5 => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='otpVerification-popup']/div/div/form/div/div/input[5]"));
        IWebElement OTPTextBox6 => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='otpVerification-popup']/div/div/form/div/div/input[6]"));

        IWebElement VerifyBtn => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='otpVerification-popup']//button[contains(text(),'Verify')]"));
        
        IWebElement SuccessfullMsg => _parallelConfig.Driver.FindElement(By.XPath("//p[contains(text(),'SMQ details successfully submitted')]"));
        IWebElement SuccessfullOkBtn => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='smqSuccess-popup']//button[contains(text(),'Ok')]"));



        public void SendOTPTextBox(string strOTP)
        {
            char[] chars = strOTP.ToCharArray();

            OTPTextBox1.SendKeys(chars[0].ToString());
            OTPTextBox2.SendKeys(chars[1].ToString());
            OTPTextBox3.SendKeys(chars[2].ToString());
            OTPTextBox4.SendKeys(chars[3].ToString());
            OTPTextBox5.SendKeys(chars[4].ToString());
            OTPTextBox6.SendKeys(chars[5].ToString());
            Log4NetHelper.Log("Entered Que5 Insurance Company Name ", Log4Type.Info);
        }

        public void ClickOnVerifyButton()
        {
            Thread.Sleep(3000);
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, VerifyBtn);
            Thread.Sleep(3000);
            VerifyBtn.Click();
            Log4NetHelper.Log("Click on Verify Button", Log4Type.Info);
        }
        public void ClickOnSuccessfullOkBtn()
        {
            Thread.Sleep(3000);
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SuccessfullOkBtn);
            Thread.Sleep(3000);
            SuccessfullOkBtn.Click();
            Log4NetHelper.Log("Click on Verify Button", Log4Type.Info);
        }


        public void ClickOnGetOTP_VerifyviaAADHAAR()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, GetOTP_VerifyviaAADHAARBtn);
            GetOTP_VerifyviaAADHAARBtn.Click();
            Log4NetHelper.Log("Clicked on OTP button ", Log4Type.Info);
        }

        public void CheckDeclaration(bool boolDeclaration)
        {
            Thread.Sleep(3000);
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, declarationChkBox);
            Thread.Sleep(3000);
            if (boolDeclaration)
            {
                declarationChkBox.Click();
                Log4NetHelper.Log("Selected Check Declaration ", Log4Type.Info);
            }

        }

        public string GetSuccessfullMsg()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SuccessfullMsg);
            return SuccessfullMsg.Text;
        }

        public string GetTitleofModalPopup()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ModalPopup);
            return ModalPopup.Text;
        }


    }
}
