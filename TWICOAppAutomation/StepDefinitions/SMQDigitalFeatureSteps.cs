using CSharpAFProject.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SurakshaAutomation.Data;
using SurakshaAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using CSharpAFProject.Config;
using CSharpAFProject.Helpers;

namespace SurakshaAutomation.StepDefinitions
{
    [Binding]
    internal class SMQDigitalFeatureSteps : BaseStep
    {

        private readonly ParallelConfig _parallelConfig;
        string strdate;
        public SMQDigitalFeatureSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        [Given(@"Login into Suraksha Portal")]
        public void GivenLoginIntoSurakshaPortal()
        {
            string _loginURL = Settings.AUT;
            _parallelConfig.Driver.Navigate().GoToUrl(_loginURL);
            _parallelConfig.Driver.Manage().Window.Maximize();
            _parallelConfig.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            _parallelConfig.CurrentPage = new LoginPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<LoginPage>().EnterEmailID_EmployeeID(AutomationSettings.ADFSLogin);
            _parallelConfig.CurrentPage.As<LoginPage>().ClickADFSLoginButton();

            _parallelConfig.CurrentPage.As<LoginPage>().ClickADFSUserName(AutomationSettings.ADFSLogin);
            _parallelConfig.CurrentPage.As<LoginPage>().ClickADFSPassword(AutomationSettings.ADFPassword);
            _parallelConfig.CurrentPage.As<LoginPage>().ClickSignInButton();
            //_parallelConfig.CurrentPage.As<LoginPage>().EnterEmailID_EmployeeID(AutomationSettings.UserName);
            //_parallelConfig.CurrentPage.As<LoginPage>().EnterPassword_TextBox(AutomationSettings.Password);
            //_parallelConfig.CurrentPage.As<LoginPage>().ClickSignIn();


        }

        [Then(@"Verify navigated to Dashboard page")]
        public void ThenVerifyNavigatedToDashboardPage()
        {
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            string Expected = "Welcome";
            Thread.Sleep(15000);
            string Actual = _parallelConfig.CurrentPage.As<DashboardPage>().GetTitle();
            Assert.IsTrue(Actual.Contains(Expected));
        }

        [Then(@"Click on Active Cases")]
        public void ThenClickOnActiveCases()
        {
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            Thread.Sleep(3000);
            _parallelConfig.CurrentPage.As<DashboardPage>().ClickonActiveCases();

        }
        [Then(@"Select the Category and click on Search button")]
        public void ThenSelectTheCategory()
        {
            _parallelConfig.CurrentPage = new ActiveCasesPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<ActiveCasesPage>().SearchCategoryDDL(AutomationSettings.SelectCategory);
            _parallelConfig.CurrentPage.As<ActiveCasesPage>().LoanNumberTxt(AutomationSettings.Loan_Number);
            _parallelConfig.CurrentPage.As<ActiveCasesPage>().ClickSearchButton();
            Thread.Sleep(5000);
        }
        [Then(@"Verify SMQ Link Status")]
        public void VerifySMQLinkStatus()
        {
            string ActualSMQStatus = _parallelConfig.CurrentPage.As<ActiveCasesPage>().GetResultSMQStatus().ToUpper();
            string ExpectedSMQStatus = TestData.BeforeSMQTest.ToUpper();
            // Assert.AreEqual(ExpectedSMQStatus, ActualSMQStatus);
            Thread.Sleep(5000);
        }


        [Then(@"Click on searchresult")]
        public void ThenClickOnSearchresult()
        {
            _parallelConfig.CurrentPage = new ActiveCasesPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<ActiveCasesPage>().ClickloanNumberSearchResult();
            Thread.Sleep(5000);
        }

        [Then(@"Navigate to TestURL, give Date of Birth")]
        public void NavigatetoTestURL()
        {
            Thread.Sleep(10000);
            _parallelConfig.CurrentPage = new ActiveCasesPage(_parallelConfig);
            strdate = _parallelConfig.CurrentPage.As<ActiveCasesPage>().GetdateofBirthPrimaryInsuredlbl();

            _parallelConfig.Driver.Navigate().GoToUrl(AutomationSettings.TestingURL);
            _parallelConfig.CurrentPage.As<ActiveCasesPage>().EnterDateofBirth(strdate);
        }


