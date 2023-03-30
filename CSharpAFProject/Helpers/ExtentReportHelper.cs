using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using CSharpAFProject.Config;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace CSharpAFProject.Helpers
{
    public class ExtentReportHelper
    {
        //private static ExtentReports extent;
        //private static string HtmlReportFullPath { get; set; }

        public static ExtentReports ExtentInitialize(ExtentReports extent,String HtmlReportFullPath)
        {
            var htmlReporter = new ExtentHtmlReporter(HtmlReportFullPath);
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            htmlReporter.LoadConfig(Environment.CurrentDirectory.ToString() + "\\Config\\extent-config.xml");

            //Attach report to reporter
            extent = new AventStack.ExtentReports.ExtentReports();
            ConfigReader.SetFrameworkSettings();

            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Application Under Test", Settings.ApplicationUnderTest);
            extent.AddSystemInfo("Environment", Settings.EnvName);
            extent.AddSystemInfo("Machine", Environment.MachineName);
            extent.AddSystemInfo("OS", Environment.OSVersion.VersionString);

            return extent;
        }
    }
}
