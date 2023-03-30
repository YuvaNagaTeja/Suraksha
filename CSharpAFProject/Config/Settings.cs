using CSharpAFProject.Base;
using System.Data.SqlClient;

namespace CSharpAFProject.Config
{
    public class Settings
    {

        public static int Timeout { get; set; }

        public static string  IsReporting { get; set; }

        public static string  TestType { get; set; }

        public static string AUT { get; set; }

        public static string EnvName { get; set; }

        public static BrowserType BrowserType { get; set; }

        public static SqlConnection ApplicationCon { get; set; }

        public static string AppConnectionString { get; set; }

        public static string IsLog { get; set; }

        public static string LogPath { get; set; }

        public static string ExcelFileNamePath { get; set; }

        public static string[] EmailAddress { get; set; }

        public static string EmailSubject { get; set; }

        public static string EmailBody { get; set; }

        public static double GetElementLoadTimeOut { get; set; }

        public static bool EmailReport { get; set; }
        public static string ChromeDriverPath { get; set; }
        public static string GeckoDriverPath { get; set; }
        public static string IEDriverPath { get; set; }
        public static string MSEdgeDriverPath { get; set; }
        public static string ApplicationUnderTest { get; set; }
        public static string DownloadedPath { get; set; }

        private static bool _fileCreated = false;
        public static bool FileCreated
        {
            get
            {
                return _fileCreated;
            }
            set
            {
                _fileCreated = value;
            }
        }
    }
}