        [Then(@"Click on Authenticate")]
        public void ThenClickOnAuthenticate()
        {
            _parallelConfig.CurrentPage = new ActiveCasesPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<ActiveCasesPage>().ClickAuthenticateButton();

            Thread.Sleep(5000);
        }

        [Then(@"Click on Start button")]
        public void ThenClickOnStartButton()
        {
            _parallelConfig.CurrentPage = new ReviewPage(_parallelConfig);
            string ActualMsg = _parallelConfig.CurrentPage.As<ReviewPage>().CheckMsgTxt();
            string ExpectedMsg = AutomationSettings.Message;
            Assert.AreEqual(ExpectedMsg, ActualMsg);
            _parallelConfig.CurrentPage.As<ReviewPage>().ClickOnStartBtn();
            Thread.Sleep(5000);
        }

        [Then(@"User should click on Continue on Medical Details button")]
        public void ThenUserShouldClickOnContinueOnMedicalDetailsButton()
        {
            _parallelConfig.CurrentPage = new ReviewPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<ReviewPage>().ClickOnCtnMedicalDetailsbtn();
        }

        [Then(@"Select Mandatory fields and click on Continue to SMQ button")]
        public void SelectMandatoryFields()
        {
            _parallelConfig.CurrentPage = new FillPage(_parallelConfig);

            // Clicking on Continue to SMQ button without entering any values
            _parallelConfig.CurrentPage.As<FillPage>().ClickOnContinuetoSMQ();

            Thread.Sleep(3000);




            bool NationalityErrorMsg = _parallelConfig.CurrentPage.As<FillPage>().ChkNationalityErrorMsg();
            Assert.IsTrue(NationalityErrorMsg);

            bool TotalNoOfBorrowersErrorMsg = _parallelConfig.CurrentPage.As<FillPage>().ChkTotalNoOfBorrowersErrorMsg();
            Assert.IsTrue(TotalNoOfBorrowersErrorMsg);

            bool TypeofEmpErrorMsg = _parallelConfig.CurrentPage.As<FillPage>().ChkTypeofEmploymentErrorMsg();
            Assert.IsTrue(TypeofEmpErrorMsg);
            bool PrimaryBorrowerCoBorrowerErrorMsg = _parallelConfig.CurrentPage.As<FillPage>().ChkPrimaryBorrowerCoBorrowerErrorMsg();
            Assert.IsTrue(PrimaryBorrowerCoBorrowerErrorMsg);

            bool PanCardErrorMsg = _parallelConfig.CurrentPage.As<FillPage>().ChkPanCardErrorMsg();
            Assert.IsTrue(PanCardErrorMsg);
            bool WeightInKGErrorMsg = _parallelConfig.CurrentPage.As<FillPage>().ChkWeightInKGErrorMsg();
            Assert.IsTrue(WeightInKGErrorMsg);
            bool AnnualIncomeErrorMsg = _parallelConfig.CurrentPage.As<FillPage>().ChkAnnualIncomeErrorMsg();
            Assert.IsTrue(AnnualIncomeErrorMsg);

            bool HeightInFeetErrorMsg = _parallelConfig.CurrentPage.As<FillPage>().ChkHeightInFeetErrorMsg();
            Assert.IsTrue(HeightInFeetErrorMsg);

            bool HeightInInchesErrorMsg = _parallelConfig.CurrentPage.As<FillPage>().ChkHeightInInchesErrorMsg();
            Assert.IsTrue(HeightInInchesErrorMsg);

            //

            bool PanCardSpc = _parallelConfig.CurrentPage.As<FillPage>().ChkPanCardSpcErrorMsg();
            Assert.IsTrue(PanCardSpc);
            bool WeightSpc = _parallelConfig.CurrentPage.As<FillPage>().ChkWeightSpcErrorMsg();
            Assert.IsTrue(WeightSpc);
            bool AnnualIncomeSpc = _parallelConfig.CurrentPage.As<FillPage>().ChkAnnualIncomeSpcErrorMsg();
            Assert.IsTrue(AnnualIncomeSpc);


            //Verifing dropdown value selection.
            _parallelConfig.CurrentPage.As<FillPage>().ChkNationality();
            _parallelConfig.CurrentPage.As<FillPage>().ChkBorrowersDDL();
            _parallelConfig.CurrentPage.As<FillPage>().ChkTypeofEmpDDL();
            _parallelConfig.CurrentPage.As<FillPage>().ChkTypeofBorrowerDDL();
            _parallelConfig.CurrentPage.As<FillPage>().ChkHeightInFeet();
            _parallelConfig.CurrentPage.As<FillPage>().ChkHeightInInches();



            //Selecting each object values from the test data file
            _parallelConfig.CurrentPage.As<FillPage>().SelectnationalityDDL(TestData.Nationality);
            _parallelConfig.CurrentPage.As<FillPage>().SelectborrowersDDL(TestData.TotalNumberofBorrowers);
            _parallelConfig.CurrentPage.As<FillPage>().SelectemploymenttypeDDL(TestData.Type_of_Employment);
            _parallelConfig.CurrentPage.As<FillPage>().SelectborrowertypeDDL(TestData.Primary_Borrower_or_Co_Borrowers);
            _parallelConfig.CurrentPage.As<FillPage>().EnterPancard(TestData.Pancard);
            _parallelConfig.CurrentPage.As<FillPage>().EnterWeight(TestData.Weight_in_Kg);
            _parallelConfig.CurrentPage.As<FillPage>().EnterAnnualIncome(TestData.Annual_Income);
            _parallelConfig.CurrentPage.As<FillPage>().SelectHeightinfeetDDL(Convert.ToInt16(TestData.Height_in_Feet));
            _parallelConfig.CurrentPage.As<FillPage>().SelectHeightininchesDDL(Convert.ToInt16(TestData.Inches));

            _parallelConfig.CurrentPage.As<FillPage>().ClickOnContinuetoSMQ();
            Thread.Sleep(10000);

            _parallelConfig.CurrentPage = new QuestionaryFillPage(_parallelConfig);
            string actualPageWarning = _parallelConfig.CurrentPage.As<QuestionaryFillPage>().GetPageWarning();
            string expectedPageWarning = TestData.PageWarning;
            Assert.AreEqual(expectedPageWarning, actualPageWarning);

            _parallelConfig.CurrentPage = new QuestionaryFillPage(_parallelConfig);
            Thread.Sleep(3000);

            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().GetAllQuestions();

            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion1_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().ClickOnProceedBtn();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().ClickOnQuestionaryBackBtn();

            _parallelConfig.CurrentPage = new FillPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<FillPage>().ClickOnContinuetoSMQ();

            _parallelConfig.CurrentPage = new QuestionaryFillPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion1_Yes();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion2_Yes();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion3_Yes();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion4_Yes();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion5_Yes();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion6_Yes();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion7_Yes();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion8_Yes();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion9_Yes();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion10_Yes();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion11_Yes();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion12_Yes();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion13_Yes();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion14_Yes();

            Thread.Sleep(10000);
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().Question1();
            Thread.Sleep(10000);

            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion2_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion3_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion4_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion5_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion6_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion7_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion8_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion9_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion10_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion11_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion12_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion13_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion14_No();


            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().ClickOnProceedBtn();
            Thread.Sleep(10000);

            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().ClickOnSummaryBackBtn();
            Thread.Sleep(10000);

            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion2_Yes();
            Thread.Sleep(10000);
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().Question2();
            Thread.Sleep(10000);
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().ClickOnProceedBtn();
            Thread.Sleep(10000);
            _parallelConfig.CurrentPage = new SummaryPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<SummaryPage>().CheckDeclaration(Convert.ToBoolean(TestData.Declaration));
            _parallelConfig.CurrentPage.As<SummaryPage>().ClickOnGetOTP_VerifyviaAADHAAR();
            Thread.Sleep(10000);

            string ExpectedModalTitle = TestData.ModalTitle;
            string ActualModalTitle = _parallelConfig.CurrentPage.As<SummaryPage>().GetTitleofModalPopup();
            Assert.AreEqual(ExpectedModalTitle, ActualModalTitle);

            _parallelConfig.CurrentPage.As<SummaryPage>().SendOTPTextBox(TestData.TestOTP);


            _parallelConfig.CurrentPage.As<SummaryPage>().ClickOnVerifyButton();
            Thread.Sleep(10000);






        }




