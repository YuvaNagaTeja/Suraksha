using CSharpAFProject.Base;
using CSharpAFProject.Extensions;
using CSharpAFProject.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace TWICOAppAutomation.Pages
{
    public class EffectiveDatePage : BasePage

    {
        public EffectiveDatePage(ParallelConfig parallelConfig) : base(parallelConfig) { }
        public IWebElement ChooseButton => _parallelConfig.Driver.FindByXpath("(//button[contains(text(),'Choose')])");
        public IWebElement PopupAddress => _parallelConfig.Driver.FindByXpath("//input[@id='notFoundAddress1']");
        public IWebElement PopupCity => _parallelConfig.Driver.FindByXpath("//input[@id='notFoundCity']");
        public IWebElement PopupState => _parallelConfig.Driver.FindByXpath("//select[@id='notFoundState']");
        public IWebElement PopupZip => _parallelConfig.Driver.FindByXpath("//input[@id='notFoundZip']");
        public IWebElement PopupCountry => _parallelConfig.Driver.FindByXpath("//select[@id='notFoundCounty']");
        public IWebElement PopupFind => _parallelConfig.Driver.FindByXpath("//*[@id='notFoundCounty']//following::button");
        public IWebElement PPCPopup => _parallelConfig.Driver.FindByXpath("//*[@id='hydrantDistance']");
        public IWebElement effectivedate => _parallelConfig.Driver.FindByXpath("//*[contains(text(),' What date would you like to begin coverage? ')]");
        public void VerifyPPCPopup()
        {
            Assert.IsTrue(PPCPopup.Displayed);
        }

        public void EnterPopupAddress(String address)
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, PopupAddress, TimeSpan.FromSeconds(10));
            PopupAddress.SendKeys(address);
            Log4NetHelper.Log("PopupAddress is entered " + address, Log4Type.Info);
        }
        public void EnterPopupCity(String city)
        {
            PopupCity.SendKeys(city);
            Log4NetHelper.Log("PopupCity is entered " + city, Log4Type.Info);
        }
        public void EnterPopupState(String state)
        {
            PopupState.SelectDropDownList(state);
            Log4NetHelper.Log("PopupState is entered " + state, Log4Type.Info);
        }

        public void EnterPopupZip(String zip)
        {
            PopupZip.SendKeys(zip);
            Log4NetHelper.Log("PopupZip is entered " + zip, Log4Type.Info);
        }
        public void EnterPopupCountry(String country)
        {
            PopupCountry.SelectDropDownList(country);
            Log4NetHelper.Log("PopupCountry is entered " + country, Log4Type.Info);
        }
        public void ClickPopupFind()
        {
            try
            {
                Thread.Sleep(1500);
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, PopupFind);
                Thread.Sleep(1000);
               
            }
            catch (Exception)
            { 
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PopupFind);
                PopupFind.Click();
              
            }
        }

        public DeclinationsPage ClickChooseButton()
        {
            try
            {
                Thread.Sleep(3500);
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ChooseButton);
                ChooseButton.Click();
                Log4NetHelper.Log("Choose button is clicked ", Log4Type.Info);
            }
            catch (Exception)
            {
                Thread.Sleep(2000);
                effectivedate.Click();
                WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, ChooseButton, TimeSpan.FromSeconds(10));
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, ChooseButton);
                Log4NetHelper.Log("Choose button is clicked in catch  ", Log4Type.Info);
            }
            return new DeclinationsPage(_parallelConfig);
        }
    }
}

