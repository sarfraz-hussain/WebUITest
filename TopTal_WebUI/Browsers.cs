//added comment to verify testproject kicks off in AWS
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Report.Extent;
using System.Configuration;
namespace Selenium.Core.CSharp
{
    public class Browsers
    {
        public Browsers(ExtentReportsHelper reportsHelper)
        {
            baseURL = ConfigurationSettings.AppSettings["url"];
            browser = ConfigurationSettings.AppSettings["browser"];
            extentReportsHelper = reportsHelper;
        }
        private IWebDriver webDriver;
        private string baseURL;
        private string browser;
        private ExtentReportsHelper extentReportsHelper;

        /// <summary>
        /// Intilize Browser, based on Selection from Config file, Also make it part of report
        /// </summary>
        public void Init()
        {
            switch (browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver();
                    var options = new ChromeOptions();
                    options.AddArgument("no-sandbox");
                    extentReportsHelper.SetStepStatusPass("Chrome Browser started.");
                    break;
                case "Firefox":
                    webDriver = new FirefoxDriver();
                    extentReportsHelper.SetStepStatusPass("FireFox Browser started.");
                    break;
                default:
                    webDriver = new ChromeDriver();
                    extentReportsHelper.SetStepStatusPass("Default Browser started.");
                    break;
            }
            
            webDriver.Manage().Window.Maximize();
            extentReportsHelper.SetStepStatusPass("Browser maximized.");
            Goto(baseURL);
            
        }

        /// <summary>
        /// To get the Title of the webDriver Selected
        /// </summary>
        public string Title
        {
            get { return webDriver.Title; }
        }

        /// <summary>
        /// Property to Get the Webdriver
        /// </summary>
        public IWebDriver getDriver
        {
            get { return webDriver; }
        }

        /// <summary>
        /// To Navigae Browser, and update report about Naviaion
        /// </summary>
        /// <param name="url"></param>
        public void Goto(string url)
        {
            webDriver.Url = url;
            extentReportsHelper.SetStepStatusPass($"Browser navigated to the url [{url}].");
        }

        /// <summary>
        /// To close the active Web Driver and updae Report Accordingly
        /// </summary>
        public void Close()
        {
            webDriver.Quit();
            extentReportsHelper.SetStepStatusPass($"Browser closed.");
        }
    }
}