        [Then(@"Verify Underwriting Decision status")]
        public void ThenVerifyUnderwritingDecisionStatus()
        {
            _parallelConfig.CurrentPage = new ActiveCasesPage(_parallelConfig);
            string ExpectedUWDecision = TestCase_VerifyReferToUW.BeforeTestUWDecision;
            string ActualUWDecision = _parallelConfig.CurrentPage.As<ActiveCasesPage>().GetResultUnderWritingDecision();
            Assert.AreEqual(ExpectedUWDecision, ActualUWDecision);

            string ActualSMQStatus = _parallelConfig.CurrentPage.As<ActiveCasesPage>().GetResultSMQStatus().ToUpper();
            string ExpectedSMQStatus = TestData.BeforeSMQTest.ToUpper();
            // Assert.AreEqual(ExpectedSMQStatus, ActualSMQStatus);
            Thread.Sleep(5000);
        }

        [Then(@"Click on Start button and redirect to first page")]
        public void ThenClickOnStartButtonAndRedirectToFirstPage()
        {
            _parallelConfig.CurrentPage = new ReviewPage(_parallelConfig);
            string ActualMsg = _parallelConfig.CurrentPage.As<ReviewPage>().CheckMsgTxt();
            string ExpectedMsg = AutomationSettings.Message;
            Assert.AreEqual(ExpectedMsg, ActualMsg);
            _parallelConfig.CurrentPage.As<ReviewPage>().ClickOnStartBtn();
            Thread.Sleep(5000);


        }

