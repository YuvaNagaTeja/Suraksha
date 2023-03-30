using CSharpAFProject.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using CSharpAFProject.Extensions;
using CSharpAFProject.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Linq;
using static iTextSharp.text.pdf.AcroFields;

namespace SurakshaAutomation.Pages
{
    public partial class LoginPage : BasePage
    {
        public LoginPage(ParallelConfig parallelConfig) : base(parallelConfig) { }


        public void EnterEmailID_EmployeeID(String EmailorEmpID)
        {
            Email_TextBox.SendKeys(EmailorEmpID);
            Log4NetHelper.Log("Entered Email ID \\ Employee ID ", Log4Type.Info);
        }
        public void EnterPassword_TextBox(String password)
        {
            Password_TextBox.SendKeys(password);
            Log4NetHelper.Log("Entered Password ", Log4Type.Info);
        }

        public void ClickSignIn()
        {
            SignIn_btn.Click();
            Log4NetHelper.Log("Click on Sign In button ", Log4Type.Info);
        }

        public void ClickADFSLoginButton()
        {
            ADFSLoginBtn.Click();
            Log4NetHelper.Log("Click on ADFS Login button ", Log4Type.Info);
        }

        public void ClickSignInButton()
        {
            ADFSSignInBtn.Click();
            Log4NetHelper.Log("Click on ADFS SignIn button ", Log4Type.Info);
        }

        public void ClickADFSUserName(string AdfsUserName )
        {

            ADFSUserName_TextBox.SendKeys(AdfsUserName);
            Log4NetHelper.Log("Entered Email ID \\ Employee ID ", Log4Type.Info);
        }

        public void ClickADFSPassword(string AdfsPassword)
        {

            ADFSPassword_TextBox.SendKeys(AdfsPassword);
            Log4NetHelper.Log("Entered Password", Log4Type.Info);
        }

        public void ChkLoginFailed(string ExpectedText)
        {
            Assert.AreEqual(ExpectedText, InvalidText.Text);
            Log4NetHelper.Log("Click on Sign In button ", Log4Type.Info);
        }
        public void ChkDashboardTxt(string ExpectedText)
        {
            Assert.AreEqual(ExpectedText, DashBoardTxt.Text);
        }

        public void VerifyDashboardLeftLinks()
        {
            string[] Expected_links = { "Dashboard1", "Create application1" };          
            Thread.Sleep(4000);
            bool linkstatus = false;
            for (int i = 0; i < Expected_links.Length ; i++)
            {
                foreach (IWebElement item in DashboardLinks)
                {
                   
                    if (string.IsNullOrEmpty(item.GetLinkText().ToString()))
                        if (item.GetLinkText().Equals(Expected_links[i]))
                        {
                           // Console.WriteLine("DashboardLinks : " + item.GetLinkText() + "   Expected_links[i] " + Expected_links[i]);

                            linkstatus = true; break;
                        }
                }
            }
            if (linkstatus)
            {
                Assert.Fail();
            }
            

        }

        public void loginTxtVerify()
        {
            string TxtVerify = LoginTxtVerify.Text;
            Assert.AreEqual("LOGIN", TxtVerify);
        }

    }
}
