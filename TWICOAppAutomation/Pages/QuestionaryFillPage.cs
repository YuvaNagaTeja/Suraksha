using CSharpAFProject.Base;
using CSharpAFProject.Extensions;
using CSharpAFProject.Helpers;
using OpenQA.Selenium;
using SurakshaAutomation.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SurakshaAutomation.Pages
{
    internal class QuestionaryFillPage : BasePage
    {
        private readonly ParallelConfig _parallelConfig;
        public QuestionaryFillPage(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }
        IWebElement pageWarning => _parallelConfig.Driver.FindElement(By.XPath("//span[contains(text(),'Please answer all the Questions')]"));

        IWebElement qu1OptNo => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'No')][@for='question-no-1']"));
        IWebElement qu2OptNo => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'No')][@for='question-no-2']"));
        IWebElement qu3OptNo => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'No')][@for='question-no-3']"));
        IWebElement qu4OptNo => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'No')][@for='question-no-4']"));
        IWebElement qu5OptNo => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'No')][@for='question-no-5']"));
        IWebElement qu6OptNo => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'No')][@for='question-no-6']"));
        IWebElement qu7OptNo => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'No')][@for='question-no-7']"));
        IWebElement qu8OptNo => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'No')][@for='question-no-8']"));
        IWebElement qu9OptNo => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'No')][@for='question-no-9']"));
        IWebElement qu10OptNo => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'No')][@for='question-no-10']"));
        IWebElement qu11OptNo => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'No')][@for='question-no-11']"));
        IWebElement qu12OptNo => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'No')][@for='question-no-12']"));
        IWebElement qu13OptNo => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'No')][@for='question-no-13']"));
        IWebElement qu14OptNo => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'No')][@for='question-no-14']"));
        IWebElement qu1OptYes => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'Yes')][@for='question-yes-1']"));
        IWebElement qu2OptYes => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'Yes')][@for='question-yes-2']"));
        IWebElement qu3OptYes => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'Yes')][@for='question-yes-3']"));
        IWebElement qu4OptYes => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'Yes')][@for='question-yes-4']"));
        IWebElement qu5OptYes => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'Yes')][@for='question-yes-5']"));
        IWebElement qu6OptYes => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'Yes')][@for='question-yes-6']"));
        IWebElement qu7OptYes => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'Yes')][@for='question-yes-7']"));
        IWebElement qu8OptYes => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'Yes')][@for='question-yes-8']"));
        IWebElement qu9OptYes => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'Yes')][@for='question-yes-9']"));
        IWebElement qu10OptYes => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'Yes')][@for='question-yes-10']"));
        IWebElement qu11OptYes => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'Yes')][@for='question-yes-11']"));
        IWebElement qu12OptYes => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'Yes')][@for='question-yes-12']"));
        IWebElement qu13OptYes => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'Yes')][@for='question-yes-13']"));
        IWebElement qu14OptYes => _parallelConfig.Driver.FindElement(By.XPath("//*[contains(.,'Yes')][@for='question-yes-14']"));

        IWebElement Qu1_NatureofAilmentDisease => _parallelConfig.Driver.FindElement(By.Name("NATURE_OF_AILMENT_1"));
        IWebElement Qu2_NatureofAilmentDisease => _parallelConfig.Driver.FindElement(By.Name("NATURE_OF_AILMENT_2"));
        IWebElement Qu3_NatureofAilmentDisease => _parallelConfig.Driver.FindElement(By.Name("NATURE_OF_AILMENT_3"));
        IWebElement Qu4_NatureofAilmentDisease => _parallelConfig.Driver.FindElement(By.Name("NATURE_OF_AILMENT_4"));


        IWebElement Qu1_DateOfDiagnosis => _parallelConfig.Driver.FindElement(By.Name("DATE_OF_DIAGNOSIS_1"));
        IWebElement Qu2_DateOfDiagnosis => _parallelConfig.Driver.FindElement(By.Name("DATE_OF_DIAGNOSIS_2"));
        IWebElement Qu3_DateOfDiagnosis => _parallelConfig.Driver.FindElement(By.Name("DATE_OF_DIAGNOSIS_3"));
        IWebElement Qu4_DateOfDiagnosis => _parallelConfig.Driver.FindElement(By.Name("DATE_OF_DIAGNOSIS_4"));
        IWebElement Qu11_DateOfDiagnosis => _parallelConfig.Driver.FindElement(By.Name("DATE_OF_DIAGNOSIS_11"));



        IWebElement Qu1_MedicationName => _parallelConfig.Driver.FindElement(By.Name("MEDICATION_NAME_1"));
        IWebElement Qu2_MedicationName => _parallelConfig.Driver.FindElement(By.Name("MEDICATION_NAME_2"));
        IWebElement Qu3_MedicationName => _parallelConfig.Driver.FindElement(By.Name("MEDICATION_NAME_3"));
        IWebElement Qu4_MedicationName => _parallelConfig.Driver.FindElement(By.Name("MEDICATION_NAME_4"));
        IWebElement Qu11_MedicationName => _parallelConfig.Driver.FindElement(By.Name("MEDICATION_NAME_11"));
        IWebElement Qu13_MedicationName => _parallelConfig.Driver.FindElement(By.Name("MEDICATION_NAME_13"));


        IWebElement Qu1_FrequencyofMedication => _parallelConfig.Driver.FindElement(By.Name("FREQUENCY_OF_MEDICATION_1"));
        IWebElement Qu2_FrequencyofMedication => _parallelConfig.Driver.FindElement(By.Name("FREQUENCY_OF_MEDICATION_2"));
        IWebElement Qu3_FrequencyofMedication => _parallelConfig.Driver.FindElement(By.Name("FREQUENCY_OF_MEDICATION_3"));
        IWebElement Qu4_FrequencyofMedication => _parallelConfig.Driver.FindElement(By.Name("FREQUENCY_OF_MEDICATION_4"));
        IWebElement Qu11_FrequencyofMedication => _parallelConfig.Driver.FindElement(By.Name("FREQUENCY_OF_MEDICATION_11"));
        IWebElement Qu13_FrequencyofMedication => _parallelConfig.Driver.FindElement(By.Name("FREQUENCY_OF_MEDICATION_13"));


        IWebElement Qu1_RecoveryStatusDDL => _parallelConfig.Driver.FindElement(By.XPath("//select[@name='RECOVERY_STATUS_1']"));
        IWebElement Qu2_RecoveryStatusDDL => _parallelConfig.Driver.FindElement(By.XPath("//select[@name='RECOVERY_STATUS_2']"));
        IWebElement Qu3_RecoveryStatusDDL => _parallelConfig.Driver.FindElement(By.XPath("//select[@name='RECOVERY_STATUS_3']"));
        IWebElement Qu4_RecoveryStatusDDL => _parallelConfig.Driver.FindElement(By.XPath("//select[@name='RECOVERY_STATUS_4']"));
        IWebElement Qu11_RecoveryStatusDDL => _parallelConfig.Driver.FindElement(By.XPath("//select[@name='RECOVERY_STATUS_11']"));
        IWebElement Qu13_RecoveryStatusDDL => _parallelConfig.Driver.FindElement(By.XPath("//select[@name='RECOVERY_STATUS_13']"));


        IWebElement Qu5_insurance_company_nameTxt => _parallelConfig.Driver.FindElement(By.Name("INSURANCE_COMPANY_NAME"));
        IWebElement Qu5_insurance_statusDDL => _parallelConfig.Driver.FindElement(By.XPath("//select[@name='INSURANCE_STATUS']"));
        IWebElement Qu5_reason_for_your_selectionTxt => _parallelConfig.Driver.FindElement(By.Name("REASON_FOR_YOUR_SELECTION"));
        IWebElement Qu6_exactly_is_your_hobbyTxt => _parallelConfig.Driver.FindElement(By.Name("EXACTLY_IS_YOUR_HOBBY"));

        IWebElement Qu6_classify_your_hobbyDDL => _parallelConfig.Driver.FindElement(By.XPath("//select[@name='CLASSIFY_YOUR_HOBBY']"));
        IWebElement Qu7_RelationTxt => _parallelConfig.Driver.FindElement(By.Name("RELATION"));
        IWebElement Qu7_type_of_ailmentTxt => _parallelConfig.Driver.FindElement(By.Name("TYPE_OF_AILMENT"));
        IWebElement Qu7_age_of_diagnosisTxt => _parallelConfig.Driver.FindElement(By.Name("AGE_OF_DIAGNOSIS"));
        IWebElement Qu7_is_the_personDDL => _parallelConfig.Driver.FindElement(By.XPath("//select[@name='IS_THE_PERSON']"));

        IWebElement Qu8_cigarette_sticksChkBox => _parallelConfig.Driver.FindElement(By.Name("CIGARETTE_STICKS"));
        IWebElement Qu8_alcoholChkBox => _parallelConfig.Driver.FindElement(By.Name("ALCOHOL"));
        IWebElement Qu8_narcoticsChkBox => _parallelConfig.Driver.FindElement(By.Name("NARCOTICS"));

        IWebElement Qu10_date_of_diagnosisTxt => _parallelConfig.Driver.FindElement(By.Name("DATE_OF_DIAGNOSIS_10"));
        IWebElement Qu10_HomeQuarantinedBtn => _parallelConfig.Driver.FindElement(By.XPath("//span[contains(text(),'Home Quarantined')]"));
        IWebElement Qu10_HospitalisedBtn => _parallelConfig.Driver.FindElement(By.XPath("//span[contains(text(),'Hospitalised')]"));
        IWebElement Qu11_symptom_you_were_diagnosedTxt => _parallelConfig.Driver.FindElement(By.Name("SYMPTOM_YOU_WERE_DIAGNOSED"));
        IWebElement Qu12_medical_specialityTxt => _parallelConfig.Driver.FindElement(By.Name("MEDICAL_SPECIALITY"));
        IWebElement Qu12_what_do_you_do_exactlyTxt => _parallelConfig.Driver.FindElement(By.Name("WHAT_DO_YOU_DO_EXACTLY"));
        IWebElement Qu13_adverse_reaction_symptomsTxt => _parallelConfig.Driver.FindElement(By.Name("ADVERSE_REACTION_SYMPTOMS"));
        IWebElement ProceedBtn => _parallelConfig.Driver.FindElement(By.XPath("//button[contains(text(),'Proceed')]"));
        IWebElement QuestionaryBackBtn => _parallelConfig.Driver.FindElement(By.XPath("(//button[contains(text(),'Back')])[2]"));
        IWebElement SummaryBackBtn => _parallelConfig.Driver.FindElement(By.XPath("(//button[contains(text(),'Back')])[3]"));



        private IList<IWebElement> allQues => _parallelConfig.Driver.FindElements(By.XPath("//p[@class='w-70 m-0 pb-3 text-justify']"));

        public void GetAllQuestions()
        {
            int i = 1;
            foreach (IWebElement item in allQues)
            {

                Console.WriteLine(i + " : " + item.Text);
                i++;
            }


        }


        public void ClickOnSummaryBackBtn()
        {
            SummaryBackBtn.Click();
        }

        public void ClickOnProceedBtn()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, ProceedBtn);
            ProceedBtn.Click();
        }

        public void ClickOnQuestionaryBackBtn()
        {
            QuestionaryBackBtn.Click();
        }


        public void SelectRecoveryStatusDDL(string strRecoryStatus)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu1_RecoveryStatusDDL);
            Qu1_RecoveryStatusDDL.SelectDropDownList(strRecoryStatus);
            Log4NetHelper.Log("Selected Recovery Status", Log4Type.Info);
        }

        public void Qu3SelectRecoveryStatusDDL(string strRecoryStatus)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu3_RecoveryStatusDDL);
            Qu3_RecoveryStatusDDL.SelectDropDownList(strRecoryStatus);
            Log4NetHelper.Log("Selected Recovery Status", Log4Type.Info);
        }
        public void Qu4SelectRecoveryStatusDDL(string strRecoryStatus)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu4_RecoveryStatusDDL);
            Qu4_RecoveryStatusDDL.SelectDropDownList(strRecoryStatus);
            Log4NetHelper.Log("Selected Recovery Status", Log4Type.Info);
        }

        public void Qu11SelectRecoveryStatusDDL(string strRecoryStatus)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu11_RecoveryStatusDDL);
            Qu11_RecoveryStatusDDL.SelectDropDownList(strRecoryStatus);
            Log4NetHelper.Log("Selected Recovery Status", Log4Type.Info);
        }
        public void Qu13SelectRecoveryStatusDDL(string strRecoryStatus)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu13_RecoveryStatusDDL);
            Qu13_RecoveryStatusDDL.SelectDropDownList(strRecoryStatus);
            Log4NetHelper.Log("Selected Recovery Status", Log4Type.Info);
        }



        public void Qu1FrequencyofMedication(string strFrequencyofMedication)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu1_FrequencyofMedication);
            Qu1_FrequencyofMedication.SendKeys(strFrequencyofMedication);
            Log4NetHelper.Log("Entered Qu1 Frequency of Medication ", Log4Type.Info);
        }
        public void Qu3FrequencyofMedication(string strFrequencyofMedication)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu3_FrequencyofMedication);
            Qu3_FrequencyofMedication.SendKeys(strFrequencyofMedication);
            Log4NetHelper.Log("Entered Qu3 Frequency of Medication ", Log4Type.Info);
        }
        public void Qu4FrequencyofMedication(string strFrequencyofMedication)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu4_FrequencyofMedication);
            Qu4_FrequencyofMedication.SendKeys(strFrequencyofMedication);
            Log4NetHelper.Log("Entered Qu4 Frequency of Medication ", Log4Type.Info);
        }
        public void Qu11FrequencyofMedication(string strFrequencyofMedication)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu11_FrequencyofMedication);
            Qu11_FrequencyofMedication.SendKeys(strFrequencyofMedication);
            Log4NetHelper.Log("Entered Qu11 Frequency of Medication ", Log4Type.Info);
        }
        public void Qu13FrequencyofMedication(string strFrequencyofMedication)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu13_FrequencyofMedication);
            Qu13_FrequencyofMedication.SendKeys(strFrequencyofMedication);
            Log4NetHelper.Log("Entered Qu13 Frequency of Medication ", Log4Type.Info);
        }

        public void Qu1MedicationName(string strMedicationName)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu1_MedicationName);
            Qu1_MedicationName.SendKeys(strMedicationName);
            Log4NetHelper.Log("Entered Qu1 Medication Name ", Log4Type.Info);
        }


        public void Qu13MedicationName(string strMedicationName)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu13_MedicationName);
            Qu13_MedicationName.SendKeys(strMedicationName);
            Log4NetHelper.Log("Entered Qu13 Medication Name ", Log4Type.Info);
        }

        public void Qu12MedicalSpc(string strMedicalSpc)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu12_medical_specialityTxt);
            Qu12_medical_specialityTxt.SendKeys(strMedicalSpc);
            Log4NetHelper.Log("Entered Qu12 Medical Special ", Log4Type.Info);
        }
        public void Qu12WhatdoyouExactly(string strWhatyoudoExactly)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu12_what_do_you_do_exactlyTxt);
            Qu12_what_do_you_do_exactlyTxt.SendKeys(strWhatyoudoExactly);
            Log4NetHelper.Log("Entered Qu12 What you do exactly", Log4Type.Info);
        }
        public void Qu13AdverseReactionSystom(string strAdverseReactionSystom)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu13_adverse_reaction_symptomsTxt);
            Qu13_adverse_reaction_symptomsTxt.SendKeys(strAdverseReactionSystom);
            Log4NetHelper.Log("Entered Qu13 Adverse Reaction Systom", Log4Type.Info);
        }

        public void Qu3MedicationName(string strMedicationName)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu3_MedicationName);
            Qu3_MedicationName.SendKeys(strMedicationName);
            Log4NetHelper.Log("Entered Qu3 Medication Name ", Log4Type.Info);
        }


        public void Qu4MedicationName(string strMedicationName)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu4_MedicationName);
            Qu4_MedicationName.SendKeys(strMedicationName);
            Log4NetHelper.Log("Entered Qu4 Medication Name ", Log4Type.Info);
        }

        public void Qu1NatureofAilmentDisease(string strNatureofAilmentDisease)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu1_NatureofAilmentDisease);
            Qu1_NatureofAilmentDisease.SendKeys(strNatureofAilmentDisease);
            Log4NetHelper.Log("Entered Qu1 Nature of Ailment Disease ", Log4Type.Info);
        }
        public void Qu3NatureofAilmentDisease(string strNatureofAilmentDisease)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu3_NatureofAilmentDisease);
            Qu3_NatureofAilmentDisease.SendKeys(strNatureofAilmentDisease);
            Log4NetHelper.Log("Entered Qu3 Nature of Ailment Disease ", Log4Type.Info);
        }
        public void Qu4NatureofAilmentDisease(string strNatureofAilmentDisease)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu4_NatureofAilmentDisease);
            Qu4_NatureofAilmentDisease.SendKeys(strNatureofAilmentDisease);
            Log4NetHelper.Log("Entered Qu4 Nature of Ailment Disease ", Log4Type.Info);
        }

        public void Qu1DateOfDiagnosis(string strDateOfDiagnosis)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu1_DateOfDiagnosis);
            Qu1_DateOfDiagnosis.SendKeys(strDateOfDiagnosis);
            Log4NetHelper.Log("Entered Qu1 Date Of Diagnosis ", Log4Type.Info);
        }
        public void Qu4DateOfDiagnosis(string strDateOfDiagnosis)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu4_DateOfDiagnosis);
            Qu4_DateOfDiagnosis.SendKeys(strDateOfDiagnosis);
            Log4NetHelper.Log("Entered Qu4 Date Of Diagnosis ", Log4Type.Info);
        }

        public void Qu10DateOfDiagnosis(string strDateOfDiagnosis)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu10_date_of_diagnosisTxt);
            Qu10_date_of_diagnosisTxt.SendKeys(strDateOfDiagnosis);
            Log4NetHelper.Log("Entered Qu10 Date Of Diagnosis ", Log4Type.Info);
        }

        public void Qu11MedicationName(string strMedicationName)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu11_MedicationName);
            Qu11_MedicationName.SendKeys(strMedicationName);
            Log4NetHelper.Log("Entered Qu10 Date Of Diagnosis ", Log4Type.Info);
        }

        public void Qu11DateOfDiagnosis(string strDateOfDiagnosis)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu11_DateOfDiagnosis);
            Qu11_DateOfDiagnosis.SendKeys(strDateOfDiagnosis);
            Log4NetHelper.Log("Entered Qu11 Date Of Diagnosis ", Log4Type.Info);
        }


        public void Qu11symptom_you_were_diagnosed(string strsymptom_you_were_diagnosed)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu11_symptom_you_were_diagnosedTxt);
            Qu11_symptom_you_were_diagnosedTxt.SendKeys(strsymptom_you_were_diagnosed);
            Log4NetHelper.Log("Entered Qu11 SYMPTOM_YOU_WERE_DIAGNOSED ", Log4Type.Info);
        }


        public void Qu10HomeQuarantined(bool HomeQuarantin)
        {
            if (HomeQuarantin)
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu10_HomeQuarantinedBtn);
                Qu10_HomeQuarantinedBtn.Click();
            }
            Log4NetHelper.Log("Entered Qu10 Home Quarantined", Log4Type.Info);
        }
        public void Qu10Hospitalised(bool Hospitalised)
        {
            if (Hospitalised)
            {
                JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu10_HospitalisedBtn);
                Qu10_HospitalisedBtn.Click();
                Log4NetHelper.Log("Entered Qu10 Hospitalised ", Log4Type.Info);
            }
        }




        public void Qu5InsuranceCompanyName(string strInsuranceComp)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu5_insurance_company_nameTxt);
            Qu5_insurance_company_nameTxt.SendKeys(strInsuranceComp);
            Log4NetHelper.Log("Entered Que5 Insurance Company Name ", Log4Type.Info);
        }





        public void Qu3DateOfDiagnosis(string strDateOfDiagnosis)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu3_DateOfDiagnosis);
            Qu3_DateOfDiagnosis.SendKeys(strDateOfDiagnosis);
            Log4NetHelper.Log("Entered Qu3 Date Of Diagnosis ", Log4Type.Info);
        }

        public void chkQuestion1_No()
        {
            // RadioButtonHelper.ClickRadioButton(_parallelConfig.Driver, By.XPath("//*[contains(.,'No')][@for='question-no-1']"));
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu1OptNo);
            qu1OptNo.Click();
            Log4NetHelper.Log("Selected option No", Log4Type.Info);
        }
        public void chkQuestion2_No()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu2OptNo);
            qu2OptNo.Click();
            Log4NetHelper.Log("Selected option No", Log4Type.Info);
        }
        public void chkQuestion3_No()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu3OptNo);
            qu3OptNo.Click();
            Log4NetHelper.Log("Selected option No", Log4Type.Info);
        }
        public void chkQuestion4_No()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu4OptNo);
            qu4OptNo.Click();
            Log4NetHelper.Log("Selected option No", Log4Type.Info);
        }
        public void chkQuestion5_No()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu5OptNo);
            qu5OptNo.Click();
            Log4NetHelper.Log("Selected option No", Log4Type.Info);
        }
        public void chkQuestion6_No()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu6OptNo);
            qu6OptNo.Click();
            Log4NetHelper.Log("Selected option No", Log4Type.Info);
        }
        public void chkQuestion7_No()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu7OptNo);
            qu7OptNo.Click();
            Log4NetHelper.Log("Selected option No", Log4Type.Info);
        }
        public void chkQuestion8_No()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu8OptNo);
            qu8OptNo.Click();
            Log4NetHelper.Log("Selected option No", Log4Type.Info);
        }
        public void chkQuestion9_No()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu9OptNo);
            qu9OptNo.Click();
            Log4NetHelper.Log("Selected option No", Log4Type.Info);
        }
        public void chkQuestion10_No()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu10OptNo);
            qu10OptNo.Click();
            Log4NetHelper.Log("Selected option No", Log4Type.Info);
        }
        public void chkQuestion11_No()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu11OptNo);
            qu11OptNo.Click();
            Log4NetHelper.Log("Selected option No", Log4Type.Info);
        }
        public void chkQuestion12_No()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu12OptNo);
            qu12OptNo.Click();
            Log4NetHelper.Log("Selected option No", Log4Type.Info);
        }
        public void chkQuestion13_No()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu13OptNo);
            qu13OptNo.Click();
            Log4NetHelper.Log("Selected option No", Log4Type.Info);
        }
        public void chkQuestion14_No()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu14OptNo);
            qu14OptNo.Click();
            Log4NetHelper.Log("Selected option No", Log4Type.Info);
        }
        public string GetPageWarning()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, pageWarning);
            return pageWarning.Text;
        }
        public void chkQuestion1_Yes()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu1OptYes);
            qu1OptYes.Click();
            Log4NetHelper.Log("Selected option Yes", Log4Type.Info);
        }
        public void chkQuestion2_Yes()
        {
            Thread.Sleep(3000);
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu2OptYes);
            Thread.Sleep(3000);
            qu2OptYes.Click();
            Log4NetHelper.Log("Selected option Yes", Log4Type.Info);
        }


        public void chkQuestion3_Yes()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu3OptYes);
            qu3OptYes.Click();
            Log4NetHelper.Log("Selected option Yes", Log4Type.Info);
        }
        public void chkQuestion4_Yes()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu4OptYes);
            qu4OptYes.Click();
            Log4NetHelper.Log("Selected option Yes", Log4Type.Info);
        }
        public void chkQuestion5_Yes()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu5OptYes);
            qu5OptYes.Click();
            Log4NetHelper.Log("Selected option Yes", Log4Type.Info);
        }
        public void chkQuestion6_Yes()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu6OptYes);
            qu6OptYes.Click();
            Log4NetHelper.Log("Selected option Yes", Log4Type.Info);
        }
        public void chkQuestion7_Yes()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu7OptYes);
            qu7OptYes.Click();
            Log4NetHelper.Log("Selected option Yes", Log4Type.Info);
        }
        public void chkQuestion8_Yes()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu8OptYes);
            Thread.Sleep(3000);
            qu8OptYes.Click();
            Log4NetHelper.Log("Selected option Yes", Log4Type.Info);
        }
        public void chkQuestion9_Yes()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu9OptYes);
            qu9OptYes.Click();
            Log4NetHelper.Log("Selected option Yes", Log4Type.Info);
        }
        public void chkQuestion10_Yes()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu10OptYes);
            qu10OptYes.Click();
            Log4NetHelper.Log("Selected option Yes", Log4Type.Info);
        }
        public void chkQuestion11_Yes()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu11OptYes);
            qu11OptYes.Click();
            Log4NetHelper.Log("Selected option Yes", Log4Type.Info);
        }
        public void chkQuestion12_Yes()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu12OptYes);
            qu12OptYes.Click();
            Log4NetHelper.Log("Selected option Yes", Log4Type.Info);
        }
        public void chkQuestion13_Yes()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu13OptYes);
            qu13OptYes.Click();
            Log4NetHelper.Log("Selected option Yes", Log4Type.Info);
        }
        public void chkQuestion14_Yes()
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, qu14OptYes);
            qu14OptYes.Click();
            Log4NetHelper.Log("Selected option Yes", Log4Type.Info);
        }

        public void Qu2NatureofAilmentDisease(string strNatureofAilmentDisease)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu2_NatureofAilmentDisease);
            Qu2_NatureofAilmentDisease.SendKeys(strNatureofAilmentDisease);
            Log4NetHelper.Log("Entered Que2 Nature of Ailment Disease ", Log4Type.Info);
        }
        public void Qu2DateOfDiagnosis(string strDateOfDiagnosis)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu2_DateOfDiagnosis);
            Qu2_DateOfDiagnosis.SendKeys(strDateOfDiagnosis);
            Log4NetHelper.Log("Entered Que2 Date Of Diagnosis ", Log4Type.Info);
        }
        public void Qu2MedicationName(string strMedicationName)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu2_MedicationName);
            Qu2_MedicationName.SendKeys(strMedicationName);
            Log4NetHelper.Log("Entered Qu2 Medication Name ", Log4Type.Info);
        }
        public void Qu2FrequencyofMedication(string strFrequencyofMedication)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu2_FrequencyofMedication);
            Qu2_FrequencyofMedication.SendKeys(strFrequencyofMedication);
            Log4NetHelper.Log("Entered Que2 Frequency of Medication ", Log4Type.Info);
        }
        public void Qu5reason_for_your_selection(string strreason_for_your_selection)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu5_reason_for_your_selectionTxt);
            Qu5_reason_for_your_selectionTxt.SendKeys(strreason_for_your_selection);
            Log4NetHelper.Log("Entered Que5 Reason for your selection", Log4Type.Info);
        }

        public void Qu6YourHobby(string strYourHobby)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu6_exactly_is_your_hobbyTxt);
            Qu6_exactly_is_your_hobbyTxt.SendKeys(strYourHobby);
            Log4NetHelper.Log("Entered Que6 exactly is your Hobby", Log4Type.Info);
        }

        public void Qu6ClassifiedHobby(string strClassifiedHobby)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu6_classify_your_hobbyDDL);
            Qu6_classify_your_hobbyDDL.SelectDropDownList(strClassifiedHobby);
            Log4NetHelper.Log("Selected Que6 Classified Hobby ", Log4Type.Info);
        }
        public void Qu7Relation(string strRelation)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu7_RelationTxt);
            Qu7_RelationTxt.SendKeys(strRelation);
            Log4NetHelper.Log("Entered Que7 Relation ", Log4Type.Info);
        }
        public void Qu7TypeofAilment(string strTypeofAilment)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu7_type_of_ailmentTxt);
            Qu7_type_of_ailmentTxt.SendKeys(strTypeofAilment);
            Log4NetHelper.Log("Entered Que7 Type of Ailment ", Log4Type.Info);
        }
        public void Qu7AgeOfDiagnosis(string strAgeOfDiagnosis)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu7_age_of_diagnosisTxt);
            Qu7_age_of_diagnosisTxt.SendKeys(strAgeOfDiagnosis);
            Log4NetHelper.Log("Entered Que7 Age Of Diagnosis", Log4Type.Info);
        }

        public void Qu7IsThePerson(string strIsthePerson)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu7_is_the_personDDL);
            Qu7_is_the_personDDL.SelectDropDownList(strIsthePerson);
            Log4NetHelper.Log("Selected Que5 Insurance Status ", Log4Type.Info);
        }


        public void Qu8Habbits()
        {
            bool Alcohol = Convert.ToBoolean(TestData.Qu8_Alcohol);
            if (Alcohol) { Qu8_alcoholChkBox.Click(); }
            
            bool Cigarette = Convert.ToBoolean(TestData.Qu8_Cigarette);
            if (Cigarette) { Qu8_cigarette_sticksChkBox.Click(); }
           
            bool Narcotics = Convert.ToBoolean(TestData.Qu8_Narcotics);
            if (Narcotics) { Qu8_narcoticsChkBox.Click(); }


        }
        public void Qu5InsuranceStatusDDL(string strInsuranceStatus)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu5_insurance_statusDDL);
            Qu5_insurance_statusDDL.SelectDropDownList(strInsuranceStatus);
            Log4NetHelper.Log("Selected Que5 Insurance Status ", Log4Type.Info);
        }


        public void Qu2RecoveryStatusDDL(string strRecoryStatus)
        {
            JavaScriptExecutor.ScrollIntoView(_parallelConfig.Driver, Qu2_RecoveryStatusDDL);
            Qu2_RecoveryStatusDDL.SelectDropDownList(strRecoryStatus);
            Log4NetHelper.Log("Selected Que2 Recovery Status", Log4Type.Info);
        }

        public void Question1()
        {
            Qu1NatureofAilmentDisease(TestData.Qu1_NatureofAilmentDisease);
            Qu1DateOfDiagnosis(TestData.Qu1_DateOfDiagnosis);
            Qu1MedicationName(TestData.Qu1_MedicationName);
            Qu1FrequencyofMedication(TestData.Qu1_FrequencyofMedication);
            SelectRecoveryStatusDDL(TestData.Qu1_RecoveryStatus);
        }

        public void Question2()
        {
            Qu2NatureofAilmentDisease(TestData.Qu2_NatureofAilmentDisease);
            Qu2DateOfDiagnosis(TestData.Qu2_DateOfDiagnosis);
            Qu2MedicationName(TestData.Qu2_MedicationName);
            Qu2FrequencyofMedication(TestData.Qu2_FrequencyofMedication);
            Qu2RecoveryStatusDDL(TestData.Qu2_RecoveryStatus);
        }

        public void Question3()
        {
            chkQuestion3_Yes();
            Qu3NatureofAilmentDisease(TestData.Qu3_NatureofAilmentDisease);
            Qu3DateOfDiagnosis(TestData.Qu3_DateOfDiagnosis);
            Qu3MedicationName(TestData.Qu3_MedicationName);
            Qu3FrequencyofMedication(TestData.Qu3_FrequencyofMedication);
            Qu3SelectRecoveryStatusDDL(TestData.Qu3_RecoveryStatus);
        }

        public void Question4()
        {
            chkQuestion4_Yes();
            Qu4NatureofAilmentDisease(TestData.Qu4_NatureofAilmentDisease);
            Qu4DateOfDiagnosis(TestData.Qu4_DateOfDiagnosis);
            Qu4MedicationName(TestData.Qu4_MedicationName);
            Qu4FrequencyofMedication(TestData.Qu4_FrequencyofMedication);
            Qu4SelectRecoveryStatusDDL(TestData.Qu4_RecoveryStatus);
        }
        public void Question5()
        {
            chkQuestion5_Yes();
            Qu5InsuranceCompanyName(TestData.Qu5_InsuranceCompanyName);
            Qu5InsuranceStatusDDL(TestData.Qu5_InsuranceStatus);
            Qu5reason_for_your_selection(TestData.Qu5_ReasonforYourSelection);
        }

        public void Question6()
        {
            chkQuestion6_Yes();
            Qu6YourHobby(TestData.Qu6_ExactHobby);
            Qu6ClassifiedHobby(TestData.Qu6_ClassifyHobby);
        }

        public void Question7()
        {
            chkQuestion7_Yes();

            Qu7Relation(TestData.Qu7_Relation);
            Qu7TypeofAilment(TestData.Qu7_TypeofAilment);
            Qu7AgeOfDiagnosis(TestData.Qu7_AgeOfDiagnosis);
            Qu7IsThePerson(TestData.Qu7_IsThePerson);
        }

        public void Question8()
        {
            chkQuestion8_Yes();

            Qu8Habbits();

        }

        public void Question10()
        {//Covid-19 Status

            chkQuestion10_Yes();

            Qu10DateOfDiagnosis(TestData.Qu10_DateOfDiagnosis);
            Qu10HomeQuarantined(Convert.ToBoolean(TestData.Qu10_HomeQuarantined));
            Qu10Hospitalised(Convert.ToBoolean(TestData.Qu10_Hospitalised));
        }

        public void Question11()
        {
            //Covid-19 Status (in the last 1 month)
            chkQuestion11_Yes();
            Qu11symptom_you_were_diagnosed(TestData.Qu11_Symptoms);
            Qu11DateOfDiagnosis(TestData.Qu11_DateOfDiagnosis);
            Qu11MedicationName(TestData.Qu11_MedicationName);
            Qu11FrequencyofMedication(TestData.Qu11_FrequencyofMedication);
            Qu11SelectRecoveryStatusDDL(TestData.Qu11_RecoveryStatus);

        }

        public void Question12()
        {
            //Covid-19 Work Status
            chkQuestion12_Yes();
            Qu12MedicalSpc(TestData.Qu12_MedicalSpecialty);
            Qu12WhatdoyouExactly(TestData.Qu12_WhatYouDo);
        }
        public void Question13()
        {
            //    chkQuestion13_No();
            //    chkQuestion13_Yes();
            Qu13AdverseReactionSystom(TestData.Qu13_AdverseReactionSymptoms);
            Qu13MedicationName(TestData.Qu13_MedicationName);
            Qu13FrequencyofMedication(TestData.Qu13_FrequencyofMedication);
            Qu13SelectRecoveryStatusDDL(TestData.Qu13_RecoveryStatus);

        }
    }
}