        [Then(@"Validate the screen and click on continue button")]
        public void ThenValidateTheScreenAndClickOnContinueButton()
        {
            _parallelConfig.CurrentPage = new ReviewPage(_parallelConfig);

            double ActualSumAssuredAmt = _parallelConfig.CurrentPage.As<ReviewPage>().GetSumAssured();
            double ExpectedSumAssuredAmt = Convert.ToDouble(TestCase_VerifyReferToUW.SumAssured);
            bool status = false;
            if (ActualSumAssuredAmt >= ExpectedSumAssuredAmt) { status = true; } else { status = false; }
            Assert.IsTrue(status);




            _parallelConfig.CurrentPage.As<ReviewPage>().ClickOnCtnMedicalDetailsbtn();
        }

        [Then(@"Navigate to first page review")]
        public void ThenNavigateToFirstPageReview()
        {
            _parallelConfig.CurrentPage = new FillPage(_parallelConfig);

            // Clicking on Continue to SMQ button without entering any values
            _parallelConfig.CurrentPage.As<FillPage>().ClickOnContinuetoSMQ();

            Thread.Sleep(3000);

        }

        [Then(@"Enter all details by selecting Nationality as NRI/PO, Others and Click on continue to SMQ button")]
        public void ThenEnterAllDetailsBySelectingNationalityAsNRIPOOthersAndClickOnContinueToSMQButton()
        {
            //Selecting each object values from the test data file
            _parallelConfig.CurrentPage = new FillPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<FillPage>().SelectnationalityDDL(TestCase_VerifyReferToUW.Nationality);
            _parallelConfig.CurrentPage.As<FillPage>().SelectborrowersDDL(TestCase_VerifyReferToUW.TotalNumberofBorrowers);
            _parallelConfig.CurrentPage.As<FillPage>().SelectemploymenttypeDDL(TestCase_VerifyReferToUW.Type_of_Employment);
            _parallelConfig.CurrentPage.As<FillPage>().SelectborrowertypeDDL(TestCase_VerifyReferToUW.Primary_Borrower_or_Co_Borrowers);
            _parallelConfig.CurrentPage.As<FillPage>().EnterPancard(TestCase_VerifyReferToUW.Pancard);
            _parallelConfig.CurrentPage.As<FillPage>().EnterWeight(TestCase_VerifyReferToUW.Weight_in_Kg);
            _parallelConfig.CurrentPage.As<FillPage>().EnterAnnualIncome(TestCase_VerifyReferToUW.Annual_Income);
            _parallelConfig.CurrentPage.As<FillPage>().SelectHeightinfeetDDL(Convert.ToInt16(TestCase_VerifyReferToUW.Height_in_Feet));
            _parallelConfig.CurrentPage.As<FillPage>().SelectHeightininchesDDL(Convert.ToInt16(TestCase_VerifyReferToUW.Inches));

            _parallelConfig.CurrentPage.As<FillPage>().ClickOnContinuetoSMQ();
            Thread.Sleep(10000);

        }


