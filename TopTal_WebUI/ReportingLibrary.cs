using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.IO;
using System.Reflection;
namespace Report.Extent
{
    public class ExtentReportsHelper
    {
        public ExtentReports extent { get; set; }
        public ExtentV3HtmlReporter reporter { get; set; }
        public ExtentTest test { get; set; }

        /// <summary>
        /// Sets Report Fields, and path of report
        /// </summary>
        public ExtentReportsHelper()
        {
            extent = new ExtentReports();
            reporter = new ExtentV3HtmlReporter(Path.Combine(Directory.GetCurrentDirectory(), string.Concat("ExtentReports ", DateTime.Now.ToString("MMM-dd-yyyy hh-mm-ss"), ".html")));
            reporter.Config.DocumentTitle = "Automation Testing Report";
            reporter.Config.ReportName = "Regression Testing";
            reporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            extent.AttachReporter(reporter);
            extent.AddSystemInfo("Application Under Test", "TinEye.com");
            extent.AddSystemInfo("Environment", "QA");
            extent.AddSystemInfo("Machine", Environment.MachineName);
            extent.AddSystemInfo("OS", Environment.OSVersion.VersionString);
            extent.AddSystemInfo("User Name", Environment.UserName);
        }

        /// <summary>
        /// Creates Extent Test Report Here
        /// </summary>
        /// <param name="testName"></param>
        public void CreateTest(string testName)
        {
            test = extent.CreateTest(testName);
        }

        /// <summary>
        /// Set Test Step Status Pass
        /// </summary>
        /// <param name="stepDescription"></param>
        public void SetStepStatusPass(string stepDescription)
        {
            test.Log(Status.Pass, stepDescription);
        }

        /// <summary>
        /// Set Test Step Status Warning
        /// </summary>
        /// <param name="stepDescription"></param>
        public void SetStepStatusWarning(string stepDescription)
        {
            test.Log(Status.Warning, stepDescription);
        }

        /// <summary>
        /// Set Test Status Pass
        /// </summary>
        public void SetTestStatusPass()
        {
            test.Pass("Test Executed Sucessfully!");
        }

        /// <summary>
        /// Set Test  Status Fail
        /// </summary>
        /// <param name="message"></param>
        public void SetTestStatusFail(string message = null)
        {
            var printMessage = "<p><b>Test FAILED!</b></p>";
            if (!string.IsNullOrEmpty(message))
            {
                printMessage += $"Message: <br>{message}<br>"; 
            }
            test.Fail(printMessage);
        }

        /// <summary>
        /// Add Screenshot on test Case Failure
        /// </summary>
        /// <param name="base64ScreenCapture"></param>
        public void AddTestFailureScreenshot(string base64ScreenCapture)
        {
            test.AddScreenCaptureFromBase64String(base64ScreenCapture, "Screenshot on Error:");
        }

        /// <summary>
        /// Set Test Status Skipped
        /// </summary>
        public void SetTestStatusSkipped()
        {
            test.Skip("Test skipped!");
        }

        /// <summary>
        /// Close the Extent report
        /// </summary>
        public void Close()
        {
            extent.Flush();
        }
}
}