using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using Report.Extent;
using Selenium.Core.CSharp;
using Return.Status;

namespace SeleniumEasy.COM
{
    public class mPaige
    {
        Status status = new Status(false);
        private IWebDriver driver;
        private ExtentReportsHelper extentReportsHelper;

        #region Locators

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(6) a")]
        [CacheLookup]
        public IWebElement ajaxFormSubmit1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(1) ul li:nth-of-type(6) a")]
        [CacheLookup]
        private IWebElement ajaxFormSubmit2;

        [FindsBy(How = How.CssSelector, Using = "#intermediate div.list-group a:nth-of-type(2)")]
        [CacheLookup]
        private IWebElement ajaxFormSubmit3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(2) a.dropdown-toggle")]
        [CacheLookup]
        private IWebElement alertsModals1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement alertsModals2;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch a")]
        [CacheLookup]
        private IWebElement allExamples;

        [FindsBy(How = How.CssSelector, Using = "a[href='../ant-tutorials']")]
        [CacheLookup]
        private IWebElement antTutorial;

        [FindsBy(How = How.CssSelector, Using = "a[href='../apachepoi-tutorials']")]
        [CacheLookup]
        private IWebElement apachePoi;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(2) ul.dropdown-menu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement bootstrapAlerts1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(5) ul li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement bootstrapAlerts2;

        [FindsBy(How = How.CssSelector, Using = "#basic div.list-group a:nth-of-type(7)")]
        [CacheLookup]
        private IWebElement bootstrapAlerts3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(2) ul.dropdown-menu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement bootstrapDatePicker1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(2) ul li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement bootstrapDatePicker2;

        [FindsBy(How = How.CssSelector, Using = "#advanced div.list-group a:nth-of-type(7)")]
        [CacheLookup]
        private IWebElement bootstrapDownloadProgressBar;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(3) ul.dropdown-menu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement bootstrapListBox1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(6) ul li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement bootstrapListBox2;

        [FindsBy(How = How.CssSelector, Using = "#intermediate div.list-group a:nth-of-type(4)")]
        [CacheLookup]
        private IWebElement bootstrapListBox3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(2) ul.dropdown-menu li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement bootstrapModals1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(5) ul li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement bootstrapModals2;

        [FindsBy(How = How.CssSelector, Using = "#basic div.list-group a:nth-of-type(8)")]
        [CacheLookup]
        private IWebElement bootstrapModals3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement bootstrapProgressBar1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(4) ul li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement bootstrapProgressBar2;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(4) ul.dropdown-menu li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement chartsDemo1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(7) ul li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement chartsDemo2;

        [FindsBy(How = How.CssSelector, Using = "#advanced div.list-group a:nth-of-type(11)")]
        [CacheLookup]
        private IWebElement chartsDemo3;

        [FindsBy(How = How.CssSelector, Using = "#basic div.list-group a:nth-of-type(2)")]
        [CacheLookup]
        private IWebElement checkBoxDemo;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement checkboxDemo1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(1) ul li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement checkboxDemo2;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(3) ul.dropdown-menu li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement dataListFilter1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(6) ul li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement dataListFilter2;

        [FindsBy(How = How.CssSelector, Using = "#intermediate div.list-group a:nth-of-type(6)")]
        [CacheLookup]
        private IWebElement dataListFilter3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(2) a.dropdown-toggle")]
        [CacheLookup]
        private IWebElement datePickers1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement datePickers2;

        [FindsBy(How = How.CssSelector, Using = "a[href='/test']")]
        [CacheLookup]
        private IWebElement demoHome;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(4) ul.dropdown-menu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement dragAndDrop1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(7) ul li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement dragAndDrop2;

        [FindsBy(How = How.CssSelector, Using = "#advanced div.list-group a:nth-of-type(9)")]
        [CacheLookup]
        private IWebElement dragAndDrop3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement dragDropSliders1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(4) ul li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement dragDropSliders2;

        [FindsBy(How = How.CssSelector, Using = "#advanced div.list-group a:nth-of-type(8)")]
        [CacheLookup]
        private IWebElement dragDropSliders3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(4) ul.dropdown-menu li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement dynamicDataLoading1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(7) ul li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement dynamicDataLoading2;

        [FindsBy(How = How.CssSelector, Using = "#advanced div.list-group a:nth-of-type(10)")]
        [CacheLookup]
        private IWebElement dynamicDataLoading3;

