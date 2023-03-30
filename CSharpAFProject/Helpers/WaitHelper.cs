using System;
using System.Collections.Generic;
using System.Text;
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
    /// Helper methods for waits
    /// </summary>
    public static class WaitHelper
    {
        private static Func<IWebDriver, bool> WaitForWebElementFunc(By locator)
        {
            return ((x) =>
            {
                if (x.FindElements(locator).Count == 1)
                    return true;
                Log4NetHelper.Log(" Waiting for Element : " + locator);
                return false;
            });
        }
        private static Func<IWebDriver, IWebElement> WaitForWebElementInPageFunc(By locator)
        {
            return ((x) =>
            {
                if (x.FindElements(locator).Count == 1)
                    return x.FindElement(locator);
                return null;
            });
        }
        /// <summary>
        /// it will return the waits
        /// </summary>
        /// <param name="driver">driver instance</param>
        /// <param name="timeout">timespan to wait for element</param>
        /// <returns>waits</returns>
        /// <example>How to use it: <code>
        ///WaitHelper.GetWebdriverWait(Driver,timeout);
        /// </code></example>
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
        /// waits till the element is present
        /// </summary>
        /// <param name="driver">driver instance</param>
        ///  <param name="locator">locator of the element</param>
        /// <param name="timeout">timespan to wait for element</param>
        /// <returns>waits</returns>
        /// <example>How to use it: <code>
        ///WaitHelper.WaitForWebElement(Driver,locator,timeout);
        /// </code></example>
        public static bool WaitForWebElement(this RemoteWebDriver driver, By locator, TimeSpan timeout)
        {
            driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(1));
            Log4NetHelper.Log(" Setting the Explicit wait to 1 sec ");
            var wait = GetWebdriverWait(driver, timeout);
            var flag = wait.Until(WaitForWebElementFunc(locator));
            driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(6));
            //driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut()));
            Log4NetHelper.Log(" Setting the Explicit wait Configured value ");
            return flag;
        }
        /// <summary>
        ///waits till element is present
        /// </summary>
        /// <param name="driver">driver instance</param>
        ///  <param name="webElement">locator of the element</param>
        /// <param name="timeout">timespan to wait for element</param>
        /// <returns>waits</returns>
        /// <example>How to use it: <code>
        ///WaitHelper.WaitForWebElement(Driver,locator,webelement);
        /// </code></example>
        public static void WaitForWebElement(this RemoteWebDriver driver, IWebElement webElement, TimeSpan timeout)
        {
            driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(1));
            var wait = GetWebdriverWait(driver, timeout);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(webElement));
            driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(6));
            //driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut()));
        }
        /// <summary>
        ///waits till element is visible
        /// </summary>
        /// <param name="driver">driver instance</param>
        ///  <param name="webElement">locator of the element</param>
        /// <param name="timeout">timespan to wait for element</param>
        /// <returns>waits</returns>
        /// <example>How to use it: <code>
        ///WaitHelper.WaitForWebElementVisible(Driver,locator,webelement);
        /// </code></example>
        public static IWebElement WaitForWebElementVisible(this RemoteWebDriver driver, By locator, TimeSpan timeout)
        {
            driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(1));
            Log4NetHelper.Log(" Setting the Explicit wait to 1 sec ");
            var wait = GetWebdriverWait(driver, timeout);
            var flag = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
            driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(6));
            //driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut()));
            Log4NetHelper.Log(" Setting the Explicit wait Configured value ");
            return (IWebElement)flag;
        }
        public static Func<IWebDriver, bool> ElementToBeVisible(IWebElement element)
        {
            return (driver) =>
            {
                try
                {
                    return element.Displayed;
                }
                catch (Exception)
                {
                    // If element is null, stale or if it cannot be located
                    return false;
                }
            };
        }
        /// <summary>
        ///waits till element is visible
        /// </summary>
        /// <param name="driver">driver instance</param>
        ///  <param name="webElement">locator of the element</param>
        /// <param name="timeout">timespan to wait for element</param>
        /// <returns>waits</returns>
        /// <example>How to use it: <code>
        ///WaitHelper.WaitForWebElementToBeVisible(Driver,locator,webelement);
        /// </code></example>
        public static bool WaitForWebElementToBeVisible(this RemoteWebDriver driver, IWebElement locator, TimeSpan timeout)
        {
            driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(1));
            Log4NetHelper.Log(" Setting the Explicit wait to 1 sec ");
            var wait = GetWebdriverWait(driver, timeout);
            var flag = wait.Until(ElementToBeVisible(locator));
            driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(6));
            //driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut()));
            Log4NetHelper.Log(" Setting the Explicit wait Configured value ");
            return flag;
        }

        /// <summary>
        ///waits for element is page
        /// </summary>
        /// <param name="driver">driver instance</param>
        ///  <param name="webElement">locator of the element</param>
        /// <param name="timeout">timespan to wait for element</param>
        /// <example>How to use it: <code>
        ///WaitHelper.WaitForWebElementToBeVisible(Driver,locator,webelement);
        /// </code></example>
        public static IWebElement WaitForWebElementInPage(this RemoteWebDriver driver, By locator, TimeSpan timeout)
        {
            driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(1));
            Log4NetHelper.Log(" Setting the Explicit wait to 1 sec ");
            var wait = GetWebdriverWait(driver, timeout);
            var flag = wait.Until(WaitForWebElementInPageFunc(locator));
            Log4NetHelper.Log(" Setting the Explicit wait Configured value ");
            driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(6));
            //driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(ObjectRepository.Config.GetElementLoadTimeOut()));
            return flag;
        }

        public static IWebElement Wait(this RemoteWebDriver driver, Func<IWebDriver, IWebElement> conditions, TimeSpan timeout)
        {
            driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(1));
            Log4NetHelper.Log(" Setting the Explicit wait to 1 sec ");
            var wait = GetWebdriverWait(driver, timeout);
            var flag = wait.Until(conditions);
            Log4NetHelper.Log(" Setting the Explicit wait Configured value ");
            driver.Manage().Timeouts().ImplicitWait = (TimeSpan.FromSeconds(6));
            return flag;
        }
        public static Func<IWebDriver, IWebElement> FluentElementToBeVisible(IWebElement element)
        {
            return ((driver) =>
            {
                if (element.Displayed)
                    return element;
                return null;
            });
        }

        public static void FluentWaitForWebElement(this RemoteWebDriver driver, IWebElement locator)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromMinutes(2);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(15);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element to be searched not found";
            IWebElement searchResult = fluentWait.Until(FluentElementToBeVisible(locator));
        }

    }
}
