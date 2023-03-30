using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace CSharpAFProject.Helpers
{
    /// <summary>
    /// Helper methods for handling buttons
    /// </summary>
    public static class ButtonHelper
    {
        private static IWebElement _element;
        /// <summary>
        /// Click the button by locator
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <param name="locator">locator of the element</param>
        /// <example>How to use it: <code>
        /// ButtonHelper.ClickButton(driver,locator);
        /// </code></example>
        public static void ClickButton(this RemoteWebDriver driver, By locator)
        {
            _element = GenericHelper.GetElement(driver, locator);
            _element.Click();
            Log4NetHelper.Log(" Button Click @ " + locator, Log4Type.Info);
        }
        /// <summary>
        /// Click the button by IwebElement
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <param name="element">IwebElement of the element</param>
        /// <example>How to use it: <code>
        /// ButtonHelper.ClickButton(driver,element);
        /// </code></example>
        public static void ClickButton(this RemoteWebDriver driver, IWebElement locator)
        {
            _element = GenericHelper.GetElement(driver, locator);
            _element.Click();
            Log4NetHelper.Log(" Button Click @ " + locator, Log4Type.Info);
        }
        /// <summary>
        /// Verify the Button is enabled
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <param name="locator">locator of the element</param>
        /// <example>How to use it: <code>
        /// ButtonHelper.IsButtonEnabled(driver,locator);
        /// </code></example>
        /// <Return>Return boolean true/false for Button is enabled</Return>
        public static bool IsButtonEnabled(this RemoteWebDriver driver, By locator)
        {
            _element = GenericHelper.GetElement(driver, locator);
            Log4NetHelper.Log(" Checking Is Button Enabled ", Log4Type.Info);
            return _element.Enabled;
        }
        /// <summary>
        /// To get the text on the button
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <param name="locator">locator of the element</param>
        /// <example>How to use it: <code>
        /// ButtonHelper.GetButtonText(driver,locator);
        /// </code></example>
        /// <Return>Return string for button text</Return>
        public static string GetButtonText(this RemoteWebDriver driver, By locator)
        {
            _element = GenericHelper.GetElement(driver, locator);
            if (_element.GetAttribute("value") == null)
                return string.Empty;
            return _element.GetAttribute("value");
        }

    }
}
