//Pages.cs
using OpenQA.Selenium.Support.PageObjects;
using Report.Extent;
using SeleniumExtras;
using System;
using Selenium.Core.CSharp;

namespace SeleniumEasy.COM

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
        private T GetPages<T>() where T : new()
        {
            var page = (T)Activator.CreateInstance(typeof(T), _browser.getDriver, _extentReportsHelper);
            PageFactory.InitElements(_browser.getDriver, page);
            return page;
        }
        public mPaige mPaige => GetPages<mPaige>();
        public BasicForm basicForm => GetPages<BasicForm>();

    }
}