        [Then(@"User should be able to enter two digits and three digits numbers in Weight in kgs field")]
        public void ThenUserShouldBeAbleToEnterTwoDigitsAndThreeDigitsNumbersInWeightInKgsField()
        {
            _parallelConfig.CurrentPage = new FillPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<FillPage>().SelectnationalityDDL(TestCase_VerifyReferToUW.Nationality);
            _parallelConfig.CurrentPage.As<FillPage>().SelectborrowersDDL(TestCase_VerifyReferToUW.TotalNumberofBorrowers);
            _parallelConfig.CurrentPage.As<FillPage>().SelectemploymenttypeDDL(TestCase_VerifyReferToUW.Type_of_Employment);
            _parallelConfig.CurrentPage.As<FillPage>().SelectborrowertypeDDL(TestCase_VerifyReferToUW.Primary_Borrower_or_Co_Borrowers);
            _parallelConfig.CurrentPage.As<FillPage>().EnterPancard(TestCase_VerifyReferToUW.Pancard);


            _parallelConfig.CurrentPage.As<FillPage>().EnterWeight("69");
            _parallelConfig.CurrentPage.As<FillPage>().ClearWeight();
            _parallelConfig.CurrentPage.As<FillPage>().EnterWeight("110");
            
            
            _parallelConfig.CurrentPage.As<FillPage>().EnterAnnualIncome(TestCase_VerifyReferToUW.Annual_Income);
            _parallelConfig.CurrentPage.As<FillPage>().SelectHeightinfeetDDL(Convert.ToInt16(TestCase_VerifyReferToUW.Height_in_Feet));
            _parallelConfig.CurrentPage.As<FillPage>().SelectHeightininchesDDL(Convert.ToInt16(TestCase_VerifyReferToUW.Inches));
        }
        [Then(@"User should be able to select Total No\.of borrower’s from the Total No\.of borrower’s dropdown in the first review page")]
        public void ThenUserShouldBeAbleToSelectTotalNo_OfBorrowerSFromTheTotalNo_OfBorrowerSDropdownInTheFirstReviewPage()
        {
            _parallelConfig.CurrentPage = new FillPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<FillPage>().SelectnationalityDDL(TestCase_VerifyReferToUW.Nationality);



            _parallelConfig.CurrentPage.As<FillPage>().SelectborrowersDDL(TestCase_VerifyReferToUW.TotalNumberofBorrowers);


            _parallelConfig.CurrentPage.As<FillPage>().SelectemploymenttypeDDL(TestCase_VerifyReferToUW.Type_of_Employment);
            _parallelConfig.CurrentPage.As<FillPage>().SelectborrowertypeDDL(TestCase_VerifyReferToUW.Primary_Borrower_or_Co_Borrowers);
            _parallelConfig.CurrentPage.As<FillPage>().EnterPancard(TestCase_VerifyReferToUW.Pancard);


            _parallelConfig.CurrentPage.As<FillPage>().EnterWeight(TestCase_VerifyReferToUW.Weight_in_Kg);


            _parallelConfig.CurrentPage.As<FillPage>().EnterAnnualIncome(TestCase_VerifyReferToUW.Annual_Income);
            _parallelConfig.CurrentPage.As<FillPage>().SelectHeightinfeetDDL(Convert.ToInt16(TestCase_VerifyReferToUW.Height_in_Feet));
            _parallelConfig.CurrentPage.As<FillPage>().SelectHeightininchesDDL(Convert.ToInt16(TestCase_VerifyReferToUW.Inches));
        }

