using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.ObjectModel;
using System.Threading;

namespace CSharpAFProject.Helpers
{
    /// <summary>
    /// Helper methods for Browser Actions
    /// </summary>
    public static class BrowserHelper
    {
        /// <summary>
        /// Maximize the Browser
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <example>How to use it: <code>
        /// BrowserHelper.BrowserMaximize(driver);
        /// </code></example>
        public static void BrowserMaximize(this RemoteWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            Log4NetHelper.Log(" Browser Maximize ", Log4Type.Info);
        }

        /// <summary>
        /// Navigated Back
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <example>How to use it: <code>
        /// BrowserHelper.GoBack(driver);
        /// </code></example>
        public static void GoBack(this RemoteWebDriver driver)
        {
            driver.Navigate().Back();
            Log4NetHelper.Log(" Navigated Back ", Log4Type.Info);
        }

        /// <summary>
        /// Navigated Forward
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <example>How to use it: <code>
        /// BrowserHelper.Forward(driver);
        /// </code></example>
        public static void Forward(this RemoteWebDriver driver)
        {
            driver.Navigate().Forward();
            Log4NetHelper.Log(" Navigated Forward ", Log4Type.Info);
        }

        /// <summary>
        /// Refresh Browser Page
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <example>How to use it: <code>
        /// BrowserHelper.RefreshPage(driver);
        /// </code></example>
        public static void RefreshPage(this RemoteWebDriver driver)
        {
            driver.Navigate().Refresh();
            Log4NetHelper.Log(" Page Refreshed ", Log4Type.Info);
        }

        /// <summary>
        /// Get Title of browser page
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <returns>Returns title of browser page. String</returns>
        public static string GetTitle(this RemoteWebDriver driver)
        {
            return driver.Title;
        }

        /// <summary>
        /// Switch to Browser Tab Window
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <param name="int index">index value of window</param>
        /// <example>How to use it: <code>
        /// BrowserHelper.SwithToWindow(driver, 1);
        /// </code></example>
        public static void SwitchToWindow(this RemoteWebDriver driver, int index = 0)
        {
            Thread.Sleep(1000);
            ReadOnlyCollection<string> windows = driver.WindowHandles;

            if ((windows.Count - 1) < index)
            {
                throw new NoSuchWindowException("Invalid Browser Window Index" + index);
            }
            driver.SwitchTo().Window(windows[index]);
            Thread.Sleep(1000);
            BrowserMaximize(driver);

        }

        /// <summary>
        /// Switch to Parent browser window
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <example>How to use it: <code>
        /// BrowserHelper.SwitchToParent(driver);
        /// </code></example>
        public static void SwitchToParent(this RemoteWebDriver driver)
        {
            var windowids = driver.WindowHandles;

            for (int i = windowids.Count - 1; i > 0;)
            {
                driver.Close();
                i = i - 1;
                Thread.Sleep(2000);
                driver.SwitchTo().Window(windowids[i]);
            }
            driver.SwitchTo().Window(windowids[0]);

        }

        /// <summary>
        /// Switch to Frame
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <param name="locator">WebDriver Instance</param>
        /// <example>How to use it: <code>
        /// BrowserHelper.SwitchToFrame(driver, locator);
        /// </code></example>
        public static void SwitchToFrame(this RemoteWebDriver driver, By locator)
        {
            driver.SwitchTo().Frame(driver.FindElement(locator));
        }

       
    }
}
