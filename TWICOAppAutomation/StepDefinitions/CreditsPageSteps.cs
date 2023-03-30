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
    public class CreditsPageSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;
        string fileName = Environment.CurrentDirectory.ToString() + Settings.ExcelFileNamePath;

        public CreditsPageSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }
        [Then(@"I enter YearPurchased ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenIEnterYearPurchasedForFrom(string yearPurchased, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage.As<CreditsPage>().EnterYearPurchased(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, yearPurchased)));
        }

        [Then(@"I select wiring replaced and enter ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenISelectWiringReplacedAndEnterForFrom(string wiringReplaced, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage = new CreditsPage(_parallelConfig);
             _parallelConfig.CurrentPage.As<CreditsPage>().ClickWiringReplaced();
            _parallelConfig.CurrentPage.As<CreditsPage>().EnterWiringReplaced(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, wiringReplaced)));
        }
        [Then(@"I select plumbing replaced and enter ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenISelectPlumbingReplacedAndEnterForFrom(string plumbingReplaced, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage = new CreditsPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<CreditsPage>().ClickPlumbingReplaced();
            _parallelConfig.CurrentPage.As<CreditsPage>().EnterPlumbingReplaced(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, plumbingReplaced)));

        }

        [Then(@"I select heating replaced and enter ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenISelectHeatingReplacedAndEnterForFrom(string heatingReplaced, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage = new CreditsPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<CreditsPage>().ClickHeatingReplaced();
            _parallelConfig.CurrentPage.As<CreditsPage>().EnterHeatingReplaced(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, heatingReplaced)));
        }

        [Then(@"I select Smoke Detectors, motion detectors, central monitored fire")]
        public void ThenISelectSmokeDetectorsMotionDetectorsCentralMonitoredFire()
        {
            _parallelConfig.CurrentPage.As<CreditsPage>().SelectSmokeDetectors();
            _parallelConfig.CurrentPage.As<CreditsPage>().MotionDetectors();
            _parallelConfig.CurrentPage.As<CreditsPage>().SelectCentralMonitoredFire();
        }

        [Then(@"I select auto ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenISelectAutoForFrom(string auto, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage.As<CreditsPage>().SelectAuto(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, auto)));

        }

        [Then(@"I select local fire, deadbolts, smoke detectors")]
        public void ThenISelectLocalFireDeadboltsSmokeDetectors()
        {
            _parallelConfig.CurrentPage.As<CreditsPage>().Local();
            _parallelConfig.CurrentPage.As<CreditsPage>().DeadBolts();
            _parallelConfig.CurrentPage.As<CreditsPage>().SelectSmokeDetectors();
        }

        [Then(@"I select local fire, deadbolts, Motion detectors")]
        public void ThenISelectLocalFireDeadboltsMotionDetectors()
        {
            _parallelConfig.CurrentPage.As<CreditsPage>().Local();
            _parallelConfig.CurrentPage.As<CreditsPage>().DeadBolts();
            _parallelConfig.CurrentPage.As<CreditsPage>().MotionDetectors();
        }



        [Then(@"I select flood ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenISelectFloodForFrom(string flood, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage.As<CreditsPage>().SelectFlood(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, flood)));
        }

        [Then(@"I select AffinityGroup ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenISelectAffinityGroupForFrom(string affinity, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage.As<CreditsPage>().BusinessOrProfessionalGroup(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, affinity)));
        }

        [Then(@"I select Umbrella ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenISelectUmbrellaForFrom(string umbrella, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage.As<CreditsPage>().SelectUmbrella(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, umbrella)));
        }

        [Then(@"I select deadbolts,Smoke Detectors, motion detectors, central monitored fire")]
        public void ThenISelectDeadboltsSmokeDetectorsMotionDetectorsCentralMonitoredFire()
        {
            _parallelConfig.CurrentPage.As<CreditsPage>().DeadBolts();
            _parallelConfig.CurrentPage.As<CreditsPage>().SelectSmokeDetectors();
            _parallelConfig.CurrentPage.As<CreditsPage>().MotionDetectors();
            _parallelConfig.CurrentPage.As<CreditsPage>().SelectCentralMonitoredFire();
        }
        [Then(@"I select gated neighbourhood")]
        public void ThenISelectGatedNeighbourhood()
        {
            _parallelConfig.CurrentPage.As<CreditsPage>().ClickGated();
        }

        [Then(@"I Select Local Fire/Burglar")]
        public void ThenISelectLocalFireBurglar()
        {
            _parallelConfig.CurrentPage.As<CreditsPage>().Local();
        }

        [Then(@"I click Next button for credits page")]
        public void ThenIClickNextButtonForCreditsPage()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<CreditsPage>().ClickNextButton();

        }
        [Then(@"A model pop should open and I click Ok")]
        public void ThenAModelPopShouldOpenAndIClickOk()
        {
           _parallelConfig.CurrentPage.As<CreditsPage>().PopUpWindowClick();

        }
        [Then(@"I verify that next button should not be clickable")]
        public void ThenIVerifyThatNextButtonShouldNotBeClickable()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<CreditsPage>().ClickNextButton();
        }
        [Then(@"I select Accredited Builders ""(.*)"" for ""(.*)"" from ""(.*)""")]
        public void ThenISelectAccreditedBuildersForFrom(string accBuilders, string testCase, string sheetName)
        {
            _parallelConfig.CurrentPage.As<CreditsPage>().SelectAccreditedBuilders(Convert.ToString(ExcelReaderHelper.GetCellDataKey(fileName, sheetName, testCase, accBuilders)));

        }

    }
}


