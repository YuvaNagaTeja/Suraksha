using CSharpAFProject.Base;
using CSharpAFProject.ExcelReader;
using CSharpAFProject.Helpers;
using iTextSharp.text.pdf.parser.clipper;
using iTextSharp.text.pdf.qrcode;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver.Core.Misc;
using NUnit.Framework;
using SurakshaAutomation.Data;
using SurakshaAutomation.Pages;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;
using Assert = NUnit.Framework.Assert;

namespace SurakshaAutomation.StepDefinitions
{
    [Parallelizable(ParallelScope.Fixtures)]
    [Binding]
    internal class PremiumCalculatorSteps : BasePage
    {
        private readonly ParallelConfig _parallelConfig;
        int _PremiumCases = 1;
        int TotalNomineeShare;
        public PremiumCalculatorSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }


        [Then(@"Click on in Create application")]
        public void ThenClickOnBulkUploadInCreateApplication()
        {
            _parallelConfig.CurrentPage.As<LeftMenu>().ClickonBulkUploadLink();
        }


        [Then(@"Click on Premium Calculator in Create application and Verify Title of the page")]
        public void ThenClickOnPremiumCalculatorInCreateApplicationAndVerifyTitleOfThePage()
        {
            _parallelConfig.CurrentPage = new LeftMenu(_parallelConfig);
            _parallelConfig.CurrentPage.As<LeftMenu>().ClickonPremiumCalculator();
            string ExpectedPremiumCalculatorTitle = "Premium Calculator Output";
            string ActualPremiumCalculatorTitle = _parallelConfig.CurrentPage.As<LeftMenu>().GetPremiumCalculatorTitle();
            NUnit.Framework.Assert.AreEqual(ActualPremiumCalculatorTitle, ExpectedPremiumCalculatorTitle);

            Thread.Sleep(2000);
        }

