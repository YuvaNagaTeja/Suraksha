using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using CSharpAFProject.Base;
using CSharpAFProject.Extensions;
using CSharpAFProject.Helpers;
using OpenQA.Selenium;

namespace TWICOAppAutomation.Pages
{
    public class TrustPage : BasePage
    {

        public TrustPage(ParallelConfig parallelConfig) : base(parallelConfig) { }

        public IWebElement TrustButton => _parallelConfig.Driver.FindByXpath("//span[contains(text(),'Select the Additional Insured type:')]//following::input[2]"); ///html/body/div/div/div[2]/div/form/div[1]/div/div[1]/div[2]/div[2]/md-radio-group/md-radio-button[2]/div[1]/div[1]
        public IWebElement TrustName => _parallelConfig.Driver.FindByXpath("//input[@id='trusteename'][1]");
        public IWebElement TrustAddress => _parallelConfig.Driver.FindByXpath("//input[@id='Address1'][1]");
        public IWebElement TrustCity => _parallelConfig.Driver.FindByXpath("//input[@id='city'][1]");
        public IWebElement TrustState => _parallelConfig.Driver.FindByXpath("//select[@id='state'][1]");
        public IWebElement TrustZip => _parallelConfig.Driver.FindByXpath("//input[@id='zipcode'][1]");
        public IWebElement AnotherInsuredButton => _parallelConfig.Driver.FindByXpath("//button[contains(text(),'Add Another Insured')][1]");
        public IWebElement PersonButton => _parallelConfig.Driver.FindByCss("#additionalInsured > div:nth-child(2) > div.row.row-med.top-pad-60 > span > span.right-pad-40 > input");
        public IWebElement AddPersonFirstName => _parallelConfig.Driver.FindByXpath("//input[@id='firstname']");
        public IWebElement AddPersonLastName => _parallelConfig.Driver.FindByXpath("//input[@id='lastname']");
        public IWebElement AddPersonAddress => _parallelConfig.Driver.FindByXpath("(//*[@id='Address1'])[2]");
        public IWebElement AddPersonCity => _parallelConfig.Driver.FindByXpath("(//*[@id='city'])[2]");
        public IWebElement AddPersonState => _parallelConfig.Driver.FindByXpath("(//*[@id='state'])[2]");
        public IWebElement AddPersonZip => _parallelConfig.Driver.FindByXpath("(//*[@id='zipcode'])[2]");
        public IWebElement PersonFirstName => _parallelConfig.Driver.FindByXpath("//*[@id='firstname']");
        public IWebElement PersonLastName => _parallelConfig.Driver.FindByXpath("//*[@id='lastname']");
        public IWebElement PersonAddress => _parallelConfig.Driver.FindByXpath("//*[@id='Address1']");
        public IWebElement PersonCity => _parallelConfig.Driver.FindByXpath("//*[@id='city']");
        public IWebElement PersonState => _parallelConfig.Driver.FindByXpath("//*[@id='state']");
        public IWebElement PersonZip => _parallelConfig.Driver.FindByXpath("//*[@id='zipcode']");
        public IWebElement NextButton => _parallelConfig.Driver.FindByXpath("//button[contains(text(),'Next')]");
        public IWebElement AddNextButton => _parallelConfig.Driver.FindByXpath("(//button[@type='submit'])[3]");
        public void ClickTrustButton()
        {
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, TrustButton);
                Log4NetHelper.Log("Clicked On  Trust Radio Button ", Log4Type.Info);
        }
        public void EnterTrustName(String name)
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, TrustName, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, TrustName);
            TrustName.SendKeys(name);
            Log4NetHelper.Log("Entered  TrustName ", Log4Type.Info);
        }
        public void EnterTrustAddress(String address)
        {
            TrustAddress.SendKeys(address);
            Log4NetHelper.Log("Entered  TrustAddress ", Log4Type.Info);
        }
        public void EnterTrustCity(String city)
        {
            TrustCity.SendKeys(city);
            Log4NetHelper.Log("Entered  Trustcity ", Log4Type.Info);
        }
        public void EnterTrustState(String state)
        {
            TrustState.SelectDropDownList(state);
            Log4NetHelper.Log("Selected  TrustState ", Log4Type.Info);
        }
        public void EnterTrustZip(String zip)
        {
            TrustZip.SendKeys(zip);
            Log4NetHelper.Log("Entered  TrustZip ", Log4Type.Info);
        }
        public void AnotherInsuredButtonClick()
        {
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, AnotherInsuredButton);
            Log4NetHelper.Log("Clicked On AnotherInsured Button ", Log4Type.Info);
        }
        public void ClickPersonButton()
        {
                Thread.Sleep(4000);
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PersonButton);
                PersonButton.Click();
                Log4NetHelper.Log("Clicked On Person Button ", Log4Type.Info);
        }
        public void EnterPersonFirstName(String fName)
        {
                PersonFirstName.SendKeys(fName);
        }
        public void EnterPersonLastName(String lName)
        {
            PersonLastName.SendKeys(lName);
            Log4NetHelper.Log("Entered PersonLastName ", Log4Type.Info);
        }
        public void EnterPersonAddress(String address)
        {
            PersonAddress.SendKeys(address);
            Log4NetHelper.Log("Entered Person address ", Log4Type.Info);
        }
        public void EnterPersonCity(String city)
        {
            PersonCity.SendKeys(city);
            Log4NetHelper.Log("Entered Person City ", Log4Type.Info);
        }
        public void EnterPersonState(String state)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PersonState);
            PersonState.SelectDropDownList(state);
            Log4NetHelper.Log("Entered Person State ", Log4Type.Info);
        }
        public void EnterPersonZip(String zip)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PersonZip);
            PersonZip.SendKeys(zip);
            Log4NetHelper.Log("Entered Person Zip ", Log4Type.Info);
        }


        public void EnterAddPersonFirstName(String fName)
        {
                AddPersonFirstName.SendKeys(fName);
                Log4NetHelper.Log("Entered PersonFirstName ", Log4Type.Info);
        }
        public void EnterAddPersonLastName(String lName)
        {
            AddPersonLastName.SendKeys(lName);
            Log4NetHelper.Log("Entered PersonLastName ", Log4Type.Info);
        }
        public void EnterAddPersonAddress(String address)
        {
            AddPersonAddress.SendKeys(address);
            Log4NetHelper.Log("Entered Person address ", Log4Type.Info);
        }
        public void EnterAddPersonCity(String city)
        {
            AddPersonCity.SendKeys(city);
            Log4NetHelper.Log("Entered Person City ", Log4Type.Info);
        }
        public void EnterAddPersonState(String state)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, AddPersonState);
            AddPersonState.SelectDropDownList(state);
            Log4NetHelper.Log("Entered Person State ", Log4Type.Info);
        }
        public void EnterAddPersonZip(String zip)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, AddPersonZip);
            AddPersonZip.SendKeys(zip);
            Log4NetHelper.Log("Entered Person Zip ", Log4Type.Info);
        }
        public SignedDocumentsPage ClickInsuredNext()
        {
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, NextButton);
            Log4NetHelper.Log("Clicked On Insured Next Button ", Log4Type.Info);
            return new SignedDocumentsPage(_parallelConfig);
        }
        public SignedDocumentsPage AddClickInsuredNext()
        {
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, AddNextButton);
            Log4NetHelper.Log("Clicked On Insured Next Button ", Log4Type.Info);
            return new SignedDocumentsPage(_parallelConfig);
        }
    }
}
