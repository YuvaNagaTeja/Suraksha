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
    public class PaymentMethodSteps : BaseStep
    {
        private readonly ParallelConfig _parallelConfig;

        string fileName = Environment.CurrentDirectory.ToString() + Settings.ExcelFileNamePath;
        public PaymentMethodSteps(ParallelConfig parellelConfig) : base(parellelConfig)
        {
            _parallelConfig = parellelConfig;
        }

        [When(@"I Click on Bill me")]
        public void WhenIClickOnBillMe()
        {
            _parallelConfig.CurrentPage = new PaymentMethodPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<PaymentMethodPage>().ClickBillMe();

        }

        [When(@"I Click on Bill Someone")]
        public void WhenIClickOnBillSomeone()
        {
            _parallelConfig.CurrentPage = new PaymentMethodPage(_parallelConfig);
            _parallelConfig.CurrentPage = _parallelConfig.CurrentPage.As<PaymentMethodPage>().ClickBillSomeone();
        }


        [When(@"I select AnnualPay")]
        public void WhenISelectAnnualPay()
        {
            _parallelConfig.CurrentPage.As<PaymentMethodPage>().ClickAnnualPay();

        }
        [When(@"I select Ten Pay")]
        public void WhenISelectTenPay()
        {
            _parallelConfig.CurrentPage.As<PaymentMethodPage>().ClickTenPay();
        }

        [When(@"I select four pay")]
        public void WhenISelectFourPay()
        {
            _parallelConfig.CurrentPage.As<PaymentMethodPage>().ClickFourPay();
        }

        [Then(@"Click next button for Payment Method")]
        public void ThenClickNextButtonForPaymentMethod()
        {
            _parallelConfig.CurrentPage = new PaymentMethodPage(_parallelConfig);
                
               _parallelConfig.CurrentPage.As<PaymentMethodPage>().ClickPaymentNextButton();
        }
        [When(@"I Click on Bill Insured")]
        public void WhenIClickOnBillInsured()
        {
            _parallelConfig.CurrentPage = new PaymentMethodPage(_parallelConfig);
            _parallelConfig.CurrentPage.As<PaymentMethodPage>().ClickBillInsured();
        }
    }
}
