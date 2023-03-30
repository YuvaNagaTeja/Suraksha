using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using log4net;
using log4net.Config;
//[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4net.config")]


namespace CSharpAFProject.Helpers
{
    /// <summary>
    /// Log generation class
    /// </summary>
    public class Log4NetHelper
    {
        private static ILog _log;
        private static object threadid;

        /// <summary>
        /// Generate Log
        /// </summary>
        /// <param name="message">Logger Message</param>
        /// <param name="type">Logger Type: Info, Warn, Fatal, Debug, Error</param>
        /// <example>How to use it: <code>
        /// Log4NetHelper.Log("Message", Log4Type.Info);
        /// </code></example>
        public static void Log(
           string message, Log4Type type = Log4Type.Debug,
           [CallerFilePath] string path = @"C:\Unknown.cs", [CallerLineNumber] int line = 0, [CallerMemberName] string method = ""
           )
        {
            // Add the caller file information
            message = $"{PrefixLog(path, line, method)} {message}";

            ProcessLog(message, type);
        }

        private static void ProcessLog(string message, Log4Type type)
        {
            EnsureLogger();

            switch (type)
            {
                case Log4Type.Fatal:
                    _log.Fatal(message);
                    break;
                case Log4Type.Error:
                    _log.Error(message);
                    break;
                case Log4Type.Warn:
                    _log.Warn(message);
                    break;
                case Log4Type.Info:
                    _log.Info(message);
                    break;
                case Log4Type.Debug:
                default:
                    _log.Debug(message);
                    break;
            }
        }

        private static string PrefixLog(string path, int line, string method)
        {
            var file = new FileInfo(path);

            return $"{file.Name}:{line} ({method})";
        }


        private static void EnsureLogger()
        {
            if (_log != null) return;

            var assembly = Assembly.GetEntryAssembly();
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            var configFile = GetConfigFile();

            // Configure Log4Net
            XmlConfigurator.Configure(logRepository, configFile);
            _log = LogManager.GetLogger(assembly, assembly.ManifestModule.Name.Replace(".dll", "").Replace(".", " "));
        }

        private static FileInfo GetConfigFile()
        {
            FileInfo configFile = null;

            // Search config file
            var configFileNames = new[] { "Config/log4net.config", "log4net.config" };

            foreach (var configFileName in configFileNames)
            {
                configFile = new FileInfo(configFileName);

                if (configFile.Exists) break;
            }

            if (configFile == null || !configFile.Exists) throw new NullReferenceException("Log4net config file not found.");

            return configFile;
        }

    }
}
