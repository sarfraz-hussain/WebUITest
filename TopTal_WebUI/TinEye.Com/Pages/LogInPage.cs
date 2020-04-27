using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Report.Extent;
using Return.Status;
using System;
using System.Collections.Generic;

public class LogInPage
{
    #region Declaration
    private Dictionary<string, string> data;
    private IWebDriver driver;
    private int timeout = 15;
    public Status status = new Status(false);
    private ExtentReportsHelper extentReportsHelper;
    public readonly string title = "TinEye.com - Login";
    public readonly string pageURL = "https://tineye.com/login";
    public int PageLoadTimeOut = 60; //Seconds
    public int ElementLoadTimeOut = 30; //Seconds
    #endregion

    #region Locators

    /// <summary>
    /// Auto Generated Locators, Selenium Page Object Generator ver. 1.3.1, is used
    /// </summary>

    [FindsBy(How = How.Id, Using = "email")]
    [CacheLookup]
    public IWebElement Email;

    [FindsBy(How = How.Id, Using = "login")]
    [CacheLookup]
    public IWebElement LogIn;

    [FindsBy(How = How.Id, Using = "password")]
    [CacheLookup]
    public IWebElement Password;

    #endregion

    #region Constructors

    public LogInPage(IWebDriver driver, ExtentReportsHelper reportsHelper)
    {
        this.driver = driver;
        extentReportsHelper = reportsHelper;
    }

    public LogInPage()
        : this(default(IWebDriver), new Dictionary<string, string>(), 15)
    {
    }

    public LogInPage(IWebDriver driver, Dictionary<string, string> data, int timeout)
    {
        this.driver = driver;
        this.data = data;
        this.timeout = timeout;
    }

    #endregion

    #region Operations

    /// <summary>
    /// Open LogIn Web Page.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage OpenLogInPage()
    {
        try
        {
            this.driver.Url = pageURL;
            this.driver.Navigate();
            extentReportsHelper.SetStepStatusPass($"Browser navigated to the url [{driver.Url}].");
            status.ErrorOccurred = false;
            status.ReturnedMessage = "Page Navigated";
            return this;
        }
        catch (Exception e)
        {
            extentReportsHelper.SetTestStatusFail($"Browser Could not navigate to the url");
            status.ErrorOccurred = true;
            status.ReturnedMessage = "Page not Navigated" + e.Message;
            return this;

        }
    }

    /// <summary>
    /// To Verify Page is Loaded
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage VerifyPageLoaded()
    {
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(PageLoadTimeOut));
        try
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(LogIn));
        }
        catch (Exception e)
        {
            extentReportsHelper.SetTestStatusFail($"Page URL [{driver.Url}] not Loaded");
            status.ErrorOccurred = true;
            status.ReturnedMessage = "Page Not Loaded" +e.Message;
            return this;
        }
        extentReportsHelper.SetStepStatusPass($"Page URL [{driver.Url}] loaded successfully.");
        status.ErrorOccurred = false;
        status.ReturnedMessage = "Page Loaded Successfuly";
        return this;

    }

    /// <summary>
    /// To Verify Page Title
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage VerifyPageTitle()
    {
        try
        {
            if (this.driver.Title == title)
            {
                extentReportsHelper.SetStepStatusPass($"Page Title [{driver.Title}] Verified successfully.");
                status.ErrorOccurred = false;
                status.ReturnedMessage = "Page title Verified";
                return this;
            }

            else
            {
                extentReportsHelper.SetTestStatusFail($"Page Title [{driver.Title}] Not Verified.");
                status.ErrorOccurred = true;
                status.ReturnedMessage = "Page title Not Verified";
                return this;
            }

        }
        catch (Exception e)
        {
            extentReportsHelper.SetTestStatusFail($"Page Title [{driver.Title}] Not Verified.");
            status.ErrorOccurred = true;
            status.ReturnedMessage = "Page title Not Verified" + e.Message;
            return this;
        }


    }

    /// <summary>
    /// To verify elements on page
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage VerifyPageElements(IWebElement element)
    {

        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(ElementLoadTimeOut));
        try
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }
        catch (Exception e)
        {
            extentReportsHelper.SetTestStatusFail($"Web Element {element.Text} not Located or not Clickable");
            status.ErrorOccurred = true;
            status.ReturnedMessage = "Element not located" + e.Message;
            return this;
        }
        extentReportsHelper.SetStepStatusPass($"Web Element {element.Text} Located and is Clickable");
        status.ErrorOccurred = false;
        status.ReturnedMessage = "Page Loaded Successfuly";
        return this;

    }

    /// <summary>
    /// To perform LogIn Action
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage PerformLogIN(string UserName, string password )
    {
        try
        {
           
                Email.SendKeys(UserName);
                extentReportsHelper.SetStepStatusPass($"[{UserName}] Typed under Email.");
                Password.SendKeys(password);
                extentReportsHelper.SetStepStatusPass($"[{password}] Typed under Password.");
                LogIn.Click();
                extentReportsHelper.SetStepStatusPass($"LogIn Button is clicked");

                status.ErrorOccurred = false;
                status.ReturnedMessage = "All actions performed for LogIn";
                return this;
         


        }
        catch (Exception e)
        {
            extentReportsHelper.SetTestStatusFail($"LogIn operation failed.");
            status.ErrorOccurred = true;
            status.ReturnedMessage = "LogIn operation failed" + e.Message;
            return this;
        }


    }

    /// <summary>
    /// To verify Login error Message, caused by Failed Login attempt
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage verifyLogInErrorMessage()
    {
        try
        {
            String ErrorMessae = "The supplied email and/or password is incorrect.";
            if (this.driver.PageSource.Contains(ErrorMessae))
            {
                extentReportsHelper.SetStepStatusPass($"Login Attempt failed, 'The supplied email and/or password is incorrect'");
                status.ErrorOccurred = false;
                status.ReturnedMessage = "As expected";
                return this;
            }

            else
            {
                extentReportsHelper.SetTestStatusFail($"Failed LogIn Attempt  Message not verified");
                status.ErrorOccurred = true;
                status.ReturnedMessage = "Abnormal Behaviour";
                return this;
            }

        }
        catch (Exception e)
        {
                extentReportsHelper.SetTestStatusFail($"Failed LogIn Attempt  Message not verified");
                status.ErrorOccurred = true;
                status.ReturnedMessage = "Abnormal Behaviour" + e.Message;
                return this;
        }

    }
    #endregion
}
