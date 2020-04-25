using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

public class BasicForm
{
    //private Dictionary<string, string> data;
    private IWebDriver driver;
    private string url = "https://www.seleniumeasy.com/test/";

    #region Selectors

    [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(6) a")]
    [CacheLookup]
    private IWebElement ajaxFormSubmit1;

    [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(1) ul li:nth-of-type(6) a")]
    [CacheLookup]
    private IWebElement ajaxFormSubmit2;

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

    [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(2) ul.dropdown-menu li:nth-of-type(1) a")]
    [CacheLookup]
    private IWebElement bootstrapDatePicker1;

    [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(2) ul li:nth-of-type(1) a")]
    [CacheLookup]
    private IWebElement bootstrapDatePicker2;

    [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(3) ul.dropdown-menu li:nth-of-type(1) a")]
    [CacheLookup]
    private IWebElement bootstrapListBox1;

    [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(6) ul li:nth-of-type(1) a")]
    [CacheLookup]
    private IWebElement bootstrapListBox2;

    [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(2) ul.dropdown-menu li:nth-of-type(2) a")]
    [CacheLookup]
    private IWebElement bootstrapModals1;

    [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(5) ul li:nth-of-type(2) a")]
    [CacheLookup]
    private IWebElement bootstrapModals2;

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

    [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(3) a")]
    [CacheLookup]
    private IWebElement dragDropSliders1;

    [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(4) ul li:nth-of-type(3) a")]
    [CacheLookup]
    private IWebElement dragDropSliders2;

    [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(4) ul.dropdown-menu li:nth-of-type(2) a")]
    [CacheLookup]
    private IWebElement dynamicDataLoading1;

    [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(7) ul li:nth-of-type(2) a")]
    [CacheLookup]
    private IWebElement dynamicDataLoading2;

    [FindsBy(How = How.Id, Using = "sum1")]
    [CacheLookup]
    private IWebElement enterA;

    [FindsBy(How = How.Id, Using = "sum2")]
    [CacheLookup]
    private IWebElement enterB;

    [FindsBy(How = How.Id, Using = "user-message")]
    [CacheLookup]
    private IWebElement enterMessage;

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

    [FindsBy(How = How.CssSelector, Using = "a[href='../selenium-tutorials/launching-firefox-browser-with-geckodriver-selenium-3']")]
    [CacheLookup]
    private IWebElement geckoDriverSelenium3;

    [FindsBy(How = How.CssSelector, Using = "#gettotal button.btn.btn-default")]
    [CacheLookup]
    private IWebElement getTotal;

    [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(5) a")]
    [CacheLookup]
    private IWebElement inputFormSubmit1;

    [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(1) ul li:nth-of-type(5) a")]
    [CacheLookup]
    private IWebElement inputFormSubmit2;

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

    [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(3) ul.dropdown-menu li:nth-of-type(2) a")]
    [CacheLookup]
    private IWebElement jqueryListBox1;

    [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(6) ul li:nth-of-type(2) a")]
    [CacheLookup]
    private IWebElement jqueryListBox2;

    [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(7) a")]
    [CacheLookup]
    private IWebElement jquerySelectDropdown1;

    [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(1) ul li:nth-of-type(7) a")]
    [CacheLookup]
    private IWebElement jquerySelectDropdown2;

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

    [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(4) a.dropdown-toggle")]
    [CacheLookup]
    private IWebElement others1;

    [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(7) a")]
    [CacheLookup]
    private IWebElement others2;

    [FindsBy(How = How.CssSelector, Using = "a[href='../selenium-tutorials/page-factory-pattern-in-selenium-webdriver']")]
    [CacheLookup]
    private IWebElement pageFactoryPattern;

    private readonly string pageLoadedText = "First Let us try with Two input fields and a Button";

    private readonly string pageUrl = "/test/basic-first-form-demo.html";

    [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(2) li:nth-of-type(2) ul.dropdown-menu li:nth-of-type(4) a")]
    [CacheLookup]
    private IWebElement progressBarModal1;

    [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(5) ul li:nth-of-type(4) a")]
    [CacheLookup]
    private IWebElement progressBarModal2;

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

    [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(4) a")]
    [CacheLookup]
    private IWebElement selectDropdownList1;

    [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(1) ul li:nth-of-type(4) a")]
    [CacheLookup]
    private IWebElement selectDropdownList2;

    [FindsBy(How = How.CssSelector, Using = "#site-name a")]
    [CacheLookup]
    private IWebElement seleniumEasy;

    [FindsBy(How = How.CssSelector, Using = "a[href='../selenium-tutorials']")]
    [CacheLookup]
    private IWebElement seleniumTutorials;

    [FindsBy(How = How.CssSelector, Using = "#get-input button.btn.btn-default")]
    [CacheLookup]
    private IWebElement showMessage;

    [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(1) ul.dropdown-menu li:nth-of-type(1) a")]
    [CacheLookup]
    private IWebElement simpleFormDemo1;

    [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(1) ul li:nth-of-type(1) a")]
    [CacheLookup]
    private IWebElement simpleFormDemo2;

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

    [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(3) ul.dropdown-menu li:nth-of-type(2) a")]
    [CacheLookup]
    private IWebElement tableDataSearch1;

    [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(3) ul li:nth-of-type(2) a")]
    [CacheLookup]
    private IWebElement tableDataSearch2;

    [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(3) ul.dropdown-menu li:nth-of-type(3) a")]
    [CacheLookup]
    private IWebElement tableFilter1;

    [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(3) ul li:nth-of-type(3) a")]
    [CacheLookup]
    private IWebElement tableFilter2;

    [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(3) ul.dropdown-menu li:nth-of-type(1) a")]
    [CacheLookup]
    private IWebElement tablePagination1;

    [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(3) ul li:nth-of-type(1) a")]
    [CacheLookup]
    private IWebElement tablePagination2;

    [FindsBy(How = How.CssSelector, Using = "#navbar-brand-centered ul:nth-of-type(1) li:nth-of-type(3) ul.dropdown-menu li:nth-of-type(4) a")]
    [CacheLookup]
    private IWebElement tableSortSearch1;

    [FindsBy(How = How.CssSelector, Using = "#treemenu li.tree-branch ul li:nth-of-type(3) ul li:nth-of-type(4) a")]
    [CacheLookup]
    private IWebElement tableSortSearch2;

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
    #endregion

    #region Constructors
    public BasicForm()
    {
        this.driver = null;
    }

    public BasicForm(IWebDriver driver)
    {
        this.driver = driver;
        PageFactory.InitElements(driver, this);
    }
    public BasicForm Navigate()
    {
        this.driver.Url = url;
        this.driver.Navigate();
        return this;
    }
    public BasicForm initPage()
    {
        PageFactory.InitElements(this.driver, this);
        return this;
    }
    #endregion

    #region operations

    /// <summary>
    /// Click on Ajax Form Submit Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickAjaxFormSubmit1Link() 
    {
        ajaxFormSubmit1.Click();
        return this;
    }

    /// <summary>
    /// Click on Ajax Form Submit Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickAjaxFormSubmit2Link() 
    {
        ajaxFormSubmit2.Click();
        return this;
    }

    /// <summary>
    /// Click on Alerts Modals Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickAlertsModals1Link() 
    {
        alertsModals1.Click();
        return this;
    }

    /// <summary>
    /// Click on Alerts Modals Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickAlertsModals2Link() 
    {
        alertsModals2.Click();
        return this;
    }

    /// <summary>
    /// Click on All Examples Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickAllExamplesLink() 
    {
        allExamples.Click();
        return this;
    }

    /// <summary>
    /// Click on Ant Tutorial Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickAntTutorialLink() 
    {
        antTutorial.Click();
        return this;
    }

    /// <summary>
    /// Click on Apache Poi Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickApachePoiLink() 
    {
        apachePoi.Click();
        return this;
    }

    /// <summary>
    /// Click on Bootstrap Alerts Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickBootstrapAlerts1Link() 
    {
        bootstrapAlerts1.Click();
        return this;
    }

    /// <summary>
    /// Click on Bootstrap Alerts Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickBootstrapAlerts2Link() 
    {
        bootstrapAlerts2.Click();
        return this;
    }

    /// <summary>
    /// Click on Bootstrap Date Picker Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickBootstrapDatePicker1Link() 
    {
        bootstrapDatePicker1.Click();
        return this;
    }

    /// <summary>
    /// Click on Bootstrap Date Picker Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickBootstrapDatePicker2Link() 
    {
        bootstrapDatePicker2.Click();
        return this;
    }

    /// <summary>
    /// Click on Bootstrap List Box Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickBootstrapListBox1Link() 
    {
        bootstrapListBox1.Click();
        return this;
    }

    /// <summary>
    /// Click on Bootstrap List Box Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickBootstrapListBox2Link() 
    {
        bootstrapListBox2.Click();
        return this;
    }

    /// <summary>
    /// Click on Bootstrap Modals Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickBootstrapModals1Link() 
    {
        bootstrapModals1.Click();
        return this;
    }

    /// <summary>
    /// Click on Bootstrap Modals Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickBootstrapModals2Link() 
    {
        bootstrapModals2.Click();
        return this;
    }

    /// <summary>
    /// Click on Bootstrap Progress Bar Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickBootstrapProgressBar1Link() 
    {
        bootstrapProgressBar1.Click();
        return this;
    }

    /// <summary>
    /// Click on Bootstrap Progress Bar Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickBootstrapProgressBar2Link() 
    {
        bootstrapProgressBar2.Click();
        return this;
    }

    /// <summary>
    /// Click on Charts Demo Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickChartsDemo1Link() 
    {
        chartsDemo1.Click();
        return this;
    }

    /// <summary>
    /// Click on Charts Demo Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickChartsDemo2Link() 
    {
        chartsDemo2.Click();
        return this;
    }

    /// <summary>
    /// Click on Checkbox Demo Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickCheckboxDemo1Link() 
    {
        checkboxDemo1.Click();
        return this;
    }

    /// <summary>
    /// Click on Checkbox Demo Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickCheckboxDemo2Link() 
    {
        checkboxDemo2.Click();
        return this;
    }

    /// <summary>
    /// Click on Data List Filter Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickDataListFilter1Link() 
    {
        dataListFilter1.Click();
        return this;
    }

    /// <summary>
    /// Click on Data List Filter Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickDataListFilter2Link() 
    {
        dataListFilter2.Click();
        return this;
    }

    /// <summary>
    /// Click on Date Pickers Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickDatePickers1Link() 
    {
        datePickers1.Click();
        return this;
    }

    /// <summary>
    /// Click on Date Pickers Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickDatePickers2Link() 
    {
        datePickers2.Click();
        return this;
    }

    /// <summary>
    /// Click on Demo Home Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickDemoHomeLink() 
    {
        demoHome.Click();
        return this;
    }

    /// <summary>
    /// Click on Drag And Drop Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickDragAndDrop1Link() 
    {
        dragAndDrop1.Click();
        return this;
    }

    /// <summary>
    /// Click on Drag And Drop Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickDragAndDrop2Link() 
    {
        dragAndDrop2.Click();
        return this;
    }

    /// <summary>
    /// Click on Drag Drop Sliders Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickDragDropSliders1Link() 
    {
        dragDropSliders1.Click();
        return this;
    }

    /// <summary>
    /// Click on Drag Drop Sliders Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickDragDropSliders2Link() 
    {
        dragDropSliders2.Click();
        return this;
    }

    /// <summary>
    /// Click on Dynamic Data Loading Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickDynamicDataLoading1Link() 
    {
        dynamicDataLoading1.Click();
        return this;
    }

    /// <summary>
    /// Click on Dynamic Data Loading Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickDynamicDataLoading2Link() 
    {
        dynamicDataLoading2.Click();
        return this;
    }

    /// <summary>
    /// Click on Execute Selenium Tests Using Maven Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickExecuteSeleniumTestsUsingMavenLink() 
    {
        executeSeleniumTestsUsingMaven.Click();
        return this;
    }

    /// <summary>
    /// Click on Execute Tests In Jenkins Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickExecuteTestsInJenkinsLink() 
    {
        executeTestsInJenkins.Click();
        return this;
    }

    /// <summary>
    /// Click on File Download Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickFileDownload1Link() 
    {
        fileDownload1.Click();
        return this;
    }

    /// <summary>
    /// Click on File Download Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickFileDownload2Link() 
    {
        fileDownload2.Click();
        return this;
    }

    /// <summary>
    /// Click on Gecko Driver Selenium 3 Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickGeckoDriverSelenium3Link() 
    {
        geckoDriverSelenium3.Click();
        return this;
    }

    /// <summary>
    /// Click on Get Total Button.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickGetTotalButton() 
    {
        getTotal.Click();
        return this;
    }

    /// <summary>
    /// Click on Input Form Submit Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickInputFormSubmit1Link() 
    {
        inputFormSubmit1.Click();
        return this;
    }

    /// <summary>
    /// Click on Input Form Submit Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickInputFormSubmit2Link() 
    {
        inputFormSubmit2.Click();
        return this;
    }

    /// <summary>
    /// Click on Input Forms Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickInputForms1Link() 
    {
        inputForms1.Click();
        return this;
    }

    /// <summary>
    /// Click on Input Forms Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickInputForms2Link() 
    {
        inputForms2.Click();
        return this;
    }

    /// <summary>
    /// Click on Javascript Alerts Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickJavascriptAlerts1Link() 
    {
        javascriptAlerts1.Click();
        return this;
    }

    /// <summary>
    /// Click on Javascript Alerts Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickJavascriptAlerts2Link() 
    {
        javascriptAlerts2.Click();
        return this;
    }

    /// <summary>
    /// Click on Jquery Date Picker Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickJqueryDatePicker1Link() 
    {
        jqueryDatePicker1.Click();
        return this;
    }

    /// <summary>
    /// Click on Jquery Date Picker Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickJqueryDatePicker2Link() 
    {
        jqueryDatePicker2.Click();
        return this;
    }

    /// <summary>
    /// Click on Jquery Download Progress Bars Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickJqueryDownloadProgressBars1Link() 
    {
        jqueryDownloadProgressBars1.Click();
        return this;
    }

    /// <summary>
    /// Click on Jquery Download Progress Bars Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickJqueryDownloadProgressBars2Link() 
    {
        jqueryDownloadProgressBars2.Click();
        return this;
    }

    /// <summary>
    /// Click on Jquery List Box Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickJqueryListBox1Link() 
    {
        jqueryListBox1.Click();
        return this;
    }

    /// <summary>
    /// Click on Jquery List Box Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickJqueryListBox2Link() 
    {
        jqueryListBox2.Click();
        return this;
    }

    /// <summary>
    /// Click on Jquery Select Dropdown Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickJquerySelectDropdown1Link() 
    {
        jquerySelectDropdown1.Click();
        return this;
    }

    /// <summary>
    /// Click on Jquery Select Dropdown Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickJquerySelectDropdown2Link() 
    {
        jquerySelectDropdown2.Click();
        return this;
    }

    /// <summary>
    /// Click on Junit Tutorial Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickJunitTutorialLink() 
    {
        junitTutorial.Click();
        return this;
    }

    /// <summary>
    /// Click on Jxl Tutorial Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickJxlTutorialLink() 
    {
        jxlTutorial.Click();
        return this;
    }

    /// <summary>
    /// Click on List Box Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickListBox1Link() 
    {
        listBox1.Click();
        return this;
    }

    /// <summary>
    /// Click on List Box Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickListBox2Link() 
    {
        listBox2.Click();
        return this;
    }

    /// <summary>
    /// Click on Maven Tutorial Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickMavenTutorialLink() 
    {
        mavenTutorial.Click();
        return this;
    }

    /// <summary>
    /// Click on Others Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickOthers1Link() 
    {
        others1.Click();
        return this;
    }

    /// <summary>
    /// Click on Others Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickOthers2Link() 
    {
        others2.Click();
        return this;
    }

    /// <summary>
    /// Click on Page Factory Pattern Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickPageFactoryPatternLink() 
    {
        pageFactoryPattern.Click();
        return this;
    }

    /// <summary>
    /// Click on Progress Bar Modal Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickProgressBarModal1Link() 
    {
        progressBarModal1.Click();
        return this;
    }

    /// <summary>
    /// Click on Progress Bar Modal Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickProgressBarModal2Link() 
    {
        progressBarModal2.Click();
        return this;
    }

    /// <summary>
    /// Click on Progress Bars Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickProgressBarsLink() 
    {
        progressBars.Click();
        return this;
    }

    /// <summary>
    /// Click on Progress Bars Sliders Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickProgressBarsSlidersLink() 
    {
        progressBarsSliders.Click();
        return this;
    }

    /// <summary>
    /// Click on Radio Buttons Demo Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickRadioButtonsDemo1Link() 
    {
        radioButtonsDemo1.Click();
        return this;
    }

    /// <summary>
    /// Click on Radio Buttons Demo Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickRadioButtonsDemo2Link() 
    {
        radioButtonsDemo2.Click();
        return this;
    }

    /// <summary>
    /// Click on Select Dropdown List Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickSelectDropdownList1Link() 
    {
        selectDropdownList1.Click();
        return this;
    }

    /// <summary>
    /// Click on Select Dropdown List Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickSelectDropdownList2Link() 
    {
        selectDropdownList2.Click();
        return this;
    }

    /// <summary>
    /// Click on Selenium Easy Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickSeleniumEasyLink() 
    {
        seleniumEasy.Click();
        return this;
    }

    /// <summary>
    /// Click on Selenium Tutorials Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickSeleniumTutorialsLink() 
    {
        seleniumTutorials.Click();
        return this;
    }

    /// <summary>
    /// Click on Show Message Button.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickShowMessageButton() 
    {
        showMessage.Click();
        return this;
    }

    /// <summary>
    /// Click on Simple Form Demo Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickSimpleFormDemo1Link() 
    {
        simpleFormDemo1.Click();
        return this;
    }

    /// <summary>
    /// Click on Simple Form Demo Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickSimpleFormDemo2Link() 
    {
        simpleFormDemo2.Click();
        return this;
    }

    /// <summary>
    /// Click on Table Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickTable1Link() 
    {
        table1.Click();
        return this;
    }

    /// <summary>
    /// Click on Table Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickTable2Link() 
    {
        table2.Click();
        return this;
    }

    /// <summary>
    /// Click on Table Data Download Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickTableDataDownload1Link() 
    {
        tableDataDownload1.Click();
        return this;
    }

    /// <summary>
    /// Click on Table Data Download Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickTableDataDownload2Link() 
    {
        tableDataDownload2.Click();
        return this;
    }

    /// <summary>
    /// Click on Table Data Search Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickTableDataSearch1Link() 
    {
        tableDataSearch1.Click();
        return this;
    }

    /// <summary>
    /// Click on Table Data Search Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickTableDataSearch2Link() 
    {
        tableDataSearch2.Click();
        return this;
    }

    /// <summary>
    /// Click on Table Filter Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickTableFilter1Link() 
    {
        tableFilter1.Click();
        return this;
    }

    /// <summary>
    /// Click on Table Filter Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickTableFilter2Link() 
    {
        tableFilter2.Click();
        return this;
    }

    /// <summary>
    /// Click on Table Pagination Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickTablePagination1Link() 
    {
        tablePagination1.Click();
        return this;
    }

    /// <summary>
    /// Click on Table Pagination Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickTablePagination2Link() 
    {
        tablePagination2.Click();
        return this;
    }

    /// <summary>
    /// Click on Table Sort Search Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickTableSortSearch1Link() 
    {
        tableSortSearch1.Click();
        return this;
    }

    /// <summary>
    /// Click on Table Sort Search Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickTableSortSearch2Link() 
    {
        tableSortSearch2.Click();
        return this;
    }

    /// <summary>
    /// Click on Testng Custom Report Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickTestngCustomReportLink() 
    {
        testngCustomReport.Click();
        return this;
    }

    /// <summary>
    /// Click on Testng Tutorial Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickTestngTutorialLink() 
    {
        testngTutorial.Click();
        return this;
    }

    /// <summary>
    /// Click on Toggle Navigation Button.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickToggleNavigationButton() 
    {
        toggleNavigation.Click();
        return this;
    }

    /// <summary>
    /// Click on View All Selenium Tutorials Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickViewAllSeleniumTutorialsLink() 
    {
        viewAllSeleniumTutorials.Click();
        return this;
    }

    /// <summary>
    /// Click on Window Popup Modal Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickWindowPopupModal1Link() 
    {
        windowPopupModal1.Click();
        return this;
    }

    /// <summary>
    /// Click on Window Popup Modal Link.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm ClickWindowPopupModal2Link() 
    {
        windowPopupModal2.Click();
        return this;
    }

    /// <summary>
    /// Fill every fields in the page.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm Fill() 
    {
        SetEnterMessageTextField();
        SetEnterATextField();
        SetEnterBTextField();
        return this;
    }

    /// <summary>
    /// Fill every fields in the page and submit it to target page.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm FillAndSubmit() 
    {
        Fill();
        return Submit();
    }

    /// <summary>
    /// Set default value to Enter A Text field.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm SetEnterATextField() 
    {
        SetEnterATextField("ENTER_A");
        return this;
    }

    /// <summary>
    /// Set value to Enter A Text field.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm SetEnterATextField(string enterAValue)
    {
        enterA.SendKeys(enterAValue);
        return this;
    }

    /// <summary>
    /// Set default value to Enter B Text field.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm SetEnterBTextField() 
    {
        SetEnterBTextField("ENTER_B");
        return this;
    }

    /// <summary>
    /// Set value to Enter B Text field.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm SetEnterBTextField(string enterBValue)
    {
        enterB.SendKeys(enterBValue);
        return this;
    }

    /// <summary>
    /// Set default value to Enter Message Text field.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm SetEnterMessageTextField() 
    {
       SetEnterMessageTextField("ENTER_MESSAGE");
        return this;
    }

    /// <summary>
    /// Set value to Enter Message Text field.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm SetEnterMessageTextField(string enterMessageValue)
    {
        enterMessage.SendKeys(enterMessageValue);
        return this;
    }

    /// <summary>
    /// Submit the form to target page.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm Submit() 
    {
        showMessage.Click();
        return this;
    }

    /// <summary>
    /// Verify that the page loaded completely.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm VerifyPageLoaded() 
    {
        //new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until<bool>((d) =>
        {
            //return d.PageSource.Contains(pageLoadedText);
            return this;
        }
       
    }

    /// <summary>
    /// Verify that current page URL matches the expected URL.
    /// </summary>
    /// <returns>The BasicForm class instance.</returns>
    public BasicForm VerifyPageUrl() 
    {
        //new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until<bool>((d) =>
        {
            // return d.Url.Contains(pageUrl);
            return this;
        }
        
    }
    #endregion
}
