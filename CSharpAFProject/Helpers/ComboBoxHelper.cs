using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace CSharpAFProject.Helpers
{
    /// <summary>
    /// Helper methods for handling buttons
    /// </summary>
    public static class ComboBoxHelper
    {
        private static SelectElement select;
        /// <summary>
        /// Returns webdriverwait
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <param name="timeout">timespan</param>
        ///<Return>Return webdriverwait</Return>
        /// <example>How to use it: <code>
        /// ComboBoxHelper.GetWebDriverWait(driver,Timespan.forseconds(10));
        /// </code></example>
        private static WebDriverWait GetWebDriverWait(IWebDriver driver,TimeSpan timeout)
        {
            WebDriverWait wait = new WebDriverWait(driver,timeout)
            {
                PollingInterval = TimeSpan.FromMilliseconds(250)
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            return wait;
        }
        /// <summary>
        /// select option from dropdown with waits by index
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <param name="locator">timespan</param>
        /// <param name="index">timespan</param>
        /// <example>How to use it: <code>
        /// ComboBoxHelper.SelectElementWitWait(driver,locator,2);
        /// </code></example>
        public static void SelectElementWitWait(this RemoteWebDriver driver, By locator, int index)
        {
            WebDriverWait wait = GetWebDriverWait(driver, TimeSpan.FromSeconds(60));
            IWebElement element =  wait.Until(ExpectedConditions.ElementIsVisible(locator));
            select = new SelectElement(element);
            select.SelectByIndex(index);
        }
        /// <summary>
        /// select option from dropdown with index
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <param name="locator">timespan</param>
        /// <param name="index">timespan</param>
        /// <example>How to use it: <code>
        /// ComboBoxHelper.SelectElement(driver,locator,2);
        /// </code></example>
        public static void SelectElement(this RemoteWebDriver driver, By locator, int index)
        {
            select = new SelectElement(GenericHelper.GetElement(driver, locator));
            select.SelectByIndex(index);
        }
        /// <summary>
        /// select option from dropdown with visibletext
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <param name="locator">timespan</param>
        /// <param name="visibletext">timespan</param>
        /// <example>How to use it: <code>
        /// ComboBoxHelper.SelectElement(driver,locator,visibletext);
        /// </code></example>
        public static void SelectElement(this RemoteWebDriver driver, By locator, string visibletext)
        {
            select = new SelectElement(GenericHelper.GetElement(driver, locator));
            select.SelectByText(visibletext);
        }
        /// <summary>
        /// select option from dropdown with valueTexts
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <param name="locator">timespan</param>
        /// <param name="valueTexts">valueTexts</param>
        /// <example>How to use it: <code>
        /// ComboBoxHelper.SelectElementByValue(driver,locator,valueTexts);
        /// </code></example>
        public static void SelectElementByValue(this RemoteWebDriver driver, By locator, string valueTexts)
        {
            select = new SelectElement(GenericHelper.GetElement(driver, locator));
            select.SelectByValue(valueTexts);
        }
        /// <summary>
        /// It gets all the items in the dropdown
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <param name="locator">timespan</param>
        /// <example>How to use it: <code>
        /// ComboBoxHelper.GetAllItem(driver,locator);
        /// </code></example>
        ///<Return>Return Ilist of string type</Return>

        public static IList<string> GetAllItem(this RemoteWebDriver driver, By locator)
        {
            select = new SelectElement(GenericHelper.GetElement(driver, locator));
            return select.Options.Select((x) => x.Text).ToList();
        }
        /// <summary>
        /// select option from dropdown with valueTexts
        /// </summary>
        /// <param name="element">IWebElement</param>
        /// <param name="valueTexts">valueTexts</param>
        /// <example>How to use it: <code>
        /// ComboBoxHelper.SelectElement(element,visibletext);
        /// </code></example>
        public static void SelectElement(IWebElement element, string visibletext)
        {
            select = new SelectElement(element);
            select.SelectByValue(visibletext);
        }
    }
}
