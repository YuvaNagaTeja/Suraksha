using CSharpAFProject.Base;
using CSharpAFProject.Config;
using CSharpAFProject.ExcelReader;
using CSharpAFProject.Helpers;
using System;
using TechTalk.SpecFlow;
using TWICOAppAutomation.Pages;

namespace TWICOAppAutomation.StepDefinitions
{
    [Binding]
    public class CustomizeQuoteSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;
        string fileName = Environment.CurrentDirectory.ToString() + Settings.ExcelFileNamePath;
        public CustomizeQuoteSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        [Then(@"I Verify that Wind/Hail Exclusion is Displayed")]
        public void ThenIVerifyThatWindHailExclusionIsDisplayed()
        {
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().VerifyWindHailExclusion();
        }

        [Then(@"I click on water damage seepage")]
        public void ThenIClickOnWaterDamageSeepage()
        {
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().SelectWaterSeepage();
        }

        [Then(@"I verify Flood Coverage should be showing on Customize page Under Flood section")]
        public void ThenIVerifyFloodCoverageShouldBeShowingOnCustomizePageUnderFloodSection()
        {
            _parallelConfig.CurrentPage = new CustomizeQuotePage(_parallelConfig);
           _parallelConfig.CurrentPage.As<CustomizeQuotePage>().VerifyFloodCoverage();
        }


        [Then(@"I click on Buy Policy")]
        public void ThenIClickOnBuyPolicy()
        {
            _parallelConfig.CurrentPage= _parallelConfig.CurrentPage.As<CustomizeQuotePage>().ClickBuyPolicy();
        }

        [Then(@"I click on recalculate button")]
        public void ThenIClickOnRecalculateButton()
        {
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().RecalculateBtn();
        }

        [Then(@"I verify the message under added SPP  Individual items must be FiveThousand or less\.")]
        public void ThenIVerifyTheMessageUnderAddedSPPIndividualItemsMustBeFiveThousandOrLess_()
        { 
        _parallelConfig.CurrentPage.As<CustomizeQuotePage>().VerifySPP5000();
        }

        [Then(@"I verify the message under added SPP  Total scheduled amount must be TwentyThousand or less\.")]
        public void ThenIVerifyTheMessageUnderAddedSPPTotalScheduledAmountMustBeTwentyThousandOrLess_()
        {
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().VerifySPP20000();
        }

        [Then(@"I verify the message under added SPP Appraisals or a bill of sale and a color photo must accompany single items worth TwoThousand or more\.")]
        public void ThenIVerifyTheMessageUnderAddedSPPAppraisalsOrABillOfSaleAndAColorPhotoMustAccompanySingleItemsWorthTwoThousandOrMore_()
        {
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().VerifySPP2000();
        }


