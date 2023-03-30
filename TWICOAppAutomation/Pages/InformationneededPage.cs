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
    public class InformationNeededPage : BasePage
    {
        public InformationNeededPage(ParallelConfig parallelConfig) : base(parallelConfig) { }
        public IWebElement SquareFootage => _parallelConfig.Driver.FindByXpath("//*[@id='squareFeet']");//label[text()='Square Footage']
        public IWebElement Stories => _parallelConfig.Driver.FindByXpath("//*[@id='numberOfStories']");
        public IWebElement YearBuilt => _parallelConfig.Driver.FindByXpath("//input[@id='yearBuilt']");
        public IWebElement ExteriorMaterial => _parallelConfig.Driver.FindByXpath("//select[@id='constructionType']");
        public IWebElement RoofMaterial => _parallelConfig.Driver.FindByXpath("//select[@id='roofMaterial']");
        public IWebElement IsThereaPool => _parallelConfig.Driver.FindByCss("#swimmingPool .md-bar");
        public IWebElement FEMAFloodZone => _parallelConfig.Driver.FindByXpath("//select[@id='femaFloodZone']");
        public IWebElement ClickNextBtn => _parallelConfig.Driver.FindByXpath("(//button[@class='button'])[2]");
        public IWebElement RoofMaterialText => _parallelConfig.Driver.FindByXpath("//label[contains(text(),'Actual Cash Value Loss Settlement – Roof')]");
        public IWebElement LimitedWaterDamageCoverageText => _parallelConfig.Driver.FindByXpath("//label[contains(text(),'Limited Water Damage Coverage')]");
        public IWebElement RoofExclusionText => _parallelConfig.Driver.FindByXpath("//label[contains(text(),'Roof Exclusion')]");
        public IWebElement NonStructuralHailText => _parallelConfig.Driver.FindByXpath("//label[contains(text(),'Non-Structural Hail Loss Limitation')]");
        public IWebElement RiskIneligibleText => _parallelConfig.Driver.FindByCss(".validation-error");                                                                                             
        public IWebElement Pool => _parallelConfig.Driver.FindByXpath("//*[contains(text(),'Is there a pool?')]//following::*[@class='onoffswitch-switch']");
        public IWebElement PoolDivingBoard => _parallelConfig.Driver.FindByXpath("//*[contains(text(),'Is there a diving board or slide?')]//following::*[@class='onoffswitch-switch']");
        public IWebElement FunctionalReplacementCostText => _parallelConfig.Driver.FindByXpath("//label[contains(text(),'Due to age, this risk is subject to Functional Replacement Cost.')]");
        public IWebElement InformationNeededPageText => _parallelConfig.Driver.FindByCss(".header-title");
        public IWebElement RoofReplaced => _parallelConfig.Driver.FindByXpath("//*[@id='roofYear']");
        public IWebElement Label => _parallelConfig.Driver.FindByXpath("//label[contains(text(),'What is the roof material on this house?*')]");

        public void EnterRoofReplaced(String roofReplaced)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, RoofReplaced);
            RoofReplaced.SendKeys(roofReplaced);
            Log4NetHelper.Log("entered squareFootage " + roofReplaced, Log4Type.Info);
        }
        public void ClickPool()
        {
            try
            {
                Thread.Sleep(1000);
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, Pool);
                PoolDivingBoard.IsElementPresent();
            }
            catch(Exception)
            {
                Pool.Click();
            }
            Log4NetHelper.Log("click Pool ", Log4Type.Info);

        }
        public void ClickPoolDivingBoard()
        {
            Thread.Sleep(1500);
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, PoolDivingBoard);
            Log4NetHelper.Log("click PoolDivingBoard ", Log4Type.Info);
        }
        public void EnterSquareFootage(String squareFootage)
        {
            try
            {
                Thread.Sleep(3000);
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SquareFootage);
                SquareFootage.Clear();
                SquareFootage.SendKeys(squareFootage);
                Log4NetHelper.Log("entered squareFootage " + squareFootage, Log4Type.Info);
            }
            catch (ElementNotVisibleException)
            {
                Thread.Sleep(4000);
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SquareFootage);
                SquareFootage.Clear();
                SquareFootage.SendKeys(squareFootage);
                Log4NetHelper.Log("entered squareFootage in catch" + squareFootage, Log4Type.Info);
            }
        }
        public void SelectStories(String stories)
        {
            try
            {
                Thread.Sleep(1500);
                Stories.SelectDropDownList(stories);
            }
            catch(Exception)
            {
                Thread.Sleep(500);
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Stories);
                Stories.SelectDropDownList(stories);
            }
            Log4NetHelper.Log("selected stories " + stories, Log4Type.Info);
        }
        public void EnterYearBuilt(String yearBuilt)
        {
            if (Convert.ToInt32(yearBuilt) < 100)
            {
                Thread.Sleep(500);
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, YearBuilt);
                YearBuilt.Clear();
                YearBuilt.SendKeys(DateHelper.GetPreviousYear(Convert.ToInt32(yearBuilt)));
                Log4NetHelper.Log("entered yearBuilt " + yearBuilt, Log4Type.Info);
            }
            else
            {
                Thread.Sleep(1000);
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, YearBuilt);
                YearBuilt.Clear();
                YearBuilt.SendKeys(yearBuilt);
                Log4NetHelper.Log(" entered yearBuilt " + yearBuilt, Log4Type.Info);
            }
        }
        public void SelectExteriorMaterial(String exteriorMaterial)
        {
            ExteriorMaterial.SelectDropDownList(exteriorMaterial);
            Log4NetHelper.Log("selected exteriorMaterial " + exteriorMaterial, Log4Type.Info);
        }
        public void SelectRoofMaterial(String roofMaterial)
        {
            try
            {
                Thread.Sleep(500);
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, RoofMaterial);
                RoofMaterial.SelectDropDownList(roofMaterial);
                Log4NetHelper.Log("selected roofMaterial " + roofMaterial, Log4Type.Info);
            }
            catch(Exception)
            {
                Thread.Sleep(1500);
                RoofMaterial.SelectDropDownList(roofMaterial);
                Log4NetHelper.Log("in catch selected roofMaterial " + roofMaterial, Log4Type.Info);
            }
        }
        public void SelectIsThereaPool()
        {
            if (IsThereaPool.Displayed)
                IsThereaPool.Click();
        }
        public void SelectFEMAFloodZone(String femaFloodZone)
        {
            Thread.Sleep(500);
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, FEMAFloodZone);
            FEMAFloodZone.SelectDropDownList(femaFloodZone);
            Log4NetHelper.Log("selected femaFloodZone " + femaFloodZone, Log4Type.Info);
        }
        public CreditsPage ClickNextButton()
        {
            try
            {
                Thread.Sleep(1000);
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ClickNextBtn);
                ClickNextBtn.Click();
            }
            catch (Exception)
            {
                JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, ClickNextBtn);
            }
            return new CreditsPage(_parallelConfig);
        }
        public void VerifyACVWarningMessage()
        {
            JavaScriptExecutor.ScrollIntoViewAndClick(_parallelConfig.Driver, Label);
            Thread.Sleep(1500);
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, RoofMaterialText);
            Assert.IsTrue(RoofMaterialText.GetLinkText().Contains("Actual Cash Value Loss Settlement – Roof  endorsement will be applied to this policy."));
            Log4NetHelper.Log("Actual Cash Value Loss Settlement text is verified ", Log4Type.Info);
        }

        public void VerifyRoofExclusionMessage()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, RoofExclusionText, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, RoofExclusionText);
            Assert.IsTrue(RoofExclusionText.GetLinkText().Contains("Roof Exclusion  will be applied to this policy."));
            Log4NetHelper.Log("Roof Exclusion text is verified ", Log4Type.Info);
        }
        public void VerifyLimitedWaterDamageCoverageText()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, LimitedWaterDamageCoverageText, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, LimitedWaterDamageCoverageText);
            Assert.IsTrue(LimitedWaterDamageCoverageText.GetLinkText().Contains("Limited Water Damage Coverage"));
            Log4NetHelper.Log("Limited Water Damage Coverage Text text is verified ", Log4Type.Info);
        }

        public void VerifyNonStructuralHailMessage()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, NonStructuralHailText, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, NonStructuralHailText);
            Assert.IsTrue(NonStructuralHailText.GetLinkText().Contains("Non-Structural Hail Loss Limitation  endorsement will be applied to this policy"));
            Log4NetHelper.Log("Non-Structural Hail Loss Limitation text is verified ", Log4Type.Info);
        }
        public void VerifyRiskIneligibleMessage()
        {
            try
            {
                WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, RiskIneligibleText, TimeSpan.FromSeconds(10));
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, RiskIneligibleText);
                Assert.IsTrue(RiskIneligibleText.GetLinkText().Contains("Risk is ineligible based on selected roof material"));
            }
            catch (Exception)
            {
                WaitHelper.FluentWaitForWebElement(_parallelConfig.Driver, RiskIneligibleText);
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, RiskIneligibleText);
                Assert.IsTrue(RiskIneligibleText.GetLinkText().Contains("Risk is ineligible based on selected exterior material"));
            }
            Log4NetHelper.Log("Risk is Ineligible text is verified", Log4Type.Info);
        }

        public void VerifyFunctionalReplacementCostText()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, FunctionalReplacementCostText, TimeSpan.FromSeconds(10));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, FunctionalReplacementCostText);
            Assert.IsTrue(FunctionalReplacementCostText.GetLinkText().Contains("Due to age, this risk is subject to Functional Replacement Cost."));
            Log4NetHelper.Log("Due to age, this risk is subject to Functional Replacement Cost. text is verified", Log4Type.Info);
        }

    }
}

