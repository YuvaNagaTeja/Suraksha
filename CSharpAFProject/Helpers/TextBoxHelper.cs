using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace CSharpAFProject.Helpers
{
    /// <summary>
    /// Helper methods for TextBox actions.
    /// </summary>
    public static class TextBoxHelper
    {
        private static IWebElement element;

        /// <summary>
        /// Enter Text in Text Box
        /// </summary>
        /// <param name="driver">Driver Instance</param>
        /// <param name="locator">By</param>
        /// <param name="text">Text to Enter</param>
        public static void TypeInTextBox(this RemoteWebDriver driver, By locator, string text)
        {
            element = GenericHelper.GetElement(driver, locator);
            element.SendKeys(text);
            Log4NetHelper.Log($" Type in Textbox @ {locator} : value : {text}", Log4Type.Info);
        }

        /// <summary>
        /// Enter Text in Text Box
        /// </summary>
        /// <param name="driver">Driver Instance</param>
        /// <param name="locator">By</param>
        /// <param name="text">Text to Enter</param>
        public static void TypeInTextBox(this RemoteWebDriver driver, IWebElement locator, string text)
        {
            element = GenericHelper.GetElement(driver, locator);
            element.SendKeys(text);
            Log4NetHelper.Log($" Type in Textbox @ {locator} : value : {text}", Log4Type.Info);
        }

        /// <summary>
        /// Clear Text in Text Box
        /// </summary>
        /// <param name="driver">Driver Instance</param>
        /// <param name="locator">WebElement</param>
        public static void ClearTextBox(this RemoteWebDriver driver, By locator)
        {
            element = GenericHelper.GetElement(driver, locator);
            element.Clear();
            Log4NetHelper.Log($" Clear the Textbox @ {locator}", Log4Type.Info);
        }
        public static void ClearTextBox(this RemoteWebDriver driver, IWebElement locator)
        {
            element = GenericHelper.GetElement(driver, locator);
            element.Clear();
            Log4NetHelper.Log($" Clear the Textbox @ {locator}", Log4Type.Info);
        }
    }
}
