using System.Threading;
using OpenQA.Selenium;
using log4net;
using OpenQA.Selenium.Remote;

namespace CSharpAFProject.Helpers
{
    /// <summary>
    /// Helper methods for scroll functionalities.
    /// </summary>
    public static class JavaScriptExecutor
    {

        public static object ExecuteScript(this RemoteWebDriver driver, string script)
        {
            IJavaScriptExecutor executor = ((IJavaScriptExecutor) driver);
            Log4NetHelper.Log($" Execute Script @ {script}", Log4Type.Info);
            return executor.ExecuteScript(script);
        }

        public static object ExecuteScript(this RemoteWebDriver driver, string script,params object[] args)
        {
            IJavaScriptExecutor executor = ((IJavaScriptExecutor)driver);
            return executor.ExecuteScript(script,args);
        }

    
        /// <summary>
        /// it will scroll and click
        /// </summary>
        /// <param name="driver">driver instance</param>
        /// <param name="element">locator of the element</param>
        /// <example>How to use it: <code>
        /// JavaScriptExecutor.ScrollToAndClick(driver,element);
        /// </code></example>
        public static void ScrollToAndClick(this RemoteWebDriver driver, IWebElement element)
        {
            ExecuteScript(driver,"window.scrollTo(0," + element.Location.Y + ")");
            Thread.Sleep(300);
            element.Click();
        }
        /// <summary>
        /// it will scroll and click
        /// </summary>
        /// <param name="driver">driver instance</param>
        /// <param name="element">locator of the element</param>
        /// <example>How to use it: <code>
        /// JavaScriptExecutor.ScrollToAndClick(driver,element);
        /// </code></example>
        public static void ScrollToAndClick(this RemoteWebDriver driver, By locator)
        {
            IWebElement element = GenericHelper.GetElement(driver, locator);
            ExecuteScript(driver, "window.scrollTo(0," + element.Location.Y + ")");
            Thread.Sleep(300);
            element.Click();
        }
        /// <summary>
        /// it will scroll to element and click
        /// </summary>
        /// <param name="driver">driver instance</param>
        /// <param name="element">locator of the element</param>
        /// <example>How to use it: <code>
        /// JavaScriptExecutor.ScrollIntoViewAndClick(driver,element);
        /// </code></example>
        public static void ScrollIntoViewAndClick(this RemoteWebDriver driver, IWebElement locator)
        {
            IWebElement element = GenericHelper.GetElement(driver, locator);
            ExecuteScript(driver, "arguments[0].scrollIntoView()",element);
            ExecuteScript(driver, "arguments[0].click();", element);
            Thread.Sleep(300);
        }

        public static void ScrollIntoView(this RemoteWebDriver driver, IWebElement locator)
        {
            IWebElement element = GenericHelper.GetElement(driver, locator);
            ExecuteScript(driver, "arguments[0].scrollIntoView()", element);
            Thread.Sleep(300);
        }

        public static void ScrollIntoViewSendKeys(this RemoteWebDriver driver, IWebElement locator, string value)
        {
            IWebElement element = GenericHelper.GetElement(driver, locator);
            ExecuteScript(driver, "arguments[0].scrollIntoView()", element);

            ExecuteScript(driver, "arguments[0].value='"+value+"'", locator);
        }
    }
}
