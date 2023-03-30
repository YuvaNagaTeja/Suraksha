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
    public class DeclinationsPageSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;
        string fileName = Environment.CurrentDirectory.ToString() + Settings.ExcelFileNamePath;
        public DeclinationsPageSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        [Then(@"I click Next button for declinations")]
        public void ThenIClickNextButtonForDeclinations()
        {
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<DeclinationsPage>().ClickNextButton();
        }

        [When(@"I Select This home is rented")]
        public void WhenISelectThisHomeIsRented()
        {
            _parallelConfig.CurrentPage.As<DeclinationsPage>().SelectedHomeIsRented();
        }

        [When(@"I Select This home has unrepaired damaged")]
        public void WhenISelectThisHomeHasUnrepairedDamaged()
        {
            _parallelConfig.CurrentPage.As<DeclinationsPage>().SelectUnrepairedDamage();
        }

        [When(@"I Select This home is under construction or renovation\.")]
        public void WhenISelectThisHomeIsUnderConstructionOrRenovation_()
        {
            _parallelConfig.CurrentPage.As<DeclinationsPage>().SelectUnderConstruction();
        }

        [When(@"I Select This home has barred doors/windows without quick-release")]
        public void WhenISelectThisHomeHasBarredDoorsWindowsWithoutQuick_Release()
        {
            _parallelConfig.CurrentPage.As<DeclinationsPage>().SelectBarredDoors();
        }

        [When(@"I Select This home is located on more then (.*) acres")]
        public void WhenISelectThisHomeIsLocatedOnMoreThenAcres(int p0)
        {
            _parallelConfig.CurrentPage.As<DeclinationsPage>().SelectTenAcres();
        }

        [When(@"I Select This home has had prior flood damage\.")]
        public void WhenISelectThisHomeHasHadPriorFloodDamage_()
        {
            _parallelConfig.CurrentPage.As<DeclinationsPage>().SelectPriorFloodDamage();
        }

        [When(@"I Select This home has solar panels\.")]
        public void WhenISelectThisHomeHasSolarPanels_()
        {
            _parallelConfig.CurrentPage.As<DeclinationsPage>().SelectHomeSolarPanels();
        }


        [When(@"click yes for prior flood damage")]
        public void WhenClickYesForPriorFloodDamage()
        {
            _parallelConfig.CurrentPage = new DeclinationsPage(_parallelConfig);
         _parallelConfig.CurrentPage.As<DeclinationsPage>().ClickPriorFloodDamageButton();
        }


        [Then(@"I click Next button for declinations and I verify Thankyou is displayed")]
        public void ThenIClickNextButtonForDeclinationsAndIVerifyThankyouIsDisplayed()
        {
            _parallelConfig.CurrentPage.As<DeclinationsPage>().VerifyThankyouPopup();
        }

    }
}
