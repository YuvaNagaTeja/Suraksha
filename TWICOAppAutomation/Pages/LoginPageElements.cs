using CSharpAFProject.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SurakshaAutomation.Pages
{
    public  partial class LoginPage: BasePage
    {
        protected IWebElement Email_TextBox => _parallelConfig.Driver.FindElement(By.XPath("//input[@id='email']"));
        protected IWebElement ADFSUserName_TextBox => _parallelConfig.Driver.FindElement(By.XPath("//input[@id='userNameInput']"));
        protected IWebElement ADFSPassword_TextBox => _parallelConfig.Driver.FindElement(By.XPath("//input[@id='passwordInput']"));
        protected IWebElement Password_TextBox => _parallelConfig.Driver.FindElement(By.XPath("//input[@id='password']"));
        protected IWebElement SignIn_btn => _parallelConfig.Driver.FindElement(By.XPath("//button[@class='btn primary-button bold']"));
        protected IWebElement InvalidText => _parallelConfig.Driver.FindElementByXPath("//span[text()='Your Email ID is not registered with us. Kindly connect with your NRM']");
        protected IWebElement DashBoardTxt => _parallelConfig.Driver.FindElement(By.XPath("//p[text()='Financial Institution Groups']"));
        protected IList<IWebElement> DashboardLinks => _parallelConfig.Driver.FindElements(By.XPath("//*[@id='navbarSupportedContent']//ul//span"));
        protected IWebElement ADFSLoginBtn=> _parallelConfig.Driver.FindElement(By.XPath("//button[contains(text(),' ADFS Login ')]"));
        protected IWebElement ADFSSignInBtn=> _parallelConfig.Driver.FindElement(By.XPath("//span[contains(text(),'Sign in')]"));
        protected IWebElement LoginTxtVerify => _parallelConfig.Driver.FindElement(By.XPath("//*[text()='login']"));




    }
}