        [Then(@"Click on Continue to SMQ button")]
        public void ThenClickOnContinueToSMQButton()
        {
            _parallelConfig.CurrentPage = new FillPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<FillPage>().ClickOnContinuetoSMQ();
            Thread.Sleep(10000);
        }


        [Then(@"Answer all questions and click on continue button")]
        public void ThenAnswerAllQuestionsAndClickOnContinueButton()
        {
            _parallelConfig.CurrentPage = new QuestionaryFillPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion1_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion2_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion3_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion4_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion5_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion6_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion7_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion8_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion9_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion10_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion11_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion12_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion13_No();
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().chkQuestion14_No();


            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().ClickOnProceedBtn();
            Thread.Sleep(10000);
        }

        [Then(@"Navigate to Submit screen")]
        public void ThenNavigateToSubmitScreen()
        {
            _parallelConfig.CurrentPage = new SummaryPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<SummaryPage>().CheckDeclaration(Convert.ToBoolean(TestData.Declaration));
            _parallelConfig.CurrentPage.As<SummaryPage>().ClickOnGetOTP_VerifyviaAADHAAR();
            Thread.Sleep(15000);
        }

        [Then(@"Click on Mobile OTP and Enter OTP")]
        public void ThenClickOnMobileOTPAndEnterOTP()
        {
            string ExpectedModalTitle = TestData.ModalTitle;
            string ActualModalTitle = _parallelConfig.CurrentPage.As<SummaryPage>().GetTitleofModalPopup();
            Assert.AreEqual(ExpectedModalTitle, ActualModalTitle);
            // _parallelConfig.CurrentPage.As<SummaryPage>().SendOTPTextBox(TestData.TestOTP);
            Thread.Sleep(15000);
        }

        [Then(@"Click on validate OTP button and submit the records")]
        public void ThenClickOnValidateOTPButtonAndSubmitTheRecords()
        {
            _parallelConfig.CurrentPage.As<SummaryPage>().ClickOnVerifyButton();
            Thread.Sleep(15000);

            string ExpectedSuccessfullMsg = AutomationSettings.OTP_SuccessfullMsg;
            string ActualSuccessfullMsg = _parallelConfig.CurrentPage.As<SummaryPage>().GetSuccessfullMsg();
            Assert.AreEqual(ExpectedSuccessfullMsg, ActualSuccessfullMsg);
            Thread.Sleep(10000);
            _parallelConfig.CurrentPage.As<SummaryPage>().ClickOnSuccessfullOkBtn();


        }

