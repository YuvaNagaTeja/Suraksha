using CSharpAFProject.Base;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CSharpAFProject.Config
{
    [JsonObject("testSettings")]
    public class TestSettings
    {

        [JsonProperty("envName")]
        public string EnvName { get; set; }

        [JsonProperty("aut")]
        public string AUT { get; set; }


        [JsonProperty("browser")]
        public BrowserType Browser { get; set; }


        [JsonProperty("testType")]
        public string TestType { get; set; }

        [JsonProperty("isLog")]
        public string IsLog { get; set; }


        [JsonProperty("logPath")]
        public string LogPath { get; set; }

        [JsonProperty("autConnectionString")]
        public string AUTConnectionString { get; set; }

        [JsonProperty("excelFileNamePath")]
        public string ExcelFileNamePath { get; set; }

        [JsonProperty("emailAddress")]
        public string[] EmailAddress { get; set; }

        [JsonProperty("emailSubject")]
        public string EmailSubject { get; set; }

        [JsonProperty("emailBody")]
        public string EmailBody { get; set; }

        [JsonProperty("getElementLoadTimeOut")]
        public double GetElementLoadTimeOut { get; set; }

        [JsonProperty("emailReport")]
        public bool EmailReport { get; set; }

        [JsonProperty("geckoDriverPath")]
        public string GeckoDriverPath { get; set; }


        [JsonProperty("chromeDriverPath")]
        public string ChromeDriverPath { get; set; }


        [JsonProperty("IEDriverPath")]
        public string IEDriverPath { get; set; }


        [JsonProperty("EdgeDriverPath")]
        public string MSEdgeDriverPath { get; set; }

        [JsonProperty("ApplicationUnderTest")]
        public string ApplicationUnderTest { get; set; }

        [JsonProperty("DownloadedPath")]
        public string DownloadedPath { get; set; }
    }
}