        [FindsBy(How = How.CssSelector, Using = "a[href='../maven-tutorials/how-to-execute-selenium-webdriver-testng-xml-using-maven']")]
        [CacheLookup]
        private IWebElement executeSeleniumTestsUsingMaven;

        [FindsBy(How = How.CssSelector, Using = "a[href='../jenkins-tutorials/invoke-testng-xml-tests-from-jenkins']")]
        [CacheLookup]
        private IWebElement executeTestsInJenkins;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(2) ul.dropdown-menu li:nth-of-type(6) a")]
        [CacheLookup]
        private IWebElement fileDownload1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(5) ul li:nth-of-type(6) a")]
        [CacheLookup]
        private IWebElement fileDownload2;

        [FindsBy(How = How.CssSelector, Using = "#intermediate div.list-group a:nth-of-type(8)")]
        [CacheLookup]
        private IWebElement fileDownload3;

        [FindsBy(How = How.CssSelector, Using = "a[href='../selenium-tutorials/launching-firefox-browser-with-geckodriver-selenium-3']")]
        [CacheLookup]
        private IWebElement geckoDriverSelenium3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement inputFormSubmit1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(1) ul li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement inputFormSubmit2;

        [FindsBy(How = How.CssSelector, Using = "#intermediate div.list-group a:nth-of-type(1)")]
        [CacheLookup]
        private IWebElement inputFormWithValidations;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(1) a.dropdown-toggle")]
        [CacheLookup]
        private IWebElement inputForms1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement inputForms2;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(2) ul.dropdown-menu li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement javascriptAlerts1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(5) ul li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement javascriptAlerts2;

        [FindsBy(How = How.CssSelector, Using = "#basic div.list-group a:nth-of-type(5)")]
        [CacheLookup]
        private IWebElement javascriptAlerts3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(2) ul.dropdown-menu li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement jqueryDatePicker1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(2) ul li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement jqueryDatePicker2;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement jqueryDownloadProgressBars1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(4) ul li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement jqueryDownloadProgressBars2;

        [FindsBy(How = How.CssSelector, Using = "#advanced div.list-group a:nth-of-type(6)")]
        [CacheLookup]
        private IWebElement jqueryDownloadProgressBars3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(3) ul.dropdown-menu li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement jqueryListBox1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(6) ul li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement jqueryListBox2;

        [FindsBy(How = How.CssSelector, Using = "#intermediate div.list-group a:nth-of-type(5)")]
        [CacheLookup]
        private IWebElement jqueryListBox3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(7) a")]
        [CacheLookup]
        private IWebElement jquerySelectDropdown1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(1) ul li:nth-of-type(7) a")]
        [CacheLookup]
        private IWebElement jquerySelectDropdown2;

        [FindsBy(How = How.CssSelector, Using = "#intermediate div.list-group a:nth-of-type(3)")]
        [CacheLookup]
        private IWebElement jquerySelectDropdown3;

        [FindsBy(How = How.CssSelector, Using = "a[href='../junit-tutorials']")]
        [CacheLookup]
        private IWebElement junitTutorial;

        [FindsBy(How = How.CssSelector, Using = "a[href='../jxl-tutorials']")]
        [CacheLookup]
        private IWebElement jxlTutorial;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(3) a.dropdown-toggle")]
        [CacheLookup]
        private IWebElement listBox1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(6) a")]
        [CacheLookup]
        private IWebElement listBox2;

        [FindsBy(How = How.CssSelector, Using = "a[href='../maven-tutorials']")]
        [CacheLookup]
        private IWebElement mavenTutorial;

        [FindsBy(How = How.CssSelector, Using = "a.right.carousel-control")]
        [CacheLookup]
        private IWebElement next;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(4) a.dropdown-toggle")]
        [CacheLookup]
        private IWebElement others1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(7) a")]
        [CacheLookup]
        private IWebElement others2;

        [FindsBy(How = How.CssSelector, Using = "a[href='../selenium-tutorials/page-factory-pattern-in-selenium-webdriver']")]
        [CacheLookup]
        private IWebElement pageFactoryPattern;

        private readonly string pageLoadedText = "Execute Selenium tests using Maven";

        public readonly string pageUrl = "https://www.seleniumeasy.com/test/";

        [FindsBy(How = How.CssSelector, Using = "a.left.carousel-control")]
        [CacheLookup]
        private IWebElement previous;

        [FindsBy(How = How.Id, Using = "btn_inter_example")]
        [CacheLookup]
        private IWebElement proceedNext1;

