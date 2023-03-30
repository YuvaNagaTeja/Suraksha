using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System.Reflection;

namespace CSharpAFProject.Helpers
{
    /// <summary>
    /// Helper methods for sceenshots.
    /// </summary>
    public static class ScreenshotHelper
    {
        /// <summary>
        /// gets the file path
        /// </summary>
        /// <param name="DirectoryName">name of the directory .</param>
        /// <param name="filename">name of the file .</param>
        /// <returns>String with removed all special chracters.</returns>
        /// <example>How to use it: <code>
        /// ScreenshotHelper.GetPath(DirectoryName,filename);
        /// </code></example>
        /// <returns>returns filename</returns>
        private static string GetPath(string DirectoryName, string filename)
        {
            //string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
              string Location = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            filename = Location + Path.DirectorySeparatorChar + DirectoryName + Path.DirectorySeparatorChar + filename + DateTime.UtcNow.ToString("yyyy-MM-dd-mm-ss") + ".Png";
           // filename = projectPath + Path.DirectorySeparatorChar + DirectoryName + Path.DirectorySeparatorChar + filename + DateTime.UtcNow.ToString("yyyy-MM-dd-mm-ss") + ".Png";

            return filename;
        }
        /// <summary>
        /// gets the screenshot
        /// </summary>
        /// <param name="filename">name of the file .</param>
        
        /// <example>How to use it: <code>
        ///ScreenshotHelper.TakeScreenShot(_parallelConfig.Driver);
        /// </code></example>
        public static void TakeScreenShot(this RemoteWebDriver driver, string filename = "Screen")
        {
            var screen = driver.TakeScreenshot();
            if (filename.Equals("Screen"))
            {
                filename = filename + DateTime.UtcNow.ToString("yyyy-MM-dd-mm-ss") + ".jpeg";
                screen.SaveAsFile(filename, ScreenshotImageFormat.Png);
                Log4NetHelper.Log(" ScreenShot Taken : " + filename, Log4Type.Info);
                return;
            }
            screen.SaveAsFile(filename, ScreenshotImageFormat.Png); Log4NetHelper.Log(" ScreenShot Taken : " + filename);
        }
        /// <summary>
        /// gets the screenshot
        /// </summary>
        /// <param name="driver">driver instance</param>
        /// <param name="DirectoryName">name of the directory .</param>
        /// <param name="filename">name of the file .</param>
        /// <example>How to use it: <code>
        ///ScreenshotHelper.TakeScreenShot(Driver,DirectoryName,filename);
        /// </code></example>
        public static void TakeScreenShot(this RemoteWebDriver driver, string DirectoryName, string filename)
        {
            if (!Directory.Exists(DirectoryName))
            {
                Directory.CreateDirectory(DirectoryName);
            }
            filename = GetPath(DirectoryName, filename);
            var screen = driver.TakeScreenshot();
            screen.SaveAsFile(filename, ScreenshotImageFormat.Png);
            Log4NetHelper.Log(" ScreenShot Taken : " + filename);
            return;
        }
    }
}
