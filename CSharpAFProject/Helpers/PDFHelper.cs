using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using iTextSharp.text.pdf.parser;
using iTextSharp.text.pdf;
using System.Text;
using CSharpAFProject.Base;
using CSharpAFProject.Config;

namespace CSharpAFProject.Helpers
{
    public class PDFHelper
    {
        private static object filenamesForLog;
        static string DownloadDirectory;
        private readonly ParallelConfig _parallelConfig;
        public PDFHelper(ParallelConfig parallelConfig)
        {
            _parallelConfig = parallelConfig;
        }
        public static List<FileInfo> ActAndWaitForFileDownload(
         Action action
         , string expectedExtension
         , TimeSpan maximumWaitTime
            , string fileToDelete)
        {

            var isTimedOut = false;
            var extensionFilter = $"*{expectedExtension}";

            DownloadDirectory = System.Environment.GetEnvironmentVariable("USERPROFILE") + Settings.DownloadedPath;


            Directory.CreateDirectory(DownloadDirectory);
            var fileCountbefore = Directory.GetFiles(DownloadDirectory, expectedExtension).Length;

            string[] deletePreviousFiles = Directory.GetFiles(DownloadDirectory, extensionFilter);
            foreach (string file in deletePreviousFiles)
            {
                if (file.Contains(fileToDelete))
                {
                    FileInfo thisFile = new FileInfo(file);
                  
                    if (DateTime.Now - thisFile.LastWriteTime > TimeSpan.FromMinutes(3))
                    {
                        File.Delete(file);
                    }

                }
            }

            action();
            var stopwatch = Stopwatch.StartNew();

            Func<bool> fileAppearedOrTimedOut = () =>
            {

                isTimedOut = stopwatch.Elapsed > maximumWaitTime;

                var isFilePresent = Directory
                                        .GetFiles(DownloadDirectory, extensionFilter).Length == fileCountbefore;
                return isFilePresent && !isTimedOut;
            };
            do
            {
                Thread.Sleep(500);
                Log4NetHelper.Log($"Waited {stopwatch.Elapsed} (max={maximumWaitTime}) for download '{extensionFilter}'...");
            }
            while (fileAppearedOrTimedOut());

            var files = Directory.GetFiles(DownloadDirectory, extensionFilter).Select(s => new FileInfo(s)).ToList();

            if (isTimedOut)
            {
                Log4NetHelper.Log($"Timed out: {filenamesForLog}");
            }
            else
            {
                filenamesForLog = string.Join(",", files.Select(f => f.Name));
                Log4NetHelper.Log($"File downloaded: {filenamesForLog}");
            }

            return files;
        }

        public static bool Extractor(IWebElement element, string text, string deletefile)
        {
            Thread.Sleep(8000);
            try
            {
                var downloadedFiles = PDFHelper.ActAndWaitForFileDownload(() => element.Click(), ".PDF", TimeSpan.FromSeconds(30), deletefile);
                string pdfFileName = string.Join(",", downloadedFiles.Select(f => f.Name));
                StringBuilder result = new StringBuilder();
                // Create a reader for the given PDF file
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                using (PdfReader reader = new PdfReader(string.Join(",", downloadedFiles)))
                //using (PdfReader reader = new PdfReader(pdfFileName))
                {
                    for (int page = 1; page <= reader.NumberOfPages; page++)
                    {
                        SimpleTextExtractionStrategy strategy =
                            new SimpleTextExtractionStrategy();
                        string pageText =
                            PdfTextExtractor.GetTextFromPage(reader, page, strategy);
                        result.Append(pageText);
                    }
                }
                if (result.ToString().Contains(text))
                    return true;
                else
                    return false;
            }
            catch (ElementClickInterceptedException e)
            {
                throw (e);

            }

        }
    }
}