        [FindsBy(How = How.Id, Using = "btn_advanced_example")]
        [CacheLookup]
        private IWebElement proceedNext2;

        [FindsBy(How = How.Id, Using = "btn_done_example")]
        [CacheLookup]
        private IWebElement proceedNext3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(2) ul.dropdown-menu li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement progressBarModal1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(5) ul li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement progressBarModal2;

        [FindsBy(How = How.CssSelector, Using = "#intermediate div.list-group a:nth-of-type(7)")]
        [CacheLookup]
        private IWebElement progressBarModal3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(1) a.dropdown-toggle")]
        [CacheLookup]
        private IWebElement progressBars;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement progressBarsSliders;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement radioButtonsDemo1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(1) ul li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement radioButtonsDemo2;

        [FindsBy(How = How.CssSelector, Using = "#basic div.list-group a:nth-of-type(3)")]
        [CacheLookup]
        private IWebElement radioButtonsDemo3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement selectDropdownList1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(1) ul li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement selectDropdownList2;

        [FindsBy(How = How.CssSelector, Using = "#basic div.list-group a:nth-of-type(4)")]
        [CacheLookup]
        private IWebElement selectDropdownList3;

        [FindsBy(How = How.CssSelector, Using = "#site-name a")]
        [CacheLookup]
        private IWebElement seleniumEasy;

        [FindsBy(How = How.CssSelector, Using = "a[href='../selenium-tutorials']")]
        [CacheLookup]
        private IWebElement seleniumTutorials;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement simpleFormDemo1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(1) ul li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement simpleFormDemo2;

        [FindsBy(How = How.CssSelector, Using = "#basic div.list-group a:nth-of-type(1)")]
        [CacheLookup]
        private IWebElement simpleFormDemo3;

        [FindsBy(How = How.Id, Using = "btn_basic_example")]
        [CacheLookup]
        private IWebElement startPractising;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(3) a.dropdown-toggle")]
        [CacheLookup]
        private IWebElement table1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement table2;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(3) ul.dropdown-menu li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement tableDataDownload1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(3) ul li:nth-of-type(5) a")]
        [CacheLookup]
        private IWebElement tableDataDownload2;

        [FindsBy(How = How.CssSelector, Using = "#advanced div.list-group a:nth-of-type(5)")]
        [CacheLookup]
        private IWebElement tableDataDownload3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(3) ul.dropdown-menu li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement tableDataSearch1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(3) ul li:nth-of-type(2) a")]
        [CacheLookup]
        private IWebElement tableDataSearch2;

        [FindsBy(How = How.CssSelector, Using = "#advanced div.list-group a:nth-of-type(2)")]
        [CacheLookup]
        private IWebElement tableDataSearch3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(3) ul.dropdown-menu li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement tableFilter1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(3) ul li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement tableFilter2;

        [FindsBy(How = How.CssSelector, Using = "#advanced div.list-group a:nth-of-type(3)")]
        [CacheLookup]
        private IWebElement tableFilter3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(3) ul.dropdown-menu li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement tablePagination1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(3) ul li:nth-of-type(1) a")]
        [CacheLookup]
        private IWebElement tablePagination2;

        [FindsBy(How = How.CssSelector, Using = "#advanced div.list-group a:nth-of-type(1)")]
        [CacheLookup]
        private IWebElement tablePagination3;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(3) ul.dropdown-menu li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement tableSortSearch1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(3) ul li:nth-of-type(4) a")]
        [CacheLookup]
        private IWebElement tableSortSearch2;

        [FindsBy(How = How.CssSelector, Using = "#advanced div.list-group a:nth-of-type(4)")]
        [CacheLookup]
        private IWebElement tableSortSearch3;

        [FindsBy(How = How.CssSelector, Using = "a[href='../testng-tutorials/testng-customize-emailable-html-report-example']")]
        [CacheLookup]
        private IWebElement testngCustomReport;

        [FindsBy(How = How.CssSelector, Using = "a[href='../testng-tutorials']")]
        [CacheLookup]
        private IWebElement testngTutorial;

        [FindsBy(How = How.CssSelector, Using = "button.navbar-toggle")]
        [CacheLookup]
        private IWebElement toggleNavigation;

        [FindsBy(How = How.CssSelector, Using = "a[href='../selenium-webdriver-tutorials']")]
        [CacheLookup]
        private IWebElement viewAllSeleniumTutorials;

