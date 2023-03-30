using CSharpAFProject.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Diagnostics;

namespace CSharpAFProject.Extensions
{
    /// <summary>
    /// Extension methods for Driver Actions
    /// </summary>
    public static class WebDriverExtensions
    {

        /// <summary>
        /// Wait For Page To Load
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <example>How to use it: <code>
        /// WebDriverExtensions.WaitForPageLoaded(driver);
        /// </code></example>
        public static void WaitForPageLoaded(this IWebDriver driver)
        {
            driver.WaitForCondition(dri =>
            {
                string state = ((IJavaScriptExecutor)dri).ExecuteScript("return document.readyState").ToString();
                return state == "complete";
            }, 10);
        }

        /// <summary>
        /// The WorkFlow Will Wait The Activity Until The Current Record Matches The Specified Condition.
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <example>How to use it: <code>
        /// WebDriverExtensions.WaitForCondition(obj, function, condition, timeout);
        /// </code></example>
        public static void WaitForCondition<T>(this T obj, Func<T, bool> condition, int timeOut)
        {
            Func<T, bool> execute =
                (arg) =>
                {
                    try
                    {
                        return condition(arg);
                    }
                    catch (Exception e)
                    {
                        return false;
                    }
                };

            var stopWatch = Stopwatch.StartNew();
            LoopingWait(obj, timeOut, execute, stopWatch);

            static void LoopingWait<T>(T obj, int timeOut, Func<T, bool> execute, Stopwatch stopWatch)
            {
                while (stopWatch.ElapsedMilliseconds < timeOut)
                {
                    if (execute(obj))
                    {
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Finds the Element By ElementId
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <example>How to use it: <code>
        /// WebDriverExtensions.FindById(obj, function, condition, timeout);
        ///IWebElement WebDriverExtensions.FindById(remoteWebDriver,element);
        /// </code></example>

        public static IWebElement FindById(this RemoteWebDriver remoteWebDriver, string element)
        {
            try
            {
                if (remoteWebDriver.FindElementById(element).IsElementPresent())
                {
                    Log4NetHelper.Log($"Element is found : {element}");
                    return remoteWebDriver.FindElementById(element);
                }
            }
            catch (Exception e)
            {
                throw new ElementNotVisibleException($"Element not found : {element}");
            }
            return null;
        }

        /// <summary>
        /// Finds the Element By ElementXPath
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <example>How to use it: <code>
        /// WebDriverExtensions.FindByXpath(obj, function, condition, timeout);
        ///IWebElement WebDriverExtensions.FindById(remoteWebDriver,element);
        /// </code></example>
        public static IWebElement FindByXpath(this RemoteWebDriver remoteWebDriver, string element)
        {
            try
            {
                if (remoteWebDriver.FindElementByXPath(element).IsElementPresent())
                {
                    Log4NetHelper.Log($"Element is found : {element}");
                    return remoteWebDriver.FindElementByXPath(element);
                }
            }
            catch (Exception e)
            {
                throw new ElementNotVisibleException($"Element not found : {element}");
            }
            return null;
        }

        /// <summary>
        /// Finds the Element By Element Css Selector
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <example>How to use it: <code>
        /// WebDriverExtensions.FindByCss(obj, function, condition, timeout);
        ///IWebElement WebDriverExtensions.FindById(remoteWebDriver,element);
        /// </code></example>
        public static IWebElement FindByCss(this RemoteWebDriver remoteWebDriver, string element)
        {
            try
            {
                if (remoteWebDriver.FindElementByCssSelector(element).IsElementPresent())
                {
                    Log4NetHelper.Log($"Element is found : {element}");
                    return remoteWebDriver.FindElementByCssSelector(element);
                }
            }
            catch (Exception e)
            {
                throw new ElementNotVisibleException($"Element not found : {element}");
            }
            return null;
        }

        /// <summary>
        /// Finds the Element By HyperLink Text
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <example>How to use it: <code>
        /// WebDriverExtensions.FindByLinkText(obj, function, condition, timeout);
        ///IWebElement WebDriverExtensions.FindById(remoteWebDriver,element);
        /// </code></example>
        public static IWebElement FindByLinkText(this RemoteWebDriver remoteWebDriver, string element)
        {
            try
            {
                if (remoteWebDriver.FindElementByLinkText(element).IsElementPresent())
                {
                    Log4NetHelper.Log($"Element is found : {element}");
                    return remoteWebDriver.FindElementByLinkText(element);
                }
            }
            catch (Exception e)
            {
                throw new ElementNotVisibleException($"Element not found : {element}");
            }
            return null;
        }

    }
}
