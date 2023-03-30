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
    public class InformationNeededSteps : BaseStep
    {

        private readonly ParallelConfig _parallelConfig;
        string fileName = Environment.CurrentDirectory.ToString() + Settings.ExcelFileNamePath;

        public InformationNeededSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        [Then(@"I enter RoofyearReplaced ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIEnterRoofyearReplacedForFrom(string roof, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage.As<InformationNeededPage>().EnterRoofReplaced(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, roof)));
        }

        [Then(@"I enter SquareFootage ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIEnterSquareFootageForFrom(string squareFootage, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage.As<InformationNeededPage>().EnterSquareFootage(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, squareFootage)));
        }
        [Then(@"I enter stories ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIEnterStoriesForFrom(string stories, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage.As<InformationNeededPage>().SelectStories(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, stories)));
        }

        [Then(@"I Click on Pool")]
        public void ThenIClickOnPool()
        {
            _parallelConfig.CurrentPage = new InformationNeededPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<InformationNeededPage>().ClickPool();
        }

        [Then(@"I Click on Pool Diving Board")]
        public void ThenIClickOnPoolDivingBoard()
        {
            _parallelConfig.CurrentPage = new InformationNeededPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<InformationNeededPage>().ClickPoolDivingBoard();
        }


        [Then(@"I select FEMAFloodZone ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenISelectFEMAFloodZoneForFrom(string FEMAFloodZone, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage = new InformationNeededPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<InformationNeededPage>().SelectFEMAFloodZone(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, FEMAFloodZone)));
        }

        [Then(@"I select RoofType ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenISelectRoofTypeForFrom(string roofMaterial, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage = new InformationNeededPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<InformationNeededPage>().SelectRoofMaterial(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, roofMaterial)));
        }

        [Then(@"I select ExteriorMaterial ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenISelectExteriorMaterialForFrom(string exteriorMaterial, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage = new InformationNeededPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<InformationNeededPage>().SelectExteriorMaterial(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, exteriorMaterial)));
        }

        [Then(@"I enter YearBuilt ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIEnterYearBuiltForFrom(string yearBuilt,string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage = new InformationNeededPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<InformationNeededPage>().EnterYearBuilt(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, yearBuilt)));

        }
        [Then(@"I verify Actual Cash Value Loss Settlement – Roof endorsement is displayed or not")]
        public void ThenIVerifyActualCashValueLossSettlementRoofEndorsementIsDisplayedOrNot()
        {
            _parallelConfig.CurrentPage = new InformationNeededPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<InformationNeededPage>().VerifyACVWarningMessage();

        }
        [Then(@"I verify Roof Exclusion will be applied to this policy\.")]
        public void ThenIVerifyRoofExclusionWillBeAppliedToThisPolicy_()
        {
            _parallelConfig.CurrentPage.As<InformationNeededPage>().VerifyRoofExclusionMessage();
        }

        [Then(@"I verify Non-Structural Hail Loss Limitation is displayed or not")]
        public void ThenIVerifyNon_StructuralHailLossLimitationIsDisplayedOrNot()
        {
            _parallelConfig.CurrentPage.As<InformationNeededPage>().VerifyNonStructuralHailMessage();
        }
        [Then(@"I verify Limited Water Damage Coverage endorsement is displayed or not")]
        public void ThenIVerifyLimitedWaterDamageCoverageEndorsementIsDisplayedOrNot()
        {
            _parallelConfig.CurrentPage.As<InformationNeededPage>().VerifyLimitedWaterDamageCoverageText();
        }
        [Then(@"I verify Due to age, this risk is subject to Functional Replacement Cost")]
        public void ThenIVerifyDueToAgeThisRiskIsSubjectToFunctionalReplacementCost()
        {
            _parallelConfig.CurrentPage.As<InformationNeededPage>().VerifyFunctionalReplacementCostText();
        }

        [Then(@"I click Next button for informationneeded page")]
        public void ThenIClickNextButtonForInformationneededPage()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<InformationNeededPage>().ClickNextButton();
        }
        [Then(@"I verify text for Risk is Ineligible in the Informationneeded page")]
        public void ThenIVerifyTextForRiskIsIneligibleInTheInformationneededPage()
        {
            _parallelConfig.CurrentPage.As<InformationNeededPage>().VerifyRiskIneligibleMessage();
        }

        [Then(@"I verify verbiage under Roof type")]
        public void ThenIVerifyVerbiageUnderRoofType()
        {
            _parallelConfig.CurrentPage = new InformationNeededPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<InformationNeededPage>().VerifyACVWarningMessage();
        }


    }

}