        [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(2) ul.dropdown-menu li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement windowPopupModal1;

        [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(5) ul li:nth-of-type(3) a")]
        [CacheLookup]
        private IWebElement windowPopupModal2;

        [FindsBy(How = How.CssSelector, Using = "#basic div.list-group a:nth-of-type(6)")]
        [CacheLookup]
        private IWebElement windowPopupModal3;

        #endregion

        #region Constructors

        public mPaige()  
        {
            this.driver = null;
            extentReportsHelper = null;
        }

        public mPaige(IWebDriver driver, ExtentReportsHelper reportsHelper)
        {
            this.driver = driver;
            extentReportsHelper = reportsHelper;

        }

        #endregion

        #region operations

        /// <summary>
        /// Click on Ajax Form Submit Link.
        /// </summary>
        /// <returns>The mPaige class instance.</returns>
        public mPaige ClickAjaxFormSubmit1Link()
        {
            try
            {
                ajaxFormSubmit1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
                
                return this;
            }
            catch (Exception e)
            {
                //status.ErrorOccurred = true;
                //status.ReturnedMessage += e.StackTrace;
                //status.ReturnedValue = 1;
                return this;
                //throw;
            }

        }

        /// <summary>
        /// Click on Ajax Form Submit Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public mPaige ClickAjaxFormSubmit2Link()
        {
            ajaxFormSubmit2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Ajax Form Submit Link.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        public mPaige ClickAjaxFormSubmit3Link()
        {
            ajaxFormSubmit3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Alerts Modals Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickAlertsModals1Link()
        {
            alertsModals1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Alerts Modals Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickAlertsModals2Link()
        {
            alertsModals2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on All Examples Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickAllExamplesLink()
        {
            allExamples.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Ant Tutorial Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickAntTutorialLink()
        {
            antTutorial.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Apache Poi Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickApachePoiLink()
        {
            apachePoi.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Bootstrap Alerts Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickBootstrapAlerts1Link()
        {
            bootstrapAlerts1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Bootstrap Alerts Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickBootstrapAlerts2Link()
        {
            bootstrapAlerts2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Bootstrap Alerts Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickBootstrapAlerts3Link()
        {
            bootstrapAlerts3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Bootstrap Date Picker Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickBootstrapDatePicker1Link()
        {
            bootstrapDatePicker1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Bootstrap Date Picker Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickBootstrapDatePicker2Link()
        {
            bootstrapDatePicker2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Bootstrap Download Progress Bar Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickBootstrapDownloadProgressBarLink()
        {
            bootstrapDownloadProgressBar.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Bootstrap List Box Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickBootstrapListBox1Link()
        {
            bootstrapListBox1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Bootstrap List Box Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickBootstrapListBox2Link()
        {
            bootstrapListBox2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Bootstrap List Box Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickBootstrapListBox3Link()
        {
            bootstrapListBox3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Bootstrap Modals Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickBootstrapModals1Link()
        {
            bootstrapModals1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Bootstrap Modals Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickBootstrapModals2Link()
        {
            bootstrapModals2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Bootstrap Modals Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickBootstrapModals3Link()
        {
            bootstrapModals3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Bootstrap Progress Bar Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickBootstrapProgressBar1Link()
        {
            bootstrapProgressBar1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Bootstrap Progress Bar Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickBootstrapProgressBar2Link()
        {
            bootstrapProgressBar2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Charts Demo Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickChartsDemo1Link()
        {
            chartsDemo1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Charts Demo Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickChartsDemo2Link()
        {
            chartsDemo2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Charts Demo Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickChartsDemo3Link()
        {
            chartsDemo3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Check Box Demo Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickCheckBoxDemoLink()
        {
            checkBoxDemo.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Checkbox Demo Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickCheckboxDemo1Link()
        {
            checkboxDemo1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Checkbox Demo Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickCheckboxDemo2Link()
        {
            checkboxDemo2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Data List Filter Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickDataListFilter1Link()
        {
            dataListFilter1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Data List Filter Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickDataListFilter2Link()
        {
            dataListFilter2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Data List Filter Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickDataListFilter3Link()
        {
            dataListFilter3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Date Pickers Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickDatePickers1Link()
        {
            datePickers1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Date Pickers Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickDatePickers2Link()
        {
            datePickers2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Demo Home Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickDemoHomeLink()
        {
            demoHome.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Drag And Drop Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickDragAndDrop1Link()
        {
            dragAndDrop1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Drag And Drop Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickDragAndDrop2Link()
        {
            dragAndDrop2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Drag And Drop Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickDragAndDrop3Link()
        {
            dragAndDrop3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Drag Drop Sliders Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickDragDropSliders1Link()
        {
            dragDropSliders1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Drag Drop Sliders Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickDragDropSliders2Link()
        {
            dragDropSliders2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Drag Drop Sliders Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickDragDropSliders3Link()
        {
            dragDropSliders3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Dynamic Data Loading Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickDynamicDataLoading1Link()
        {
            dynamicDataLoading1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Dynamic Data Loading Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickDynamicDataLoading2Link()
        {
            dynamicDataLoading2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Dynamic Data Loading Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickDynamicDataLoading3Link()
        {
            dynamicDataLoading3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Execute Selenium Tests Using Maven Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickExecuteSeleniumTestsUsingMavenLink()
        {
            executeSeleniumTestsUsingMaven.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Execute Tests In Jenkins Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickExecuteTestsInJenkinsLink()
        {
            executeTestsInJenkins.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on File Download Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickFileDownload1Link()
        {
            fileDownload1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on File Download Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickFileDownload2Link()
        {
            fileDownload2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on File Download Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickFileDownload3Link()
        {
            fileDownload3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Gecko Driver Selenium 3 Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickGeckoDriverSelenium3Link()
        {
            geckoDriverSelenium3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Input Form Submit Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickInputFormSubmit1Link()
        {
            inputFormSubmit1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Input Form Submit Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickInputFormSubmit2Link()
        {
            inputFormSubmit2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Input Form With Validations Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickInputFormWithValidationsLink()
        {
            inputFormWithValidations.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Input Forms Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickInputForms1Link()
        {
            inputForms1.ClickWrapper(driver, extentReportsHelper, "Input Form");
            return this;
        }

        /// <summary>
        /// Click on Input Forms Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickInputForms2Link()
        {
            inputForms2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Javascript Alerts Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickJavascriptAlerts1Link()
        {
            javascriptAlerts1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Javascript Alerts Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickJavascriptAlerts2Link()
        {
            javascriptAlerts2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Javascript Alerts Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickJavascriptAlerts3Link()
        {
            javascriptAlerts3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Jquery Date Picker Link.
        /// </summary>
        /// <returns>The mPaige class instance.</returns>
        public mPaige ClickJqueryDatePicker1Link()
        {
            jqueryDatePicker1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Jquery Date Picker Link.
        /// </summary>
        /// <returns>The mPaige class instance.</returns>
        public mPaige ClickJqueryDatePicker2Link()
        {
            jqueryDatePicker2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Jquery Download Progress Bars Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickJqueryDownloadProgressBars1Link()
        {
            jqueryDownloadProgressBars1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Jquery Download Progress Bars Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickJqueryDownloadProgressBars2Link()
        {
            jqueryDownloadProgressBars2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Jquery Download Progress Bars Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickJqueryDownloadProgressBars3Link()
        {
            jqueryDownloadProgressBars3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Jquery List Box Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickJqueryListBox1Link()
        {
            jqueryListBox1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Jquery List Box Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickJqueryListBox2Link()
        {
            jqueryListBox2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Jquery List Box Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickJqueryListBox3Link()
        {
            jqueryListBox3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Jquery Select Dropdown Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickJquerySelectDropdown1Link()
        {
            jquerySelectDropdown1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Jquery Select Dropdown Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickJquerySelectDropdown2Link()
        {
            jquerySelectDropdown2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Jquery Select Dropdown Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickJquerySelectDropdown3Link()
        {
            jquerySelectDropdown3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Junit Tutorial Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickJunitTutorialLink()
        {
            junitTutorial.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Jxl Tutorial Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickJxlTutorialLink()
        {
            jxlTutorial.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on List Box Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickListBox1Link()
        {
            listBox1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on List Box Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickListBox2Link()
        {
            listBox2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Maven Tutorial Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickMavenTutorialLink()
        {
            mavenTutorial.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Next Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickNextLink()
        {
            next.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Others Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickOthers1Link()
        {
            others1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Others Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickOthers2Link()
        {
            others2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Page Factory Pattern Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickPageFactoryPatternLink()
        {
            pageFactoryPattern.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Previous Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickPreviousLink()
        {
            previous.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Proceed Next Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickProceedNext1Link()
        {
            proceedNext1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Proceed Next Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickProceedNext2Link()
        {
            proceedNext2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Proceed Next Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickProceedNext3Link()
        {
            proceedNext3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Progress Bar Modal Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickProgressBarModal1Link()
        {
            progressBarModal1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Progress Bar Modal Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickProgressBarModal2Link()
        {
            progressBarModal2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Progress Bar Modal Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickProgressBarModal3Link()
        {
            progressBarModal3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Progress Bars Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickProgressBarsLink()
        {
            progressBars.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Progress Bars Sliders Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickProgressBarsSlidersLink()
        {
            progressBarsSliders.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Radio Buttons Demo Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickRadioButtonsDemo1Link()
        {
            radioButtonsDemo1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Radio Buttons Demo Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickRadioButtonsDemo2Link()
        {
            radioButtonsDemo2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Radio Buttons Demo Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickRadioButtonsDemo3Link()
        {
            radioButtonsDemo3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Select Dropdown List Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickSelectDropdownList1Link()
        {
            selectDropdownList1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Select Dropdown List Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickSelectDropdownList2Link()
        {
            selectDropdownList2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Select Dropdown List Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickSelectDropdownList3Link()
        {
            selectDropdownList3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Selenium Easy Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickSeleniumEasyLink()
        {
            seleniumEasy.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Selenium Tutorials Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickSeleniumTutorialsLink()
        {
            seleniumTutorials.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Simple Form Demo Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickSimpleFormDemo1Link()
        {
            simpleFormDemo1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Simple Form Demo Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickSimpleFormDemo2Link()
        {
            simpleFormDemo2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Simple Form Demo Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickSimpleFormDemo3Link()
        {
            simpleFormDemo3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Start Practising Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickStartPractisingLink()
        {
            startPractising.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Table Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickTable1Link()
        {
            table1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Table Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickTable2Link()
        {
            table2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Table Data Download Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickTableDataDownload1Link()
        {
            tableDataDownload1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Table Data Download Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickTableDataDownload2Link()
        {
            tableDataDownload2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Table Data Download Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickTableDataDownload3Link()
        {
            tableDataDownload3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Table Data Search Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickTableDataSearch1Link()
        {
            tableDataSearch1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Table Data Search Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickTableDataSearch2Link()
        {
            tableDataSearch2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Table Data Search Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickTableDataSearch3Link()
        {
            tableDataSearch3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Table Filter Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickTableFilter1Link()
        {
            tableFilter1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Table Filter Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickTableFilter2Link()
        {
            tableFilter2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Table Filter Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickTableFilter3Link()
        {
            tableFilter3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Table Pagination Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickTablePagination1Link()
        {
            tablePagination1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Table Pagination Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickTablePagination2Link()
        {
            tablePagination2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Table Pagination Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickTablePagination3Link()
        {
            tablePagination3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Table Sort Search Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickTableSortSearch1Link()
        {
            tableSortSearch1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Table Sort Search Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickTableSortSearch2Link()
        {
            tableSortSearch2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Table Sort Search Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickTableSortSearch3Link()
        {
            tableSortSearch3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Testng Custom Report Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickTestngCustomReportLink()
        {
            testngCustomReport.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Testng Tutorial Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickTestngTutorialLink()
        {
            testngTutorial.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Toggle Navigation Button.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickToggleNavigationButton()
        {
            toggleNavigation.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on View All Selenium Tutorials Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickViewAllSeleniumTutorialsLink()
        {
            viewAllSeleniumTutorials.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Window Popup Modal Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickWindowPopupModal1Link()
        {
            windowPopupModal1.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Window Popup Modal Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickWindowPopupModal2Link()
        {
            windowPopupModal2.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Click on Window Popup Modal Link.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige ClickWindowPopupModal3Link()
        {
            windowPopupModal3.ClickWrapper(driver, extentReportsHelper, "Clicked on Element");
            return this;
        }

        /// <summary>
        /// Submit the form to target page.
        /// </summary>
        /// <returns>The this class instance.</returns>
        public mPaige Submit()
        {
            //ClickInputFormWithValidationsLink
            return this;
        }

        /// <summary>
        /// Verify that the page loaded completely.
        /// </summary>
        /// <returns>The this class instance.</returns>
        //public Status VerifyPageLoaded()
        //{
        //    new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until<bool>((d) =>
        //    {
        //        status.CustomMessage =   d.PageSource.   //d.PageSource.Contains(pageLoadedText);
        //    });
        //    return status;
        //}

        /// <summary>
        /// Verify that current page URL matches the expected URL.
        /// </summary>
        /// <returns>The Status class instance.</returns>
        //public Status VerifyPageUrl()
        //{
        //    new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until<bool>((d) =>
        //    {
        //        return d.Url.Contains(pageUrl);
        //    });
        //    return status;
        //}
        #endregion
    }

}
