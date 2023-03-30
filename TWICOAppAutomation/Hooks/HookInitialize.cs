using TechTalk.SpecFlow;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using CSharpAFProject.Base;
using CSharpAFProject.Config;
using CSharpAFProject.Helpers;
using System.IO;
using System;
using System.Diagnostics;
using System.Linq;
using TestContext = NUnit.Framework.TestContext;
using System.Reflection;
using System.Threading;

namespace TWICOAppAutomation.Hooks
{

    [Binding]
    public class HookInitialize : TestInitializeHook
    {
        private readonly ParallelConfig _parallelConfig;
        private readonly FeatureContext _featureContext;
        private readonly ScenarioContext _scenarioContext;
        [ThreadStatic]
        private static ExtentTest _currentScenarioName;

        private static string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        private static string folderName = Path.Combine(projectPath, "Results");
        public static string LatestResultsReportFolder { get; set; }
        private static string HtmlReportFullPath { get; set; }


        public HookInitialize(ParallelConfig parallelConfig, FeatureContext featureContext, ScenarioContext scenarioContext) : base(parallelConfig)
        {
            _parallelConfig = parallelConfig;
            _featureContext = featureContext;
            _scenarioContext = scenarioContext;
        }

        private static ExtentTest featureName;
        private static ExtentReports extent;

        [AfterStep]
        public void AfterEachStep()
        {

            var stepType = _scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();

            if (_scenarioContext.TestError == null)
            {
                if (stepType == "Given")
                    _currentScenarioName.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "When")
                    _currentScenarioName.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "Then")
                    _currentScenarioName.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "And")
                    _currentScenarioName.CreateNode<And>(_scenarioContext.StepContext.StepInfo.Text);
            }
            else if (_scenarioContext.TestError != null)
            {
                //screenshot in the Base64 format
                var mediaEntity = _parallelConfig.CaptureScreenshotAndReturnModel(_scenarioContext.ScenarioInfo.Title.Trim());
                //Azure Report
                var filePath = $"{TestContext.CurrentContext.TestDirectory}\\{TestContext.CurrentContext.Test.MethodName}.jpg";
                ((OpenQA.Selenium.ITakesScreenshot)_parallelConfig.Driver).GetScreenshot().SaveAsFile(filePath);
                TestContext.AddTestAttachment(filePath);
                if (stepType == "Given")
                    _currentScenarioName.CreateNode<Given>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message, mediaEntity);
                else if (stepType == "When")
                    _currentScenarioName.CreateNode<When>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message, mediaEntity);
                else if (stepType == "Then")
                    _currentScenarioName.CreateNode<Then>(_scenarioContext.StepContext.StepInfo.Text).Fail(_scenarioContext.TestError.Message, mediaEntity);
            }
            else if (_scenarioContext.ScenarioExecutionStatus.ToString() == "StepDefinitionPending")
            {
                if (stepType == "Given")
                    _currentScenarioName.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "When")
                    _currentScenarioName.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "Then")
                    _currentScenarioName.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");

            }
        }

       /* private static void CreateReportDirectory()
        {
            var filePath = Path.GetFullPath(folderName);
            LatestResultsReportFolder = Path.Combine(filePath, DateTime.Now.ToString("MMdd_HHmm"));
            Directory.CreateDirectory(LatestResultsReportFolder);

            HtmlReportFullPath = $"{LatestResultsReportFolder}\\TestResults.html";
            Log4NetHelper.Log("Full path of HTML report=>" + HtmlReportFullPath);
        }*/


        [BeforeTestRun]
        public static void TestInitalize()
        {
            /* System.Diagnostics.Process.Start(Environment.CurrentDirectory.ToString() +"\\starthub.bat");
             System.Diagnostics.Process.Start(Environment.CurrentDirectory.ToString() + "\\startnode.bat");
             Thread.Sleep(15000);*/


            //Settings.ApplicationCon = Settings.ApplicationCon.DBConnect(Settings.AppConnectionString);
            //Initialize Extent report before test starts
            HtmlReportFullPath = Reporter.CreateExtentReportDirectory();
            extent = ExtentReportHelper.ExtentInitialize(extent, HtmlReportFullPath);

        }

        [BeforeScenario]
        public void Initialize()
        {
            InitializeSettings();

            _scenarioContext.TryGetValue("Browser", out string browser);
            if (browser != null)
            {
                var browserType = (BrowserType)System.Enum.Parse(typeof(BrowserType), browser);
                OpenBrowser(GetBrowserOption(browserType));
            }
            else
            {
                OpenBrowser(GetBrowserOption(Settings.BrowserType));

            }
            //DB Connection
            Settings.ApplicationCon = Settings.ApplicationCon.DBConnect(Settings.AppConnectionString);

            //Get feature Name
            featureName = extent.CreateTest<Feature>(_scenarioContext.ScenarioInfo.Title, _featureContext.FeatureInfo.Title)
                .AssignCategory(_featureContext.FeatureInfo.Tags);
            
            //Create dynamic scenario name
            _currentScenarioName = featureName.CreateNode<Scenario>(TestContext.CurrentContext.Test.Name);
            
        }

        [AfterScenario]
        public void TestStop()
        {
          _parallelConfig.Driver.Quit();
        }

        [AfterTestRun]
        public static void TearDownReport()
        {
            //Flush report once test completes
            extent.Flush();
            TestContext.AddTestAttachment(HtmlReportFullPath.Replace("TestResults", "index"));
            var processes = Process.GetProcessesByName("msedgedriver").ToList();
            processes.AddRange(Process.GetProcessesByName("chromedriver"));
            processes.AddRange(Process.GetProcessesByName("geckodriver"));

            foreach (var process in processes)
                process.Kill();

           /* if (Settings.EmailReport)
                EmailSender.SendEmail(Settings.EmailAddress, Settings.EmailSubject, HtmlReportFullPath.Replace("TestResults", "index"), Settings.EmailBody);
*/
        }
    }
}