        [Then(@"I enter waterbackup as ""(.*)"" for ""(.*)"" from ""(.*)"" and verify selectable or not")]
        public void ThenIEnterWaterbackupAsForFromAndVerifySelectableOrNot(string waterBackup, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().SelectWaterBackup(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, waterBackup)));
        }

        [Then(@"I click yes for Do you have a Pit Bull")]
        public void ThenIClickYesForDoYouHaveAPitBull()
        {
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().ClickPitBullButton();
        }

        [Then(@"I verify message displayed under Do you have a Pit Bull")]
        public void ThenIVerifyMessageDisplayedUnderDoYouHaveAPitBull()
        {
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().VerifyMessagePitBull();
        }

        [Then(@"I click on Scheduled personal property and select ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIClickOnScheduledPersonalPropertyAndSelectForFrom(string sppClass, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage = new CustomizeQuotePage(_parallelConfig);
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().ClickSPP();
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().EnterSPPClass(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, sppClass)));
        }

        [Then(@"I enter ""(.*)"", ""(.*)"" for ""(.*)"" from ""(.*)"" and click add")]
        public void ThenIEnterForFromAndClickAdd(string sppDesc, string sppAmount, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().EnterSPPDescription(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, sppDesc)));
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().EnterSPPAmount(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, sppAmount)));
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().ClickSPPAdd();
        }


        [Then(@"I select home sytem protection")]
        public void ThenISelectHomeSytemProtection()
        {
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().ClickHomeSystemButton();

        }

        [Then(@"I click on service line and select ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIClickOnServiceLineAndSelectForFrom(string limit, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().ClickServiceLine();
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().SelectServiceLineLimit(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, limit)));

        }

        [Then(@"I select home cyber protection")]
        public void ThenISelectHomeCyberProtection()
        {
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().ClickHomeCyberButton();
        }

        [When(@"I select data breach protection and select ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void WhenISelectDataBreachProtectionAndSelectForFrom(string limit, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().ClickDataBreachButton();
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().SelectHCPLimit(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, limit)));
        }

        [When(@"I select extended liability and enter ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void WhenISelectExtendedLiabilityAndEnterForFrom(string addResidences, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().ClickELButton();
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().EnterELAddResidences(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, addResidences)));
        }

        [When(@"I select is rented and enter ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void WhenISelectIsRentedAndEnterForFrom(string families, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().EnterELIsRented();
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().EnterELFamilies(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, families)));

        }

        [When(@"I enter ""(.*)"",""(.*)"", ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void WhenIEnterForFrom(string address, string city, string zip, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().EnterELAddress(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, address)));
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().EnterELCity(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, city)));
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().EnterELZip(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, zip)));
        }
        [When(@"I Select is rented and number of families ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void WhenISelectIsRentedAndNumberOfFamiliesForFrom(string families, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().EnterELIsRentedTwo();
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().EnterELFamiliesTwo(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, families)));
        }

        [When(@"I Enter another details ""(.*)"", ""(.*)"", ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void WhenIEnterAnotherDetailsForFrom(string address, string city, string zip, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().EnterELAddressTwo(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, address)));
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().EnterELCityTwo(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, city)));
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().EnterELZipTwo(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, zip)));
        }
        [Then(@"I Select Foundation, IncreasedReplacementCost and I Enter ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenISelectFoundationIncreasedReplacementCostAndIEnterForFrom(string ircLimit, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().ClickIRCButton();
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().SelectIRCLimit(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, ircLimit)));
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().ClickFoundationCoverage();

        }
        [When(@"I select Watercraft and enter ""(.*)"" and ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void WhenISelectWatercraftAndEnterAndForFrom(string engine, string horsePower, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().ClickWaterCraft();
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().SelectEngineType(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, engine)));
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().SelectHorsePower(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, horsePower)));
        }
        [Then(@"I compare the premium ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenICompareThePremiumForFrom(string premium, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().VerifyPremiumInCustomize(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, premium)));

        }
        [Then(@"I verify Message is displayed on Customize page:Your location is ineligible for Flood coverage\. However, you may still add Limited Water Backup coverage")]
        public void ThenIVerifyMessageIsDisplayedOnCustomizePageYourLocationIsIneligibleForFloodCoverage_HoweverYouMayStillAddLimitedWaterBackupCoverage()
        {
             _parallelConfig.CurrentPage = new CustomizeQuotePage(_parallelConfig);
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().VerifyIneligibleFloodCoverage();

        }
        [Then(@"I verify text for wind/hail exclusion deductible is Two% in the customize qoute page")]
        public void ThenIVerifyTextForWindHailExclusionDeductibleIsTwoInTheCustomizeQoutePage()
        {
            _parallelConfig.CurrentPage = new CustomizeQuotePage(_parallelConfig);
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().VerifyTwoPerDisplayed();
        }
        [Then(@"I verify message displayed the verbiage on Customize page under Home coverage slider")]
        public void ThenIVerifyMessageDisplayedTheVerbiageOnCustomizePageUnderHomeCoverageSlider()
        {
            _parallelConfig.CurrentPage = new CustomizeQuotePage(_parallelConfig);
            _parallelConfig.CurrentPage.As<CustomizeQuotePage>().VerifyMessageHomeCoverageA();
        }


    }
}
