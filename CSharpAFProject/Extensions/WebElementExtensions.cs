using CSharpAFProject.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAFProject.Extensions
{
    /// <summary>
    /// Extension methods for Element Actions
    /// </summary>

    public static class WebElementExtensions
    {
        /// <summary>
        /// Select Element In Drop Down List
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <example>How to use it: <code>
        /// WebElementExtensions.GetSelectedDropDown(element);
        /// </code></example>
        public static string GetSelectedDropDown(this IWebElement element)
        {
            SelectElement ddl = new SelectElement(element);
            return ddl.AllSelectedOptions.First().ToString();
        }

        /// <summary>
        /// Get All The Options In DropDown List
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <example>How to use it: <code>
        /// WebElementExtensions.GetSelectedListOptions(element);
        /// </code></example>
        public static IList<IWebElement> GetSelectedListOptions(this IWebElement element)
        {
            SelectElement ddl = new SelectElement(element);
            return ddl.AllSelectedOptions;
        }

        /// <summary>
        /// Identify The Hyperlinks
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <example>How to use it: <code>
        /// WebElementExtensions.GetLinkText(element);
        /// </code></example>
        public static string GetLinkText(this IWebElement element)
        {
            string text = element.Text;
            return element.Text;
        }


        /// <summary>
        /// Select Element In Drop Down List By Value
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <example>How to use it: <code>
        /// WebElementExtensions.SelectDropDownList(value);
        /// </code></example>
        public static void SelectDropDownList(this IWebElement element, int indexValue)
        {
            SelectElement ddl = new SelectElement(element);
            ddl.SelectByIndex(indexValue);
        }

        /// <summary>
        /// Select Element In Drop Down List By Value
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <example>How to use it: <code>
        /// WebElementExtensions.SelectDropDownList(value);
        /// </code></example>
        public static void SelectDropDownList(this IWebElement element, string value)
        {
            SelectElement ddl = new SelectElement(element);
            ddl.SelectByText(value);
        }

        /// <summary>
        /// Verify Element is Present       
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <example>How to use it: <code>
        /// WebElementExtensions.AssertElementPresent(element);
        /// </code></example>
        public static void AssertElementPresent(this IWebElement element)
        {
            if (!IsElementPresent(element))
                throw new Exception(string.Format("Element Not Present"));
        }

        /// <summary>
        /// Method Will Return Boolean Type If Method Is Present
        /// </summary>
        /// <param name="driver">WebDriver Instance</param>
        /// <example>How to use it: <code>
        /// WebElementExtensions.IsElementPresent(element);
        /// </code></example>
        public static bool IsElementPresent(this IWebElement element)
        {
            try
            {
                bool ele = element.Displayed;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
