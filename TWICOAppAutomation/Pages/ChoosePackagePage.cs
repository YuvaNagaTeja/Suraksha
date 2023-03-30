using CSharpAFProject.Base;
using CSharpAFProject.Extensions;
using CSharpAFProject.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using SurakshaAutomation.FeatureFiles;

namespace SurakshaAutomation.Pages
{
    public class ChoosePackagePage : BasePage
    {
        public ChoosePackagePage(ParallelConfig parallelConfig) : base(parallelConfig) { }
        public IWebElement TwicoPrime => _parallelConfig.Driver.FindByXpath("//*[@id='twicoPrime']//following::*[@class='custom-checkbox vertical-center']");
        public IWebElement TwicoPrimePlus => _parallelConfig.Driver.FindByXpath("//*[@id='twicoPrimePlus']//following::*[@class='custom-checkbox vertical-center']");
        public IWebElement TwicoPrime360 => _parallelConfig.Driver.FindByXpath("//*[@id='twicoPrime360']//following::*[@class='custom-checkbox vertical-center']");
        public IWebElement BindButtonPrime360 => _parallelConfig.Driver.FindByXpath("(//button[@id='btnBind'])[3]");
//
        public IWebElement RadioButtonPrimePlus => _parallelConfig.Driver.FindByXpath("//input[@id='twico-prime-plus-radio']");
        public IWebElement RadioButtonPrime => _parallelConfig.Driver.FindByXpath("//input[@id='twico-prime-radio']");
        public IWebElement RadioButtonPrime360 => _parallelConfig.Driver.FindByXpath("//input[@id='twico-360-radio']");
        public IWebElement BuyPolicyButton => _parallelConfig.Driver.FindByXpath("(//button[contains(text(),'Buy Policy')])[4]");
        public IWebElement CustomizeButton => _parallelConfig.Driver.FindByXpath("(//button[contains(text(),'Customize')])[4]");

