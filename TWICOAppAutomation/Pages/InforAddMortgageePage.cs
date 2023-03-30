using CSharpAFProject.Base;
using CSharpAFProject.Extensions;
using CSharpAFProject.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TWICOAppAutomation.Pages
{
   public class InforAddMortgageePage : BasePage
    {
        public InforAddMortgageePage(ParallelConfig parallelConfig) : base(parallelConfig) { }

        public IWebElement NameOfMort => _parallelConfig.Driver.FindByXpath("(//input[@id='mort1name'])[1]");
        public IWebElement AddressOfMort => _parallelConfig.Driver.FindByXpath("(//input[@id='mort1Address1'])[1]");
        public IWebElement CityOfMort => _parallelConfig.Driver.FindByXpath("(//input[@id='mort1city'])[1]");
        public IWebElement StateOfMort => _parallelConfig.Driver.FindByXpath("(//select[@id='mort1state'])[1]");
        public IWebElement ZipCodeOfMort => _parallelConfig.Driver.FindByXpath("(//input[@id='mort1zipcode'])[1]");
        public IWebElement LoanMort => _parallelConfig.Driver.FindByXpath("(//input[@id='mort1loannumber'])[1]");
        public IWebElement AdditionalMortButton => _parallelConfig.Driver.FindByXpath("//button[contains(text(),'Add Another Mortgagee')]");
        public IWebElement AdditionalNameOfMort => _parallelConfig.Driver.FindByXpath("(//input[@id='mort1name'])[2]");
        public IWebElement AdditionalAddressOfMort => _parallelConfig.Driver.FindByXpath("(//input[@id='mort1Address1'])[2]");
        public IWebElement AdditionalCityOfMort => _parallelConfig.Driver.FindByXpath("(//input[@id='mort1city'])[2]");
        public IWebElement AdditionalStateOfMort => _parallelConfig.Driver.FindByXpath("(//select[@id='mort1state'])[2]");
        public IWebElement AdditionalZipCodeOfMort => _parallelConfig.Driver.FindByXpath("(//input[@id='mort1zipcode'])[2]");
        public IWebElement AdditionalLoanMort => _parallelConfig.Driver.FindByXpath("(//input[@id='mort1loannumber'])[2]");
        public IWebElement ClickNextButton => _parallelConfig.Driver.FindByXpath("(//button[contains(text(),'Next')])[1]");
        public IWebElement AddClickNextButton => _parallelConfig.Driver.FindByXpath("//*[@id='mortgageeSection']//following::button[@type='submit']");

        public void EnterNameOfMort(String name)
        {
            Thread.Sleep(1500);
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, NameOfMort);
            NameOfMort.SendKeys(name);
            Log4NetHelper.Log("Entered NameOfMort ", Log4Type.Info);
        }
        public void EnterAddressOfMort(String address)
        {
            AddressOfMort.SendKeys(address);
            Log4NetHelper.Log("Entered AddressOfMort ", Log4Type.Info);
        }
        public void EnterCityOfMort(String city)
        {
            CityOfMort.SendKeys(city);
            Log4NetHelper.Log("Entered CityOfMort ", Log4Type.Info);
        }
        public void EnterStateOfMort(String state)
        {
            StateOfMort.SelectDropDownList(state);
        }
        public void EnterZipcodeOfMort(String zipCode)
        {
            ZipCodeOfMort.SendKeys(zipCode);
            Log4NetHelper.Log("Entered ZipcodeOfMort ", Log4Type.Info);
        }
        public void EnterLoanMort(String loan)
        {
            LoanMort.SendKeys(loan);
            Log4NetHelper.Log("Entered LoanMort ", Log4Type.Info);
        }
        public void ClickAdditionalMortButton()
        {
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, AdditionalMortButton);
            Log4NetHelper.Log("Clicked On AdditionalMort Button ", Log4Type.Info);
        }
        public void EnterAdditionalNameOfMort(String name)
        {
            AdditionalNameOfMort.SendKeys(name);
            Log4NetHelper.Log("Entered AdditionalNameOfMort ", Log4Type.Info);
        }
        public void EnterAdditionalAddressOfMort(String address)
        {
            AdditionalAddressOfMort.SendKeys(address);
            Log4NetHelper.Log("Entered AdditionalAddressOfMort ", Log4Type.Info);
        }
        public void EnterAdditionalCityOfMort(String city)
        {
            AdditionalCityOfMort.SendKeys(city);
            Log4NetHelper.Log("Entered AdditionalCityOfMort ", Log4Type.Info);
        }
        public void EnterAdditionalStateOfMort(String state)
        {
            AdditionalStateOfMort.SelectDropDownList(state);
            Log4NetHelper.Log("Selected AdditionalStateOfMort ", Log4Type.Info);
        }
        public void EnterAdditionalZipcodeOfMort(String zipCode)
        {
            AdditionalZipCodeOfMort.SendKeys(zipCode);
            Log4NetHelper.Log("Entered AdditionalZipcodeOfMort ", Log4Type.Info);
        }
        public void EnterAdditionalLoanMort(String loan)
        {
            AdditionalLoanMort.SendKeys(loan);
            Log4NetHelper.Log("Entered AdditionalLoanMort ", Log4Type.Info);
        }
        public InsuredPage ClickMortNextBtn()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, ClickNextButton, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, ClickNextButton);
            Log4NetHelper.Log("Clicked On MortNextBtn Button ", Log4Type.Info);
            return new InsuredPage(_parallelConfig);
        }
        public InsuredPage ClickAddMortNextBtn()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, AddClickNextButton, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, AddClickNextButton);
            Log4NetHelper.Log("Clicked On MortNextBtn Button ", Log4Type.Info);
            return new InsuredPage(_parallelConfig);
        }

    }
}


