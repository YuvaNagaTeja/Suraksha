using System.IO;
using CSharpAFProject.Helpers;
using Microsoft.Extensions.Configuration;


namespace CSharpAFProject.Config
{
    public class ConfigReader
    {
        public static void SetFrameworkSettings()
        {

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");


            IConfigurationRoot configurationRoot = builder.Build();

            //Test lab configuration settings
            Settings.EnvName = configurationRoot.GetSection("testSettings").Get<TestSettings>().EnvName;
            Settings.AUT = configurationRoot.GetSection("testSettings").Get<TestSettings>().AUT;
            Settings.TestType = configurationRoot.GetSection("testSettings").Get<TestSettings>().TestType;
            Settings.IsLog = configurationRoot.GetSection("testSettings").Get<TestSettings>().IsLog;
            //Settings.IsReporting = EATestConfiguration.EASettings.TestSettings["staging"].IsReadOnly;
            Settings.LogPath = configurationRoot.GetSection("testSettings").Get<TestSettings>().LogPath;
            Settings.AppConnectionString = configurationRoot.GetSection("testSettings").Get<TestSettings>().AUTConnectionString;
            Settings.BrowserType = configurationRoot.GetSection("testSettings").Get<TestSettings>().Browser;
            Settings.ExcelFileNamePath = configurationRoot.GetSection("testSettings").Get<TestSettings>().ExcelFileNamePath;
            Settings.GetElementLoadTimeOut = configurationRoot.GetSection("testSettings").Get<TestSettings>().GetElementLoadTimeOut;
            //Email configuration settings
            Settings.EmailReport = configurationRoot.GetSection("emailSettings").Get<TestSettings>().EmailReport;
            Settings.EmailAddress = configurationRoot.GetSection("emailSettings").Get<TestSettings>().EmailAddress;
            Settings.EmailSubject = configurationRoot.GetSection("emailSettings").Get<TestSettings>().EmailSubject;
            Settings.EmailBody = configurationRoot.GetSection("emailSettings").Get<TestSettings>().EmailBody;
            Settings.ApplicationUnderTest = configurationRoot.GetSection("testSettings").Get<TestSettings>().ApplicationUnderTest;
            Settings.DownloadedPath = configurationRoot.GetSection("testSettings").Get<TestSettings>().DownloadedPath;

            Settings.GeckoDriverPath = configurationRoot.GetSection("testSettings").Get<TestSettings>().GeckoDriverPath;
            Settings.ChromeDriverPath = configurationRoot.GetSection("testSettings").Get<TestSettings>().ChromeDriverPath;
            Settings.IEDriverPath = configurationRoot.GetSection("testSettings").Get<TestSettings>().IEDriverPath;
            Settings.MSEdgeDriverPath = configurationRoot.GetSection("testSettings").Get<TestSettings>().MSEdgeDriverPath;


            Log4NetHelper.Log("Configuration settings are \n " +"AUT: "+ Settings.AUT + "\n " +"Test Type: "+ Settings.TestType + 
                "\n " +"IsLog: "+ Settings.IsLog + "\n " +"LogPath: "+ Settings.LogPath + "\n "+"Browser: "+Settings.BrowserType +
                "\n " +"ExcelFilePath: "+Settings.ExcelFileNamePath);
        }

    }
}
