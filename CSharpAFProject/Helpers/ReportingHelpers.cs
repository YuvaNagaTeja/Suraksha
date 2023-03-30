using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace CSharpAFProject.Helpers
{
    public class Reporter
    {
        private static ExtentReports ReportManager { get; set; }
        private static string ApplicationDebuggingFolder => System.IO.Directory.GetParent(@"./").FullName;

        private static string HtmlReportFullPath { get; set; }

        public static string LatestResultsReportFolder { get; set; }

        private static TestContext MyTestContext { get; set; }

        private static ExtentTest CurrentTestCase { get; set; }

        private static bool IsExtenetReportStarted = false;
        private static string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        private static string folderName = Path.Combine(projectPath, "Results");

        public static void StartReporter()
        {
            Log4NetHelper.Log("Starting a one time setup for the entire" +
                            " .CreatingReports namespace." +
                            "Going to initialize the reporter next...");
            CreateReportDirectory();
            var htmlReporter = new ExtentHtmlReporter(HtmlReportFullPath);
            ReportManager = new ExtentReports();
            ReportManager.AttachReporter(htmlReporter);
        }

        private static void CreateReportDirectory()
        {
            var filePath = Path.GetFullPath(ApplicationDebuggingFolder);
            LatestResultsReportFolder = Path.Combine(filePath, DateTime.Now.ToString("MMdd_HHmm"));
            Directory.CreateDirectory(LatestResultsReportFolder);

            HtmlReportFullPath = $"{LatestResultsReportFolder}\\TestResults.html";
            Log4NetHelper.Log("Full path of HTML report=>" + HtmlReportFullPath);
        }

        public static string CreateExtentReportDirectory()
        {
            var filePath = Path.GetFullPath(folderName);
            LatestResultsReportFolder = Path.Combine(filePath, DateTime.Now.ToString("MMdd_HHmm"));
            Directory.CreateDirectory(LatestResultsReportFolder);

            HtmlReportFullPath = $"{LatestResultsReportFolder}\\TestResults.html";
            Log4NetHelper.Log("Full path of HTML report=>" + HtmlReportFullPath);
            return HtmlReportFullPath;
        }

        public static void AddTestCaseMetadataToHtmlReport(TestContext testContext)
        {
            MyTestContext = testContext;
            CurrentTestCase = ReportManager.CreateTest(MyTestContext.TestName);
        }

        public static void LogPassingTestStepToBugLogger(string message)
        {
            Log4NetHelper.Log(message, Log4Type.Info);
            CurrentTestCase.Log(Status.Pass, message);
        }

        public static void ReportTestOutcome(string screenshotPath)
        {
            var status = MyTestContext.CurrentTestOutcome;

            switch (status)
            {
                case UnitTestOutcome.Failed:
                    Log4NetHelper.Log($"Test Failed=>{MyTestContext.FullyQualifiedTestClassName}", Log4Type.Error);
                    CurrentTestCase.AddScreenCaptureFromPath(screenshotPath);
                    CurrentTestCase.Fail("Fail");
                    break;
                case UnitTestOutcome.Inconclusive:
                    CurrentTestCase.AddScreenCaptureFromPath(screenshotPath);
                    CurrentTestCase.Warning("Inconclusive");
                    break;
                case UnitTestOutcome.Unknown:
                    CurrentTestCase.Skip("Test skipped");
                    break;
                default:
                    CurrentTestCase.Pass("Pass");
                    break;
            }

            ReportManager.Flush();
        }

        public static void LogTestStepForBugLogger(Status status, string message)
        {
            Log4NetHelper.Log(message, Log4Type.Info);
            CurrentTestCase.Log(status, message);
        }

        public static void GetReportManager()
        {
            if (!IsExtenetReportStarted)
            {
                IsExtenetReportStarted = true;
                StartReporter();
            }
        }
    }
}
