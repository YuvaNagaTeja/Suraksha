using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using WDSE;
using WDSE.Decorators;
using WDSE.ScreenshotMaker;


namespace CSharpAFProject.Base
{
    public class ParallelConfig
    {

        public RemoteWebDriver Driver { get; set; }

        public BasePage CurrentPage { get; set; }

        public MediaEntityModelProvider CaptureScreenshotAndReturnModel(string Name)
        {
           // var screenShot = Driver.TakeScreenshot(new VerticalCombineDecorator(new ScreenshotMaker())).ToMagickImage().ToBase64();
            //string base64String = Convert.ToBase64String(screenShot, 0, screenShot.Length);
            
            var screenShot = ((ITakesScreenshot)Driver).GetScreenshot().AsBase64EncodedString;

            return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenShot, Name).Build();
        }

    }
}
