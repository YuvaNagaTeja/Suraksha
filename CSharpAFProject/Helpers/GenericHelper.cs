using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace CSharpAFProject.Helpers
{
    /// <summary>
    /// Helper methods for general functions.
    /// </summary>
    public static class GenericHelper
    {

        private static Func<IWebDriver, IList<IWebElement>> GetAllElements(By locator)
        {
            return ((x) =>
            {
                return x.FindElements(locator);
            });
        }
        /// <summary>
        /// To select options from autoseggetions 
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <param name="autoSuggesLocator">locator of the element</param>
        /// <param name="initialStr">value to be selected</param>
        /// <param name="strToSelect">string to be selected</param>
        /// <param name="autoSuggestistLocator">locator of auto suggestion</param>
        /// <example>How to use it: <code>
        /// GenericHelper.SelecFromAutoSuggest(driver,autoSuggesLocator,initialStr,strToSelect,autoSuggestistLocator);
        /// </code></example>
        public static void SelecFromAutoSuggest(this RemoteWebDriver driver, By autoSuggesLocator, string initialStr, string strToSelect,
            By autoSuggestistLocator)
        {
            var autoSuggest = driver.FindElement(autoSuggesLocator);
            autoSuggest.SendKeys(initialStr);
            Thread.Sleep(1000);

            var wait = GenericHelper.GetWebdriverWait(driver, TimeSpan.FromSeconds(40));
            var elements = wait.Until(GetAllElements(autoSuggestistLocator));
            var select = elements.First((x => x.Text.Equals(strToSelect, StringComparison.OrdinalIgnoreCase)));
            select.Click();
            Thread.Sleep(1000);
        }
        /// <summary>
        /// Opens the excel
        /// </summary>
        /// <param name="driver">driver instance</param>
        /// <param name="timeout">time span</param>
        /// <example>How to use it: <code>
        /// GenericHelper.GetWebdriverWait(driver,timeout);
        /// </code></example>
        /// <Return>Return WebDriverWait type </Return>
        public static WebDriverWait GetWebdriverWait(this RemoteWebDriver driver, TimeSpan timeout)
        {
            driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(1));
            WebDriverWait wait = new WebDriverWait(driver, timeout)
            {
                PollingInterval = TimeSpan.FromMilliseconds(500),
            };
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            Log4NetHelper.Log(" Wait Object Created ");
            return wait;
        }
        /// <summary>
        /// checks if the element is present
        /// </summary>
        /// <param name="driver">driver instance</param>
        /// <param name="locator">locator of the element</param>
        /// <example>How to use it: <code>
        /// GenericHelper.IsElementPresent(driver,locator);
        /// </code></example>
        /// <Return>Return bool type if element is present</Return>
        public static bool IsElementPresent(this RemoteWebDriver driver, By locator)
        {
            try
            {
                Log4NetHelper.Log(" Checking for the element " + locator, Log4Type.Info);
                return driver.FindElements(locator).Count == 1;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// checks if the element is present
        /// </summary>
        /// <param name="driver">driver instance</param>
        /// <param name="iwebelement">iwebelement</param>
        /// <example>How to use it: <code>
        /// GenericHelper.IsElementPresent(driver,iwebelement);
        /// </code></example>
        /// <Return>Return bool type if element is present</Return>
        public static bool IsElemetPresent(this RemoteWebDriver driver, IWebElement locator)
        {
            try
            {
                Log4NetHelper.Log(" Checking for the element " + locator, Log4Type.Info);
                return locator.Displayed;
            }
            catch (Exception)
            {
                return false;
            }

        }
        /// <summary>
        /// returns the webelement if present
        /// </summary>
        /// <param name="driver">driver instance</param>
        /// <param name="locator">locator of the element</param>
        /// <example>How to use it: <code>
        /// GenericHelper.GetElement(driver,locator);
        /// </code></example>
        /// <Return>Return IWebElement type</Return>
        public static IWebElement GetElement(this RemoteWebDriver driver, By locator)
        {
            if (IsElementPresent(driver, locator))
                return driver.FindElement(locator);
            else
                throw new NoSuchElementException("Element Not Found : " + locator.ToString());
        }
        /// <summary>
        /// returns the webelement if present
        /// </summary>
        /// <param name="driver">driver instance</param>
        /// <param name="Iwebelement">locator of the element</param>
        /// <example>How to use it: <code>
        /// GenericHelper.GetElement(driver,Iwebelement);
        /// </code></example>
        /// <Return>Return IWebElement type</Return>
        public static IWebElement GetElement(this RemoteWebDriver driver, IWebElement locator)
        {
            if (IsElemetPresent(driver, locator))
                return locator;
            else
                throw new NoSuchElementException("Element Not Found : " + locator.ToString());
        }

    }
}