        [Then(@"User should enter (.*), (.*) and (.*) information")]
        public void ThenUserShouldEnterRegionAndBranchNameData(string FinancialInst, string region, string branchName)
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().FinancialInstituteDetails(FinancialInst, region, branchName);
        }


        [Then(@"User should enter (.*), (.*), (.*), (.*), (.*) and (.*) Policy Details")]
        public void ThenUserShouldEnterPolicyNoPolicyTypeModeTotalTenureCoverAmountAndIsPremiumFundedPolicyDetails(string PolicyNumber, string PolicyType, string Mode, int TotalTenure, string CoverAmt, string IsPremium)
        {

            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().PolicyDetails(PolicyNumber, PolicyType, Mode, TotalTenure, CoverAmt, IsPremium);
        }



        [Then(@"User should enter (.*),(.*), (.*), (.*), (.*) and (.*) in the BorrowerDetails section")]
        public void ThenUserShouldEnterBorrowerStateBorrowerGenderDateOfBirthOfInsuredCustomerAgeofInsuredCustomerAndDateOfCommencementofLoanInTheBorrowerDetailsSection(string BorrowerState, string BorrowerGender, string DateOfBirthOfInsuredCustomer, string DateOfBirthofSecondaryInsured, string SecondaryMemberdetailsGender, string DateOfCommencementofLoan)
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().BorrowersDetails(BorrowerState, BorrowerGender, DateOfBirthOfInsuredCustomer, DateOfBirthofSecondaryInsured, SecondaryMemberdetailsGender, DateOfCommencementofLoan);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickonCalculatePremium();

        }

        [Then(@"User should click on Create Insurance Application button on Premium Output page")]
        public void ThenUserShouldClickOnCreateInsuranceApplicationButtonOnPremiumOutputPage()
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickOnCreateInsuranceApplication();
            Thread.Sleep(3000);
        }

        [Then(@"User should select (.*) and (.*) and Click on preceed button")]
        public void ThenUserShouldSelectDOGHSubmittedAndUTRNoAndClickOnPreceedButton(string DOHGSubmitted, string refUTRNo)
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);

            _parallelConfig.CurrentPage.As<Premium_Calculator>().AdditionalDetails(DOHGSubmitted, refUTRNo);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickOnProceedBtn();
            Thread.Sleep(3000);

        }


        [Then(@"User should enter (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*) and Click on Proceed button")]
        public void ThenUserShouldEnterBorrowerFirstOneSurnameFirstOneMVenkatesh_YadaValuemomentum_ComKOLPNoKOCCAndClickOnProceedButton(string FirstName, string Surname, string Gender, string MobileNo, string emailID, string LoanID, string TempLoanID, string CustId)
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);

            _parallelConfig.CurrentPage.As<Premium_Calculator>().BorrowerPersonalDetails(FirstName, Surname, Gender, MobileNo, emailID, "", LoanID, TempLoanID, "", CustId);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickOnBorrowerDetailsProceedBtn();

            Thread.Sleep(3000);
        }


        [Then(@"User should enter (.*), (.*), (.*), (.*), (.*) and click on proceed button in Borrower address page")]
        public void ThenUserShouldEnterBorrowersAddressAddressLineBorrowersAddressStateUTBorrowersAddressPinCodeAndClickOnProceedButtonInBorrowerAddressPage(string AddressLine1, string AddressLine2, string AddressLine3, string BorrowersState, string BorrowerZipCode)
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);

            _parallelConfig.CurrentPage.As<Premium_Calculator>().BorrowerAddressDetails(AddressLine1, AddressLine2, AddressLine3, BorrowersState, BorrowerZipCode);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickOnBorrowerAddressProceedBtn();

            Thread.Sleep(3000);
        }

        [Then(@"User should enter Nominee (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*) in Nominee page and click on Save and submit button")]
        public void ThenNominee1Entries(string NomineeSalutation, string NomineeFirstName, string NomineeSurname, string NomineeDOB, string NomineeGender, string NomineeRelation, string NomineeShare, string NomineeMobileNumber, string PolicyType)
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);

            _parallelConfig.CurrentPage.As<Premium_Calculator>().Nominee1Details(NomineeSalutation, NomineeFirstName, NomineeSurname, NomineeGender, NomineeDOB, NomineeRelation, NomineeShare, NomineeMobileNumber);




            int YearDiff = _parallelConfig.CurrentPage.As<Premium_Calculator>().GetDateDiff(NomineeDOB);
            if (YearDiff < 18)
            {
                _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickOnProceed4();
            }
            else if (PolicyType.Contains("Joint"))
            {
                _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickOnProceed4();
            }
            else
            {
                _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickOnSaveAndSubmit();
            }
            Thread.Sleep(3000);
        }


        [When(@"Nominee is less than eighteen years user should enter Appointee details (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*) in Appointee page and click on Save and submit button")]
        public void AppointeeDetails(string AppointeeSalutation, string AppointeeFirstName, string AppointeeSurname, string AppointeeGender, string AppointeeMaritalStatus, string AppointeeDOB, string AppointeeIDNo, string AppointeeRelationship, string NomineeDOB)
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            int YearDiff = _parallelConfig.CurrentPage.As<Premium_Calculator>().GetDateDiff(NomineeDOB);
            if (YearDiff < 18)
            {
                _parallelConfig.CurrentPage.As<Premium_Calculator>().AppointeeDetails(AppointeeSalutation, AppointeeFirstName, AppointeeSurname, AppointeeGender, AppointeeMaritalStatus, AppointeeDOB, AppointeeIDNo, AppointeeRelationship, NomineeDOB);
                _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickOnSaveAndSubmit();
                Thread.Sleep(3000);

            }
        }

        [When(@"role associated with the loan is joint then user should enter details (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*) in secondary members details")]
        public void SecondaryMemberDetails(string SecondarySalutation, string SecondaryFirstName, string SecondarySurname, string SecondaryMobileNo, string SecondaryEmailId, string SecondaryCustomerID, string SecondaryLoanId, string PolicyType)
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            if (PolicyType.Contains("Joint"))
            {
                _parallelConfig.CurrentPage.As<Premium_Calculator>().SecondaryDetails(SecondarySalutation, SecondaryFirstName, SecondarySurname, SecondaryMobileNo, SecondaryEmailId, SecondaryCustomerID, SecondaryLoanId);
                _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickOnSaveAndSubmit();
                Thread.Sleep(3000);
            }
        }



        [Then(@"Verify the successful messages and click go to Dashboard button")]
        public void ThenVerifyTheSuccessfulMessagesAndClickGoToDashboardButton()
        {

            string ActualSuccessMsg = _parallelConfig.CurrentPage.As<Premium_Calculator>().PremiumCalculatorSuccessMsg();
            string ExpectedSuccessMsg = PremiumCalculatorData.SaveSubmitSuccessfulMessage1;
            NUnit.Framework.Assert.AreEqual(ExpectedSuccessMsg, ActualSuccessMsg);

            string ActualViewSuccessMsg = _parallelConfig.CurrentPage.As<Premium_Calculator>().PremiumCalculatorViewSuccessfulMsg();
            string ExpectedViewSuccessMsg = PremiumCalculatorData.SaveSubmitSuccessfulMessage2;
            NUnit.Framework.Assert.IsTrue(ActualViewSuccessMsg.Contains(ExpectedViewSuccessMsg));
            _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickonGotoDashboardBtn();
            Thread.Sleep(3000);

        }

        //ID15_Nikhila(CalculatePremium)
        [Then(@"click on calculate premium button")]
        public void ThenClickOnCalculatePremiumButton()
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig); _parallelConfig.CurrentPage.As<Premium_Calculator>().clickOnCalculateButton();
        }
        [Then(@"Validate the error messages in the page")]
        public void ThenValidateTheErrorMessagesInThePage()
        {
            _parallelConfig.CurrentPage.As<Premium_Calculator>().VerifyErrorMsg();
        }

        //[Then(@"User should enter four Nominees (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*) in Nominee page and click on Save and submit button")]
        //public void ThenNominee4Entries1(string Nominee1Salutation, string Nominee1FirstName, string Nominee1Surname, string Nominee1DOB, string Nominee1Gender, string Nominee1Relation, string Nominee1Share, string Nominee1MobileNumber, string Nominee2Salutation, string Nominee2FirstName, string Nominee2Surname, string Nominee2DOB, string Nominee2Gender, string Nominee2Relation, string Nominee2Share, string Nominee2MobileNumber, string Nominee3Salutation, string Nominee3FirstName, string Nominee3Surname, string Nominee3DOB, string Nominee3Gender, string Nominee3Relation, string Nominee3Share, string Nominee3MobileNumber, string Nominee4Salutation, string Nominee4FirstName, string Nominee4Surname, string Nominee4DOB, string Nominee4Gender, string Nominee4Relation, string Nominee4Share, string Nominee4MobileNumber, string PolicyType)
        //{
        //    throw new PendingStepException();
        //}

        //, string Nominee2Salutation, string Nominee2FirstName, string Nominee2Surname, string Nominee2DOB, string Nominee2Gender, string Nominee2Relation, string Nominee2Share, string Nominee2MobileNumber, string Nominee3Salutation, string Nominee3FirstName, string Nominee3Surname, string Nominee3DOB, string Nominee3Gender, string Nominee3Relation, string Nominee3Share, string Nominee3MobileNumber, string Nominee4Salutation, string Nominee4FirstName, string Nominee4Surname, string Nominee4DOB, string Nominee4Gender, string Nominee4Relation, string Nominee4Share, string Nominee4MobileNumber



        [Then(@"User should enter first Nominee (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*) in Nominee page and click on Save and submit button")]
        public void ThenfirstNomineeEntries(string NomineeSalutation, string NomineeFirstName, string NomineeSurname, string NomineeDOB, string NomineeGender, string NomineeRelation, string NomineeShare, string NomineeMobileNumber, string PolicyType)
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().Nominee1Details(NomineeSalutation, NomineeFirstName, NomineeSurname, NomineeGender, NomineeDOB, NomineeRelation, NomineeShare, NomineeMobileNumber);

            TotalNomineeShare = TotalNomineeShare + int.Parse(NomineeShare);
        }

        [Then(@"User should enter Second Nominee (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*) in Nominee page and click on Save and submit button")]
        public void ThenSecondNomineeEntries(string Nominee2Salutation, string Nominee2FirstName, string Nominee2Surname, string Nominee2DOB, string Nominee2Gender, string Nominee2Relation, string Nominee2Share, string Nominee2MobileNumber, string PolicyType)
        {
            if (TotalNomineeShare < 100)
            {
                _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
                _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickOnAddNominee();
                _parallelConfig.CurrentPage.As<Premium_Calculator>().Nominee2Details(Nominee2Salutation, Nominee2FirstName, Nominee2Surname, Nominee2DOB, Nominee2Gender, Nominee2Relation, Nominee2Share, Nominee2MobileNumber);
                TotalNomineeShare = TotalNomineeShare + int.Parse(Nominee2Share);
            }
        }

        [Then(@"User should enter Third Nominee (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*) in Nominee page and click on Save and submit button")]
        public void ThenThirdNomineeEntries(string Nominee3Salutation, string Nominee3FirstName, string Nominee3Surname, string Nominee3DOB, string Nominee3Gender, string Nominee3Relation, string Nominee3Share, string Nominee3MobileNumber, string PolicyType)
        {
            if (TotalNomineeShare < 100)
            {
                _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
                _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickOnAddNominee();
                _parallelConfig.CurrentPage.As<Premium_Calculator>().Nominee3Details(Nominee3Salutation, Nominee3FirstName, Nominee3Surname, Nominee3DOB, Nominee3Gender, Nominee3Relation, Nominee3Share, Nominee3MobileNumber);
            }
            TotalNomineeShare = TotalNomineeShare + int.Parse(Nominee3Share);
            // if (TotalNomineeShare == 100)
            //{
            ////bool ActualStatus = _parallelConfig.CurrentPage.As<Premium_Calculator>().VerifyingAddNomineeButtonIsDisabled();
            ////Assert.IsFalse(ActualStatus);
            //}

        }

        [Then(@"User should enter fourth Nominee (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*) in Nominee page and click on Save and submit button")]
        public void ThenfourthNomineeEntries(string Nominee4Salutation, string Nominee4FirstName, string Nominee4Surname, string Nominee4DOB, string Nominee4Gender, string Nominee4Relation, string Nominee4Share, string Nominee4MobileNumber, string PolicyType)
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            if (TotalNomineeShare < 100)
            {
                _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickOnAddNominee();
                _parallelConfig.CurrentPage.As<Premium_Calculator>().Nominee4Details(Nominee4Salutation, Nominee4FirstName, Nominee4Surname, Nominee4DOB, Nominee4Gender, Nominee4Relation, Nominee4Share, Nominee4MobileNumber);
                TotalNomineeShare = TotalNomineeShare + int.Parse(Nominee4Share);
            }
            // _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickOnProceed4();

            if (PolicyType.Contains("Joint"))
            {
                _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickOnProceed4();
            }
            else
            {

                _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickOnSaveAndSubmit();
                Thread.Sleep(2000);
            }
        }

        [Then(@"Validate Borrower's Address page elements")]
        public void ThenValidateBorrowersAddressPageElements()
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().VerifyBorrowersAddressPage();
        }

        [Then(@"User should enter four Nominees (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*) in Nominee page and click on Save and submit button")]
        public void ThenNominee4Entries(string Nominee1Salutation, string Nominee1FirstName, string Nominee1Surname, string Nominee1DOB, string Nominee1Gender, string Nominee1Relation, string Nominee1Share, string Nominee1MobileNumber, string Nominee2Salutation, string Nominee2FirstName, string Nominee2Surname, string Nominee2DOB, string Nominee2Gender, string Nominee2Relation, string Nominee2Share, string Nominee2MobileNumber, string PolicyType)
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);

            _parallelConfig.CurrentPage.As<Premium_Calculator>().Nominee1Details(Nominee1Salutation, Nominee1FirstName, Nominee1Surname, Nominee1Gender, Nominee1DOB, Nominee1Relation, Nominee1Share, Nominee1MobileNumber);

            TotalNomineeShare = TotalNomineeShare + int.Parse(Nominee1Share);



            int YearDiff = _parallelConfig.CurrentPage.As<Premium_Calculator>().GetDateDiff(Nominee1DOB);
            if (YearDiff < 18)
            {
                if (TotalNomineeShare < 100)
                {
                    _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickOnAddNominee();
                    _parallelConfig.CurrentPage.As<Premium_Calculator>().Nominee2Details(Nominee2Salutation, Nominee2FirstName, Nominee2Surname, Nominee2Gender, Nominee2DOB, Nominee2Relation, Nominee2Share, Nominee2MobileNumber);
                    TotalNomineeShare = TotalNomineeShare + int.Parse(Nominee2Share);
                    if (TotalNomineeShare < 100)
                    {
                        //_parallelConfig.CurrentPage.As<Premium_Calculator>().ClickOnAddNominee();
                        //_parallelConfig.CurrentPage.As<Premium_Calculator>().Nominee3Details(Nominee3Salutation, Nominee3FirstName, Nominee3Surname, Nominee3Gender, Nominee3DOB, Nominee3Relation, Nominee3Share, Nominee3MobileNumber);
                        //TotalNomineeShare = TotalNomineeShare + int.Parse(Nominee3Share);
                    }
                    if (TotalNomineeShare < 100)
                    {
                        //_parallelConfig.CurrentPage.As<Premium_Calculator>().ClickOnAddNominee();
                        //_parallelConfig.CurrentPage.As<Premium_Calculator>().Nominee3Details(Nominee4Salutation, Nominee4FirstName, Nominee4Surname, Nominee4Gender, Nominee4DOB, Nominee4Relation, Nominee4Share, Nominee4MobileNumber);
                        //TotalNomineeShare = TotalNomineeShare + int.Parse(Nominee4Share);
                    }

                }
                else
                {
                    _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickOnProceed4();
                }



            }
            else if (PolicyType.Contains("Joint"))
            {
                _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickOnProceed4();
            }
            else
            {
                _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickOnSaveAndSubmit();
            }
            Thread.Sleep(3000);
        }

        [Then(@"validate premium output page elements")]
        public void ThenValidatePremiumOutputPageElements()
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().VerifyPremiumOutputPage();



            _parallelConfig.CurrentPage.As<Premium_Calculator>().checkProductValue();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().checkAgeOfInsuredValue();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().checkUWStatusValue();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().checkFinalSIValuee();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().checkKotakPremiumValue();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().checkGoodsServicesValuee();



        }

        [Then(@"User should able to view the application details in dashboard with Underwriting status - SMQ")]
        public void ThenUserShouldAbleToViewTheApplicationDetailsInDashboardWithUnderwritingStatus_SMQ()
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            string ActualSMQText = _parallelConfig.CurrentPage.As<Premium_Calculator>().VerifySMQ();
            string ExpectedSMQText = "SMQ";
            Assert.AreEqual(ExpectedSMQText, ActualSMQText);

        }

        [Then(@"fill all the details as Single life")]
        public void ThenFillAllTheDetailsAsSingleLife()
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().FillFinancialInstitutionDDL();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().FillRegionDDL();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().FillBranchDDL();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().FillPolicyNoDDL();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().FillPolicyTypeDDL();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().FillModeDDL();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().FillTotaltenureDDL();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().FillCoverAmountTxt();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().FillIsPremiumFundedDDL();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().FillBorrowerStateDDL();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().FillGenderDDL();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().FillInsureddob();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().FillLoanCoverDOC();

            Thread.Sleep(3000);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickonCalculatePremium();
        }

        [Then(@"User shoud click on Edit after premium got successfully calculated")]
        public void ThenUserShoudClickOnEditAfterPremiumGotSuccessfullyCalculated()
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickonEditBtn();
        }

        [Then(@"User should able to enter/select the values successfully in firstPage")]
        public void ThenUserShouldAbleToEnterSelectTheValuesSuccessfullyInFirstPage()
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().chkFinancialDDL();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().chkRegionDDL();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().chkBranchDDL();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().chkPolicyNoDDL();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().chkPolicyTypeDDL();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().chkModeDDL();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().chkTotaltenureDDL();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().chkCoverAmountTxt();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().chkBorrowerStateDDL();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().chkGenderDDL();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().chkInsureddob();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().chkLoanCoverDOC();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().chkSecondInsuredDob();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().chkSecondInsuredGenderDDL();
        }

        [Then(@"Premium should get calculated sucessfully")]
        public void ThenPremiumShouldGetCalculatedSucessfully()
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            Assert.IsTrue(_parallelConfig.CurrentPage.As<Premium_Calculator>().checkTotalPreminumValue());
        }
        [Then(@"DOGH Submitted and Reference/UTR No should be in editable in premium calculator ouput page\.")]
        public void ThenDOGHSubmittedAndReferenceUTRNoShouldBeInEditableInPremiumCalculatorOuputPage_()
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().chkdoghSubmittedDDL();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().chkUTRNumber();
            Thread.Sleep(5000);
        }

        [Then(@"User should able to add the data for all the fields in Borrower Address details tab\.")]
        public void ThenUserShouldAbleToAddTheDataForAllTheFieldsInBorrowerAddressDetailsTab_()
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().chkAddressLine1();
            _parallelConfig.CurrentPage.As<Premium_Calculator>().chkStateDDL();

            _parallelConfig.CurrentPage.As<Premium_Calculator>().ClickOnBorrowerAddressProceedBtn();
        }

        [Then(@"User should be able to see success message as - SMQ details are successfully submitted")]
        public void ThenUserShouldBeAbleToSeeSuccessMessageAs_SMQDetailsAreSuccessfullySubmitted()
        {
            string ExpectedSuccessfullMsg = AutomationSettings.OTP_SuccessfullMsg;
            string ActualSuccessfullMsg = _parallelConfig.CurrentPage.As<SummaryPage>().GetSuccessfullMsg();
            Assert.AreEqual(ExpectedSuccessfullMsg, ActualSuccessfullMsg);
            Thread.Sleep(10000);
        }

        [Then(@"User should be able to click on Continue to SMQ button and navigate to Fill page")]
        public void ThenUserShouldBeAbleToClickOnContinueToSMQButtonAndNavigateToFillPage()
        {
            _parallelConfig.CurrentPage = new ReviewPage(_parallelConfig);

            double ActualSumAssuredAmt = _parallelConfig.CurrentPage.As<ReviewPage>().GetSumAssured();
            double ExpectedSumAssuredAmt = Convert.ToDouble(TestCase_VerifyReferToUW.SumAssured);
            bool status = false;
            if (ActualSumAssuredAmt >= ExpectedSumAssuredAmt) { status = true; } else { status = false; }
            Assert.IsTrue(status);
            _parallelConfig.CurrentPage.As<ReviewPage>().ClickOnCtnMedicalDetailsbtn();
        }

        [Then(@"Verify with premium Calculator Output title")]
        public void ThenVerifyWithPremiumCalculatorOutputTitle()
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            string actual = _parallelConfig.CurrentPage.As<Premium_Calculator>().VerifyPremiumOutputTitle();
            string expected = PremiumCalculatorData.PremiumCalculatorTitle;
            Assert.AreEqual(expected, actual);
        } 



[Then(@"User should enter (.*), (.*), (.*), (.*), (.*), (.*), (.*) and then verify")]
 public void BorrowerSurnameAndEmailID(string FirstName, string Surname, string MobileNo, string emailID, string LoanID, string TempLoanID, string CustId)
        {
            _parallelConfig.CurrentPage = new Premium_Calculator(_parallelConfig);
            _parallelConfig.CurrentPage.As<Premium_Calculator>().BorrowerPersonalDetailsSpecified(FirstName, Surname, MobileNo, emailID, "", LoanID, TempLoanID, "", CustId);

        }






    }
}
