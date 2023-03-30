using CSharpAFProject.Base;
using CSharpAFProject.Extensions;
using CSharpAFProject.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TWICOAppAutomation.Pages
{
   public class DeclinationsPage : BasePage
    {
        public DeclinationsPage(ParallelConfig parallelConfig) : base(parallelConfig) { }
      
        public IWebElement HomeIsRented => _parallelConfig.Driver.FindByXpath("(//span[@class='custom-checkbox vertical-center'])[1]");
        public IWebElement UnrepairedDamage => _parallelConfig.Driver.FindByXpath("(//span[@class='custom-checkbox vertical-center'])[2]");
        public IWebElement UnderConstruction => _parallelConfig.Driver.FindByXpath("(//span[@class='custom-checkbox vertical-center'])[3]");
        public IWebElement BarredDoors => _parallelConfig.Driver.FindByXpath("(//span[@class='custom-checkbox vertical-center'])[4]");
        public IWebElement TenAcres => _parallelConfig.Driver.FindByXpath("(//span[@class='custom-checkbox vertical-center'])[6]");
        public IWebElement PriorFloodDamage => _parallelConfig.Driver.FindByXpath("(//span[@class='custom-checkbox vertical-center'])[7]");
        public IWebElement FloodDamageRepaired => _parallelConfig.Driver.FindByCss(".onoffswitch-switch");
        public IWebElement HomeSolarPanels => _parallelConfig.Driver.FindByXpath("(//span[@class='custom-checkbox vertical-center'])[5]");
        public IWebElement NextButton => _parallelConfig.Driver.FindByXpath("//button[contains(.,'Next')]");
        public IWebElement ThankyouPopup => _parallelConfig.Driver.FindByCss(".twico-modal-header");
        public IWebElement PriorFloodDamageButton => _parallelConfig.Driver.FindByCss(".onoffswitch-switch");
        public void SelectedHomeIsRented()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, HomeIsRented, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, HomeIsRented);
            Log4NetHelper.Log("Selected Home Is Rented", Log4Type.Info);
        }

        public void SelectUnrepairedDamage()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, UnrepairedDamage, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, UnrepairedDamage);
            Log4NetHelper.Log("Selected Unrepaired Damage", Log4Type.Info);
        }

        public void SelectUnderConstruction()
        {
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, UnderConstruction);
            Log4NetHelper.Log("Selected Under Construction", Log4Type.Info);
        }

        public void SelectBarredDoors()
        {
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, BarredDoors);
            Log4NetHelper.Log("Selected Barred Doors", Log4Type.Info);
        }

        public void SelectTenAcres()
        {
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, TenAcres);
            Log4NetHelper.Log("Selected home is in TenAcres", Log4Type.Info);
        }

        public void SelectPriorFloodDamage()
        {
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, PriorFloodDamage);
            Log4NetHelper.Log("Selected Prior Flood Damage", Log4Type.Info);
        }
        public void SelectHomeSolarPanels()
        {
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, HomeSolarPanels);
            Log4NetHelper.Log("Selected Home Solar Panels", Log4Type.Info);
        }

        public void CheckFloodDamageRepaired()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, FloodDamageRepaired, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, FloodDamageRepaired);
            Log4NetHelper.Log("Selected Flood Damage is repaired", Log4Type.Info);
        }
        public void ClickPriorFloodDamageButton()
        {
            try
            {
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, PriorFloodDamageButton);
                Log4NetHelper.Log("Clicked Prior Flood Damage Button", Log4Type.Info);
            }
            catch (Exception)
            {
                Thread.Sleep(2000);
                 PriorFloodDamageButton.Click();
                Log4NetHelper.Log("Clicked Prior Flood Damage Button in catch", Log4Type.Info);
            }
        }

        public ClientPage ClickNextButton()
        {
            try
            {
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, NextButton);
                Log4NetHelper.Log("Clicked next Button", Log4Type.Info);
            }
            catch (ElementNotVisibleException)
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, NextButton);
                NextButton.Click();
                Log4NetHelper.Log("Clicked next Button in catch", Log4Type.Info);
            }
            return new ClientPage(_parallelConfig);
        }

        public void VerifyThankyouPopup()
        {
            Thread.Sleep(1500);
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, NextButton);
            Assert.IsTrue(ThankyouPopup.GetLinkText().Contains("Thank You for Your Interest in Twico!"));
        }
    }
}