        [Then(@"Validate the Underwriting decision Status")]
        public void ThenValidateTheUnderwritingDecisionStatus()
        {
            Thread.Sleep(10000);
            string _loginURL = Settings.AUT;
            _parallelConfig.Driver.Navigate().GoToUrl(_loginURL);
            _parallelConfig.Driver.Manage().Window.Maximize();
            _parallelConfig.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            Thread.Sleep(10000);


            _parallelConfig.CurrentPage = new LoginPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<LoginPage>().EnterEmailID_EmployeeID(AutomationSettings.ADFSLogin);
            _parallelConfig.CurrentPage.As<LoginPage>().ClickADFSLoginButton();

            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            Thread.Sleep(10000);
            _parallelConfig.CurrentPage.As<DashboardPage>().ClickonActiveCases();
            Thread.Sleep(10000);

            _parallelConfig.CurrentPage = new ActiveCasesPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<ActiveCasesPage>().SearchCategoryDDL(AutomationSettings.SelectCategory);
            _parallelConfig.CurrentPage.As<ActiveCasesPage>().LoanNumberTxt(AutomationSettings.Loan_Number);
            _parallelConfig.CurrentPage.As<ActiveCasesPage>().ClickSearchButton();
            Thread.Sleep(5000);

            string ExpectedUWDecision = TestCase_VerifyReferToUW.AfterTestUWDecision;
            string ActualUWDecision = _parallelConfig.CurrentPage.As<ActiveCasesPage>().GetResultUnderWritingDecision();
            Assert.AreEqual(ExpectedUWDecision, ActualUWDecision);

            string ActualSMQStatus = _parallelConfig.CurrentPage.As<ActiveCasesPage>().GetResultSMQStatus().ToUpper();
            string ExpectedSMQStatus = TestData.AfterSMQTest.ToUpper();
            Assert.AreEqual(ExpectedSMQStatus, ActualSMQStatus);
            Thread.Sleep(5000);
        }

        [Then(@"Verify Question8")]
        public void VerifyQuestion8()
        {
            _parallelConfig.CurrentPage = new QuestionaryFillPage(_parallelConfig);
            Thread.Sleep(10000);
            _parallelConfig.CurrentPage.As<QuestionaryFillPage>().Question8();
            Thread.Sleep(10000);
        }

        [Then(@"User should be able to click on start button and navigate to SMQ submission page")]
        public void ThenUserShouldBeAbleToClickOnStartButtonAndNavigateToSMQSubmissionPage()
        {
            _parallelConfig.CurrentPage = new ReviewPage(_parallelConfig);
            string ActualMsg = _parallelConfig.CurrentPage.As<ReviewPage>().CheckMsgTxt();
            string ExpectedMsg = AutomationSettings.Message;
            Assert.AreEqual(ExpectedMsg, ActualMsg);
            _parallelConfig.CurrentPage.As<ReviewPage>().ClickOnStartBtn();
            Thread.Sleep(5000);
        }         
        
        //@TC_6(21)
        [Then(@"User should be able to select Nationality from the Nationality dropdown in the first review page")]
        public void ThenUserShouldBeAbleToSelectNationalityFromTheNationalityDropdownInTheFirstReviewPage()
        {
            _parallelConfig.CurrentPage = new FillPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<FillPage>().ChkNationality();
        }         
        
        //@TC_5(17)
        [Then(@"User should able to enter Pan card number as Alpha numeric value with maximum value (.*) character \(AAAAA(.*)A\)")]
        public void ThenUserShouldAbleToEnterPanCardNumberAsAlphaNumericValueWithMaximumValueCharacterAAAAAA(int p0, int p1)
        {
            _parallelConfig.CurrentPage = new FillPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<FillPage>().EnterPancard("AAAAAA");
            _parallelConfig.CurrentPage.As<FillPage>().ClickOnContinuetoSMQ();
            _parallelConfig.CurrentPage.As<FillPage>().ChkPanCardSpcErrorMsg();
            _parallelConfig.CurrentPage.As<FillPage>().ClrPANcard();
            _parallelConfig.CurrentPage.As<FillPage>().EnterPancard("DSKPA9152A");
            Thread.Sleep(3000);
        }

        [Then(@"Click on SMQ Physical Dashborad from Application on the left menu of Screen")]
        public void ThenClickOnSMQPhysicalAndDigitalFromApplicationOnTheLeftMenuOfScreen()
        {
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<DashboardPage>().clickOnSMQPhysicalDashboard();
        }

        [Then(@"Click on SMQ Digital Dashborad from Application on the left menu of Screen")]
        public void ThenClickOnSMQDigitalDashboradFromApplicationOnTheLeftMenuOfScreen()
        {
            _parallelConfig.CurrentPage = new DashboardPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<DashboardPage>().clickOnSMQDigitalDashboard();
        }
    }
}
