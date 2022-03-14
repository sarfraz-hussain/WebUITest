//Pages.cs
using OpenQA.Selenium.Support.PageObjects;
using Report.Extent;
using SeleniumExtras;
using System;
using Selenium.Core.CSharp;
//Sample comment for test
namespace TopTal.WebUI

{
    public class Pages
    {
        public Pages(Browsers browser, ExtentReportsHelper extentReportsHelper)
        {
            _browser = browser;
            _extentReportsHelper = extentReportsHelper;
        }
        Browsers _browser { get; }
        ExtentReportsHelper _extentReportsHelper { get; set; }

        /// <summary>
        /// Page Generator Implementation
        /// </summary>

        private T GetPages<T>() where T : new()
        {
            var page = (T)Activator.CreateInstance(typeof(T), _browser.getDriver, _extentReportsHelper);
            PageFactory.InitElements(_browser.getDriver, page);
            return page;
        }
       
        public HomePage homePage => GetPages<HomePage>();
        public SearchPage searchPage => GetPages<SearchPage>();
        public SearchErrorPage errorPage => GetPages<SearchErrorPage>();
        public LogInPage loginPage => GetPages<LogInPage>();


    }
}
