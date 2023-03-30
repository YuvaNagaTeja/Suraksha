using CSharpAFProject.Base;
using CSharpAFProject.Extensions;
using CSharpAFProject.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

namespace TWICOAppAutomation.Pages
{
   public class ClientPage : BasePage
    {
        public ClientPage(ParallelConfig parallelConfig) : base(parallelConfig) { }

        public IWebElement ClientFirstName => _parallelConfig.Driver.FindById("clientFirstName");
        public IWebElement ClientLastName => _parallelConfig.Driver.FindById("clientLastName");
        public IWebElement ClientPhone => _parallelConfig.Driver.FindById("clientPhone");
        public IWebElement ClientEmail => _parallelConfig.Driver.FindById("clientEmail");
        public IWebElement ClientDate => _parallelConfig.Driver.FindById("dob");
        public IWebElement ClickNextBtn => _parallelConfig.Driver.FindByXpath("(//button[@class='button'])[1]");
        public IWebElement ElectronicButton => _parallelConfig.Driver.FindByXpath("//input[@id='radioFlgEmailOptionElectronic']");//radiobutton
        public IWebElement MailButton => _parallelConfig.Driver.FindByXpath("//*[@id='radioFlgEmailOptionMail']");//radiobutton
        public IWebElement ClientPageText => _parallelConfig.Driver.FindByXpath("//*[@class='title']");
        public void VerifyClientPage()
        {
            Thread.Sleep(1500);
            Assert.IsTrue(ClientPageText.GetLinkText().Contains("Named Insured Primary Occupant"));
            //return ClientPageText.GetLinkText();
        }
        public void EnterClientFirstName(String fName)
        {
            WaitHelper.WaitForWebElement(_parallelConfig.Driver, ClientFirstName, TimeSpan.FromSeconds(60));
            ClientFirstName.SendKeys(fName);
            Log4NetHelper.Log("firstname is entered "+fName, Log4Type.Info);
        }

        public void EnterClientLastName(String lName)
        {
            ClientLastName.SendKeys(lName);
            Log4NetHelper.Log("lastname is entered " + lName, Log4Type.Info);
        }

        public void EnterClientPhone(String phone)
        {
            ClientPhone.SendKeys(phone);
            Log4NetHelper.Log("phone is entered " + phone, Log4Type.Info);
        }

        public void EnterClientEmail(String email)
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, ClientEmail, TimeSpan.FromSeconds(10));
            ClientEmail.SendKeys(email);
            Log4NetHelper.Log("email is entered " + email, Log4Type.Info);
        }
        
        public void EnterClientDate(String date)
        {
            ClientDate.SendKeys(date);
            Log4NetHelper.Log("date is entered " + date, Log4Type.Info);
        }

        public void ClickElectronicButton()
        {
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, ElectronicButton);
            Log4NetHelper.Log("ElectronicButton is clicked ", Log4Type.Info);
        }
        public void ClickMailButton()
        {
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, MailButton);
            Log4NetHelper.Log("MailButton is clicked ", Log4Type.Info);
        }
        public InformationNeededPage ClickNextButton()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, ClickNextBtn, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, ClickNextBtn);
            return new InformationNeededPage(_parallelConfig);
        }

    }
}

