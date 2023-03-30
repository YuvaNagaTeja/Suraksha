using System;
using System.Threading;
using CSharpAFProject.Base;
using CSharpAFProject.Extensions;
using CSharpAFProject.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace TWICOAppAutomation.Pages
{
    public class CustomizeQuotePage : BasePage
    {

        public CustomizeQuotePage(ParallelConfig parallelConfig) : base(parallelConfig) { }

        public IWebElement SPPButton => _parallelConfig.Driver.FindByXpath("//*[contains(text(),' Scheduled Personal Property ')]//following::*[@class='onoffswitch-switch']");
        public IWebElement IRCButton => _parallelConfig.Driver.FindByXpath("//*[contains(text(),' Increased Replacement Cost')]//following::*[@class='onoffswitch-switch']");
        public IWebElement FoundationCoverage => _parallelConfig.Driver.FindByXpath("//*[contains(text(),'Foundation Coverage')]//following::*[@class='onoffswitch-switch']");
        public IWebElement WaterCraft => _parallelConfig.Driver.FindByXpath("//*[contains(text(),'Watercraft')]//following::*[@class='onoffswitch-switch']");
        public IWebElement HomeSystemButton => _parallelConfig.Driver.FindByXpath("//*[contains(text(),'Home System Protection')]//following::*[@class='onoffswitch-switch']");
        public IWebElement ServiceLine => _parallelConfig.Driver.FindByXpath("(//*[contains(text(),'Service Line')]//following::*[@class='onoffswitch-switch'])[1]");
        public IWebElement HomeCyberButton => _parallelConfig.Driver.FindByXpath("//*[contains(text(),'Home Cyber Protection')]//following::*[@class='onoffswitch-switch']");
        public IWebElement DataBreachButton => _parallelConfig.Driver.FindByXpath("//*[contains(text(),'Data Breach Protection')]//following::*[@class='onoffswitch-switch']");
        public IWebElement PitBullButton => _parallelConfig.Driver.FindByXpath("//*[contains(text(),'Do you have a Pit Bull, German Shepherds, Akita, Doberman Pinscher, Chow, Rottweiler, Great Danes, Caucasian Mountain Dog, a mixed breed of any of the previous breeds, or another breed with a history of biting?')]//following::*[@class='onoffswitch-switch']");
        public IWebElement TwoPerDisplayed => _parallelConfig.Driver.FindByXpath("//*[contains(text(),' Wind Hail Deductible')]//following::*[@id='windHail']");//div[contains(text(),' Wind Hail Deductible ')]//following::div[2]//select[@id='windHail']//option[2]
        public IWebElement BindButton => _parallelConfig.Driver.FindByXpath("(//button[contains(text(),'Ready to Bind')])[1]");
        public IWebElement WindHail => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Wind Hail Exclusion ')]"); 
        public IWebElement Recalculate => _parallelConfig.Driver.FindByXpath("(//button[@id='btnRecalculate'])[2]");
        public IWebElement WaterSeepage => _parallelConfig.Driver.FindByXpath("//*[contains(text(),' Water Damage/Seepage ')]//following::*[@class='onoffswitch-switch'][1]");
        public IWebElement CustomizeQuotePageText => _parallelConfig.Driver.FindByCss(".header-title");
        public IWebElement BuyPolicy => _parallelConfig.Driver.FindByXpath("(//button[@id='buyPolicy'])[2]");
       // public IWebElement SPPButton => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Scheduled Personal Property ')]//following::div[2]//span[2]");
        public IWebElement SPPButtonACH => _parallelConfig.Driver.FindByXpath("(//span[@class='onoffswitch-switch'])[18]");
        public IWebElement SPPDescription => _parallelConfig.Driver.FindByXpath("//*[@id='sppDesc']");
        public IWebElement SPPAmount => _parallelConfig.Driver.FindByXpath("//*[@id='sppAmount']");
        public IWebElement SPPAdd => _parallelConfig.Driver.FindByXpath("//button[text()=' Add ']");       
        public IWebElement SPPClass => _parallelConfig.Driver.FindByXpath("//select[@id='sppClass']");
        public IWebElement ELButton => _parallelConfig.Driver.FindByXpath("//*[contains(text(),'Extended Liability - Additional Residences(Off Premises)')]//following::*[@class='onoffswitch-switch']");//div[contains(text(), 'Extended Liability - Additional Residences(Off Premises) ')]//parent::div//following::div[1]//span[2]
        public IWebElement ELAddResidences => _parallelConfig.Driver.FindByXpath("//select[@id='addResidences']");
        public IWebElement ELIsRented => _parallelConfig.Driver.FindByXpath("//label[contains(text(),'Location One')]//parent::div//following::div[1]//span[2]"); //  div:nth-child(74) .onoffswitch-switch
        public IWebElement ELFamilies => _parallelConfig.Driver.FindByXpath("//select[@id='location1Families']");
        public IWebElement ELAddress => _parallelConfig.Driver.FindByXpath("//input[@id='location1Address']");
        public IWebElement ELCity => _parallelConfig.Driver.FindByXpath("//input[@id='location1City']");
        public IWebElement ELZip => _parallelConfig.Driver.FindByXpath("//input[@id='location1Zip']");       
        public IWebElement ELIsRentedTwo => _parallelConfig.Driver.FindByXpath("//*[contains(text(),'Location Two')]//following::*[@class='onoffswitch-switch']"); //label[contains(text(),'Location Two')]//parent::div//following::div[1]//span[2]
        public IWebElement ELFamiliesTwo => _parallelConfig.Driver.FindByXpath("//select[@id='location2Families']");
        public IWebElement ELAddressTwo => _parallelConfig.Driver.FindByXpath("//input[@id='location2Address']");
        public IWebElement ELCityTwo => _parallelConfig.Driver.FindByXpath("//input[@id='location2City']");
        public IWebElement ELZipTwo => _parallelConfig.Driver.FindByXpath("//input[@id='location2Zip']");
       // public IWebElement IRCButton => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Increased Replacement Cost ')]//parent::div//following::div[2]//span[2]");
        public IWebElement IRCLimit => _parallelConfig.Driver.FindByXpath("//select[@id='irLimit']");
      //  public IWebElement FoundationCoverage => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Foundation Coverage ')]//parent::div//following::div[2]//span[2]");
       // public IWebElement WaterCraft => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Watercraft ')]//parent::div//following::div[2]//span[2]");
        public IWebElement EngineType => _parallelConfig.Driver.FindByXpath("//select[@id='engineType']");
        public IWebElement HorsePower => _parallelConfig.Driver.FindByXpath("//select[@id='horsePower']");
      //  public IWebElement HomeSystemButton => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Home System Protection ')]//following::div[2]//span[2]");
      //  public IWebElement ServiceLine => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Service Line ')]//parent::div//following::div[2]//span[2]");
        public IWebElement ServiceLineLimit => _parallelConfig.Driver.FindByXpath("//select[@id='serviceLineLimit']");
     //   public IWebElement HomeCyberButton => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Home Cyber Protection ')]//parent::div//following::div[2]//span[2]");
      //  public IWebElement DataBreachButton => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Data Breach Protection ')]//parent::div//following::div[2]//span[2]");
        public IWebElement HCPLimit => _parallelConfig.Driver.FindByXpath("//select[@id='hcpLimit']");
        public IWebElement PremiumInCustomize => _parallelConfig.Driver.FindByXpath("(//*[@class='plan-header-label'])[2]");
        public IWebElement WaterBackup => _parallelConfig.Driver.FindByXpath("//select[@id='waterBackupLimit']");//5000
        public IWebElement FloodCoverage => _parallelConfig.Driver.FindByXpath("//*[contains(text(),' Flood Coverage ')]");
        public IWebElement SPP5000 => _parallelConfig.Driver.FindByXpath("//*[contains(text(),'Individual items must be $5,000 or less.')]");
        public IWebElement SPP20000 => _parallelConfig.Driver.FindByXpath("//*[contains(text(),'Total scheduled amount must be $20,000 or less.')]");
        public IWebElement SPP2000 => _parallelConfig.Driver.FindByXpath("//*[contains(text(),' Appraisals or a bill of sale (less than 3 years old) and a color photo must accompany single items worth $2,000 or more. (Copy of appraisal or receipt is acceptable). ')]");
        public IWebElement IneligibleFloodCoverage => _parallelConfig.Driver.FindByXpath("//label[text()=' Your location is ineligible for Flood coverage. However, you may still add Limited Water Backup coverage ']");
      //  public IWebElement PitBullButton => _parallelConfig.Driver.FindByXpath("//label[contains(text(),' Do you have a Pit Bull, German Shepherds, Akita, Doberman Pinscher, Chow, Rottweiler, Great Danes, Caucasian Mountain Dog, a mixed breed of any of the previous breeds, or another breed with a history of biting? ')]//parent::div//following::div[1]//span[2]");
        public IWebElement MessagePitBull => _parallelConfig.Driver.FindByXpath("//*[contains(text(),'Breed is not eligible for this coverage.')]");
        //   public IWebElement TwoPerDisplayed => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Wind Hail Deductible ')]//following::div[2]//select[@id='windHail']//option[2]");
        public IWebElement MessageHomeCoverageA => _parallelConfig.Driver.FindByXpath("//*[contains(text(),'The default Coverage A amount is an estimated minimum. Documentation may be requested to verify your coverage selection.')]");

        public void VerifyMessageHomeCoverageA()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, MessageHomeCoverageA, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, MessageHomeCoverageA);
            Assert.IsTrue(MessageHomeCoverageA.GetLinkText().Contains("The default Coverage A amount is an estimated minimum. Documentation may be requested to verify your coverage selection."));
            Log4NetHelper.Log("'The default Coverage A amount is an estimated minimum. Documentation may be requested to verify your coverage selection.' is displayed.", Log4Type.Info);
        }
        public void VerifyTwoPerDisplayed()
        {
            try
            {
                Thread.Sleep(1500);
                WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, TwoPerDisplayed, TimeSpan.FromSeconds(10));
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, TwoPerDisplayed);
                //if (TwoPerDisplayed.Displayed)
                Assert.IsTrue(TwoPerDisplayed.GetLinkText().Contains("2%"));
            }catch(Exception)
            {
                Thread.Sleep(1500);
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, TwoPerDisplayed);
                //if (TwoPerDisplayed.Displayed)
                Assert.IsTrue(TwoPerDisplayed.GetLinkText().Contains("2%"));
            }
                Log4NetHelper.Log("2% is displayed.", Log4Type.Info);
        }
        public void ClickPitBullButton()
        {
            try
            {
                Thread.Sleep(2000);
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, PitBullButton);
                Log4NetHelper.Log("Pit Bull Button clicked", Log4Type.Info);
            }
            catch (ElementNotVisibleException)
            {
                WaitHelper.FluentWaitForWebElement(_parallelConfig.Driver, PitBullButton);
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, PitBullButton);
                Log4NetHelper.Log("Pit Bull Button clicked in catch ", Log4Type.Info);
            }
        }

        public void VerifyMessagePitBull()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, MessagePitBull, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, MessagePitBull);
            Assert.IsTrue(MessagePitBull.GetLinkText().Contains("Breed is not eligible for this coverage."));
            Log4NetHelper.Log("Breed is not eligible for this coverage.", Log4Type.Info);
        }
        public void VerifySPP5000()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, SPP5000, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SPP5000);
            Assert.IsTrue(SPP5000.GetLinkText().Contains("Individual items must be $5,000 or less."));
            Log4NetHelper.Log("Individual items must be $5,000 or less. text is verified  ", Log4Type.Info);
        }
        public void VerifySPP20000()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, SPP20000, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SPP20000);
            Assert.IsTrue(SPP20000.GetLinkText().Contains("Total scheduled amount must be $20,000 or less."));
            Log4NetHelper.Log(" Total scheduled amount must be $20,000 or less.  text is verified  ", Log4Type.Info);
        }
        public void VerifySPP2000()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, SPP2000, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SPP2000);
            Assert.IsTrue(SPP2000.GetLinkText().Contains("Appraisals or a bill of sale (less than 3 years old) and a color photo must accompany single items worth $2,000 or more. (Copy of appraisal or receipt is acceptable)."));
            Log4NetHelper.Log(" Appraisals or a bill of sale (less than 3 years old) and a color photo must accompany single items worth $2,000 or more. (Copy of appraisal or receipt is acceptable). text is verified  ", Log4Type.Info);
        }
        public void SelectWaterBackup(string waterBackup)
        {
            Thread.Sleep(1500);
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, WaterBackup, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, WaterBackup);
            WaterBackup.SelectDropDownList(waterBackup);
            Log4NetHelper.Log("WaterBackup 25000 is selected ", Log4Type.Info);
        }

        public void VerifyIneligibleFloodCoverage()
        {
            Thread.Sleep(1500);
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, IneligibleFloodCoverage, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, IneligibleFloodCoverage);           
            Assert.IsTrue(IneligibleFloodCoverage.GetLinkText().Contains("Your location is ineligible for Flood coverage. However, you may still add Limited Water Backup coverage"));
           Log4NetHelper.Log("Your location is ineligible for Flood coverage. However, you may still add Limited Water Backup coverage  text is verified  ", Log4Type.Info);
        }

        public void VerifyPremiumInCustomize(string premium)
        {
            Thread.Sleep(1500);
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PremiumInCustomize);
            Assert.IsTrue(PremiumInCustomize.GetLinkText().Contains(premium));
            Log4NetHelper.Log("verified premium in customize page ", Log4Type.Info);
        }
        public void ClickHomeSystemButton()
        {
            Thread.Sleep(1500);
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, HomeSystemButton, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, HomeSystemButton);
            Log4NetHelper.Log("clicked on home system button", Log4Type.Info);
        }
        public void ClickServiceLine()
        {
            try
            {
                Thread.Sleep(1500);
                WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, ServiceLine, TimeSpan.FromSeconds(10));
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, ServiceLine);
                ServiceLineLimit.IsElementPresent();
                Log4NetHelper.Log("clicked on service line button ", Log4Type.Info);
            }
            catch (Exception)
            {
                ServiceLine.Click();
            }
        }
        public void ClickHomeCyberButton()
        {
            Thread.Sleep(1500);
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, HomeCyberButton, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, HomeCyberButton);
            Log4NetHelper.Log("clicked on home cyber button", Log4Type.Info);
        }
        public void ClickDataBreachButton()
        {
            Thread.Sleep(1500);
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, DataBreachButton, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, DataBreachButton);
            Log4NetHelper.Log("clicked on data breach button", Log4Type.Info);
        }
        public void SelectServiceLineLimit(string limit)
        {
            Thread.Sleep(1500);
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, ServiceLineLimit, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ServiceLineLimit);
            ServiceLineLimit.SelectDropDownList(limit);
            Log4NetHelper.Log("selected service limit as"+ limit, Log4Type.Info);
        }
        public void SelectHCPLimit(string limit)
        {
            try
            {
                Thread.Sleep(1500);
                WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, HCPLimit, TimeSpan.FromSeconds(10));
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, HCPLimit);
                HCPLimit.SelectDropDownList(limit);
                Log4NetHelper.Log("selected HCP limit as" + limit, Log4Type.Info);
            }
            catch (ElementNotVisibleException)
            {
                Thread.Sleep(2000);
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, HCPLimit);
                HCPLimit.SelectDropDownList(limit);
                Log4NetHelper.Log("in catch selected HCP limit as" + limit, Log4Type.Info);
            }
        }

        public void ClickIRCButton()
        {
            Thread.Sleep(1500);
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, IRCButton, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, IRCButton);
            Log4NetHelper.Log("clicked on IRC button", Log4Type.Info);
        }
        public void SelectIRCLimit(string limit)
        {
            Thread.Sleep(2000);
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, IRCLimit, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, IRCLimit);
            IRCLimit.SelectDropDownList(limit);
            Log4NetHelper.Log(" selected IRC limit as" + limit, Log4Type.Info);
        }
        public void ClickFoundationCoverage()
        {
            Thread.Sleep(1500);
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, FoundationCoverage, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, FoundationCoverage);
            Log4NetHelper.Log("clicked foundation coverage", Log4Type.Info);
        }
        public void ClickWaterCraft()
        {
            Thread.Sleep(1500);
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, WaterCraft, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, WaterCraft);
            Log4NetHelper.Log("clicked water craft", Log4Type.Info);
        }
        public void SelectEngineType(string engineType)
        {
            Thread.Sleep(1500);
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, EngineType, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, EngineType);
            EngineType.SelectDropDownList(engineType);
            Log4NetHelper.Log(" selected enginetype as" + engineType, Log4Type.Info);
        }
        public void SelectHorsePower(string horsePower)
        {
            Thread.Sleep(1500);
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, HorsePower, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, HorsePower);
            HorsePower.SelectDropDownList(horsePower);
            Log4NetHelper.Log(" selected horse power as" + horsePower, Log4Type.Info);
        }
        public void VerifyFloodCoverage()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, FloodCoverage, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, FloodCoverage);
            Assert.IsTrue(FloodCoverage.GetLinkText().Contains("Flood Coverage"));
            Log4NetHelper.Log("Flood Coverage text is verified  ", Log4Type.Info);
        }
        public void ClickELButton()
        {
            try
            {
                Thread.Sleep(1500);
                WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, ELButton, TimeSpan.FromSeconds(10));
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ELButton);
                ELButton.Click();
                Log4NetHelper.Log("clicked EL Button ", Log4Type.Info);
            }
            catch (Exception)
            {
                Thread.Sleep(2500);
                WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, ELButton, TimeSpan.FromSeconds(10));
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, ELButton);
                Log4NetHelper.Log("clicked EL Button in catch", Log4Type.Info);
            }
        }
        
        public void EnterELAddResidences(string elAddResidences)
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, ELAddResidences, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ELAddResidences);
            ELAddResidences.SelectDropDownList(elAddResidences);
            Log4NetHelper.Log("Entered EL AddResidences" + elAddResidences, Log4Type.Info);
        }
        public void EnterELIsRented()
        {
            Thread.Sleep(1500);
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, ELIsRented, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, ELIsRented);
            Log4NetHelper.Log("clicked EL Is Rented", Log4Type.Info);
        }
        
        public void EnterELFamilies(string elFamilies)
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, ELFamilies, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ELFamilies);
            ELFamilies.SelectDropDownList(elFamilies);
            Log4NetHelper.Log("Entered EL Families" + elFamilies, Log4Type.Info);
        }
        public void EnterELAddress(string elAddress)
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, ELAddress, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ELAddress);
            ELAddress.SendKeys(elAddress);
            Log4NetHelper.Log("Entered EL address" + elAddress, Log4Type.Info);
        }
        
        public void EnterELCity(string elCity)
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, ELCity, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ELCity);
            ELCity.SendKeys(elCity);
            Log4NetHelper.Log("Entered EL city" + elCity, Log4Type.Info);
        }
        
        public void EnterELZip(string elZip)
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, ELZip, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ELZip);
            ELZip.SendKeys(elZip);
            Log4NetHelper.Log("Entered EL zip" + elZip, Log4Type.Info);
        }

        public void EnterELIsRentedTwo()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, ELIsRentedTwo, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, ELIsRentedTwo);
            Log4NetHelper.Log("clicked EL Is Rented two", Log4Type.Info);
        }

        public void EnterELFamiliesTwo(string elFamilies)
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, ELFamiliesTwo, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ELFamiliesTwo);
            ELFamiliesTwo.SelectDropDownList(elFamilies);
            Log4NetHelper.Log("Entered EL Families two" + elFamilies, Log4Type.Info);
        }
        public void EnterELAddressTwo(string elAddress)
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, ELAddressTwo, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ELAddressTwo);
            ELAddressTwo.SendKeys(elAddress);
            Log4NetHelper.Log("Entered EL address two" + elAddress, Log4Type.Info);
        }

        public void EnterELCityTwo(string elCity)
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, ELCityTwo, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ELCityTwo);
            ELCityTwo.SendKeys(elCity);
            Log4NetHelper.Log("Entered EL city two" + elCity, Log4Type.Info);
        }

        public void EnterELZipTwo(string elZip)
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, ELZipTwo, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ELZipTwo);
            ELZipTwo.SendKeys(elZip);
            Log4NetHelper.Log("Entered EL zip two" + elZip, Log4Type.Info);
        }

        public void ClickSPP()
        {
            try
            {
                Thread.Sleep(2000);
                WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, SPPButton, TimeSpan.FromSeconds(10));
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SPPButton);
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, SPPButton);
                Log4NetHelper.Log("clicked SPP button", Log4Type.Info);
            }
            catch (ElementNotVisibleException)
            {
                Thread.Sleep(2500);
                WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, SPPButton, TimeSpan.FromSeconds(10));
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, SPPButton);
                Log4NetHelper.Log("clicked SPP button in catch ", Log4Type.Info);
            }
        }


        public void EnterSPPClass(string sppClass)
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, SPPClass, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SPPClass);
            SPPClass.SelectDropDownList(sppClass);
            Log4NetHelper.Log("selected spp class"+ sppClass, Log4Type.Info);
        }
        public void EnterSPPDescription(string sppDescription)
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, SPPDescription, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SPPDescription);
            SPPDescription.SendKeys(sppDescription);
            Log4NetHelper.Log("selected spp description" + sppDescription, Log4Type.Info);

        }
        public void EnterSPPAmount(string sppAmount)
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, SPPAmount, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SPPAmount);
            SPPAmount.SendKeys(sppAmount);
            Log4NetHelper.Log("selected spp amount" + sppAmount, Log4Type.Info);
        }
        public void ClickSPPAdd()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, SPPAdd, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, SPPAdd);
            Log4NetHelper.Log("clicked SPP add button", Log4Type.Info);
        }

        public string VerifyCustomizeQuotePage()
        {
            return CustomizeQuotePageText.GetLinkText();
        }

        public void VerifyWindHailExclusion()
        {
            Thread.Sleep(1500);
            ((IJavaScriptExecutor)_parallelConfig.Driver).ExecuteScript("arguments[0].scrollIntoView(true);", WindHail);
            if (WindHail.IsElementPresent())
                Log4NetHelper.Log(" Wind/Hail Exclusion is displayed", Log4Type.Info);
        }
        public void RecalculateBtn()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, Recalculate, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, Recalculate);
            Log4NetHelper.Log("Clicked on ReCalculate Button");
        }
        public void SelectWaterSeepage()
        {
            Thread.Sleep(1500);
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, WaterSeepage, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, WaterSeepage);
            Log4NetHelper.Log("Clicked on waterseepage Button");
        }
        public CoApplicantPage ClickBindbutton()
        {
            try
            {
                BindButton.Click();
                Log4NetHelper.Log("Clicked on bind Button");
            }
            catch (Exception)
            {
                _parallelConfig.Driver.RefreshPage();
                Thread.Sleep(1500);
                BindButton.Click();
                Log4NetHelper.Log("Clicked on bind Button in Catch");
            }
            return new CoApplicantPage(_parallelConfig);
        }

        public CoApplicantPage ClickBuyPolicy()
        {
            try
            {
                Thread.Sleep(1500);
                WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, BuyPolicy, TimeSpan.FromSeconds(10));
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, BuyPolicy);
                BuyPolicy.Click();
            }
            catch (Exception)
            {
                Thread.Sleep(2000);
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, BuyPolicy);
            }
           return new CoApplicantPage(_parallelConfig);
        }

    }
}
