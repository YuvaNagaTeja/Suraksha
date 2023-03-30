using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace CSharpAFProject.Helpers
{
    /// <summary>
    /// Helper methods for Alerts handling
    /// </summary>
    public static class AlertHelper
    {
        /// <summary>
        /// Verify the Alert Popup is present
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <Return>Return boolean true/false for alert displayed</Return>
        public static bool IsPopupPresent(this RemoteWebDriver driver)
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        /// <summary>
        /// Return text present on alert
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <Return>Return string if alert present </Return>
        public static string GetPopUpText(this RemoteWebDriver driver)
        {
            if (!IsPopupPresent(driver))
                return String.Empty;
            return driver.SwitchTo().Alert().Text;
        }

        /// <summary>
        /// Click Ok button on alert
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        public static void ClickOkOnPopup(this RemoteWebDriver driver)
        {
            if (!IsPopupPresent(driver))
                return;
            driver.SwitchTo().Alert().Accept();
        }

        /// <summary>
        /// Click Cancel button on alert
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        public static void ClickCancelOnPopup(this RemoteWebDriver driver)
        {
            if (!IsPopupPresent(driver))
                return;
            driver.SwitchTo().Alert().Dismiss();
        }

        /// <summary>
        /// Enter text when alert text box is present
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <param name="text">WebDriver Instance</param>
        public static void SendKeys(this RemoteWebDriver driver, string text)
        {
            if (!IsPopupPresent(driver))
                return;
            driver.SwitchTo().Alert().SendKeys(text);
        }
    }
}