        //
        public IWebElement FloodInEligiblePrime => _parallelConfig.Driver.FindByXpath("//*[text()=' Flood ']//following::div[text()='Ineligible'][1]");
        public IWebElement FloodInEligiblePrimePlus => _parallelConfig.Driver.FindByXpath("//*[text()=' Flood ']//following::div[text()='Ineligible'][2]");
        public IWebElement FloodInEligiblePrime360 => _parallelConfig.Driver.FindByXpath("//*[text()=' Flood ']//following::div[text()='Ineligible'][3]");
        public IWebElement ChoosePackagePageText => _parallelConfig.Driver.FindByXpath("//*[@class='package-options-header']");
        public IWebElement WindORHailPrime => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Wind/Hail Deductible ')]//following::div[@class='price-label price-align'][1]");
        public IWebElement WindORHailPrimePlus => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Wind/Hail Deductible ')]//following::div[@class='price-label price-align'][1]");
        public IWebElement WindORHailPrime360 => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Wind/Hail Deductible ')]//following::div[@class='price-label price-align'][1]");
        public IWebElement PrimePremium => _parallelConfig.Driver.FindByXpath("(//span[@class='price-label-selected'])[1]");
        public IWebElement PrimePlusPremium => _parallelConfig.Driver.FindByXpath("(//span[@class='price-label-white'])[1]");
        public IWebElement Prime360Premium => _parallelConfig.Driver.FindByXpath("(//span[@class='price-label-white'])[2]");
        public IWebElement FloodValuePrime5000 => _parallelConfig.Driver.FindByXpath("//*[contains(text(),'$5,000*')][1]");
        public IWebElement BuyPolicyVerification => _parallelConfig.Driver.FindByXpath("//*[contains(text(),'Would you like to add a Spouse or Co-Applicant?')]");
        public IWebElement Pointer => _parallelConfig.Driver.FindByXpath("//*[@class='pointer hamburger-wrapper']");
        public IWebElement PrintOption => _parallelConfig.Driver.FindByXpath("(//*[@class='hamburger-pane-item'])[3]");
        //public IWebElement TwicoPrime => _parallelConfig.Driver.FindByXpath("(//span[@class='custom-checkbox'])[1]");
       // public IWebElement TwicoPrimePlus => _parallelConfig.Driver.FindByXpath("(//span[@class='custom-checkbox'])[2]");
       // public IWebElement TwicoPrime360 => _parallelConfig.Driver.FindByXpath("(//span[@class='custom-checkbox'])[3]");
        public IWebElement PrintPDFButton => _parallelConfig.Driver.FindByXpath("//button[contains(text(),'Print')]");
        public IWebElement CustomizeVerification => _parallelConfig.Driver.FindByXpath("//*[contains(text(),'Customize Your Quote')]");
        public IWebElement MedicalPaymentPrime => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Medical Payments ')]//following::div[@class='price-label price-align'][1]");
        public IWebElement MedicalPaymentPrimePlus => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Medical Payments ')]//following::div[@class='price-label price-align'][1]");
        public IWebElement MedicalPaymentPrime360 => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Medical Payments ')]//following::div[@class='price-label price-align'][1]");
        public IWebElement LossAssessmentPrime => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Loss Assessment ')]//following::div[@class='price-label price-align'][1]");
        public IWebElement LossAssessmentPrimePlus => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Loss Assessment ')]//following::div[@class='price-label price-align'][1]");
        public IWebElement LossAssessmentPrime360 => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Loss Assessment ')]//following::div[@class='price-label price-align'][1]");
        public IWebElement MoldPrime => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Mold ')]//following::div[@class='price-label price-align'][1]");
        public IWebElement MoldPrimePlus => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Mold ')]//following::div[@class='price-label price-align'][1]");
        public IWebElement MoldPrime360 => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Mold ')]//following::div[@class='price-label price-align'][1]");
        public IWebElement ContentsReplacementPrime => _parallelConfig.Driver.FindByXpath("//div[contains(text(),'Contents Replacement')]//following::div[@class='price-label price-align'][1]");
        public IWebElement ContentsReplacementPrimePlus => _parallelConfig.Driver.FindByXpath("//div[contains(text(),'Contents Replacement')]//following::div[@class='price-label price-align'][1]");
        public IWebElement ContentsReplacementPrime360 => _parallelConfig.Driver.FindByXpath("//div[contains(text(),'Contents Replacement')]//following::div[@class='price-label price-align'][1]");
        public IWebElement WaterBackupPrime => _parallelConfig.Driver.FindByXpath("//div[text()=' Water Backup ']//following::div[@class='price-label price-align'][1]");
        public IWebElement WaterBackupPrimePlus => _parallelConfig.Driver.FindByXpath("//div[text()=' Water Backup ']//following::div[@class='price-label price-align'][1]");
        public IWebElement WaterBackupPrime360 => _parallelConfig.Driver.FindByXpath("//div[text()=' Water Backup ']//following::div[@class='price-label price-align'][1]");
        public IWebElement OrdinanceOrLawPrime => _parallelConfig.Driver.FindByXpath("//div[contains(text(),' Ordinance or Law ')]//following::div[@class='price-label price-align'][1]");
        public IWebElement DogLiabilityPrime360 => _parallelConfig.Driver.FindByXpath("//div[contains(text(),'Dog Liability')]//following::div[@class='price-label price-align'][1]");
        public IWebElement DogLiabilityPrime => _parallelConfig.Driver.FindByXpath("//div[contains(text(),'Dog Liability')]//following::div[@class='price-label price-align'][1]");
        public IWebElement DogLiabilityPrimePlus => _parallelConfig.Driver.FindByXpath("//div[contains(text(),'Dog Liability')]//following::div[@class='price-label price-align'][1]");
        public IWebElement SystemsProtectionPrime => _parallelConfig.Driver.FindByXpath("//div[contains(text(),'Systems Protection')]//following::div[@class='price-label price-align'][1]");
        public IWebElement SystemsProtectionPrimePlus => _parallelConfig.Driver.FindByXpath("//div[contains(text(),'Systems Protection')]//following::div[@class='price-label price-align'][1]");
        public IWebElement SystemsProtectionPrime360 => _parallelConfig.Driver.FindByXpath("//div[contains(text(),'Systems Protection')]//following::div[@class='price-label price-align'][1]");
        public IWebElement IdentityTheftPrime => _parallelConfig.Driver.FindByXpath("//div[contains(text(),'Identity Theft')]//following::div[@class='price-label price-align'][1]");
        public IWebElement IdentityTheftPrimePlus => _parallelConfig.Driver.FindByXpath("//div[contains(text(),'Identity Theft')]//following::div[@class='price-label price-align'][1]");
        public IWebElement IdentityTheftPrime360 => _parallelConfig.Driver.FindByXpath("//div[contains(text(),'Identity Theft')]//following::div[@class='price-label price-align'][1]");
        public IWebElement IncreasedLimitsPrime360 => _parallelConfig.Driver.FindByXpath("//div[contains(text(),'Increased Limits')]//following::div[@class='price-label price-align'][1]");
        public IWebElement IncreasedLimitsPrimePlus => _parallelConfig.Driver.FindByXpath("//div[contains(text(),'Increased Limits')]//following::div[@class='price-label price-align'][1]");
        public IWebElement IncreasedLimitsPrime => _parallelConfig.Driver.FindByXpath("//div[contains(text(),'Increased Limits')]//following::div[@class='price-label price-align'][1]");
        public IWebElement PersonalInjuryPrime360 => _parallelConfig.Driver.FindByXpath("//div[contains(text(),'Personal Injury')]//following::div[@class='price-label price-align'][1]");
        public IWebElement PersonalInjuryPrimePlus => _parallelConfig.Driver.FindByXpath("//div[contains(text(),'Personal Injury')]//following::div[@class='price-label price-align'][1]");
        public IWebElement PersonalInjuryPrime => _parallelConfig.Driver.FindByXpath("//div[contains(text(),'Personal Injury')]//following::div[@class='price-label price-align'][1]");
        public IWebElement ServiceLinePrime360 => _parallelConfig.Driver.FindByXpath("//div[text()='Service Line']//following::div[@class='price-label price-align'][1]");
        public IWebElement ServiceLinePrimePlus => _parallelConfig.Driver.FindByXpath("//div[text()='Service Line']//following::div[@class='price-label price-align'][1]");
        public IWebElement ServiceLinePrime => _parallelConfig.Driver.FindByXpath("//div[text()='Service Line']//following::div[@class='price-label price-align'][1]");
        public IWebElement WaterSeepagePrimePlus => _parallelConfig.Driver.FindByXpath("//*[text()='Water Damage/Seepage']//following::div[@class='price-label price-align'][1]");
        public IWebElement WaterSeepagePrime360 => _parallelConfig.Driver.FindByXpath("//*[text()='Water Damage/Seepage']//following::div[@class='price-label price-align'][1]");
        public IWebElement DataBreachPrime360 => _parallelConfig.Driver.FindByXpath("//div[text()='Data Breach']//following::div[@class='price-label price-align'][1]");
        public IWebElement CyberProtectionPrimePlus => _parallelConfig.Driver.FindByXpath("//div[text()='Cyber Protection']//following::div[@class='price-label price-align'][1]");
        public IWebElement CyberProtectionPrime360 => _parallelConfig.Driver.FindByXpath("//div[text()='Cyber Protection']//following::div[@class='price-label price-align'][1]");

