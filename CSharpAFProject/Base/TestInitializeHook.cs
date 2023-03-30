using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Remote;
using System;
using OpenQA.Selenium;
using CSharpAFProject.Config;
using CSharpAFProject.Helpers;
using OpenQA.Selenium.Edge;
using Protractor;
using System.Collections.Generic;
/*using NUnit.Framework;

[assembly: Parallelizable(ParallelScope.Fixtures)]*/

namespace CSharpAFProject.Base
{
    public class TestInitializeHook : Steps
    {
        private readonly ParallelConfig _parallelConfig;
        EdgeDriver driver;
        public TestInitializeHook(ParallelConfig parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }
        public void InitializeSettings()
        {
            //Set all the settings for framework
            ConfigReader.SetFrameworkSettings();

            //Open Browser
            //OpenBrowser(GetBrowserOption(Settings.BrowserType));

            Log4NetHelper.Log("Initialized framework settings with " + Settings.BrowserType);

        }

        public void OpenBrowser(DriverOptions driverOptions)
        {

            switch (driverOptions)
            {
                case InternetExplorerOptions internetExplorerOptions:
                    internetExplorerOptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                    internetExplorerOptions.IgnoreZoomLevel = true;
                    internetExplorerOptions.RequireWindowFocus = true;
                    internetExplorerOptions.PageLoadStrategy = PageLoadStrategy.Normal;
                    Log4NetHelper.Log("Using InternetExplorer Browser Options");
                    break;
                case FirefoxOptions firefoxOptions:
                    firefoxOptions.PageLoadStrategy = PageLoadStrategy.Eager;
                    Log4NetHelper.Log("Using Firefox Browser Options");
                    break;
                case ChromeOptions chromeOptions:
                   // chromeOptions.BinaryLocation = @"C:\Users\pavand\AppData\Local\Google\Chrome\Application\chrome.exe";
                    //chromeOptions.BinaryLocation = @"chromedriver.exe";
                    chromeOptions.AddArguments("--no-sandbox");
                    chromeOptions.AddAdditionalCapability(CapabilityType.EnableProfiling, true, true);
                    chromeOptions.AddAdditionalCapability(CapabilityType.AcceptSslCertificates, true, true);
                    chromeOptions.AddArgument("start-maximized");
                    chromeOptions.PageLoadStrategy = PageLoadStrategy.Eager;

                    //lines for headless browser testing

                    // chromeOptions.AddArguments("--headless");

                    Log4NetHelper.Log("Using Chrome Browser Options");
                    break;
             
                case EdgeOptions edgeOptions:
                    edgeOptions.UseInPrivateBrowsing = true;
                    edgeOptions.PageLoadStrategy = PageLoadStrategy.Eager;
                    break;
            }

            try
            {
                if (driverOptions.BrowserName == "chrome")
                {
                    _parallelConfig.Driver = new ChromeDriver((ChromeOptions)driverOptions);

                }
                else if (driverOptions.BrowserName == "MicrosoftEdge")
                {
                    _parallelConfig.Driver = new EdgeDriver(EdgeDriverService.CreateDefaultService(".", "msedgedriver.exe"));
                }
                // _parallelConfig.Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), driverOptions.ToCapabilities());
                else if (driverOptions.BrowserName == "firefox")
                {
                    _parallelConfig.Driver = new FirefoxDriver((FirefoxOptions)driverOptions);
                }
            }
            catch (WebDriverException e)
            {
                Log4NetHelper.Log(" WebDriverException " + e, Log4Type.Warn);
                throw e;
            }
            _parallelConfig.Driver.Manage().Cookies.DeleteAllCookies();
            _parallelConfig.Driver.Manage().Window.Maximize();
            _parallelConfig.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Settings.GetElementLoadTimeOut);
        }

        public virtual NgWebDriver NaviateSite()
        {
            // DriverContext.Browser.GoToUrl(Settings.AUT);
            //  LogHelpers.Write("Opened the browser !!!");
            var ngDriver = new NgWebDriver(_parallelConfig.Driver);
            _parallelConfig.Driver.Navigate().GoToUrl(Settings.AUT);
            Log4NetHelper.Log("Opened the browser !!!");
            BrowserHelper.BrowserMaximize(_parallelConfig.Driver);
            return ngDriver;
        }


        public DriverOptions GetBrowserOption(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    return new InternetExplorerOptions();
                case BrowserType.FireFox:
                    return new FirefoxOptions();
                case BrowserType.Chrome:
                    return new ChromeOptions();
                case BrowserType.Edge:
                    return new EdgeOptions();
                case BrowserType.ChromeHeadless:
                    return new ChromeOptions();

                default:
                    return new ChromeOptions();
            }
        }

    }
}
