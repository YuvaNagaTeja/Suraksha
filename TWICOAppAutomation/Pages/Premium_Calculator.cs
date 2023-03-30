using AventStack.ExtentReports.Utils;
using CSharpAFProject.Base;
using CSharpAFProject.ExcelReader;
using CSharpAFProject.Extensions;
using CSharpAFProject.Helpers;
using Dynamitey;
using iTextSharp.text;
using log4net.Util;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Protractor;
using SurakshaAutomation.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace SurakshaAutomation.Pages
{
    public partial class Premium_Calculator : BasePage
    {
        private readonly ParallelConfig _parallelConfig;
        public Premium_Calculator(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        public void SelectFinancialIns(string strFinInst)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, FinancialInstitutionDDL);
            FinancialInstitutionDDL.SelectDropDownList(strFinInst);
            Log4NetHelper.Log("Selected Financial Institution", Log4Type.Info);
        }


        public void SelectRegionDDL(string strRegion)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, RegionDDL);
            RegionDDL.SelectDropDownList(strRegion);
            Log4NetHelper.Log("Selected Region  ", Log4Type.Info);
        }
        public void SelectBranchDDL(string strBranch)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, BranchDDL);
            BranchDDL.SelectDropDownList(strBranch);
            Log4NetHelper.Log("Selected Branch   ", Log4Type.Info);
        }
        public void SelectPolicyNoDDL(string PolicyNumber)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PolicyNoDDL);
            PolicyNoDDL.SelectDropDownList(PolicyNumber);
            Log4NetHelper.Log("Selected Policy No   ", Log4Type.Info);
        }
        public void SelectPolicyTypeDDL(int PolicyType)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PolicyTypeDDL);
            PolicyTypeDDL.SelectDropDownList(PolicyType);
            Log4NetHelper.Log("Selected Policy Type   ", Log4Type.Info);
        }

        public void SelectModeDDL(string modeDDL)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ModeDDL);
            ModeDDL.SelectDropDownList(modeDDL);
            Log4NetHelper.Log("Selected Mode ", Log4Type.Info);
        }

        public void SelectTotaltenureDDL(int Totaltenure)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, TotaltenureDDL);
            TotaltenureDDL.SelectDropDownList(Totaltenure);
            Log4NetHelper.Log("Selected Totaltenure  ", Log4Type.Info);
        }
        public void EnterCoverAmount(string coverAmount)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, CoverAmountTxt);
            CoverAmountTxt.SendKeys(coverAmount.ToString());
            Log4NetHelper.Log("Selected Cover Amount ", Log4Type.Info);
        }

        public void EnterOccupationCode(string strOccCode)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, OccupationTxt);
            OccupationTxt.SendKeys(strOccCode.ToString());
            Log4NetHelper.Log("Selected Occupation Code", Log4Type.Info);
        }

        public void EnterAdhaarNo(string strAdhaarNo)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, AadharTxt);
            AadharTxt.SendKeys(strAdhaarNo.ToString());
            Log4NetHelper.Log("Selected Occupation Code", Log4Type.Info);
        }


        public void EnterCustomerID(string strCustomerID)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, CustomerIdTxt);
            CustomerIdTxt.SendKeys(strCustomerID.ToString());
            Log4NetHelper.Log("Selected Customer ID", Log4Type.Info);
        }
        public void EnterSecondaryCustomerID(string strSecondaryCustomerId)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SecondaryCustomerIdTxt);
            SecondaryCustomerIdTxt.SendKeys(strSecondaryCustomerId.ToString());
            Log4NetHelper.Log("Selected Secondary Customer ID", Log4Type.Info);
        }


        public void EnterLoanId(string strLoanID)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, LoanIdTxt);
            LoanIdTxt.SendKeys(strLoanID.ToString());
            Log4NetHelper.Log("Selected Loan ID", Log4Type.Info);
        }

        public void EnterSecondaryLoanId(string strLoanID)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SecondaryLoanIdTxt);
            SecondaryLoanIdTxt.SendKeys(strLoanID.ToString());
            Log4NetHelper.Log("Selected Secondary Loan ID", Log4Type.Info);
        }



        public void SelectIsTempLoanID(string TempLoanID)
        {
            if (!TempLoanID.IsNullOrEmpty())
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, TemporaryLoanIdDDL);
                TemporaryLoanIdDDL.SelectDropDownList(TempLoanID);
                Log4NetHelper.Log("Selected Is Temporary loan id", Log4Type.Info);
            }
        }

        public void EnterAddressLine1(string strAddressLine1)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Address1Txt);
            Address1Txt.SendKeys(strAddressLine1.ToString());
            Log4NetHelper.Log("Enter Addressline 1", Log4Type.Info);
        }

        //NomineeSalutation
        public void EnterNominee1Salutation(string strNominee)
        {
            if (!strNominee.IsNullOrEmpty())
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee1honorificDDL);
                Nominee1honorificDDL.SelectDropDownList(strNominee);
                Log4NetHelper.Log("Selected Nominee Honorific ", Log4Type.Info);
            }
        }
        public void EnterNominee2Salutation(string strNominee)
        {
            if (!strNominee.IsNullOrEmpty())
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee2honorificDDL);
                Nominee2honorificDDL.SelectDropDownList(strNominee);
                Log4NetHelper.Log("Selected Nominee Honorific ", Log4Type.Info);
            }
        }
        public void EnterNominee3Salutation(string strNominee)
        {
            if (!strNominee.IsNullOrEmpty())
            {

                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee3honorificDDL);
                Thread.Sleep(2000);
                Nominee3honorificDDL.SelectDropDownList(strNominee);
                Log4NetHelper.Log("Selected Nominee Honorific ", Log4Type.Info);
            }
        }
        public void EnterNominee4Salutation(string strNominee)
        {
            if (!strNominee.IsNullOrEmpty())
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee4honorificDDL);
                Nominee4honorificDDL.SelectDropDownList(strNominee);
                Log4NetHelper.Log("Selected Nominee Honorific ", Log4Type.Info);
            }
        }

        public void EnterPincode(string strPinCode)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PincodeTxt);
            PincodeTxt.SendKeys(strPinCode.ToString());
            Log4NetHelper.Log("Enter Pincode", Log4Type.Info);
        }
        public void EnterAddressLine2(string strAddressLine2)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Address2Txt);
            Address2Txt.SendKeys(strAddressLine2.ToString());
            Log4NetHelper.Log("Enter Addressline 2", Log4Type.Info);
        }
        public void EnterAddressLine3(string strAddressLine3)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Address3Txt);
            Address3Txt.SendKeys(strAddressLine3.ToString());
            Log4NetHelper.Log("Enter Addressline 3", Log4Type.Info);
        }
        public void SelectBorrowerState(string strBorrowerState)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, StateDDL);
            StateDDL.SelectDropDownList(strBorrowerState);
            Log4NetHelper.Log("Selected State ", Log4Type.Info);
        }
        public void SelectIsPremiumFundedDDL(string isPremiumFunded)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, IsPremiumFundedDDL);
            IsPremiumFundedDDL.SelectDropDownList(isPremiumFunded);
            Log4NetHelper.Log("Selected Is Premium Funded  ", Log4Type.Info);
        }

        public void SelectBorrowerStateDDL(string BorrowerState)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, BorrowerStateDDL);
            BorrowerStateDDL.SelectDropDownList(BorrowerState);
            Log4NetHelper.Log("Selected Borrower State", Log4Type.Info);
        }

        public void SelectGenderDDL(string Gender)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, GenderDDL);
            if (Gender == "M")
            {
                Gender = "Male";
            }
            else if (Gender == "F") { Gender = "Female"; }
            else if (Gender == "T") { Gender = "Transgender"; }

            GenderDDL.SelectDropDownList(Gender);
            Log4NetHelper.Log("Selected Gender", Log4Type.Info);
        }

        public void SelectdoghSubmittedDDL(string DOGH)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, doghSubmittedDDL);
            doghSubmittedDDL.SelectDropDownList(DOGH);
            Log4NetHelper.Log("Selected DOGH", Log4Type.Info);
        }

        public void SelectNominee1Relationship(string relationship)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, NomineeReleationshipDDL);
            NomineeReleationshipDDL.SelectDropDownList(relationship);
            Log4NetHelper.Log("Selected Nominee1 Releationship DDL", Log4Type.Info);
        }


        public void SelectNominee2Relationship(string relationship)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee2ReleationshipDDL);
            Nominee2ReleationshipDDL.SelectDropDownList(relationship);
            Log4NetHelper.Log("Selected Nominee2 Releationship DDL", Log4Type.Info);
        }

        public void SelectNominee3Relationship(string relationship)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee3ReleationshipDDL);
            Nominee3ReleationshipDDL.SelectDropDownList(relationship);
            Log4NetHelper.Log("Selected Nominee3 Releationship DDL", Log4Type.Info);
        }
        public void SelectNominee4Relationship(string relationship)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee4ReleationshipDDL);
            Nominee4ReleationshipDDL.SelectDropDownList(relationship);
            Log4NetHelper.Log("Selected Nominee4 Releationship DDL", Log4Type.Info);
        }
        public void EnterRefUTRNo(string refUTRNo)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ReferenceUtrTxt);
            ReferenceUtrTxt.SendKeys(refUTRNo.Trim());
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ProceedButton1);
            Log4NetHelper.Log("Selected Reference Utr ", Log4Type.Info);
        }

        public void EnterInsureddob(string Insured)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Insureddob);
            Insureddob.SendKeys(Insured);
            Log4NetHelper.Log("Selected Insured dob", Log4Type.Info);
        }

        public void EnterNominee1ddob(string strNomineeDOB)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, DOBNominee);
            DOBNominee.SendKeys(strNomineeDOB);
            Log4NetHelper.Log("Selected Nominee dob", Log4Type.Info);
        }
        public void EnterNominee2ddob(string strNomineeDOB)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee2DOBNominee);
            Nominee2DOBNominee.SendKeys(strNomineeDOB);
            Log4NetHelper.Log("Selected Nominee dob", Log4Type.Info);
        }
        public void EnterNominee3ddob(string strNomineeDOB)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee3DOBNominee);
            Nominee3DOBNominee.SendKeys(strNomineeDOB);
            Log4NetHelper.Log("Selected Nominee dob", Log4Type.Info);
        }
        public void EnterNominee4ddob(string strNomineeDOB)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee4DOBNominee);
            Nominee4DOBNominee.SendKeys(strNomineeDOB);
            Log4NetHelper.Log("Selected Nominee dob", Log4Type.Info);
        }
        public void EnterNominee1MobileNumber(string strNomineeDOB)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, NomineeMobileNumberTxt);
            NomineeMobileNumberTxt.SendKeys(strNomineeDOB);
            Log4NetHelper.Log("Selected Nominee dob", Log4Type.Info);
        }
        public void EnterNominee2MobileNumber(string strNomineeDOB)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee2MobileNumberTxt);
            Nominee2MobileNumberTxt.SendKeys(strNomineeDOB);
            Log4NetHelper.Log("Selected Nominee dob", Log4Type.Info);
        }

        public void EnterNominee3MobileNumber(string strNomineeDOB)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee3MobileNumberTxt);
            Nominee3MobileNumberTxt.SendKeys(strNomineeDOB);
            Log4NetHelper.Log("Selected Nominee3 dob", Log4Type.Info);
        }

        public void EnterNominee4MobileNumber(string strNomineeDOB)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee4MobileNumberTxt);
            Nominee4MobileNumberTxt.SendKeys(strNomineeDOB);
            Log4NetHelper.Log("Selected Nominee4 dob", Log4Type.Info);
        }

        public void EnterNominee1Share(int strNomineeShare)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, NomineePercentageTxt);
            NomineePercentageTxt.SendKeys(strNomineeShare.ToString());
            Log4NetHelper.Log("Selected Nominee1 Share", Log4Type.Info);
        }

        public void EnterNominee2Share(int strNomineeShare)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee2PercentageTxt);
            Nominee2PercentageTxt.SendKeys(strNomineeShare.ToString());
            Log4NetHelper.Log("Selected Nominee2 Share", Log4Type.Info);
        }
        public void EnterNominee3Share(string strNomineeShare)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee3PercentageTxt);
            Nominee3PercentageTxt.SendKeys(strNomineeShare);
            Log4NetHelper.Log("Selected Nominee3 Share", Log4Type.Info);
        }
        public void EnterNominee4Share(string strNomineeShare)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee4PercentageTxt);
            Nominee4PercentageTxt.SendKeys(strNomineeShare);
            Log4NetHelper.Log("Selected Nominee4 Share", Log4Type.Info);
        }
        public void EnterLoanCoverDOC(string LoanCover)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, LoanCoverDOC);
            LoanCoverDOC.SendKeys(LoanCover);
            Log4NetHelper.Log("Selected Loan Cover DOC", Log4Type.Info);
        }

        public void EnterFirstName(string FName)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, borrowerFirstnameTxt);

            if (FName.ToLower().Equals("random"))
            {
                FName = RandomString(10);
            }
            borrowerFirstnameTxt.SendKeys(FName);
            Log4NetHelper.Log("Entered First Name", Log4Type.Info);
        }
        public void EnterNominee1FirstName(string FName)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, FirstnameNomineeTxt);

            if (FName.ToLower().Equals("random"))
            {
                FName = RandomString(10);
            }
            FirstnameNomineeTxt.SendKeys(FName);
            Log4NetHelper.Log("Entered First Name", Log4Type.Info);
        }
        public void EnterNominee2FirstName(string FName)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee2FirstnameNomineeTxt);

            if (FName.ToLower().Equals("random"))
            {
                FName = RandomString(10);
            }
            Nominee2FirstnameNomineeTxt.SendKeys(FName);
            Log4NetHelper.Log("Entered First Name", Log4Type.Info);
        }
        public void EnterNominee3FirstName(string FName)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee3FirstnameNomineeTxt);

            if (FName.ToLower().Equals("random"))
            {
                FName = RandomString(10);
            }
            Nominee3FirstnameNomineeTxt.SendKeys(FName);
            Log4NetHelper.Log("Entered First Name", Log4Type.Info);
        }

        public void EnterNominee4FirstName(string FName)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee4FirstnameNomineeTxt);

            if (FName.ToLower().Equals("random"))
            {
                FName = RandomString(10);
            }
            Nominee4FirstnameNomineeTxt.SendKeys(FName);
            Log4NetHelper.Log("Entered First Name", Log4Type.Info);
        }



        public void EnterNominee1SurName(string SurName)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SurnameNomineeTxt);

            if (SurName.ToLower().Equals("random"))
            {
                SurName = RandomString(10);
            }
            SurnameNomineeTxt.SendKeys(SurName);
            Log4NetHelper.Log("Entered Surname", Log4Type.Info);
        }



        public void EnterNominee2SurName(string SurName)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee2SurnameNomineeTxt);

            if (SurName.ToLower().Equals("random"))
            {
                SurName = RandomString(10);
            }
            Nominee2SurnameNomineeTxt.SendKeys(SurName);
            Log4NetHelper.Log("Entered Surname", Log4Type.Info);
        }

        public void EnterNominee3SurName(string SurName)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee3SurnameNomineeTxt);

            if (SurName.ToLower().Equals("random"))
            {
                SurName = RandomString(10);
            }
            Nominee3SurnameNomineeTxt.SendKeys(SurName);
            Log4NetHelper.Log("Entered Surname", Log4Type.Info);
        }

        public void EnterNominee4SurName(string SurName)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee4SurnameNomineeTxt);

            if (SurName.ToLower().Equals("random"))
            {
                SurName = RandomString(10);
            }
            Nominee4SurnameNomineeTxt.SendKeys(SurName);
            Log4NetHelper.Log("Entered Surname", Log4Type.Info);
        }

        public void EnterSurname(string surname)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, borrowerSurnameTxt);
            if (surname.ToLower().Equals("random"))
            {
                surname = RandomString(10);
            }
            borrowerSurnameTxt.SendKeys(surname);
            Log4NetHelper.Log("Entered Sur Name", Log4Type.Info);
        }

        public void SelectBorrowerGenderDDL(string strGender)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, borrowerGenderDDL);
            if (strGender == "M")
            {
                strGender = "Male";
            }
            else if (strGender == "F") { strGender = "Female"; }
            else if (strGender == "T") { strGender = "Transgender"; }

            borrowerGenderDDL.SelectDropDownList(strGender);
            Log4NetHelper.Log("Selected Borrower Gender", Log4Type.Info);
        }
        public void SelectNominee1GenderDDL(string strGender)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, GenderNomineeDDL);
            if (strGender == "M")
            {
                strGender = "Male";
            }
            else if (strGender == "F") { strGender = "Female"; }
            else if (strGender == "T") { strGender = "Transgender"; }

            GenderNomineeDDL.SelectDropDownList(strGender);
            Log4NetHelper.Log("Selected Nominee Gender", Log4Type.Info);
        }

        public void SelectNominee2GenderDDL(string strGender)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee2GenderNomineeDDL);
            if (strGender == "M")
            {
                strGender = "Male";
            }
            else if (strGender == "F") { strGender = "Female"; }
            else if (strGender == "T") { strGender = "Transgender"; }

            Nominee2GenderNomineeDDL.SelectDropDownList(strGender);
            Log4NetHelper.Log("Selected Nominee Gender", Log4Type.Info);
        }
        public void SelectNominee3GenderDDL(string strGender)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee3GenderNomineeDDL);
            if (strGender == "M")
            {
                strGender = "Male";
            }
            else if (strGender == "F") { strGender = "Female"; }
            else if (strGender == "T") { strGender = "Transgender"; }

            Nominee3GenderNomineeDDL.SelectDropDownList(strGender);
            Log4NetHelper.Log("Selected Nominee Gender", Log4Type.Info);
        }

        public void SelectNominee4GenderDDL(string strGender)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Nominee4GenderNomineeDDL);
            if (strGender == "M")
            {
                strGender = "Male";
            }
            else if (strGender == "F") { strGender = "Female"; }
            else if (strGender == "T") { strGender = "Transgender"; }

            Nominee4GenderNomineeDDL.SelectDropDownList(strGender);
            Log4NetHelper.Log("Selected Nominee Gender", Log4Type.Info);
        }

        public void SelectSecondaryGenderDDL(string strGender)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SecondInsuredGenderDDL);
            if (strGender == "M")
            {
                strGender = "Male";
            }
            else if (strGender == "F") { strGender = "Female"; }
            else if (strGender == "T") { strGender = "Transgender"; }

            SecondInsuredGenderDDL.SelectDropDownList(strGender);
            Log4NetHelper.Log("Selected Secondary Gender", Log4Type.Info);
        }

        public void EnterBorrowerMobileNo(string strMobileNo)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, borrowerMobileNoTxt);
            borrowerMobileNoTxt.SendKeys(strMobileNo.ToString());
            Log4NetHelper.Log("Selected Borrower Mobile No ", Log4Type.Info);
        }

        public void EnterSecondaryMobileNo(string strMobileNo)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SecondaryMobileNoTxt);
            SecondaryMobileNoTxt.SendKeys(strMobileNo.ToString());
            Log4NetHelper.Log("Selected Secondary Mobile No ", Log4Type.Info);
        }
        public void EnterBorrowerEmailId(string strEmailID)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, borrowerEmailTxt);
            borrowerEmailTxt.SendKeys(strEmailID.ToString());
            Log4NetHelper.Log("Selected Borrower email id ", Log4Type.Info);
        }

        public void EnterSecondaryEmailId(string strEmailID)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SecondaryEmailTxt);
            SecondaryEmailTxt.SendKeys(strEmailID.ToString());
            Log4NetHelper.Log("Selected Secondary email id ", Log4Type.Info);
        }
        public void EnterSecondaryDOB(string strSecondaryDOB)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SecondInsuredDob);
            SecondInsuredDob.SendKeys(strSecondaryDOB.ToString());
            Log4NetHelper.Log("Selected Second Insured Dob", Log4Type.Info);
        }

        public void ClickonCalculatePremium()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, CalculatePremium);

            Thread.Sleep(5000);
            if (CalculatePremium.Enabled)
            {
                CalculatePremium.Click();
            }
        }

        //Create_Insurance_Application_btn
        public void ClickOnCreateInsuranceApplication()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Create_Insurance_Application_btn);

            Thread.Sleep(5000);
            if (Create_Insurance_Application_btn.Enabled)
            {
                Create_Insurance_Application_btn.Click();
            }
        }

        public bool CheckMandatory()
        {
            if (RegionMandatory.Enabled)
            {
                return true;
            }
            else if (BranchMandatory.Enabled) { return true; }
            else if (PolicyNumberMandatory.Enabled) { return true; }
            else if (PolicyNumberMandatory.Enabled) { return true; }
            else if (ModeMandatory.Enabled) { return true; }
            else if (TotalTenureMonthsYearsMandatory.Enabled) { return true; }
            else { return false; }

        }


        // public bool RegionDDLOptions(string[] opts)
        public bool RegionDDLOptions(string[] opts)
        {
            bool found = false;
            try
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, RegionDDL);
                SelectElement ddl = new SelectElement(RegionDDL);
                for (int i = 0; i < opts.Length; i++)
                {
                    RegionDDL.SelectDropDownList(opts[i]);
                    found = true;
                }
                Log4NetHelper.Log("Verrifing Region  ", Log4Type.Info);
            }
            catch (Exception)
            {
                Log4NetHelper.Log("Verrifing Region  ", Log4Type.Error);
                found = false;
            }
            return found;
        }

        public bool CheckAvail_TotaltenureDDL()
        {
            bool found = false;
            if (TotaltenureDDL.Enabled && TotaltenureDDL.Displayed)
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, TotaltenureDDL);
                found = true;
            }

            Log4NetHelper.Log("Verifying Total Tenure ", Log4Type.Info);
            return found;
        }

        public void SelectPolicyTypeDDL(string Option)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PolicyTypeDDL);
            PolicyTypeDDL.SelectDropDownList(Option);
            Log4NetHelper.Log("Selected PolicyType as " + Option, Log4Type.Info);
        }

        public bool CheckAvail_SecondInsuredDob()
        {
            bool found = false;//second-insured-dob
            if (SecondInsuredDob.Enabled && SecondInsuredDob.Displayed)
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SecondInsuredDob);
                found = true;
            }

            Log4NetHelper.Log("Verifying Insureddob dropdown exists ", Log4Type.Info);
            return found;
        }
        public void FinancialInstituteDetails(string strFinancialInst, string strRegion, string strBranch)
        {
            SelectFinancialIns(strFinancialInst);
            SelectRegionDDL(strRegion);
            SelectBranchDDL(strBranch);
        }

        public void PolicyDetails(string PolicyNumber, string PolicyType, string Mode, int TotalTenure, string CoverAmt, string IsPremiumFunded)
        {
            SelectPolicyNoDDL(PolicyNumber);
            SelectPolicyTypeDDL(PolicyType);
            SelectModeDDL(Mode);
            SelectTotaltenureDDL(TotalTenure);
            EnterCoverAmount(CoverAmt);
            SelectIsPremiumFundedDDL(IsPremiumFunded);
        }

        public void BorrowersDetails(string BorrowerState, string BorrowerGender, string DateOfBirthOfInsuredCustomer, string DateOfBirthofSecondaryInsured, string SecondaryMemberdetailsGender, string DateOfCommencementofLoan)
        {
            //SecondInsuredDob
            SelectBorrowerStateDDL(BorrowerState);
            SelectGenderDDL(BorrowerGender);
            EnterInsureddob(DateOfBirthOfInsuredCustomer);
            EnterLoanCoverDOC(DateOfCommencementofLoan);
            if (!DateOfBirthofSecondaryInsured.IsNullOrEmpty())
            {
                EnterSecondaryDOB(DateOfBirthofSecondaryInsured);
            }
            if (!SecondaryMemberdetailsGender.IsNullOrEmpty())
            {
                SelectSecondaryGenderDDL(SecondaryMemberdetailsGender);
            }
        }


        public void AdditionalDetails(string DOHGSubmitted, string refUTRNo)
        {
            EnterRefUTRNo(refUTRNo);
            SelectdoghSubmittedDDL(DOHGSubmitted);
        }

        public void ClickOnProceedBtn()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ProceedButton1);
            ProceedButton1.Click();
            Log4NetHelper.Log("Selected Borrower State", Log4Type.Info);
        }
        public void ClickOnBorrowerDetailsProceedBtn()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ProceedButton2);
            ProceedButton2.Click();
            Log4NetHelper.Log("Selected Borrower State", Log4Type.Info);
        }

        public void ClickOnBorrowerAddressProceedBtn()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ProceedButton3);
            ProceedButton3.Click();
            Log4NetHelper.Log("Clicked on Proceed button on borrower address page", Log4Type.Info);
        }
        public void ClickOnProceed4()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ProceedButton4);
            ProceedButton4.Click();
            Log4NetHelper.Log("Clicked on Proceed button on borrower address page", Log4Type.Info);
        }

        public void ClickOnSaveAndSubmit()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SubmitAndSubmit);
            Thread.Sleep(2000);
            SubmitAndSubmit.Click();
            Log4NetHelper.Log("Clicked on Submit And Submit", Log4Type.Info);
        }


        public void BorrowerPersonalDetails(string FirstName, string Surname, string Gender, string MobileNo, string emailID, string OcccupationCode, string LoanID, string TempLoanID, string AadhaarRefNo, string CustId)
        {
            EnterFirstName(FirstName);
            EnterSurname(Surname);
            SelectBorrowerGenderDDL(Gender);
            EnterBorrowerMobileNo(MobileNo);
            EnterBorrowerEmailId(emailID);
            EnterOccupationCode(OcccupationCode);
            EnterLoanId(LoanID);
            SelectIsTempLoanID(TempLoanID);
            EnterAdhaarNo(AadhaarRefNo);
            EnterCustomerID(CustId);
        }
        public void BorrowerAddressDetails(string AddressLine1, string AddressLine2, string AddressLine3, string BorrowersState, string BorrowerZipCode)
        {
            EnterAddressLine1(AddressLine1);
            EnterAddressLine2(AddressLine2);
            EnterAddressLine3(AddressLine3);
            SelectBorrowerState(BorrowersState);
            EnterPincode(BorrowerZipCode);
        }

        public void Nominee1Details(string NomineeSalutation, string NomineeFirstName, string NomineeSurname, string NomineeGender, string NomineeDOB, string NomineeRelation, string NomineeShare, string NomineeMobileNumber)
        {

            EnterNominee1Salutation(NomineeSalutation);
            EnterNominee1FirstName(NomineeFirstName);
            EnterNominee1SurName(NomineeSurname);
            SelectNominee1GenderDDL(NomineeGender);
            EnterNominee1ddob(NomineeDOB);
            SelectNominee1Relationship(NomineeRelation);
            EnterNominee1Share(int.Parse(NomineeShare));
            EnterNominee1MobileNumber(NomineeMobileNumber);
        }

        public void Nominee2Details(string Nominee2Salutation, string Nominee2FirstName, string Nominee2Surname, string Nominee2DOB, string Nominee2Gender, string Nominee2Relation, string Nominee2Share, string Nominee2MobileNumber)
        {

            EnterNominee2Salutation(Nominee2Salutation);
            EnterNominee2FirstName(Nominee2FirstName);
            EnterNominee2SurName(Nominee2Surname);
            SelectNominee2GenderDDL(Nominee2Gender);
            EnterNominee2ddob(Nominee2DOB);
            SelectNominee2Relationship(Nominee2Relation);
            EnterNominee2Share(int.Parse(Nominee2Share));
            EnterNominee2MobileNumber(Nominee2MobileNumber);
        }
        public void Nominee3Details(string Nominee3Salutation, string Nominee3FirstName, string Nominee3Surname, string Nominee3DOB, string Nominee3Gender, string Nominee3Relation, string Nominee3Share, string Nominee3MobileNumber)
        {

            EnterNominee3Salutation(Nominee3Salutation);
            EnterNominee3FirstName(Nominee3FirstName);
            EnterNominee3SurName(Nominee3Surname);
            SelectNominee3GenderDDL(Nominee3Gender);
            EnterNominee3ddob(Nominee3DOB);
            SelectNominee3Relationship(Nominee3Relation);
            EnterNominee3Share(Nominee3Share);
            EnterNominee3MobileNumber(Nominee3MobileNumber);
        }
        public void Nominee4Details(string Nominee4Salutation, string Nominee4FirstName, string Nominee4Surname, string Nominee4DOB, string Nominee4Gender, string Nominee4Relation, string Nominee4Share, string Nominee4MobileNumber)
        {

            EnterNominee4Salutation(Nominee4Salutation);
            EnterNominee4FirstName(Nominee4FirstName);
            EnterNominee4SurName(Nominee4Surname);
            SelectNominee4GenderDDL(Nominee4Gender);
            EnterNominee4ddob(Nominee4DOB);
            SelectNominee4Relationship(Nominee4Relation);
            EnterNominee4Share(Nominee4Share);
            EnterNominee4MobileNumber(Nominee4MobileNumber);
        }
        public string PremiumCalculatorSuccessMsg()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SubmittedSuccessfulMsg);
            Log4NetHelper.Log("Getting the succesfull message ", Log4Type.Info);
            return SubmittedSuccessfulMsg.Text;
        }

        public string PremiumCalculatorViewSuccessfulMsg()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ViewSuccessfulMsg);
            Log4NetHelper.Log("Getting the succesfull message ", Log4Type.Info);
            return ViewSuccessfulMsg.Text;
        }

        public void ClickonGotoDashboardBtn()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, GotoDashboardBtn);

            Thread.Sleep(3000);
            if (GotoDashboardBtn.Enabled)
            {
                GotoDashboardBtn.Click();
            }
        }


        public string RandomString(int length)
        {

            Random random = new Random();
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                char c = (char)random.Next('a', 'z' + 1); // generates a random lowercase letter
                builder.Append(c);
            }

            return builder.Replace("{", "").Replace("}", "").ToString();

        }

        public int GetDateDiff(string NomineeDOB)
        {
            DateTime dateTime = Convert.ToDateTime(NomineeDOB);
            int Nyr = dateTime.Year;
            int diffYr = DateTime.Now.Year - Nyr;
            return diffYr;
        }


        public void EnterAppointeeFirstName(string FName)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Appointeefirstname);

            if (FName.ToLower().Equals("random"))
            {
                FName = RandomString(10);
            }
            Appointeefirstname.SendKeys(FName);
            Log4NetHelper.Log("Entered First Name", Log4Type.Info);
        }
        public void EnterSecondaryFirstName(string FName)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Secondaryfirstname);

            if (FName.ToLower().Equals("random"))
            {
                FName = RandomString(10);
            }
            Secondaryfirstname.SendKeys(FName);
            Log4NetHelper.Log("Entered Secondary Name", Log4Type.Info);
        }

        public void EnterAppointeeSurname(string SName)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Appointeeesurname);

            if (SName.ToLower().Equals("random"))
            {
                SName = RandomString(10);
            }
            Appointeeesurname.SendKeys(SName);
            Log4NetHelper.Log("Entered Surname Name", Log4Type.Info);
        }
        public void EnterSecondarysurname(string SName)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Secondarysurname);

            if (SName.ToLower().Equals("random"))
            {
                SName = RandomString(10);
            }
            Secondarysurname.SendKeys(SName);
            Log4NetHelper.Log("Entered Surname Name", Log4Type.Info);
        }

        public void EnterAppointeeddob(string strNomineeDOB)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Appointeedob);
            Appointeedob.SendKeys(strNomineeDOB);
            Log4NetHelper.Log("Selected Appointee dob", Log4Type.Info);
        }

        public void EnterSecondarydob(string strSecondaryDOB)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Secondarydob);
            Secondarydob.SendKeys(strSecondaryDOB);
            Log4NetHelper.Log("Selected Secondary dob", Log4Type.Info);
        }

        //

        public void EnterAppointeeIDNo(string strAppointeeIDNo)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, AppointeeIDNo);
            AppointeeIDNo.SendKeys(strAppointeeIDNo);
            Log4NetHelper.Log("Selected Appointee ID No", Log4Type.Info);
        }

        public void EnterSecondaryIDNo(string strSecondaryIDNo)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SecondaryIDNo);
            SecondaryIDNo.SendKeys(strSecondaryIDNo);
            Log4NetHelper.Log("Selected Secondary ID No", Log4Type.Info);
        }

        public void SelectAppointeeGenderDDL(string strGender)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Appointeegender);
            if (strGender == "M")
            {
                strGender = "Male";
            }
            else if (strGender == "F") { strGender = "Female"; }
            else if (strGender == "T") { strGender = "Transgender"; }

            Appointeegender.SelectDropDownList(strGender);
            Log4NetHelper.Log("Selected Appointee Gender", Log4Type.Info);
        }

        public void SelectAppointeehonorific(string strAppointeeHonorific)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Appointeehonorific);
            Appointeehonorific.SelectDropDownList(strAppointeeHonorific);
            Log4NetHelper.Log("Selected Appointee Honorific ", Log4Type.Info);
        }
        public void SelectSecondaryhonorific(string strSecondaryHonorific)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Secondaryhonorific);
            Secondaryhonorific.SelectDropDownList(strSecondaryHonorific);
            Log4NetHelper.Log("Selected Secondary Honorific ", Log4Type.Info);
        }

        public void SelectAppointeeMartialStatus(string strAppointeeMartialStatus)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, AppointeeMartialStatus);
            AppointeeMartialStatus.SelectDropDownList(strAppointeeMartialStatus);
            Log4NetHelper.Log("Selected Appointee Martial Status ", Log4Type.Info);
        }
        public void SelectSecondaryMartialStatus(string strSecondaryMartialStatus)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SecondaryMartialStatus);
            SecondaryMartialStatus.SelectDropDownList(strSecondaryMartialStatus);
            Log4NetHelper.Log("Selected Scondary Martial Status ", Log4Type.Info);
        }

        public void SelectAppointeeRelationShip(string strAppointeeRelationShip)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, AppointeeReleationship);
            AppointeeReleationship.SelectDropDownList(strAppointeeRelationShip);
            Log4NetHelper.Log("Selected Appointee Releationship Status ", Log4Type.Info);
        }

        public void SelectSecondaryReleationship(string strSecondaryReleationship)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SecondaryReleationship);
            SecondaryReleationship.SelectDropDownList(strSecondaryReleationship);
            Log4NetHelper.Log("Selected Secondary Releationship Status ", Log4Type.Info);
        }


        public void AppointeeDetails(string AppointeeSalutation, string AppointeeFirstName, string AppointeeSurname, string AppointeeGender, string AppointeeMaritalStatus, string AppointeeDOB, string AppointeeIDNo, string AppointeeRelationship, string NomineeDOB)
        {

            SelectAppointeehonorific(AppointeeSalutation);
            EnterAppointeeFirstName(AppointeeFirstName);
            EnterAppointeeSurname(AppointeeSurname);
            SelectAppointeeGenderDDL(AppointeeGender);
            SelectAppointeeMartialStatus(AppointeeMaritalStatus);
            EnterAppointeeddob(AppointeeDOB);
            EnterAppointeeIDNo(AppointeeIDNo);
            SelectAppointeeRelationShip(AppointeeRelationship);


        }

        public void SecondaryDetails(string SecondarySalutation, string SecondaryFirstName, string SecondarySurname, string SecondaryMobileNo, string SecondaryEmailId, string SecondaryCustomerID, string SecondaryLoanId)
        {

            SelectSecondaryhonorific(SecondarySalutation);
            EnterSecondaryFirstName(SecondaryFirstName);
            EnterSecondarysurname(SecondarySurname);
            EnterSecondaryMobileNo(SecondaryMobileNo);
            EnterSecondaryEmailId(SecondaryEmailId);
            EnterSecondaryCustomerID(SecondarySurname);
            EnterSecondaryLoanId(SecondaryLoanId);




        }

        public void clickOnCalculateButton()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, calculateButton); calculateButton.Click();
        }
        public void VerifyErrorMsg()
        {
            Assert.AreEqual(FIErrorMsg.Text, AutomationSettings.ErrorMessage);
            Assert.AreEqual(RegionErrorMsg.Text, AutomationSettings.ErrorMessage);
            Assert.AreEqual(BranchErrorMsg.Text, AutomationSettings.ErrorMessage);
            Assert.AreEqual(PolicynoErrorMsg.Text, AutomationSettings.ErrorMessage);
            Assert.AreEqual(PolicytypeErrorMsg.Text, AutomationSettings.ErrorMessage);
            Assert.AreEqual(ModeErrorMsg.Text, AutomationSettings.ErrorMessage);
            Assert.AreEqual(TenureErrorMsg.Text, AutomationSettings.ErrorMessage);
            Assert.AreEqual(CoverAmountErrorMsg.Text, AutomationSettings.ErrorMessage);
            Assert.AreEqual(IsPremiumErrorMsg.Text, AutomationSettings.ErrorMessage);
            Assert.AreEqual(BorrweerStateErrorMsg.Text, AutomationSettings.ErrorMessage);
            Assert.AreEqual(GenderErrorMsg.Text, AutomationSettings.ErrorMessage);
            Assert.AreEqual(DOBErrorMsg.Text, AutomationSettings.ErrorMessage);
            Assert.AreEqual(DOCErrorMsg.Text, AutomationSettings.ErrorMessage);
            Thread.Sleep(2000);
        }

        public void ClickOnAddNominee()
        {
            Thread.Sleep(2000);
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, AddNominee);
            Thread.Sleep(2000);
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, AddNominee);
            AddNominee.Click();
            Log4NetHelper.Log("Clicked on Add Nominee", Log4Type.Info);
        }

        public void VerifyBorrowersAddressPage()
        {
            Assert.AreEqual(BorrowersAddress.Text, AutomationSettings.ProductField);
            Assert.AreEqual(AD1.Text, AutomationSettings.AD1Value);
            Assert.AreEqual(AD2.Text, AutomationSettings.AD2Value);
            Assert.AreEqual(AD3.Text, AutomationSettings.AD3Value);
            Assert.AreEqual(State.Text, AutomationSettings.StateValue);
            Assert.AreEqual(pincode.Text, AutomationSettings.PincodeValue);



        }


        public void VerifyPremiumOutputPage()

        {

            Assert.AreEqual(product.Text, AutomationSettings.ProductField);

            Assert.AreEqual(AgeOfInsured.Text, AutomationSettings.Age);

            Assert.AreEqual(UWStatus.Text, AutomationSettings.UWstatusField);

            Assert.AreEqual(FinalSI.Text, AutomationSettings.FinalSIField);

            Assert.AreEqual(KotakPremium.Text, AutomationSettings.KPfield);

            Assert.AreEqual(GoodsServices.Text, AutomationSettings.GSField);

        }

        public bool checkProductValue()
        {
            return productValue.Displayed;
        }

        public bool checkAgeOfInsuredValue()
        {
            return AgeOfInsuredValue.Displayed;
        }

        public bool checkUWStatusValue()
        {
            return UWStatusValue.Displayed;
        }

        public bool checkFinalSIValuee()
        {
            return FinalSIValue.Displayed;
        }

        public bool checkKotakPremiumValue()
        {
            return KotakPremiumValue.Displayed;
        }

        public bool checkGoodsServicesValuee()
        {
            return GoodsServicesValue.Displayed;
        }


        public bool VerifyingAddNomineeButtonIsDisabled()
        {
            return AddNominee.Enabled;
        }
        public string VerifySMQ()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, searchResultUnderwritingStatus);
            return searchResultUnderwritingStatus.Text;
        }

        public bool checkTotalPreminumValue()
        {
            return TotalPremiumValueTitle.Displayed;
        }



        //teja3(9)    Then fill all the details as Single life
        public void FillFinancialInstitutionDDL()
        {
            FinancialInstitutionDDL.SendKeys("Demo Client");
            Thread.Sleep(10000);
        }
        public void FillRegionDDL()
        {
            RegionDDL.SendKeys("North");
            Thread.Sleep(2000);
        }
        public void FillBranchDDL()
        {
            BranchDDL.SendKeys("ANUP");
            Thread.Sleep(2000);
        }
        public void FillPolicyNoDDL()
        {
            PolicyNoDDL.SendKeys("CD000150-Business Loan");
            Thread.Sleep(2000);
        }
        public void FillPolicyTypeDDL()
        {
            PolicyTypeDDL.SendKeys("Single Life");
            Thread.Sleep(2000);
        }
        public void FillModeDDL()
        {
            ModeDDL.SendKeys("Single Premium");
        }
        public void FillTotaltenureDDL()
        {
            TotaltenureDDL.SendKeys("7");
        }
        public void FillCoverAmountTxt()
        {
            CoverAmountTxt.SendKeys("2000100");
        }
        public void FillIsPremiumFundedDDL()
        {
            IsPremiumFundedDDL.SendKeys("No");
        }
        public void FillBorrowerStateDDL()
        {
            BorrowerStateDDL.SendKeys("Andhra Pradesh");
        }
        public void FillGenderDDL()
        {
            GenderDDL.SendKeys("Male");
        }
        public void FillInsureddob()
        {
            Insureddob.SendKeys("10-10-2004");
        }
        public void FillLoanCoverDOC()
        {
            LoanCoverDOC.SendKeys("10-03-2023");
        }
        public void ClickonEditBtn()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, EditButton);
            EditButton.Click();
        }

        public void chkFinancialDDL()
        {
            SelectElement option = new SelectElement(FinancialInstitutionDDL);
            for (int i = 1; i < option.Options.Count; i++)
            {
                option.SelectByIndex(i);
                //Thread.Sleep(1000);
            }
        }
        public void chkRegionDDL()
        {
            SelectElement option = new SelectElement(RegionDDL);
            for (int i = 1; i < option.Options.Count; i++)
            {
                option.SelectByIndex(i);
                //Thread.Sleep(1000);
            }
        }
        public void chkBranchDDL()
        {
            SelectElement option = new SelectElement(BranchDDL);
            for (int i = 1; i < option.Options.Count; i++)
            {
                option.SelectByIndex(i);
                //Thread.Sleep(1000);
            }
        }
        public void chkPolicyNoDDL()
        {
            SelectElement option = new SelectElement(PolicyNoDDL);
            for (int i = 1; i < option.Options.Count; i++)
            {
                option.SelectByIndex(i);
                //Thread.Sleep(1000);
            }
        }
        public void chkPolicyTypeDDL()
        {
            SelectElement option = new SelectElement(PolicyTypeDDL);
            for (int i = 1; i < option.Options.Count; i++)
            {
                option.SelectByIndex(i);
                //Thread.Sleep(1000);
            }
        }
        public void chkModeDDL()
        {
            SelectElement option = new SelectElement(ModeDDL);
            for (int i = 1; i < option.Options.Count; i++)
            {
                option.SelectByIndex(i);
                //Thread.Sleep(1000);
            }
        }
        public void chkTotaltenureDDL()
        {
            SelectElement option = new SelectElement(TotaltenureDDL);
            for (int i = 1; i < option.Options.Count; i++)
            {
                option.SelectByIndex(i);
                //Thread.Sleep(1000);
            }
        }
        public void chkCoverAmountTxt()
        {
            CoverAmountTxt.SendKeys("2000000");
        }
        public void chkIsPremiumFundedDDL()
        {
            SelectElement option = new SelectElement(IsPremiumFundedDDL);
            for (int i = 1; i < option.Options.Count; i++)
            {
                option.SelectByIndex(i);
                //Thread.Sleep(1000);
            }
        }
        public void chkBorrowerStateDDL()
        {
            SelectElement option = new SelectElement(BorrowerStateDDL);
            for (int i = 1; i < option.Options.Count; i++)
            {
                option.SelectByIndex(i);
                //Thread.Sleep(1000);
            }
        }
        public void chkGenderDDL()
        {
            SelectElement option = new SelectElement(GenderDDL);
            for (int i = 1; i < option.Options.Count; i++)
            {
                option.SelectByIndex(i);
                //Thread.Sleep(1000);
            }
        }
        public void chkInsureddob()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Insureddob);
            Insureddob.SendKeys("10101978");
        }
        public void chkLoanCoverDOC()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Insureddob);
            Insureddob.SendKeys("10032023");
        }
        public void chkSecondInsuredDob()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SecondInsuredDob);
            Insureddob.SendKeys("10101964");
        }
        public void chkSecondInsuredGenderDDL()
        {
            SelectElement option = new SelectElement(SecondInsuredGenderDDL);
            for (int i = 1; i < option.Options.Count; i++)
            {
                option.SelectByIndex(i);
                //Thread.Sleep(1000);
            }
        }
        public void chkdoghSubmittedDDL()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, doghSubmittedDDL);
            SelectElement DOGHddl = new SelectElement(doghSubmittedDDL);
            for (int i = 1; i < DOGHddl.Options.Count; i++)
            {
                DOGHddl.SelectByIndex(i);
                Thread.Sleep(1000);
            }
            Log4NetHelper.Log("Veifying Region ", Log4Type.Info);
        }

        public void chkUTRNumber()
        {
            Random num = new Random();
            int RndNum = num.Next(100, 999999999);
            string Number = RndNum.ToString();
            ReferenceUtrTxt.SendKeys(Number);
        }

        public void chkAddressLine1()
        {
            Random ran = new Random();
            int rand_num = ran.Next(100000, 999999);
            string s1 = rand_num.ToString();
            string b = "ABCDEFGHIJKLMNOOPQRSTUVWXYZ";
            int length = 5;
            string random = "";



            for (int i = 0; i < length; i++)
            {
                int a = ran.Next(26);
                random = random + b.ElementAt(a);
            }



            Console.WriteLine(random + s1);




            Address1Txt.SendKeys(random + s1);
            Address2Txt.SendKeys(random + s1);
            Address3Txt.SendKeys(random + s1);
            PincodeTxt.SendKeys(s1);
        }

        public void chkStateDDL()
        {
            SelectElement opt = new SelectElement(StateDDL);



            for (int i = 1; i < opt.Options.Count; i++)
            {
                opt.SelectByIndex(i);
                Thread.Sleep(1000);
            }
        }

        public string VerifyPremiumOutputTitle()
        {
            return PremiumOutputTitle.Text;
        }
        public void BorrowerPersonalDetailsSpecified(string FirstName, string Surname, string MobileNo, string emailID, string OcccupationCode, string LoanID, string TempLoanID, string AadhaarRefNo, string CustId)
        {
            EnterFirstName(FirstName);
            EnterSurname(Surname);
            EnterSalutation();
            EnterGender();
            EnterBorrowerMobileNo(MobileNo);
            EnterBorrowerEmailId(emailID);
            EnterOccupationCode(OcccupationCode);
            EnterLoanId(LoanID);
            SelectIsTempLoanID(TempLoanID);
            EnterAdhaarNo(AadhaarRefNo);
            EnterCustomerID(CustId);
        }
        public void EnterSalutation()
        {
            SelectElement option = new SelectElement(borrowerSalutation);
            for (int i = 1; i < option.Options.Count; i++)
            {
                option.SelectByIndex(i);
                Thread.Sleep(1000);
            }
        }

        public void EnterGender()
        {
            SelectElement option = new SelectElement(borrowerGenderDDL);
            for (int i = 1; i < option.Options.Count; i++)
            {
                option.SelectByIndex(i);
                Thread.Sleep(1000);
            }
        }
    }
}
