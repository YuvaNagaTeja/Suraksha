using CSharpAFProject.Base;
using CSharpAFProject.Extensions;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CSharpAFProject.Helpers;
using OpenQA.Selenium;
using System;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TWICOAppAutomation.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(ParallelConfig parallelConfig) : base(parallelConfig) { }
        public IWebElement AddressTextBox => _parallelConfig.Driver.FindByXpath("//input[@id='addressInput']");
        public IWebElement Findbutton => _parallelConfig.Driver.FindByXpath("//button[contains(text(),'Find')]");
        public IWebElement ChooseButton => _parallelConfig.Driver.FindByXpath("//button[contains(text(),'Choose')]");
        public IWebElement AgentLogin => _parallelConfig.Driver.FindByCss(".nav-login");
        public IWebElement LoginId => _parallelConfig.Driver.FindByXpath("//input[@name='email']");
        public IWebElement LoginPassword => _parallelConfig.Driver.FindByXpath("//input[@name='password']");
        public IWebElement LoginButton => _parallelConfig.Driver.FindByXpath("//button[contains(text(),'Login')]");
        public IWebElement OKButton => _parallelConfig.Driver.FindByXpath("//button[contains(.,'OK')]");
        public IWebElement effectivedate => _parallelConfig.Driver.FindByXpath("//*[contains(text(),' What date would you like to begin coverage? ')]");
        public IWebElement html => _parallelConfig.Driver.FindElementByTagName("html");

        public void ZoomOut()
        {
            Actions action = new Actions(_parallelConfig.Driver);
            IJavaScriptExecutor executor = (IJavaScriptExecutor)_parallelConfig.Driver;
            executor.ExecuteScript("document.body.style.zoom = '0.75'");
        }

        public void ClickAgentLogin()
        {
            Thread.Sleep(2000);
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, AgentLogin);
            Log4NetHelper.Log("Click AgentLogin  ", Log4Type.Info);
        }
        public void EnterLoginId(string id)
        {
            LoginId.SendKeys(id);
            Log4NetHelper.Log("Entered LoginId as " + id, Log4Type.Info);
        }

        public void EnterLoginPassword(string password)
        {
            LoginPassword.SendKeys(password);
            Log4NetHelper.Log("Entered LoginPassword as " + password, Log4Type.Info);
        }

        public void ClickLoginButton()
        {
            try
            {
                Thread.Sleep(2000);
                LoginButton.Click();
                Log4NetHelper.Log("Click LoginButton  ", Log4Type.Info);
            }
            catch (Exception)
            {
             
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, LoginButton);
            }
        
        }
        public void ClickOKButton()
        {
            Thread.Sleep(2000);
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, OKButton);
            Log4NetHelper.Log("Click OKButton  ", Log4Type.Info);
        }

        public void EnterAddress(string address)
        {
            Thread.Sleep(2000);
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, AddressTextBox);
            AddressTextBox.SendKeys(address);
            Log4NetHelper.Log("Entered Address as " + address, Log4Type.Info);
        }
            public EffectiveDatePage ClickFindbutton()
            {
                try
                {
                    Thread.Sleep(1000);
                    WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, Findbutton, TimeSpan.FromSeconds(60));
                    JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Findbutton);
                    Findbutton.Click();
                    Thread.Sleep(3000);
                Assert.IsTrue(effectivedate.GetLinkText().Contains("What date would you like to begin coverage?"));
                Log4NetHelper.Log("find button is clicked ", Log4Type.Info);
                }
                catch (Exception)
                {
                   
                    WaitHelper.FluentWaitForWebElement(_parallelConfig.Driver, Findbutton);
                    JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, Findbutton);
                    Log4NetHelper.Log("find button is clicked in catch", Log4Type.Info);
                }
                return new EffectiveDatePage(_parallelConfig);
            }


        } 
}

