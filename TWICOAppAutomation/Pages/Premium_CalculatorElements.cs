using CSharpAFProject.Base;
using CSharpAFProject.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;
using SurakshaAutomation.Data;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace SurakshaAutomation.Pages
{
    public partial class Premium_Calculator : BasePage
    {
        protected IWebElement CalculatePremium => _parallelConfig.Driver.FindElement(By.XPath("//button[@class='btn primary-button']"));
        protected IWebElement RegionMandatory => _parallelConfig.Driver.FindElement(By.XPath("//span[text()='This field is mandatory']//preceding::label[contains(text(),'Region')]"));
        protected IWebElement BranchMandatory => _parallelConfig.Driver.FindElement(By.XPath("//span[text()='This field is mandatory']//preceding::label[contains(text(),'Branch')]"));
        protected IWebElement PolicyNumberMandatory => _parallelConfig.Driver.FindElement(By.XPath("//span[text()='This field is mandatory']//preceding::label[contains(text(),'Policy Number - Policy Name')]"));
        protected IWebElement policyTypeMandatory => _parallelConfig.Driver.FindElement(By.XPath("//span[text()='This field is mandatory']//preceding::label[contains(text(),'policyType')]"));
        protected IWebElement ModeMandatory => _parallelConfig.Driver.FindElement(By.XPath("//span[text()='This field is mandatory']//preceding::label[contains(text(),'Mode')]"));
        protected IWebElement TotalTenureMonthsYearsMandatory => _parallelConfig.Driver.FindElement(By.XPath("//span[text()='This field is mandatory']//preceding::label[contains(text(),'Total Tenure(Months/Years)')]"));


        protected IWebElement FinancialInstitutionDDL => _parallelConfig.Driver.FindElement(By.Id("financial-institution"));
        protected IWebElement RegionDDL => _parallelConfig.Driver.FindByXpath("//select[@id='region']");
        protected IWebElement BranchDDL => _parallelConfig.Driver.FindByXpath("//select[@id='branch']");
        protected IWebElement PolicyNoDDL => _parallelConfig.Driver.FindElement(By.Id("policyNo"));
        protected IWebElement PolicyTypeDDL => _parallelConfig.Driver.FindElement(By.Id("policyType"));
        protected IWebElement ModeDDL => _parallelConfig.Driver.FindElement(By.Id("mode"));
        protected IWebElement TotaltenureDDL => _parallelConfig.Driver.FindElement(By.Id("total-tenure"));
        protected IWebElement CoverAmountTxt => _parallelConfig.Driver.FindElement(By.Id("cover-amount"));
        protected IWebElement IsPremiumFundedDDL => _parallelConfig.Driver.FindElement(By.Id("is-premium-funded"));
        protected IWebElement BorrowerStateDDL => _parallelConfig.Driver.FindElement(By.Id("borrower-state"));
        protected IWebElement GenderDDL => _parallelConfig.Driver.FindElement(By.Id("gender"));
        protected IWebElement Insureddob => _parallelConfig.Driver.FindElement(By.Id("insured-dob"));
        protected IWebElement SecondInsuredDob => _parallelConfig.Driver.FindElement(By.Id("second-insured-dob"));
        protected IWebElement SecondInsuredGenderDDL => _parallelConfig.Driver.FindElement(By.Id("secondary-gender"));
        protected IWebElement LoanCoverDOC => _parallelConfig.Driver.FindElement(By.Id("loan-cover-doc"));





        //PATHS  FOR AFTER CLICKING on CALCULATE PREMIMUM
        // 1 - Premimum Output Page
        protected IWebElement Create_Insurance_Application_btn => _parallelConfig.Driver.FindByXpath("//button[@class='btn primary-button']");
        //Paths after clicking CREATE INSURANCE APPLICATION
        protected IWebElement doghSubmittedDDL => _parallelConfig.Driver.FindElement(By.Id("dogh-submitted"));
        protected IWebElement ReferenceUtrTxt => _parallelConfig.Driver.FindElement(By.Id("reference-utr-no"));
        protected IWebElement ProceedButton1 => _parallelConfig.Driver.FindElementByXPath(" (//button[text()=' Proceed '])[1] ");
        //After clicking on PROCEED BTN1
        //2 Borrower's Details
        protected IWebElement borrowerFirstnameTxt => _parallelConfig.Driver.FindElement(By.Id("borrower-firstName"));
        protected IWebElement borrowerSurnameTxt => _parallelConfig.Driver.FindElement(By.Id("borrower-surname"));
        protected IWebElement borrowerGenderDDL => _parallelConfig.Driver.FindElement(By.Id("borrower-gender"));
        protected IWebElement borrowerMobileNoTxt => _parallelConfig.Driver.FindElement(By.Id("borrower-mobile"));
        protected IWebElement borrowerEmailTxt => _parallelConfig.Driver.FindElement(By.Id("borrower-email"));
        protected IWebElement OccupationTxt => _parallelConfig.Driver.FindElement(By.Id("borrower-occupation-name"));
        protected IWebElement LoanIdTxt => _parallelConfig.Driver.FindElement(By.Id("borrower-loanID"));
        protected IWebElement TemporaryLoanIdDDL => _parallelConfig.Driver.FindElement(By.Id("is-temp-loan"));
        protected IWebElement AadharTxt => _parallelConfig.Driver.FindElement(By.Id("borrower-adhaar"));
        protected IWebElement CustomerIdTxt => _parallelConfig.Driver.FindElement(By.Id("borrower-customerID"));
        protected IWebElement ProceedButton2 => _parallelConfig.Driver.FindElementByXPath(" (//button[text()=' Proceed '])[2] ");
        //2Page Error Messages
        protected IWebElement FirstnameMandatory => _parallelConfig.Driver.FindElementByXPath(" (//label[text()='First Name ']/following::*[text()='This field is mandatory'])[1] ");
        protected IWebElement SurnameMandatory => _parallelConfig.Driver.FindElementByXPath(" (//label[text()='First Name ']/following::*[text()='This field is mandatory'])[2] ");
        protected IWebElement GederMandatory => _parallelConfig.Driver.FindElementByXPath(" (//label[text()='First Name ']/following::*[text()='This field is mandatory'])[3] ");
        protected IWebElement MobileMandatory => _parallelConfig.Driver.FindElementByXPath(" (//label[text()='First Name ']/following::*[text()='This field is mandatory'])[4] ");
        protected IWebElement LoanMandatory => _parallelConfig.Driver.FindElementByXPath(" (//label[text()='First Name ']/following::*[text()='This field is mandatory'])[5] ");
        protected IWebElement CustomerIdMandatory => _parallelConfig.Driver.FindElementByXPath(" (//label[text()='First Name ']/following::*[text()='This field is mandatory'])[6] ");         //After Clicking on PROCEED BTN2
        //3 Borrower's Address
        protected IWebElement Address1Txt => _parallelConfig.Driver.FindElement(By.Id("borrower-address-1"));
        protected IWebElement Address2Txt => _parallelConfig.Driver.FindElement(By.Id("borrower-address-2"));
        protected IWebElement Address3Txt => _parallelConfig.Driver.FindElement(By.Id("borrower-address-3"));
        protected IWebElement StateDDL => _parallelConfig.Driver.FindElement(By.Id("borrower-state"));
        protected IWebElement PincodeTxt => _parallelConfig.Driver.FindElement(By.Id("borrower-pincode"));
        //Error msgs in 3 page
        protected IWebElement Address1Mandatory => _parallelConfig.Driver.FindElementByXPath("(//*[text()='Address Line 1 ']/following::*[text()='This field is mandatory'])[1]");
        protected IWebElement StateMandatory => _parallelConfig.Driver.FindElementByXPath("(//*[text()='State ']/following::*[text()='This field is mandatory'])[1]");
        protected IWebElement PincodeMandatory => _parallelConfig.Driver.FindElementByXPath("(//*[text()='Pincode ']/following::*[text()='This field is mandatory'])[1]"); protected IWebElement ProceedButton3 => _parallelConfig.Driver.FindElementByXPath(" (//button[text()=' Proceed '])[3] ");

        protected IWebElement ProceedButton4 => _parallelConfig.Driver.FindElementByXPath("(//button[text()=' Proceed '])[4] ");
        //After clicking on PROCEED BUTTON3
        //4 Nominee Details
        protected IWebElement FirstnameNomineeTxt => _parallelConfig.Driver.FindElement(By.Id("first-name-0"));
        protected IWebElement SurnameNomineeTxt => _parallelConfig.Driver.FindElement(By.Id("surname-0"));
        protected IWebElement GenderNomineeDDL => _parallelConfig.Driver.FindElement(By.Id("nominee-gender-0"));
        protected IWebElement DOBNominee => _parallelConfig.Driver.FindElement(By.Id("nominee-dob-0"));
        protected IWebElement NomineeReleationshipDDL => _parallelConfig.Driver.FindElement(By.Id("nominee-relationship-0"));
        protected IWebElement NomineePercentageTxt => _parallelConfig.Driver.FindElement(By.Id("share-percent-0"));
        protected IWebElement NomineeMobileNumberTxt => _parallelConfig.Driver.FindElement(By.Id("mobile-number-0"));

        protected IWebElement Appointeehonorific => _parallelConfig.Driver.FindElement(By.Id("appointee-honorific"));
        protected IWebElement Appointeefirstname => _parallelConfig.Driver.FindElement(By.Id("appointee-firstname"));
        protected IWebElement Appointeeesurname => _parallelConfig.Driver.FindElement(By.Id("appointeee-surname"));
        protected IWebElement Appointeedob => _parallelConfig.Driver.FindElement(By.Id("appointee-dob"));
        protected IWebElement Appointeegender => _parallelConfig.Driver.FindElement(By.Id("appointee-gender"));
        protected IWebElement AppointeeMartialStatus => _parallelConfig.Driver.FindElement(By.Id("appointee-marital-status"));
        protected IWebElement AppointeeIDNo => _parallelConfig.Driver.FindElement(By.Id("appointee-id"));
        protected IWebElement AppointeeReleationship => _parallelConfig.Driver.FindElement(By.Id("appointee-relationship"));


        protected IWebElement Secondaryhonorific => _parallelConfig.Driver.FindElement(By.Id("secondaryMember-honorific"));
        protected IWebElement Secondaryfirstname => _parallelConfig.Driver.FindElement(By.Id("secondary-firstname"));
        protected IWebElement Secondarysurname => _parallelConfig.Driver.FindElement(By.Id("secondary-surname"));


        protected IWebElement SecondaryMobileNoTxt => _parallelConfig.Driver.FindElement(By.Id("secondary-mobile"));
        protected IWebElement SecondaryEmailTxt => _parallelConfig.Driver.FindElement(By.Id("secondary-email-id"));
        protected IWebElement SecondaryCustomerIdTxt => _parallelConfig.Driver.FindElement(By.Id("secondary-customer-id"));
        protected IWebElement SecondaryLoanIdTxt => _parallelConfig.Driver.FindElement(By.Id("secondary-loan-id"));

        protected IWebElement Secondarydob => _parallelConfig.Driver.FindElement(By.Id("secondaryMember-dob"));
        protected IWebElement Secondarygender => _parallelConfig.Driver.FindElement(By.Id("secondaryMember-gender"));
        protected IWebElement SecondaryMartialStatus => _parallelConfig.Driver.FindElement(By.Id("secondaryMember-marital-status"));
        protected IWebElement SecondaryIDNo => _parallelConfig.Driver.FindElement(By.Id("secondaryMember-id"));
        protected IWebElement SecondaryReleationship => _parallelConfig.Driver.FindElement(By.Id("secondaryMember-relationship"));



        protected IWebElement SubmitAndSubmit => _parallelConfig.Driver.FindElement(By.XPath("(//button[text()=' Save & Submit '])[1]"));
        protected IWebElement SubmittedSuccessfulMsg => _parallelConfig.Driver.FindElement(By.XPath("//p[contains(text(),'Application submitted successfully')]"));
        protected IWebElement ViewSuccessfulMsg => _parallelConfig.Driver.FindElement(By.XPath("//p[contains(text(),'has been submitted successfully. View it on')]"));
        protected IWebElement GotoDashboardBtn => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='success-popup']/div/div/div[3]/button"));


        //Nikhila ID15 premium calculator

        IWebElement calculateButton => _parallelConfig.Driver.FindByXpath("//*[@class='btn primary-button']");
        IWebElement AddNominee => _parallelConfig.Driver.FindByXpath("//*[@id='nominee-details']/div[2]/button");
        IWebElement FIErrorMsg => _parallelConfig.Driver.FindByXpath("(//span[text()='This field is mandatory'])[1]");
        IWebElement RegionErrorMsg => _parallelConfig.Driver.FindByXpath("(//span[text()='This field is mandatory'])[2]");
        IWebElement BranchErrorMsg => _parallelConfig.Driver.FindByXpath("(//span[text()='This field is mandatory'])[3]");
        IWebElement PolicynoErrorMsg => _parallelConfig.Driver.FindByXpath("(//span[text()='This field is mandatory'])[4]");
        IWebElement PolicytypeErrorMsg => _parallelConfig.Driver.FindByXpath("(//span[text()='This field is mandatory'])[5]");
        IWebElement ModeErrorMsg => _parallelConfig.Driver.FindByXpath("(//span[text()='This field is mandatory'])[6]");
        IWebElement TenureErrorMsg => _parallelConfig.Driver.FindByXpath("(//span[text()='This field is mandatory'])[7]");
        IWebElement CoverAmountErrorMsg => _parallelConfig.Driver.FindByXpath("(//span[text()='This field is mandatory'])[8]");
        IWebElement IsPremiumErrorMsg => _parallelConfig.Driver.FindByXpath("(//span[text()='This field is mandatory'])[9]");
        IWebElement BorrweerStateErrorMsg => _parallelConfig.Driver.FindByXpath("(//span[text()='This field is mandatory'])[10]");
        IWebElement GenderErrorMsg => _parallelConfig.Driver.FindByXpath("(//span[text()='This field is mandatory'])[11]");
        IWebElement DOBErrorMsg => _parallelConfig.Driver.FindByXpath("(//span[text()='This field is mandatory'])[12]");
        IWebElement DOCErrorMsg => _parallelConfig.Driver.FindByXpath("(//span[text()='This field is mandatory'])[13]");

        protected IWebElement Nominee1honorificDDL => _parallelConfig.Driver.FindElement(By.Id("nominee-honorific-0"));
        protected IWebElement Nominee2honorificDDL => _parallelConfig.Driver.FindElement(By.Id("nominee-honorific-1"));
        protected IWebElement Nominee2FirstnameNomineeTxt => _parallelConfig.Driver.FindElement(By.Id("first-name-1"));
        protected IWebElement Nominee2SurnameNomineeTxt => _parallelConfig.Driver.FindElement(By.Id("surname-1"));
        protected IWebElement Nominee2GenderNomineeDDL => _parallelConfig.Driver.FindElement(By.Id("nominee-gender-1"));
        protected IWebElement Nominee2DOBNominee => _parallelConfig.Driver.FindElement(By.Id("nominee-dob-1"));
        protected IWebElement Nominee2ReleationshipDDL => _parallelConfig.Driver.FindElement(By.Id("nominee-relationship-1"));
        protected IWebElement Nominee2PercentageTxt => _parallelConfig.Driver.FindElement(By.Id("share-percent-1"));
        protected IWebElement Nominee2MobileNumberTxt => _parallelConfig.Driver.FindElement(By.Id("mobile-number-1"));

        protected IWebElement Nominee3honorificDDL => _parallelConfig.Driver.FindElement(By.Id("nominee-honorific-2"));
        protected IWebElement Nominee3FirstnameNomineeTxt => _parallelConfig.Driver.FindElement(By.Id("first-name-2"));
        protected IWebElement Nominee3SurnameNomineeTxt => _parallelConfig.Driver.FindElement(By.Id("surname-2"));
        protected IWebElement Nominee3GenderNomineeDDL => _parallelConfig.Driver.FindElement(By.Id("nominee-gender-2"));
        protected IWebElement Nominee3DOBNominee => _parallelConfig.Driver.FindElement(By.Id("nominee-dob-2"));
        protected IWebElement Nominee3ReleationshipDDL => _parallelConfig.Driver.FindElement(By.Id("nominee-relationship-2"));
        protected IWebElement Nominee3PercentageTxt => _parallelConfig.Driver.FindElement(By.Id("share-percent-2"));
        protected IWebElement Nominee3MobileNumberTxt => _parallelConfig.Driver.FindElement(By.Id("mobile-number-2"));

        protected IWebElement Nominee4honorificDDL => _parallelConfig.Driver.FindElement(By.Id("nominee-honorific-3"));
        protected IWebElement Nominee4FirstnameNomineeTxt => _parallelConfig.Driver.FindElement(By.Id("first-name-3"));
        protected IWebElement Nominee4SurnameNomineeTxt => _parallelConfig.Driver.FindElement(By.Id("surname-3"));
        protected IWebElement Nominee4GenderNomineeDDL => _parallelConfig.Driver.FindElement(By.Id("nominee-gender-3"));
        protected IWebElement Nominee4DOBNominee => _parallelConfig.Driver.FindElement(By.Id("nominee-dob-3"));
        protected IWebElement Nominee4ReleationshipDDL => _parallelConfig.Driver.FindElement(By.Id("nominee-relationship-3"));
        protected IWebElement Nominee4PercentageTxt => _parallelConfig.Driver.FindElement(By.Id("share-percent-3"));
        protected IWebElement Nominee4MobileNumberTxt => _parallelConfig.Driver.FindElement(By.Id("mobile-number-3"));

        //@ID_22_Nikhila_(PremiumCalculator)
        IWebElement BorrowersAddress => _parallelConfig.Driver.FindByXpath("//p[text()=\"Borrower's Address\"]");
        IWebElement AD1 => _parallelConfig.Driver.FindByXpath("//label[text()='Address Line 1 ']");
        IWebElement AD2 => _parallelConfig.Driver.FindByXpath("//label[text()='Address Line 2']");
        IWebElement AD3 => _parallelConfig.Driver.FindByXpath("//label[text()='Address Line 3']");
        IWebElement State => _parallelConfig.Driver.FindByXpath("//label[text()='State ']");
        IWebElement pincode => _parallelConfig.Driver.FindByXpath("//label[text()='Pincode ']");





        IWebElement product => _parallelConfig.Driver.FindByXpath("//*[text()='Product']");

        IWebElement AgeOfInsured => _parallelConfig.Driver.FindByXpath("//*[text()='Age of Insured Customer(Years)']");

        IWebElement UWStatus => _parallelConfig.Driver.FindByXpath("//*[text()='Underwriting Status']");

        IWebElement FinalSI => _parallelConfig.Driver.FindByXpath("//*[text()='Final Sum Insured']");

        IWebElement KotakPremium => _parallelConfig.Driver.FindByXpath("//*[text()='Kotak Premium(in Rs.)']");

        IWebElement GoodsServices => _parallelConfig.Driver.FindByXpath("//*[text()='Goods Service Tax(in Rs.)']");



        IWebElement productValue => _parallelConfig.Driver.FindByXpath("//*[text()='Product']/following-sibling::*");

        IWebElement AgeOfInsuredValue => _parallelConfig.Driver.FindByXpath("//*[text()='Age of Insured Customer(Years)']/following-sibling::*");

        IWebElement UWStatusValue => _parallelConfig.Driver.FindByXpath("//*[text()='Underwriting Status']/following-sibling::*");

        IWebElement FinalSIValue => _parallelConfig.Driver.FindByXpath("//*[text()='Final Sum Insured']/following-sibling::*");

        IWebElement KotakPremiumValue => _parallelConfig.Driver.FindByXpath("//*[text()='Kotak Premium(in Rs.)']/following-sibling::*");

        IWebElement GoodsServicesValue => _parallelConfig.Driver.FindByXpath("//*[text()='Goods Service Tax(in Rs.)']/following-sibling::*");
        IWebElement searchResultUnderwritingStatus => _parallelConfig.Driver.FindElement(By.XPath("//tr[2]/td[9]"));
        IWebElement TotalPremiumValueTitle => _parallelConfig.Driver.FindElement(By.XPath("//*[text()=' Total Premium(in Rs.) ']//following-sibling::*"));

        IWebElement EditButton => _parallelConfig.Driver.FindByXpath("//button[text()=' Edit ']");


        IWebElement borrowerSalutation => _parallelConfig.Driver.FindElement(By.Id("borrower-honorific"));


        IWebElement PremiumOutputTitle => _parallelConfig.Driver.FindElement(By.XPath("//*[text()=' Premium Output ']"));














    }
}
