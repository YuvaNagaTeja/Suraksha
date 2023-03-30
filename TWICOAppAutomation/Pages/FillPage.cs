using CSharpAFProject.Base;
using CSharpAFProject.Extensions;
using CSharpAFProject.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SurakshaAutomation.Pages
{
    internal class FillPage : BasePage
    {
        private readonly ParallelConfig _parallelConfig;
        public FillPage(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        private IWebElement nationalityDDL => _parallelConfig.Driver.FindElement(By.Id("nationality"));
        private IWebElement borrowersDDL => _parallelConfig.Driver.FindElement(By.Id("borrowers"));
        private IWebElement employmenttypeDDL => _parallelConfig.Driver.FindElement(By.Id("employment-type"));
        private IWebElement borrowertypeDDL => _parallelConfig.Driver.FindElement(By.Id("borrower-type"));
        private IWebElement pancardTxt => _parallelConfig.Driver.FindElement(By.Id("pancard"));
        private IWebElement weightTxt => _parallelConfig.Driver.FindElement(By.Id("weight"));
        private IWebElement annualincomeTxt => _parallelConfig.Driver.FindElement(By.Id("annual-income"));
        private IWebElement heightinfeetDDL => _parallelConfig.Driver.FindElement(By.Id("height-in-feet"));
        private IWebElement heightininchesDDL => _parallelConfig.Driver.FindElement(By.Id("height-in-inches"));
        private IWebElement ContinueToSMQBtn => _parallelConfig.Driver.FindElement(By.XPath("//button[contains(text(),'Continue to SMQ')]"));
        private IWebElement Error_Nationality_Madatory => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='fill-tab']/form/div[2]/div/div[1]/div/span"));
        private IWebElement Error_TotalNoOfBorrowers_Madatory => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='fill-tab']/form/div[2]/div/div[2]/div/span"));
        private IWebElement Error_TypeofEmployment_Madatory => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='fill-tab']/form/div[2]/div/div[3]/div/span"));
        private IWebElement Error_PrimaryBorrowerCoBorrower_Madatory => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='fill-tab']/form/div[2]/div/div[4]/div/span"));
        private IWebElement Error_PanCard_Madatory => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='fill-tab']/form/div[2]/div/div[5]/div/span"));
        private IWebElement Error_WeightInKG_Madatory => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='fill-tab']/form/div[2]/div/div[6]/div/span"));
        private IWebElement Error_AnnualIncome_Madatory => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='fill-tab']/form/div[2]/div/div[7]/div/span"));
        private IWebElement Error_HeightInFeet_Madatory => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='fill-tab']/form/div[2]/div/div[8]/div[1]/div/span"));
        private IWebElement Error_HeightInInches_Madatory => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='fill-tab']/form/div[2]/div/div[8]/div[2]/div/span"));
        private IWebElement Error_PanCardSpc => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='fill-tab']/form/div[2]/div/div[5]/div[1]/span"));
        private IWebElement Error_WeightSpc => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='fill-tab']/form/div[2]/div/div[6]/div[1]/span"));
        private IWebElement Error_AnnualIncomeSpc => _parallelConfig.Driver.FindElement(By.XPath("//*[@id='fill-tab']/form/div[2]/div/div[7]/div[1]/span"));
        private IWebElement FullNameTitle => _parallelConfig.Driver.FindElement(By.XPath("//p[text()='Full Name']"));
        private IWebElement ActualFullNameTitle => _parallelConfig.Driver.FindElement(By.XPath("//p[text()='Full Name']/following-sibling::*"));
        private IWebElement SumAssuredTitle => _parallelConfig.Driver.FindElement(By.XPath("//p[text()='Sum Assured']"));
        private IWebElement ActualSumAssuredTitle => _parallelConfig.Driver.FindElement(By.XPath("//p[text()='Sum Assured']/following-sibling::*"));
        private IWebElement TenureTitle => _parallelConfig.Driver.FindElement(By.XPath("//p[text()='Tenure']"));
        private IWebElement ActualTenureTitle => _parallelConfig.Driver.FindElement(By.XPath("//p[text()='Tenure']/following-sibling::*"));
        private IWebElement PremiumTitle => _parallelConfig.Driver.FindElement(By.XPath("//p[text()='Premium']"));
        private IWebElement ActualPremiumTitle => _parallelConfig.Driver.FindElement(By.XPath("//p[text()='Premium']/following-sibling::*"));
        private IWebElement NomineeAssuredDetailsTitle => _parallelConfig.Driver.FindElement(By.XPath("//p[text()='Nominee Assured Details']"));
        private IWebElement ActualNomineeAssuredDetailsTitle => _parallelConfig.Driver.FindElement(By.XPath("//p[text()='Nominee Assured Details']/following-sibling::*"));
        private IWebElement NomineeFullNameTitle => _parallelConfig.Driver.FindElement(By.XPath("//p[text()='Nominee Full Name']"));
        private IWebElement ActualNomineeFullNameTitle => _parallelConfig.Driver.FindElement(By.XPath("//p[text()='Nominee Full Name']/following-sibling::*"));
        private IWebElement NomineePercentofShareTitle => _parallelConfig.Driver.FindElement(By.XPath("//p[text()='Nominee Percent of Share']"));
        private IWebElement ActualNomineePercentofShareTitle => _parallelConfig.Driver.FindElement(By.XPath("//p[text()='Nominee Percent of Share']/following-sibling::*"));
        private IWebElement RelationshipwithlifeinsuredTitle => _parallelConfig.Driver.FindElement(By.XPath("//p[text()='Relationship with life insured']"));
        private IWebElement ActualRelationshipwithlifeinsuredTitle => _parallelConfig.Driver.FindElement(By.XPath("//p[text()='Relationship with life insured']/following-sibling::*"));



        public bool ChkAnnualIncomeSpcErrorMsg()
        {
            annualincomeTxt.Click();

            if (Error_AnnualIncomeSpc.Displayed)
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Error_AnnualIncomeSpc);
                return true;
            }
            else return false;
        }



        public bool ChkWeightSpcErrorMsg()
        {
            weightTxt.Click();

            if (Error_WeightSpc.Displayed)
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Error_WeightSpc);
                return true;
            }
            else return false;
        }

        public bool ChkPanCardSpcErrorMsg()
        {
            pancardTxt.Click();

            if (Error_PanCardSpc.Displayed)
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Error_PanCardSpc);
                return true;
            }
            else return false;
        }
        public void ClrPANcard()
        {
            pancardTxt.Clear();
        }

        public bool ChkHeightInInchesErrorMsg()
        {

            if (Error_HeightInInches_Madatory.Displayed)
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Error_HeightInInches_Madatory);
                return true;
            }
            else return false;
        }


        public bool ChkHeightInFeetErrorMsg()
        {

            if (Error_HeightInFeet_Madatory.Displayed)
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Error_HeightInFeet_Madatory);
                return true;
            }
            else return false;
        }


        public bool ChkAnnualIncomeErrorMsg()
        {
            if (Error_AnnualIncome_Madatory.Displayed)
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Error_AnnualIncome_Madatory);
                return true;
            }
            else return false;
        }

        public bool ChkWeightInKGErrorMsg()
        {
            if (Error_WeightInKG_Madatory.Displayed)
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Error_WeightInKG_Madatory);
                return true;
            }
            else return false;
        }
        public bool ChkPanCardErrorMsg()
        {
            if (Error_PanCard_Madatory.Displayed)
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Error_PanCard_Madatory);
                return true;
            }
            else return false;
        }



        public bool ChkPrimaryBorrowerCoBorrowerErrorMsg()
        {
            if (Error_PrimaryBorrowerCoBorrower_Madatory.Displayed)
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Error_PrimaryBorrowerCoBorrower_Madatory);
                return true;
            }
            else return false;
        }

        public bool ChkTypeofEmploymentErrorMsg()
        {
            if (Error_TypeofEmployment_Madatory.Displayed)
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Error_TypeofEmployment_Madatory);
                return true;
            }
            else return false;
        }


        public bool ChkNationalityErrorMsg()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, Error_Nationality_Madatory, TimeSpan.FromSeconds(10));
            if (Error_Nationality_Madatory.Displayed)
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Error_Nationality_Madatory);
                return true;
            }
            else return false;
        }

        public bool ChkTotalNoOfBorrowersErrorMsg()
        {
            WaitHelper.WaitForWebElementToBeVisible(_parallelConfig.Driver, Error_TotalNoOfBorrowers_Madatory, TimeSpan.FromSeconds(10));
            if (Error_TotalNoOfBorrowers_Madatory.Displayed)
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Error_TotalNoOfBorrowers_Madatory);
                return true;
            }
            else return false;
        }


        public void ClickOnContinuetoSMQ()
        {
            if (ContinueToSMQBtn.Displayed)
            {
                ContinueToSMQBtn.Click();
            }
        }

        public void ChkNationality()
        {

            SelectElement options = new SelectElement(nationalityDDL);
            for (int i = 0; i < options.Options.Count; i++)
            {
                options.SelectByIndex(i);

            }
            Log4NetHelper.Log("Verifing Nationality dropdown selections ", Log4Type.Info);
        }

        public void ChkBorrowersDDL()
        {

            SelectElement options = new SelectElement(borrowersDDL);
            for (int i = 0; i < options.Options.Count; i++)
            {
                options.SelectByIndex(i);
            }
            Log4NetHelper.Log("Verifing Total number of borrowers dropdown selections ", Log4Type.Info);
        }
        public void ChkTypeofEmpDDL()
        {

            SelectElement options = new SelectElement(employmenttypeDDL);
            for (int i = 0; i < options.Options.Count; i++)
            {
                options.SelectByIndex(i);
            }
            Log4NetHelper.Log("Verifing type of employment dropdown selections ", Log4Type.Info);
        }

        public void ChkTypeofBorrowerDDL()
        {

            SelectElement options = new SelectElement(borrowertypeDDL);
            for (int i = 0; i < options.Options.Count; i++)
            {
                options.SelectByIndex(i);
            }
            Log4NetHelper.Log("Verifing Primary Borrower or Co-Borrower dropdown selections ", Log4Type.Info);
        }
        public void ChkHeightInFeet()
        {

            SelectElement options = new SelectElement(heightinfeetDDL);
            for (int i = 0; i < options.Options.Count; i++)
            {
                options.SelectByIndex(i);
            }
            Log4NetHelper.Log("Verifing height in feet dropdown selections ", Log4Type.Info);
        }
        public void ChkHeightInInches()
        {

            SelectElement options = new SelectElement(heightininchesDDL);
            for (int i = 0; i < options.Options.Count; i++)
            {
                options.SelectByIndex(i);
            }
            Log4NetHelper.Log("Verifing height in inches dropdown selections ", Log4Type.Info);
        }

        public void SelectHeightininchesDDL(int inches)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, heightininchesDDL);
            heightininchesDDL.SendKeys(inches.ToString());
            Log4NetHelper.Log("Selected Height in inches", Log4Type.Info);
        }

        public void SelectHeightinfeetDDL(int feet)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, heightinfeetDDL);
            heightinfeetDDL.SendKeys(feet.ToString());
            Log4NetHelper.Log("Selected Height in Feet", Log4Type.Info);
        }

        public void EnterAnnualIncome(string strAnnualIncome)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, annualincomeTxt);
            annualincomeTxt.SendKeys(strAnnualIncome);
            Log4NetHelper.Log("Entered Annual Income ", Log4Type.Info);
        }

        public void EnterPancard(string pancard)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, pancardTxt);
            pancardTxt.SendKeys(pancard);
            Log4NetHelper.Log("Entered Pancard ", Log4Type.Info);
        }

        public void EnterWeight(string weight)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, weightTxt);
            weightTxt.SendKeys(weight);
            Log4NetHelper.Log("Entered Weight ", Log4Type.Info);
        }

        public void ClearWeight()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, weightTxt);
            weightTxt.Clear();
            Log4NetHelper.Log("Clear Weight ", Log4Type.Info);
        }

        public void SelectborrowertypeDDL(string strborrowertype)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, borrowertypeDDL);
            borrowertypeDDL.SelectDropDownList(strborrowertype);
            Log4NetHelper.Log("Selected Primary Borrower or Co-Borrower   ", Log4Type.Info);
        }
        public void SelectnationalityDDL(string strNationality)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, nationalityDDL);
            nationalityDDL.SelectDropDownList(strNationality);
            Log4NetHelper.Log("Selected Nationality  ", Log4Type.Info);
        }
        public void SelectemploymenttypeDDL(string stremploymenttype)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, employmenttypeDDL);
            employmenttypeDDL.SelectDropDownList(stremploymenttype);
            Log4NetHelper.Log("Selected Type of employment ", Log4Type.Info);
        }
        public void SelectborrowersDDL(string strborrowers)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, borrowersDDL);
            borrowersDDL.SelectDropDownList(strborrowers);
            Log4NetHelper.Log("Selected Borrowers  ", Log4Type.Info);
        }

        public string GetFullNameText()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, FullNameTitle);
            return FullNameTitle.Text;
        }
        public string GetSumAssuredTitle()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, SumAssuredTitle);
            return SumAssuredTitle.Text;
        }
        public string GetTennure()
        {



            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, TenureTitle);
            return TenureTitle.Text;
        }
        public string GetPremiumTitle()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, PremiumTitle);
            return PremiumTitle.Text;
        }
        public string GetNomineeAssuredTitle()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, NomineeAssuredDetailsTitle);
            return NomineeAssuredDetailsTitle.Text;
        }
        public string GetNomineeFullNameTitle()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, NomineeFullNameTitle);
            return NomineeFullNameTitle.Text;



        }
        public string GetNomineePercentageShare()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, NomineePercentofShareTitle);
            return NomineePercentofShareTitle.Text;
        }
        public string GetRelationshipwithInsured()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, RelationshipwithlifeinsuredTitle);
            return RelationshipwithlifeinsuredTitle.Text;
        }
        public bool IsFullNameText()
        {
            return ActualFullNameTitle.Displayed;
        }
        public bool iSActualSumAssuredTitle()
        {
            return ActualSumAssuredTitle.Displayed;
        }
        public bool IsActualTenureTitle()
        {
            return ActualTenureTitle.Displayed;
        }
        public bool IsActualPremiumTitle()
        {
            return ActualPremiumTitle.Displayed;
        }
        public bool IsActualNomineeAssuredDetailsTitle()
        {
            return ActualNomineeAssuredDetailsTitle.Displayed;
        }
        public bool IsActualNomineeFullNameTitle()
        {
            return ActualNomineeFullNameTitle.Displayed;
        }
        public bool IsActualNomineePercentofShareTitle()
        {
            return ActualNomineePercentofShareTitle.Displayed;
        }
        public bool IsActualRelationshipwithlifeinsuredTitle()
        {
            return ActualRelationshipwithlifeinsuredTitle.Displayed;
        }



        public void ChkHeight()

        {



            SelectElement options = new SelectElement(heightinfeetDDL);

            for (int i = 0; i < options.Options.Count; i++)

            {

                options.SelectByIndex(i);

                Thread.Sleep(1000);

            }

            Log4NetHelper.Log("Verifing Height dropdown selections ", Log4Type.Info);

        }



        //durga

        public void ChkInches()

        {



            SelectElement options = new SelectElement(heightininchesDDL);

            for (int i = 0; i < options.Options.Count; i++)

            {

                options.SelectByIndex(i);

                Thread.Sleep(1000);

            }

            Log4NetHelper.Log("Verifing Inches dropdown selections ", Log4Type.Info);

        }



        //Durga

        public void ChkPrimaryBorrower()

        {

            SelectElement options = new SelectElement(borrowertypeDDL);

            for (int i = 0; i < options.Options.Count; i++)

            {

                options.SelectByIndex(i);

                Thread.Sleep(1000);

            }

            Log4NetHelper.Log("Verifing borrowertypeDDL dropdown selections ", Log4Type.Info);

        }




    }
}
