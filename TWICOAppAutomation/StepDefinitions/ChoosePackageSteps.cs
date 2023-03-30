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
    public class ChoosePackageSteps :BaseStep 
    {
        private readonly ParallelConfig _parallelConfig;
        string fileName = Environment.CurrentDirectory.ToString() + Settings.ExcelFileNamePath;
        public ChoosePackageSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        [Then(@"I click on Buy Policy for primeplus button")]
        public void ThenIClickOnBuyPolicyForPrimeplusButton()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ChoosePackagePage>().ClickBuyPolicyPrimePlus();

        }

        [Then(@"I click on Buy Policy for prime button")]
        public void ThenIClickOnBuyPolicyForPrimeButton()
        {
            _parallelConfig.CurrentPage = new ChoosePackagePage(_parallelConfig);
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ChoosePackagePage>().ClickBuyPolicyPrime();
        }


        [Then(@"I verify text for Flood Eligibility in the choose package page for prime \(FiveThousand\) is displayed")]
        public void ThenIVerifyTextForFloodEligibilityInTheChoosePackagePageForPrimeFiveThousandIsDisplayed()
        {
            _parallelConfig.CurrentPage = new ChoosePackagePage(_parallelConfig);
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyFloodValuePrime5000();
        }


        [Then(@"I verify text for wind/hail exclusion in the choose package page")]
        public void ThenIVerifyTextForWindHailExclusionInTheChoosePackagePage()
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyWindORHailExcluded();
            
        }

        [Then(@"I verify text for wind/hail exclusion deductible is Two% in the choose package page")]
        public void ThenIVerifyTextForWindHailExclusionDeductibleIsTwoInTheChoosePackagePage()
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyWindORHail2Percentage();
        }

        [Then(@"I verify text for wind/hail exclusion deductible is One% in the choose package page")]
        public void ThenIVerifyTextForWindHailExclusionDeductibleIsOneInTheChoosePackagePage()
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyWindORHail1Percentage();
        }

        [Then(@"I click on customize for prime button")]
        public void ThenIClickOnCustomizeForPrimeButton()
        {
            _parallelConfig.CurrentPage = new ChoosePackagePage(_parallelConfig);
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ChoosePackagePage>().CustomizeButtonPrimeClick();
        }
        [Then(@"I click on customize for primeplus button")]
        public void ThenIClickOnCustomizeForPrimeplusButton()
        {
            _parallelConfig.CurrentPage = new ChoosePackagePage(_parallelConfig);
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ChoosePackagePage>().CustomizeButtonPrimePlusClick();
        }
        [Then(@"I click on Buy Policy for prime button\(ThreeSixty\)")]
        public void ThenIClickOnBuyPolicyForPrimeButtonThreeSixty()
        {
            
        _parallelConfig.CurrentPage = new ChoosePackagePage(_parallelConfig);
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ChoosePackagePage>().ClickBuyPolicyPrime360();
        }


        [Then(@"I click on customize for prime\(ThreeSixty\) button")]
        public void ThenIClickOnCustomizeForPrimeThreeSixtyButton()
        {
            _parallelConfig.CurrentPage = new ChoosePackagePage(_parallelConfig);

            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<ChoosePackagePage>().CustomizeButtonPrime360Click();
        }

        [Then(@"I compare the premium for ""(.*)"",""(.*)"" and ""(.*)"" in choose package page for ""(.*)"" from ""(.*)""")]
        public void ThenICompareThePremiumForAndInChoosePackagePageForFrom(string prime, string primePlus, string prime360, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyPrimePremium(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, prime)));
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyPrimePlusPremium(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, primePlus)));
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyPrime360Premium(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, prime360)));

        }
        [Then(@"I verify text for Flood Eligibility  in the choose package page of prime plus Ineligible is displayed")]
        public void ThenIVerifyTextForFloodEligibilityInTheChoosePackagePageOfPrimePlusIneligibleIsDisplayed()
        {
            _parallelConfig.CurrentPage = new ChoosePackagePage(_parallelConfig);
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyFloodInelegiblePrime();
        }
        [Then(@"I verify if the Flood is marked as Ineligible for Prime,Prime_plus and Prime_Full")]
        public void ThenIVerifyIfTheFloodIsMarkedAsIneligibleForPrimePrime_PlusAndPrime_Full()
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().PrimeInEligible();
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().PrimePlusInEligible();
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().Prime360InEligible();

        }
        [When(@"I Click the Print option on options page")]
        public void WhenIClickThePrintOptionOnOptionsPage()
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().ClickPrintOption();
        }
        [Then(@"I Select Twico Prime")]
        public void ThenISelectTwicoPrime()
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().SelectTwicoPrime();
        }
        [Then(@"I Select Twico PrimePlus")]
        public void ThenISelectTwicoPrimePlus()
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().SelectTwicoPrimePlus();
        }

        [Then(@"I Select Twico Prime\(ThreeSixty\)")]
        public void ThenISelectTwicoPrimeThreeSixty()
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().SelectTwicoPrime360();
        }

        [Then(@"I click on Print Button And I verify ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIClickOnPrintButtonAndIVerifyForFrom(string validation, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().ClickPrintPDF(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, validation)));
        }
        [Then(@"I verify Medical payment for PrimePlus in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyMedicalPaymentForPrimePlusInOptionsPageIsForFrom(string opverification, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyMedicalPaymentPrimePlus(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, opverification)));
        }

        [Then(@"I verify Medical payment for Prime\(ThreeSixty\) in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyMedicalPaymentForPrimeThreeSixtyInOptionsPageIsForFrom(string opverification, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyMedicalPaymentPrime360(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, opverification)));
        }

        [Then(@"I verify Medical payment for Prime in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyMedicalPaymentForPrimeInOptionsPageIsForFrom(string opverification, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyMedicalPaymentPrime(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, opverification)));
        }
        [Then(@"I verify Loss Assessment for PrimePlus in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyLossAssessmentForPrimePlusInOptionsPageIsForFrom(string opverification, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyLossAssessmentPrimePlus(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, opverification)));
        }

        [Then(@"I verify Loss Assessment for Prime\(ThreeSixty\) in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyLossAssessmentForPrimeThreeSixtyInOptionsPageIsForFrom(string opverification, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyLossAssessmentPrime360(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, opverification)));
        }
        [Then(@"I verify Loss Assessment for Prime in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyLossAssessmentForPrimeInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyLossAssessmentPrime(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        [Then(@"I verify Contents replacement for PrimePlus in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyContentsReplacementForPrimePlusInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyContentsReplacementPrimePlus(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        [Then(@"I verify Contents replacement for Prime in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyContentsReplacementForPrimeInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyContentsReplacementPrime(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        [Then(@"I verify Contents replacement for Prime\(ThreeSixty\) in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyContentsReplacementForPrimeThreeSixtyInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyContentsReplacementPrime360(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        [Then(@"I verify Water Backup for PrimePlus in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyWaterBackupForPrimePlusInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyWaterBackupPrimePlus(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }
        [Then(@"I verify Water Backup for Prime in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyWaterBackupForPrimeInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyWaterBackupPrime(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        [Then(@"I verify Water Backup for Prime\(ThreeSixty\) in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyWaterBackupForPrimeThreeSixtyInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyWaterBackupPrime360(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        [Then(@"I verify Mold for PrimePlus in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyMoldForPrimePlusInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyMoldPrimePlus(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        [Then(@"I verify Mold for Prime in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyMoldForPrimeInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyMoldPrime(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        [Then(@"I verify Mold for Prime\(ThreeSixty\) in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyMoldForPrimeThreeSixtyInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyMoldPrime360(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }
       
        [Then(@"I verify  Check Ordinance or Law for Prime in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyCheckOrdinanceOrLawForPrimeInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyOrdinanceOrLawPrime(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }
        [Then(@"I verify Dog Liability for Prime\(ThreeSixty\) in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyDogLiabilityForPrimeThreeSixtyInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyDogLiabilityPrime360(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }
        [Then(@"I verify Dog Liability for Prime in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyDogLiabilityForPrimeInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyDogLiabilityPrime(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        [Then(@"I verify Dog Liability for PrimePlus in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyDogLiabilityForPrimePlusInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyDogLiabilityPrimePlus(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        [Then(@"I verify Identity Theft for Prime\(ThreeSixty\) in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyIdentityTheftForPrimeThreeSixtyInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyIdentityTheftPrime360(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        [Then(@"I verify Systems Protection for PrimePlus in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifySystemsProtectionForPrimePlusInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifySystemsProtectionPrimePlus(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }


        [Then(@"I verify Systems Protection for Prime in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifySystemsProtectionForPrimeInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifySystemsProtectionPrime(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        

        [Then(@"I verify Identity Theft for Prime in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyIdentityTheftForPrimeInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyIdentityTheftPrime(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        [Then(@"I verify Identity Theft for PrimePlus in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyIdentityTheftForPrimePlusInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyIdentityTheftPrimePlus(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        [Then(@"I verify Increased Limits for Prime\(ThreeSixty\) in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyIncreasedLimitsForPrimeThreeSixtyInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyIncreasedLimitsPrime360(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        [Then(@"I verify Increased Limits for Prime in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyIncreasedLimitsForPrimeInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyIncreasedLimitsPrime(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        [Then(@"I verify Increased Limits for Prime Plus in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyIncreasedLimitsForPrimePlusInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyIncreasedLimitsPrimePlus(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }


        [Then(@"I verify Personal Injury for Prime Plus in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyPersonalInjuryForPrimePlusInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyPersonalInjuryPrimePlus(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        [Then(@"I verify Personal Injury for Prime in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyPersonalInjuryForPrimeInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyPersonalInjuryPrime(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        
        [Then(@"I verify Personal Injury for Prime\(ThreeSixty\) in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyPersonalInjuryForPrimeThreeSixtyInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyPersonalInjuryPrime360(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        [Then(@"I verify Systems Protection for Prime\(ThreeSixty\) in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifySystemsProtectionForPrimeThreeSixtyInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifySystemsProtectionPrime360(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }


        [Then(@"I verify Service Line for Prime Plus in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyServiceLineForPrimePlusInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyServiceLinePrimePlus(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        [Then(@"I verify Service Line for Prime in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyServiceLineForPrimeInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyServiceLinePrime(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }


        [Then(@"I verify Service Line for Prime\(ThreeSixty\) in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyServiceLineForPrimeThreeSixtyInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyServiceLinePrime360(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }
        [Then(@"I verify water Seepage for PrimePlus in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyWaterSeepageForPrimePlusInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyWaterSeepagePrimePlus(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        [Then(@"I verify water Seepage for PrimeThreeSixty in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyWaterSeepageForPrimeThreeSixtyInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyWaterSeepagePrime360(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        [Then(@"I verify Cyber protection for Prime Plus in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyCyberProtectionForPrimePlusInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyCyberProtectionPrimePlus(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        [Then(@"I verify Cyber protection for PrimeThreeSixty in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyCyberProtectionForPrimeThreeSixtyInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyCyberProtectionPrime360(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

        [Then(@"I verify Data Breach for PrimeThreeSixty in options page is ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIVerifyDataBreachForPrimeThreeSixtyInOptionsPageIsForFrom(string opverification, string testcase, string sheetname)
        {
            _parallelConfig.CurrentPage.As<ChoosePackagePage>().VerifyDataBreachPrime360(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetname, testcase, opverification)));
        }

    }

}



