﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
// Generation customised by SpecFlow.Contrib.Variants
namespace SurakshaAutomation.FeatureFiles
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("BulkUpload")]
    public partial class BulkUploadFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "BulkUpload.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "FeatureFiles", "BulkUpload", "A short summary of the feature", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify user able to Navigate to View Bulk Upload Screen")]
        [NUnit.Framework.CategoryAttribute("TC04_Nikhila(BulkUpload)")]
        public virtual void VerifyUserAbleToNavigateToViewBulkUploadScreen()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify user able to Navigate to View Bulk Upload Screen", null, new string[] {
                        "TC04_Nikhila(BulkUpload)"}, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            testRunner.Given("Enter Suraksha Portal URL in the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("Enter Emaild ID and Password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Click on Sign In button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Verify navigated to Dashboard page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Click Create application on the left side of the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Click on View Bulk Upload in Create application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Verify View Bulk Upload page loaded successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify Financial Institution field is auto populated and non-editable")]
        [NUnit.Framework.CategoryAttribute("Teja")]
        public virtual void VerifyFinancialInstitutionFieldIsAutoPopulatedAndNon_Editable()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify Financial Institution field is auto populated and non-editable", null, new string[] {
                        "Teja"}, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            testRunner.Given("Login into Suraksha Portal as ExternalUser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("Click Create application on the left side of the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Click on Bulk Upload in Create application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Observe the FI field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify FIG able to import the Excel file from the local drive in Upload file fiel" +
            "d")]
        [NUnit.Framework.CategoryAttribute("durgaID3")]
        public virtual void VerifyFIGAbleToImportTheExcelFileFromTheLocalDriveInUploadFileField()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify FIG able to import the Excel file from the local drive in Upload file fiel" +
                    "d", null, new string[] {
                        "durgaID3"}, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            testRunner.Given("Login into Suraksha Portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("Verify navigated to Dashboard page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Click Create application on the left side of the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Click on Bulk Upload in Create application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("User should be able to navigate to Bulk upload screen successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("User should be able to see FI field is auto populated and disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("User should select the file and upload", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify FIG able to download the records when click on Failed number hyperlink")]
        [NUnit.Framework.CategoryAttribute("Teja")]
        public virtual void VerifyFIGAbleToDownloadTheRecordsWhenClickOnFailedNumberHyperlink()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify FIG able to download the records when click on Failed number hyperlink", null, new string[] {
                        "Teja"}, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            testRunner.Given("Enter Suraksha Portal URL in the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("Enter Emaild ID and Password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Click on Sign In button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Click Create application on the left side of the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Click on View Bulk Upload in Create application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Click on Failed number Hyperlink and download\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify FIG able to Navigate to Bulk upload screen")]
        [NUnit.Framework.CategoryAttribute("Pavan")]
        public virtual void VerifyFIGAbleToNavigateToBulkUploadScreen()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify FIG able to Navigate to Bulk upload screen", null, new string[] {
                        "Pavan"}, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            testRunner.Given("Enter Suraksha Portal URL in the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.When("Enter Emaild ID and Password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
            testRunner.Then("Click on Sign In button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Click Create application on the left side of the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Click on Bulk Upload in Create application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("User should be able to navigate to Bulk upload screen successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify FIG able to download the records when click on Success number hyperlink")]
        [NUnit.Framework.CategoryAttribute("Pavan")]
        public virtual void VerifyFIGAbleToDownloadTheRecordsWhenClickOnSuccessNumberHyperlink()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify FIG able to download the records when click on Success number hyperlink", null, new string[] {
                        "Pavan"}, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            testRunner.Given("Login into Suraksha Portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("Verify navigated to Dashboard page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Click Create application on the left side of the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Click on View Bulk Upload in Create application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Verify View Bulk Upload page loaded successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("User should be able to download the success number of records", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify user able to Navigate to Bulk upload screen")]
        [NUnit.Framework.CategoryAttribute("TC1_BulkUpload")]
        [NUnit.Framework.CategoryAttribute("Demo")]
        public virtual void VerifyUserAbleToNavigateToBulkUploadScreen()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify user able to Navigate to Bulk upload screen", null, new string[] {
                        "TC1_BulkUpload",
                        "Demo"}, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            testRunner.Given("Login into Suraksha Portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("Verify navigated to Dashboard page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Click Create application on the left side of the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Click on Bulk Upload in Create application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("User should be able to navigate to Bulk upload screen successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("User should be able to see FI field is auto populated and disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("User should select the file and upload", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Verify the successfull messages and click okay button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify user able to navigate to the View Bulk upload screen")]
        [NUnit.Framework.CategoryAttribute("TC2_BulkUpload")]
        [NUnit.Framework.CategoryAttribute("Demo")]
        public virtual void VerifyUserAbleToNavigateToTheViewBulkUploadScreen()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify user able to navigate to the View Bulk upload screen", null, new string[] {
                        "TC2_BulkUpload",
                        "Demo"}, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            testRunner.Given("Login into Suraksha Portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("Verify navigated to Dashboard page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Click Create application on the left side of the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Click on View Bulk Upload in Create application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Verify View Bulk Upload page loaded successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Give necessary data and click on Load Data button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify Errors file")]
        [NUnit.Framework.CategoryAttribute("TC3_FailedErrors")]
        [NUnit.Framework.CategoryAttribute("Demo")]
        public virtual void VerifyErrorsFile()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify Errors file", null, new string[] {
                        "TC3_FailedErrors",
                        "Demo"}, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            testRunner.Given("Login into Suraksha Portal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("Verify navigated to Dashboard page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Click Create application on the left side of the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("Click on View Bulk Upload in Create application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Verify View Bulk Upload page loaded successfully", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("Give necessary data and click on failed cases link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion