using CSharpAFProject.Base;
using CSharpAFProject.Extensions;
using CSharpAFProject.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Protractor;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TWICOAppAutomation.Pages
{
    public class CreditsPage : BasePage
    {
        public CreditsPage(ParallelConfig parallelConfig) : base(parallelConfig) { }
        public IWebElement YearPurchased => _parallelConfig.Driver.FindByXpath("//*[@id='creditsYearPurchased']");
        public IWebElement WiringReplaced => _parallelConfig.Driver.FindById("wiringYearUpdated");
        public IWebElement PlumbingReplaced => _parallelConfig.Driver.FindById("plumbingYearUpdated");
        public IWebElement HeatingReplaced => _parallelConfig.Driver.FindById("heatingYearUpdated");
        public IWebElement PopUpWindow => _parallelConfig.Driver.FindByCss("ngb-modal-window div:nth-child(1) > img");
        public IWebElement AffinityGroup => _parallelConfig.Driver.FindById("affinityGroupId");
        public IWebElement ProtectiveDevicesLocal => _parallelConfig.Driver.FindByXpath("//*[@id='protLocalFireBurg']//following::*[@class='custom-checkbox vertical-center']");
        public IWebElement ProtectiveDevicesDeadBolts => _parallelConfig.Driver.FindByXpath("//*[@id='protDeadbolts']//following::*[@class='custom-checkbox vertical-center']");
        public IWebElement SmokeDetectors => _parallelConfig.Driver.FindByXpath("//*[@id='protSmokeDetector']//following::*[@class='custom-checkbox vertical-center']");
        public IWebElement ProtectveDeviceMotionDetectors => _parallelConfig.Driver.FindByXpath("//*[@id='protMotionDetector']//following::*[@class='custom-checkbox vertical-center']");
        public IWebElement CentralMonitoredFire => _parallelConfig.Driver.FindByXpath("//*[@id='protCentralFireBurg']//following::*[@class='custom-checkbox vertical-center']");
        public IWebElement Smokers => _parallelConfig.Driver.FindByCss("#smokers .md-bar");
        public IWebElement ClickAuto => _parallelConfig.Driver.FindByXpath("//*[@id='compAuto']");
        public IWebElement ClickFlood => _parallelConfig.Driver.FindByXpath("//*[@id='compFlood']");
        public IWebElement ClickUmbrella => _parallelConfig.Driver.FindByXpath("//*[@id='compUmbrella']");
        public IWebElement Gated => _parallelConfig.Driver.FindByXpath("//label[contains(text(),'Is the residence in a gated neighborhood with a 24-hour guard?')]//parent::div//following::span[2]");
        public IWebElement ClickNextBtn => _parallelConfig.Driver.FindByXpath("(//button[@class='button'])[3]");
        public IWebElement CreditsPageText => _parallelConfig.Driver.FindByCss(".header-title");
        public IWebElement OptionsPageText => _parallelConfig.Driver.FindByXpath("//*[contains(text(),'Choose Your Package')]");
        public IWebElement AccreditedBuilders => _parallelConfig.Driver.FindByXpath("//*[@id='accreditedBuilderId']");
        public IWebElement SelectWiringReplaced => _parallelConfig.Driver.FindByXpath("//label[contains(text(),'Has the wiring in your home been updated or the circuit breaker panel been checked by an electrician?')]//parent::div//following::span[2]");
        public IWebElement SelectPlumbingReplaced => _parallelConfig.Driver.FindByXpath("//label[contains(text(),'Has the plumbing in your home been updated?')]//parent::div//following::span[2]");// 
        public IWebElement SelectHeatingReplaced => _parallelConfig.Driver.FindByXpath("//label[contains(text(),'Has the heating in your home been updated?')]//parent::div//following::span[2]");//
            public void SelectAccreditedBuilders(string accBuilders)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, AccreditedBuilders);
            AccreditedBuilders.SelectDropDownList(accBuilders);
            Log4NetHelper.Log("Accredited Builders  is selected" + accBuilders, Log4Type.Info);
        }
        public void PopUpWindowClick()
        {
            Thread.Sleep(2000);
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, PopUpWindow);
            Log4NetHelper.Log("popup is clicked ", Log4Type.Info);
        }
        public void EnterYearPurchased(String yearPurchased)
        {
            try
            {
                Thread.Sleep(2500);
                if (YearPurchased.Displayed)
                    YearPurchased.SendKeys(yearPurchased);
                Log4NetHelper.Log("yearpurchased is entered "+ yearPurchased, Log4Type.Info);
            }
            catch (ElementNotVisibleException)
            {
                WaitHelper.FluentWaitForWebElement(_parallelConfig.Driver, YearPurchased);
                YearPurchased.Clear();
                if (YearPurchased.Displayed)
                    YearPurchased.SendKeys(yearPurchased);
                Log4NetHelper.Log("in catch yearpurchased is entered " + yearPurchased, Log4Type.Info);
               
            }
        }

        public void ClickWiringReplaced()
        {
            Thread.Sleep(1500);
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, SelectWiringReplaced);
            Log4NetHelper.Log("popup is clicked ", Log4Type.Info);
        }

        public void ClickPlumbingReplaced()
        {
            Thread.Sleep(1500);
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, SelectPlumbingReplaced);
            Log4NetHelper.Log("popup is clicked ", Log4Type.Info);
        }
        public void ClickHeatingReplaced()
        {
            Thread.Sleep(1500);
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, SelectHeatingReplaced);
            Log4NetHelper.Log("popup is clicked ", Log4Type.Info);
        }
        public void EnterPlumbingReplaced(String plumbingReplaced)
        {
                Thread.Sleep(1500);
                PlumbingReplaced.SendKeys(plumbingReplaced);
                Log4NetHelper.Log("plumbingReplaced is entered " + plumbingReplaced, Log4Type.Info);
        }
        public void EnterWiringReplaced(String wiringReplaced)
        {
                Thread.Sleep(1500);
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, WiringReplaced);
                WiringReplaced.SendKeys(wiringReplaced);
                Log4NetHelper.Log("wiringReplaced is entered " + wiringReplaced, Log4Type.Info);
        }
        public void EnterHeatingReplaced(String heatingReplaced)
        {
                Thread.Sleep(1500);
                HeatingReplaced.SendKeys(heatingReplaced);
                Log4NetHelper.Log("heatingReplaced is entered " + heatingReplaced, Log4Type.Info);
        }
        public void BusinessOrProfessionalGroup(string selectAffinityGroup)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, AffinityGroup);
            AffinityGroup.SelectDropDownList(selectAffinityGroup);
            Log4NetHelper.Log("AffinityGroup is entered " + selectAffinityGroup, Log4Type.Info);
        }
        public void Local()
        {
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, ProtectiveDevicesLocal);
            Log4NetHelper.Log(" Protective Devices Local  is selected", Log4Type.Info);
        }
        public void MotionDetectors()
        {
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, ProtectveDeviceMotionDetectors);
            Log4NetHelper.Log(" ProtectveDeviceMotionDetectors  is selected", Log4Type.Info);
        }
        public void DeadBolts()
        {
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, ProtectiveDevicesDeadBolts);
            Log4NetHelper.Log(" Protective Devices DeadBolts  is selected", Log4Type.Info);
        }
        public void SelectSmokeDetectors()
        {
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, SmokeDetectors);
            Log4NetHelper.Log(" Protective Devices DeadBolts  is selected", Log4Type.Info);
        }
        public void SelectCentralMonitoredFire()
        {
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, CentralMonitoredFire);
            Log4NetHelper.Log(" Protective Devices DeadBolts  is selected", Log4Type.Info);
        }

        public void ClickSmokers()
        {
            if (Smokers.Displayed)
                Smokers.Click();
        }
        public void SelectAuto(string auto)
        {
            ClickAuto.SelectDropDownList(auto);
            Log4NetHelper.Log("auto policy  is selected"+ auto, Log4Type.Info);
        }

        public void SelectFlood(string flood)
        {
            ClickFlood.SelectDropDownList(flood);
            Log4NetHelper.Log("flood policy  is selected" + flood, Log4Type.Info);
        }

        public void SelectUmbrella(string umbrella)
        {
            ClickUmbrella.SelectDropDownList(umbrella);
            Log4NetHelper.Log("umbrella policy  is selected" + umbrella, Log4Type.Info);
        }

        public void ClickGated()
        {
            Thread.Sleep(1500);
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, Gated);
            Log4NetHelper.Log("gated is selected", Log4Type.Info);
        }

      public ChoosePackagePage ClickNextButton()
        {
            try
            {
                Thread.Sleep(2000);
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ClickNextBtn);
                ClickNextBtn.Click();
                Thread.Sleep(1500);
                Assert.IsTrue(OptionsPageText.GetLinkText().Contains("Choose Your Package"));
                Log4NetHelper.Log("next button is clicked", Log4Type.Info);
            }
            catch (Exception)
            {
                WaitHelper.FluentWaitForWebElement(_parallelConfig.Driver, ClickNextBtn);
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, ClickNextBtn);
                Log4NetHelper.Log("in catch next button is clicked", Log4Type.Info);
            }
            return new ChoosePackagePage(_parallelConfig);
        }
    }
}
