using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace CSharpAFProject.Helpers
{
    /// <summary>
    /// Helper methods for Radio Button actions.
    /// </summary>
    public static class RadioButtonHelper
    {
        private static IWebElement element;

        /// <summary>
        /// Click Radio Button
        /// </summary>
        /// <param name="driver">Driver Instance</param>
        /// <param name="locator">WebElement</param>
        public static void ClickRadioButton(this RemoteWebDriver driver, By locator)
        {
            element = GenericHelper.GetElement(driver, locator);
            element.Click();
        }

        /// <summary>
        /// Verify Radio Button is selected
        /// </summary>
        /// <param name="driver">Driver Instance</param>
        /// <param name="locator">WebElement</param>
        public static bool IsRadioButtonSelected(this RemoteWebDriver driver, By locator)
        {
            element = GenericHelper.GetElement(driver, locator);
            string flag = element.GetAttribute("checked");

            if (flag == null)
                return false;
            else
                return flag.Equals("true") || flag.Equals("checked");
        }

    }
}
