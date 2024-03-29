﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.3.0.0
//      SpecFlow Generator Version:3.1.0.0
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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("FIGUser")]
    public partial class FIGUserFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FIGUser.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-GB"), "FIGUser", "A short summary of the feature", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [NUnit.Framework.TestCaseAttribute("Venkatesh.yada@valuemomentum.com", "Venky@123", null, TestName="VerifyFIGUserAbleToNavigateToPremiumCalculatorUsingLeftNavigationMenu with \"Venka" +
            "tesh_yada@valuemomentum_com\", \"Venky@123\"")]
        public virtual void VerifyFIGUserAbleToNavigateToPremiumCalculatorUsingLeftNavigationMenu(string userName, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "FigUserTestCase1"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("UserName", userName);
            argumentsOfScenario.Add("Password", password);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify FIG User able to navigate to premium calculator using left navigation menu" +
                    "", null, @__tags, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            testRunner.Given(string.Format("User should login into Suraksha using {0} and {1}", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("User should click on Create application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("User should click on Premium Calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify FIG User able to calculate premium without updating mandatory values in th" +
            "e premium calculator page")]
        [NUnit.Framework.CategoryAttribute("FigUserTestCase2")]
        public virtual void VerifyFIGUserAbleToCalculatePremiumWithoutUpdatingMandatoryValuesInThePremiumCalculatorPage()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify FIG User able to calculate premium without updating mandatory values in th" +
                    "e premium calculator page", null, new string[] {
                        "FigUserTestCase2"}, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "UserName",
                        "Password"});
            table1.AddRow(new string[] {
                        "Venkatesh.yada@valuemomentum.com",
                        "Venky@123"});
            testRunner.Given("User should login into Suraksha using user name and password", ((string)(null)), table1, "Given ");
            testRunner.Then("User should click on Create application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("User should click on Premium Calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("User should click on Calculate Premium", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify FIG User able to enter values for the following fields")]
        [NUnit.Framework.CategoryAttribute("FigUserTestCase3")]
        public virtual void VerifyFIGUserAbleToEnterValuesForTheFollowingFields()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify FIG User able to enter values for the following fields", null, new string[] {
                        "FigUserTestCase3"}, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "UserName",
                        "Password"});
            table2.AddRow(new string[] {
                        "Venkatesh.yada@valuemomentum.com",
                        "Venky@123"});
            testRunner.Given("User should login into Suraksha using user name and password", ((string)(null)), table2, "Given ");
            testRunner.Then("User should click on Create application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("User should click on Premium Calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("User should click on Calculate Premium", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.Then("User should enter/select the following fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify FIG User able to view values like after clicking on Region dropdown")]
        [NUnit.Framework.CategoryAttribute("FigUserTestCase4")]
        [NUnit.Framework.CategoryAttribute("DataSource:UserTestData.xlsx")]
        public virtual void VerifyFIGUserAbleToViewValuesLikeAfterClickingOnRegionDropdown()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify FIG User able to view values like after clicking on Region dropdown", null, new string[] {
                        "FigUserTestCase4",
                        "DataSource:UserTestData.xlsx"}, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            testRunner.Given("User should login into Suraksha using <UserName> and <Password>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
            testRunner.Then("User should click on Create application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("User should click on Premium Calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Verify FIG User able to view values after clicking on Region", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify FIG User able to view the two dropdown (years and Months) for Tenure field" +
            ".")]
        [NUnit.Framework.CategoryAttribute("FigUserTestCase5")]
        public virtual void VerifyFIGUserAbleToViewTheTwoDropdownYearsAndMonthsForTenureField_()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify FIG User able to view the two dropdown (years and Months) for Tenure field" +
                    ".", null, new string[] {
                        "FigUserTestCase5"}, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "UserName",
                        "Password"});
            table3.AddRow(new string[] {
                        "Venkatesh.yada@valuemomentum.com",
                        "Venky@123"});
            testRunner.Given("User should login into Suraksha using user name and password", ((string)(null)), table3, "Given ");
            testRunner.Then("User should click on Create application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("User should click on Premium Calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Verify Years Months dropdown should display for Tenure in premium calculator scre" +
                    "en", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify FIG User able to view Date of Birth Secondary Insured is displayed after s" +
            "electing Policy Type - Joint Policy/Co-borrower")]
        [NUnit.Framework.CategoryAttribute("FigUserTestCase6")]
        public virtual void VerifyFIGUserAbleToViewDateOfBirthSecondaryInsuredIsDisplayedAfterSelectingPolicyType_JointPolicyCo_Borrower()
        {
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify FIG User able to view Date of Birth Secondary Insured is displayed after s" +
                    "electing Policy Type - Joint Policy/Co-borrower", null, new string[] {
                        "FigUserTestCase6"}, argumentsOfScenario);
            this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "UserName",
                        "Password"});
            table4.AddRow(new string[] {
                        "Venkatesh.yada@valuemomentum.com",
                        "Venky@123"});
            testRunner.Given("User should login into Suraksha using user name and password", ((string)(null)), table4, "Given ");
            testRunner.Then("User should click on Create application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            testRunner.And("User should click on Premium Calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.And("User should select Policy Type - Joint Life/Co-Borrower from the dropdown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
            testRunner.Then("Verify Date of birth of Secondary Insured field should get added on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