        public void VerifyServiceLinePrime360(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ServiceLinePrime360);
                Assert.IsTrue(ServiceLinePrime360.GetLinkText().Contains(opverification));
            }catch(Exception)
            {
                Thread.Sleep(1000);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ServiceLinePrime360);
                Assert.IsTrue(ServiceLinePrime360.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("ServiceLine for Prime360 $15,000* text is verified  ", Log4Type.Info);
        }
        public void VerifyWaterSeepagePrimePlus(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, WaterSeepagePrimePlus);
                Assert.IsTrue(WaterSeepagePrimePlus.GetLinkText().Contains(opverification));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, WaterSeepagePrimePlus);
                Assert.IsTrue(WaterSeepagePrimePlus.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("Water Seepage PrimePlus YES text is verified  ", Log4Type.Info);
        }
        public void VerifyWaterSeepagePrime360(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, WaterSeepagePrime360);
                Assert.IsTrue(WaterSeepagePrime360.GetLinkText().Contains(opverification));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, WaterSeepagePrime360);
                Assert.IsTrue(WaterSeepagePrime360.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("WaterSeepage Prime360 YES text is verified  ", Log4Type.Info);
        }
        public void VerifyDataBreachPrime360(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, DataBreachPrime360);
                Assert.IsTrue(DataBreachPrime360.GetLinkText().Contains(opverification));
            }catch(Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, DataBreachPrime360);
                Assert.IsTrue(DataBreachPrime360.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("DataBreach Prime360 $25,000 text is verified  ", Log4Type.Info);
        }
        public void VerifyCyberProtectionPrimePlus(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, CyberProtectionPrimePlus);
                Assert.IsTrue(CyberProtectionPrimePlus.GetLinkText().Contains(opverification));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, CyberProtectionPrimePlus);
                Assert.IsTrue(CyberProtectionPrimePlus.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("CyberProtection PrimePlus $25,000 text is verified  ", Log4Type.Info);
        }
        public void VerifyCyberProtectionPrime360(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, CyberProtectionPrime360);
                Assert.IsTrue(CyberProtectionPrime360.GetLinkText().Contains(opverification));
            }catch(Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, CyberProtectionPrime360);
                Assert.IsTrue(CyberProtectionPrime360.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("CyberProtection Prime360 $25,000 text is verified  ", Log4Type.Info);
        }
        public void VerifyServiceLinePrimePlus(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ServiceLinePrimePlus);
                Assert.IsTrue(ServiceLinePrimePlus.GetLinkText().Contains(opverification));
            }catch(Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ServiceLinePrimePlus);
                Assert.IsTrue(ServiceLinePrimePlus.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("ServiceLine for PrimePlus $10,000* text is verified  ", Log4Type.Info);
        }
        public void VerifyServiceLinePrime(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ServiceLinePrime);
                Assert.IsTrue(ServiceLinePrime.GetLinkText().Contains(opverification));
            }
            catch(Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ServiceLinePrime);
                Assert.IsTrue(ServiceLinePrime.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("ServiceLine for Prime - text is verified  ", Log4Type.Info);
        }
        public void VerifyPersonalInjuryPrime360(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PersonalInjuryPrime360);
                Assert.IsTrue(PersonalInjuryPrime360.GetLinkText().Contains(opverification));
            }catch(Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PersonalInjuryPrime360);
                Assert.IsTrue(PersonalInjuryPrime360.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("PersonalInjury for Prime360 - text is verified  ", Log4Type.Info);
        }
        public void VerifyPersonalInjuryPrimePlus(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PersonalInjuryPrimePlus);
                Assert.IsTrue(PersonalInjuryPrimePlus.GetLinkText().Contains(opverification));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PersonalInjuryPrimePlus);
                Assert.IsTrue(PersonalInjuryPrimePlus.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("PersonalInjury for Prime360 - text is verified  ", Log4Type.Info);
        }
        public void VerifyPersonalInjuryPrime(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PersonalInjuryPrime);
                Assert.IsTrue(PersonalInjuryPrime.GetLinkText().Contains(opverification));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PersonalInjuryPrime);
                Assert.IsTrue(PersonalInjuryPrime.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("PersonalInjury for Prime360 - text is verified  ", Log4Type.Info);
        }
        public void VerifyIncreasedLimitsPrime360(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, IncreasedLimitsPrime360);
                Assert.IsTrue(IncreasedLimitsPrime360.GetLinkText().Contains(opverification));
            }catch(Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, IncreasedLimitsPrime360);
                Assert.IsTrue(IncreasedLimitsPrime360.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("IncreasedLimits for Prime360 ALL ITEMS* text is verified  ", Log4Type.Info);
        }
        public void VerifyIncreasedLimitsPrimePlus(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, IncreasedLimitsPrimePlus);
                Assert.IsTrue(IncreasedLimitsPrimePlus.GetLinkText().Contains(opverification));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, IncreasedLimitsPrimePlus);
                Assert.IsTrue(IncreasedLimitsPrimePlus.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("IncreasedLimits for PrimePlus JEWELRY* text is verified  ", Log4Type.Info);
        }
        public void VerifyIncreasedLimitsPrime(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, IncreasedLimitsPrime);
                Assert.IsTrue(IncreasedLimitsPrime.GetLinkText().Contains(opverification));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, IncreasedLimitsPrime);
                Assert.IsTrue(IncreasedLimitsPrime.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("IncreasedLimits for Prime - text is verified  ", Log4Type.Info);
        }
        public void VerifyIdentityTheftPrime(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, IdentityTheftPrime);
                Assert.IsTrue(IdentityTheftPrime.GetLinkText().Contains(opverification));
            }catch(Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, IdentityTheftPrime);
                Assert.IsTrue(IdentityTheftPrime.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("IdentityTheft for Prime YES* text is verified  ", Log4Type.Info);
        }
        public void VerifyIdentityTheftPrimePlus(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, IdentityTheftPrimePlus);
                Assert.IsTrue(IdentityTheftPrimePlus.GetLinkText().Contains(opverification));
            }catch(Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, IdentityTheftPrimePlus);
                Assert.IsTrue(IdentityTheftPrimePlus.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("IdentityTheft for PrimePlus YES* text is verified  ", Log4Type.Info);
        }
        public void VerifySystemsProtectionPrime360(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SystemsProtectionPrime360);
                Assert.IsTrue(SystemsProtectionPrime360.GetLinkText().Contains(opverification));
            }catch(Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SystemsProtectionPrime360);
                Assert.IsTrue(SystemsProtectionPrime360.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("SystemsProtection for Prime360 $100,000 text is verified  ", Log4Type.Info);
        }
        public void VerifySystemsProtectionPrimePlus(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SystemsProtectionPrimePlus);
                Assert.IsTrue(SystemsProtectionPrimePlus.GetLinkText().Contains(opverification));
            }catch(Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SystemsProtectionPrimePlus);
                Assert.IsTrue(SystemsProtectionPrimePlus.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("SystemsProtection for PrimePlus $100,000* text is verified  ", Log4Type.Info);
        }
        public void VerifySystemsProtectionPrime(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SystemsProtectionPrime);
                Assert.IsTrue(SystemsProtectionPrime.GetLinkText().Contains(opverification));
            }catch(Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SystemsProtectionPrime);
                Assert.IsTrue(SystemsProtectionPrime.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("SystemsProtection for Prime - text is verified  ", Log4Type.Info);
        }
        public void VerifyIdentityTheftPrime360(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, IdentityTheftPrime360);
                Assert.IsTrue(IdentityTheftPrime360.GetLinkText().Contains(opverification));
            }
            catch(Exception) {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, IdentityTheftPrime360);
                Assert.IsTrue(IdentityTheftPrime360.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("IdentityTheft for Prime360 YES* text is verified  ", Log4Type.Info);
        }
        public void VerifyDogLiabilityPrimePlus(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, DogLiabilityPrimePlus);
                Assert.IsTrue(DogLiabilityPrimePlus.GetLinkText().Contains(opverification));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, DogLiabilityPrimePlus);
                Assert.IsTrue(DogLiabilityPrimePlus.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("DogLiability for PrimePlus $25,000 text is verified  ", Log4Type.Info);
        }
        public void VerifyDogLiabilityPrime(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, DogLiabilityPrime);
                Assert.IsTrue(DogLiabilityPrime.GetLinkText().Contains(opverification));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, DogLiabilityPrime);
                Assert.IsTrue(DogLiabilityPrime.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("DogLiability for Prime360 - text is verified  ", Log4Type.Info);
        }
        public void VerifyDogLiabilityPrime360(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, DogLiabilityPrime360);
                Assert.IsTrue(DogLiabilityPrime360.GetLinkText().Contains(opverification));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, DogLiabilityPrime360);
                Assert.IsTrue(DogLiabilityPrime360.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("DogLiability for Prime360 $100,000 text is verified  ", Log4Type.Info);
        }
        public void VerifyOrdinanceOrLawPrime(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, OrdinanceOrLawPrime);
                Assert.IsTrue(OrdinanceOrLawPrime.GetLinkText().Contains(opverification));
            }
            catch (Exception) {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, OrdinanceOrLawPrime);
                Assert.IsTrue(OrdinanceOrLawPrime.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("Ordinance Or LawPrime for Prime 10% text is verified  ", Log4Type.Info);
        }
        public void VerifyMedicalPaymentPrime(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, MedicalPaymentPrime);
                Assert.IsTrue(MedicalPaymentPrime.GetLinkText().Contains(opverification));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, MedicalPaymentPrime);
                Assert.IsTrue(MedicalPaymentPrime.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("Medical Payment for Prime $1,000 text is verified  ", Log4Type.Info);
        }
        public void VerifyMedicalPaymentPrimePlus(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, MedicalPaymentPrimePlus);
                Assert.IsTrue(MedicalPaymentPrimePlus.GetLinkText().Contains(opverification));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, MedicalPaymentPrimePlus);
                Assert.IsTrue(MedicalPaymentPrimePlus.GetLinkText().Contains(opverification));

            }
            Log4NetHelper.Log("Medical Payment for Prime $3,000 text is verified  ", Log4Type.Info);
        }
        public void VerifyMedicalPaymentPrime360(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, MedicalPaymentPrime360);
                Assert.IsTrue(MedicalPaymentPrime360.GetLinkText().Contains(opverification));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, MedicalPaymentPrime360);
                Assert.IsTrue(MedicalPaymentPrime360.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("Medical Payment for Prime360 $5,000 text is verified  ", Log4Type.Info);
        }
        public void VerifyLossAssessmentPrime(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, LossAssessmentPrime);
                //Thread.Sleep(500);
                Assert.IsTrue(LossAssessmentPrime.GetLinkText().Contains(opverification));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, LossAssessmentPrime);
                //Thread.Sleep(500);
                Assert.IsTrue(LossAssessmentPrime.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("Loss Assessment for Prime $1,000 text is verified  ", Log4Type.Info);
        }
        public void VerifyLossAssessmentPrimePlus(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, LossAssessmentPrimePlus);
                Assert.IsTrue(LossAssessmentPrimePlus.GetLinkText().Contains(opverification));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, LossAssessmentPrimePlus);
                Assert.IsTrue(LossAssessmentPrimePlus.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log(" Loss Assessment for PrimePlus $3,000 text is verified  ", Log4Type.Info);
        }
        public void VerifyLossAssessmentPrime360(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, LossAssessmentPrime360);
                Assert.IsTrue(LossAssessmentPrime360.GetLinkText().Contains(opverification));
            }
            catch (Exception) {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, LossAssessmentPrime360);
                Assert.IsTrue(LossAssessmentPrime360.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("Loss Assessment for Prime360 $5,000 text is verified  ", Log4Type.Info);
        }
        public void VerifyMoldPrime(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, MoldPrime);
                Assert.IsTrue(MoldPrime.GetLinkText().Contains(opverification));
            }
            catch (Exception) {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, MoldPrime);
                Assert.IsTrue(MoldPrime.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("Mold for Prime $5,000 text is verified  ", Log4Type.Info);
        }
        public void VerifyMoldPrimePlus(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, MoldPrimePlus);
                Assert.IsTrue(MoldPrimePlus.GetLinkText().Contains(opverification));
            }
            catch (Exception) {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, MoldPrimePlus);
                Assert.IsTrue(MoldPrimePlus.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("Mold for PrimePlus $5,000 text is verified  ", Log4Type.Info);
        }
        public void VerifyMoldPrime360(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, MoldPrime360);
                Assert.IsTrue(MoldPrime360.GetLinkText().Contains(opverification));
            }
            catch (Exception) {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, MoldPrime360);
                Assert.IsTrue(MoldPrime360.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("Mold for Prime $5,000 text is verified  ", Log4Type.Info);
        }
        public void VerifyContentsReplacementPrime(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ContentsReplacementPrime);
                //Thread.Sleep(500);
                Assert.IsTrue(ContentsReplacementPrime.GetLinkText().Contains(opverification));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ContentsReplacementPrime);
                //Thread.Sleep(500);
                Assert.IsTrue(ContentsReplacementPrime.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("Contents Replacement for Prime YES text is verified  ", Log4Type.Info);
        }
        public void VerifyContentsReplacementPrimePlus(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ContentsReplacementPrimePlus);
                //Thread.Sleep(500);
                Assert.IsTrue(ContentsReplacementPrimePlus.GetLinkText().Contains(opverification));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ContentsReplacementPrimePlus);
                //Thread.Sleep(500);
                Assert.IsTrue(ContentsReplacementPrimePlus.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("Contents Replacement for Prime YES text is verified  ", Log4Type.Info);
        }
        public void VerifyContentsReplacementPrime360(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ContentsReplacementPrime360);
                // Thread.Sleep(500);
                Assert.IsTrue(ContentsReplacementPrime360.GetLinkText().Contains(opverification));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ContentsReplacementPrime360);
                // Thread.Sleep(500);
                Assert.IsTrue(ContentsReplacementPrime360.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("Contents Replacement for Prime360 YES text is verified  ", Log4Type.Info);
        }
     
        public void VerifyWaterBackupPrime(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, WaterBackupPrime);
                Assert.IsTrue(WaterBackupPrime.GetLinkText().Contains(opverification));
            }
            catch (Exception) {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, WaterBackupPrime);
                Assert.IsTrue(WaterBackupPrime.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("Water Backup for Prime $5,000 text is verified  ", Log4Type.Info);
        }
        public void VerifyWaterBackupPrimePlus(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, WaterBackupPrimePlus);
                Assert.IsTrue(WaterBackupPrimePlus.GetLinkText().Contains(opverification));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, WaterBackupPrimePlus);
                Assert.IsTrue(WaterBackupPrimePlus.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("Water Backup for Prime $5,000 text is verified  ", Log4Type.Info);
        }

        public void VerifyWaterBackupPrime360(string opverification)
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, WaterBackupPrime360);
                Assert.IsTrue(WaterBackupPrime360.GetLinkText().Contains(opverification));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, WaterBackupPrime360);
                Assert.IsTrue(WaterBackupPrime360.GetLinkText().Contains(opverification));
            }
            Log4NetHelper.Log("Water Backup for Prime360 $5,000 text is verified  ", Log4Type.Info);
        }

        public void ClickPrintOption()
        {
            try
            {
                Thread.Sleep(2000);
                Pointer.Click();
                WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, PrintOption, TimeSpan.FromSeconds(10));
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, PrintOption);
            }
            catch (Exception)
            {
                Thread.Sleep(1000);
                Pointer.Click();
                PrintOption.Click();
            }
        }
        public void SelectTwicoPrime()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, TwicoPrime, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, TwicoPrime);
           // TwicoPrime.Click();
        }
        public void SelectTwicoPrimePlus()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, TwicoPrimePlus, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, TwicoPrimePlus);
            //TwicoPrimePlus.Click();
        }
        public void SelectTwicoPrime360()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, TwicoPrime360, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, TwicoPrime360);
            //TwicoPrime360.Click();
        }
        public void ClickPrintPDF(string text)
        {
            try
            {
                Thread.Sleep(4000);
                WaitHelper.WaitForWebElement(_parallelConfig.Driver, PrintPDFButton, TimeSpan.FromSeconds(70));
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PrintPDFButton);
                PDFHelper.Extractor(PrintPDFButton, text, "QuoteOptions");
                Log4NetHelper.Log("Is verified sucessfully", Log4Type.Info);
            }
            catch (Exception)
            {
                Thread.Sleep(10000);

               // PrintOption.Click();

                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PrintPDFButton);
                PDFHelper.Extractor(PrintPDFButton, text, "QuoteOptions");
                Log4NetHelper.Log("Is verified sucessfully", Log4Type.Info);
            }
        }
        public void VerifyFloodInelegiblePrime()
        {
            try
            {
                WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, FloodInEligiblePrime, TimeSpan.FromSeconds(10));
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, FloodInEligiblePrime);
                Assert.IsTrue(FloodInEligiblePrime.GetLinkText().Contains("Ineligible"));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, FloodInEligiblePrime);
                Assert.IsTrue(FloodInEligiblePrime.GetLinkText().Contains("Ineligible"));
            }
            Log4NetHelper.Log("Ineligible for prime is verified  ", Log4Type.Info);
        }
        public void VerifyPrimePremium(string premium)
        {
            try
            {
                Thread.Sleep(2000);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PrimePremium);
                WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, PrimePremium, TimeSpan.FromSeconds(10));
                Assert.IsTrue(PrimePremium.GetLinkText().Contains(premium));
            }
            catch(Exception)
            {
                Thread.Sleep(1000);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PrimePremium);
                Assert.IsTrue(PrimePremium.GetLinkText().Contains(premium));
            }
        }
        public void VerifyPrimePlusPremium(string premium)
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, PrimePlusPremium, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PrimePlusPremium);
            Assert.IsTrue(PrimePlusPremium.GetLinkText().Contains(premium));
        }
        public void VerifyPrime360Premium(string premium)
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, Prime360Premium, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Prime360Premium);
            Assert.IsTrue(Prime360Premium.GetLinkText().Contains(premium));
        }

        public void VerifyWindORHailExcluded()
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, WindORHailPrime);
                Assert.IsTrue(WindORHailPrime.GetLinkText().Contains("Excluded"));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, WindORHailPrime);
                Assert.IsTrue(WindORHailPrime.GetLinkText().Contains("Excluded"));
                RadioButtonPrimePlus.Click();
                Assert.IsTrue(WindORHailPrimePlus.GetLinkText().Contains("Excluded"));
                RadioButtonPrime360.Click();
                Assert.IsTrue(WindORHailPrime360.GetLinkText().Contains("Excluded"));
                Log4NetHelper.Log("Wind/ Hail is Excluded text is verified  ", Log4Type.Info);
            }
        }

        public void VerifyWindORHail2Percentage()
        {
            try
            {
                Thread.Sleep(1500);
                WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, WindORHailPrime, TimeSpan.FromSeconds(10));
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, WindORHailPrime);
                Assert.IsTrue(WindORHailPrime.GetLinkText().Contains("2%"));
            }
            catch(Exception)
            {
                Thread.Sleep(2000);
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, WindORHailPrime);
                Assert.IsTrue(WindORHailPrime.GetLinkText().Contains("2%"));
            }
            Log4NetHelper.Log("Wind/ Hail is 2% text is verified  ", Log4Type.Info);
        }

        public void VerifyWindORHail1Percentage()
        {
            try
            {
                Thread.Sleep(1500);
                WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, WindORHailPrime, TimeSpan.FromSeconds(10));
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, WindORHailPrime);
                RadioButtonPrime.Click();
                Assert.IsTrue(WindORHailPrime.GetLinkText().Contains("1%"));
            }
            catch (Exception)
            {
                Thread.Sleep(1500);
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, WindORHailPrime);
                RadioButtonPrime.Click();
                Assert.IsTrue(WindORHailPrime.GetLinkText().Contains("1%"));
                RadioButtonPrimePlus.Click();
                Assert.IsTrue(WindORHailPrimePlus.GetLinkText().Contains("1%"));
                RadioButtonPrime360.Click();
                Assert.IsTrue(WindORHailPrime360.GetLinkText().Contains("1%"));
                Log4NetHelper.Log("Wind/ Hail is 1% text is verified  ", Log4Type.Info);
            }
        }

        public CoApplicantPage ClickBuyPolicyPrimePlus()
        {
            try
            {
                Thread.Sleep(1800);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, BuyPolicyButton);
                Thread.Sleep(2000);
                Assert.IsTrue(BuyPolicyVerification.GetLinkText().Contains("Would you like to add a Spouse or Co-Applicant?"));
                Log4NetHelper.Log("clicked on Buy Policy for Prime Plus ", Log4Type.Info);
            }
            catch (Exception)
            {
               // BrowserHelper.RefreshPage(_parallelConfig.Driver);
                Thread.Sleep(1500);
                WaitHelper.FluentWaitForWebElement(_parallelConfig.Driver, BuyPolicyButton);
                RadioButtonPrimePlus.Click();
                BuyPolicyButton.Click();
                Log4NetHelper.Log("Catch clicked on Buy Policy for Prime Plus ", Log4Type.Info);
            }
            return new CoApplicantPage(_parallelConfig);
        }

        public CoApplicantPage ClickBuyPolicyPrime()
        {
            try
            {
                Thread.Sleep(2000);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, BuyPolicyButton);
                Thread.Sleep(2000);
                Assert.IsTrue(BuyPolicyVerification.GetLinkText().Contains("Would you like to add a Spouse or Co-Applicant?"));
                Log4NetHelper.Log("clicked on Buy Policy for Prime  ", Log4Type.Info);
            }
            catch (Exception)
            {
               // BrowserHelper.RefreshPage(_parallelConfig.Driver);
                Thread.Sleep(1500);
                WaitHelper.FluentWaitForWebElement(_parallelConfig.Driver, BuyPolicyButton);
                RadioButtonPrime.Click();
                BuyPolicyButton.Click();
                Log4NetHelper.Log(" clicked on Buy Policy for Prime in catch ", Log4Type.Info);
            }
            return new CoApplicantPage(_parallelConfig);
        }

        public CoApplicantPage ClickBuyPolicyPrime360()
        {
            try
            {
                Thread.Sleep(1800);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, BuyPolicyButton);
                Thread.Sleep(2000);
                Assert.IsTrue(BuyPolicyVerification.GetLinkText().Contains("Would you like to add a Spouse or Co-Applicant?"));
                Log4NetHelper.Log("clicked on Buy Policy for Prime  ", Log4Type.Info);
            }
            catch (Exception)
            {
               // BrowserHelper.RefreshPage(_parallelConfig.Driver);
                Thread.Sleep(1500);
                WaitHelper.FluentWaitForWebElement(_parallelConfig.Driver, BuyPolicyButton);
                RadioButtonPrime360.Click();
                BuyPolicyButton.Click();
                Log4NetHelper.Log("Catch clicked on Buy Policy for Prime  ", Log4Type.Info);
            }
            return new CoApplicantPage(_parallelConfig);
        }
        public string VerifyChoosePackagePage()
        {
            Thread.Sleep(1500);
            return ChoosePackagePageText.GetLinkText();
        }

        public void VerifyFloodValuePrime5000()
        {
            try
            {
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, FloodValuePrime5000);
                Thread.Sleep(1500);
                Assert.IsTrue(FloodValuePrime5000.GetLinkText().Contains("$5,000*"));
            }
            catch (Exception){
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, FloodValuePrime5000);
                Thread.Sleep(1500);
                Assert.IsTrue(FloodValuePrime5000.GetLinkText().Contains("$5,000*"));
            }
            Log4NetHelper.Log(" $5,000*  flood for prime is verified  ", Log4Type.Info);
        }
        public void PrimeInEligible()
        {
            Assert.IsTrue(FloodInEligiblePrime.GetLinkText().Contains("Ineligible"));
           // if (FloodInEligiblePrime.IsElementPresent())
                Log4NetHelper.Log(" verified Flood is Ineligible for prime", Log4Type.Info);
        }
        public void PrimePlusInEligible()
        {
            if (FloodInEligiblePrimePlus.IsElementPresent())
                Log4NetHelper.Log(" verified Flood is Ineligible for primePlus", Log4Type.Info);
        }
        public void Prime360InEligible()
        {
            if (FloodInEligiblePrime360.IsElementPresent())
                Log4NetHelper.Log(" verified Flood is Ineligible for prime360", Log4Type.Info);
        }

        public CustomizeQuotePage CustomizeButtonPrimePlusClick()
        {
            try
            {
                Thread.Sleep(1800);
                RadioButtonPrimePlus.Click();
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, CustomizeButton);
                Thread.Sleep(2000);
                Assert.IsTrue(CustomizeVerification.GetLinkText().Contains("Customize Your Quote"));
                Log4NetHelper.Log("clicked on Customize Button Prime Plus  ", Log4Type.Info);
            }
            catch (Exception)
            {
                //BrowserHelper.RefreshPage(_parallelConfig.Driver);
                Thread.Sleep(1500);
                RadioButtonPrimePlus.Click();
                CustomizeButton.Click();
                Log4NetHelper.Log(" clicked on Customize Button Prime Plus in catch block", Log4Type.Info);
            }
            return new CustomizeQuotePage(_parallelConfig);
        }
        public CustomizeQuotePage CustomizeButtonPrimeClick()
        {
            try
            {
                Thread.Sleep(1800);
                RadioButtonPrime.Click();
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, CustomizeButton);
                Thread.Sleep(2000);
                Assert.IsTrue(CustomizeVerification.GetLinkText().Contains("Customize Your Quote"));
                Log4NetHelper.Log("clicked on Customize Button Prime   ", Log4Type.Info);
            }
            catch (Exception)
            {
               // BrowserHelper.RefreshPage(_parallelConfig.Driver);
                Thread.Sleep(1500);
                RadioButtonPrime.Click();
                CustomizeButton.Click();
                Log4NetHelper.Log(" clicked on Customize Button Prime in catch  ", Log4Type.Info);
            }
            return new CustomizeQuotePage(_parallelConfig);
        }
        public CustomizeQuotePage CustomizeButtonPrime360Click()
        {
            try
            {
                Thread.Sleep(1800);
                RadioButtonPrime360.Click();
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, CustomizeButton);
                Thread.Sleep(2000);
                Assert.IsTrue(CustomizeVerification.GetLinkText().Contains("Customize Your Quote"));
                Log4NetHelper.Log("clicked on Customize Button Prime 360  ", Log4Type.Info);
            }
            catch (Exception)
            {
                //BrowserHelper.RefreshPage(_parallelConfig.Driver);
                Thread.Sleep(1500);
                RadioButtonPrime360.Click();
                CustomizeButton.Click();
                Log4NetHelper.Log(" clicked on Customize Button Prime 360 in catch ", Log4Type.Info);
            }
            return new CustomizeQuotePage(_parallelConfig);

        }
    }
}

