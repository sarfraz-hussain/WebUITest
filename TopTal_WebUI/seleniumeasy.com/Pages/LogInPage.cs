using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Report.Extent;
using Return.Status;
using System;
using System.Collections.Generic;

public class LogInPage
{
    private Dictionary<string, string> data;
    private IWebDriver driver;
    private int timeout = 15;

    public Status status = new Status(false);
    private ExtentReportsHelper extentReportsHelper;

    public readonly string title = "TinEye.com - Login";
    public readonly string pageURL = "https://tineye.com/login";

    [FindsBy(How = How.Id, Using = "about")]
    [CacheLookup]
    private IWebElement about1;

    [FindsBy(How = How.CssSelector, Using = "#mobile-menu ul li:nth-of-type(4) a")]
    [CacheLookup]
    private IWebElement about2;

    [FindsBy(How = How.CssSelector, Using = "a[href='/register']")]
    [CacheLookup]
    private IWebElement createOneForFree;

    [FindsBy(How = How.Id, Using = "email")]
    [CacheLookup]
    public IWebElement Email;

    [FindsBy(How = How.Id, Using = "rememberme")]
    [CacheLookup]
    private IWebElement keepMeLoggedIn;

    [FindsBy(How = How.CssSelector, Using = "#mobile-menu ul li:nth-of-type(5) a")]
    [CacheLookup]
    private IWebElement logIn1;

    [FindsBy(How = How.CssSelector, Using = "header div.container div.row div.col-md-12 div:nth-of-type(3) a")]
    [CacheLookup]
    private IWebElement logIn2;

    [FindsBy(How = How.Id, Using = "login")]
    [CacheLookup]
    public IWebElement LogIn;

    private readonly string pageLoadedText = "If you don't have a";

    private readonly string pageUrl = "/login";

    [FindsBy(How = How.Id, Using = "password")]
    [CacheLookup]
    public IWebElement Password;

    [FindsBy(How = How.Id, Using = "products")]
    [CacheLookup]
    private IWebElement products1;

    [FindsBy(How = How.CssSelector, Using = "#mobile-menu ul li:nth-of-type(3) a")]
    [CacheLookup]
    private IWebElement products2;

    [FindsBy(How = How.CssSelector, Using = "a.reset")]
    [CacheLookup]
    private IWebElement resetYourPassword;

    [FindsBy(How = How.Id, Using = "search")]
    [CacheLookup]
    private IWebElement search1;

    [FindsBy(How = How.CssSelector, Using = "#mobile-menu ul li:nth-of-type(1) a")]
    [CacheLookup]
    private IWebElement search2;

    [FindsBy(How = How.CssSelector, Using = "a.toggle-pass")]
    [CacheLookup]
    private IWebElement showPassword;

    [FindsBy(How = How.CssSelector, Using = "a[href='https://services.tineye.com/support']")]
    [CacheLookup]
    private IWebElement support;

    [FindsBy(How = How.Id, Using = "technology")]
    [CacheLookup]
    private IWebElement technology1;

    [FindsBy(How = How.CssSelector, Using = "#mobile-menu ul li:nth-of-type(2) a")]
    [CacheLookup]
    private IWebElement technology2;

    [FindsBy(How = How.CssSelector, Using = "header div.container div.row div.col-md-12 h1 a")]
    [CacheLookup]
    private IWebElement tineye1;

    [FindsBy(How = How.CssSelector, Using = "div.container.login div:nth-of-type(3) div.col-sm-10.col-sm-offset-1.col-md-8.col-md-offset-2.col-lg-6.col-lg-offset-3 p.center a:nth-of-type(1)")]
    [CacheLookup]
    private IWebElement tineye2;

    public LogInPage(IWebDriver driver, ExtentReportsHelper reportsHelper)
    {
        this.driver = driver;
        extentReportsHelper = reportsHelper;
    }

    public LogInPage()
        : this(default(IWebDriver), new Dictionary<string, string>(), 15)
    {
    }

    public LogInPage(IWebDriver driver)
        : this(driver, new Dictionary<string, string>(), 15)
    {
    }

    public LogInPage(IWebDriver driver, Dictionary<string, string> data)
        : this(driver, data, 15)
    {
    }

    public LogInPage(IWebDriver driver, Dictionary<string, string> data, int timeout)
    {
        this.driver = driver;
        this.data = data;
        this.timeout = timeout;
    }

    /// <summary>
    /// Click on About Link.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage ClickAbout1Link() 
    {
        about1.Click();
        return this;
    }

    /// <summary>
    /// Click on About Link.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage ClickAbout2Link() 
    {
        about2.Click();
        return this;
    }

    /// <summary>
    /// Click on Create One For Free Link.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage ClickCreateOneForFreeLink() 
    {
        createOneForFree.Click();
        return this;
    }

    /// <summary>
    /// Click on Log In Link.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage ClickLogIn1Link() 
    {
        logIn1.Click();
        return this;
    }

    /// <summary>
    /// Click on Log In Link.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage ClickLogIn2Link() 
    {
        logIn2.Click();
        return this;
    }

    /// <summary>
    /// Click on Log In Button.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage ClickLogIn3Button() 
    {
        LogIn.Click();
        return this;
    }

    /// <summary>
    /// Click on Products Link.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage ClickProducts1Link() 
    {
        products1.Click();
        return this;
    }

    /// <summary>
    /// Click on Products Link.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage ClickProducts2Link() 
    {
        products2.Click();
        return this;
    }

    /// <summary>
    /// Click on Reset Your Password Link.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage ClickResetYourPasswordLink() 
    {
        resetYourPassword.Click();
        return this;
    }

    /// <summary>
    /// Click on Search Link.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage ClickSearch1Link() 
    {
        search1.Click();
        return this;
    }

    /// <summary>
    /// Click on Search Link.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage ClickSearch2Link() 
    {
        search2.Click();
        return this;
    }

    /// <summary>
    /// Click on Show Password Link.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage ClickShowPasswordLink() 
    {
        showPassword.Click();
        return this;
    }

    /// <summary>
    /// Click on Support Link.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage ClickSupportLink() 
    {
        support.Click();
        return this;
    }

    /// <summary>
    /// Click on Technology Link.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage ClickTechnology1Link() 
    {
        technology1.Click();
        return this;
    }

    /// <summary>
    /// Click on Technology Link.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage ClickTechnology2Link() 
    {
        technology2.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Link.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage ClickTineye1Link() 
    {
        tineye1.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Link.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage ClickTineye2Link() 
    {
        tineye2.Click();
        return this;
    }

    /// <summary>
    /// Fill every fields in the page.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage Fill() 
    {
        SetEmailTextField();
        SetPasswordPasswordField();
        SetKeepMeLoggedInCheckboxField();
        return this;
    }

    /// <summary>
    /// Set default value to Email Text field.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage SetEmailTextField() 
    {
        return SetEmailTextField(data["EMAIL"]);
    }

    /// <summary>
    /// Set value to Email Text field.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage SetEmailTextField(string emailValue)
    {
        Email.SendKeys(emailValue);
        return this;
    }

    /// <summary>
    /// Set Keep Me Logged In Checkbox field.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage SetKeepMeLoggedInCheckboxField() 
    {
        if (!keepMeLoggedIn.Selected) {
            keepMeLoggedIn.Click();
        }
        return this;
    }

    /// <summary>
    /// Set default value to Password Password field.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage SetPasswordPasswordField() 
    {
        return SetPasswordPasswordField(data["PASSWORD"]);
    }

    /// <summary>
    /// Set value to Password Password field.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage SetPasswordPasswordField(string passwordValue)
    {
        Password.SendKeys(passwordValue);
        return this;
    }

    /// <summary>
    /// Unset Keep Me Logged In Checkbox field.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage UnsetKeepMeLoggedInCheckboxField() 
    {
        if (keepMeLoggedIn.Selected) {
            keepMeLoggedIn.Click();
        }
        return this;
    }

    /// <summary>
    /// Verify that the page loaded completely.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    //public LogInPage VerifyPageLoaded() 
    //{
    //    new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until<bool>((d) =>
    //    {
    //        return d.PageSource.Contains(pageLoadedText);
    //    });
    //    return this;
    //}

    /// <summary>
    /// Verify that current page URL matches the expected URL.
    /// </summary>
    /// <returns>The LogInPage class instance.</returns>
    public LogInPage VerifyPageUrl() 
    {
        new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until<bool>((d) =>
        {
            return d.Url.Contains(pageUrl);
        });
        return this;
    }

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
            status.ReturnedMessage = "Page not Navigated";
            return this;

        }
    }

    public LogInPage VerifyPageLoaded()
    {
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
        try
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(LogIn));
        }
        catch (Exception e)
        {
            extentReportsHelper.SetTestStatusFail($"Page URL [{driver.Url}] not Loaded");
            status.ErrorOccurred = true;
            status.ReturnedMessage = "Page Not Loaded";
            return this;
        }
        extentReportsHelper.SetStepStatusPass($"Page URL [{driver.Url}] loaded successfully.");
        status.ErrorOccurred = false;
        status.ReturnedMessage = "Page Loaded Successfuly";
        return this;

    }

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
            status.ReturnedMessage = "Page title Not Verified";
            return this;
        }


    }

    public LogInPage VerifyPageElements(IWebElement element)
    {

        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
        try
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }
        catch (Exception e)
        {
            extentReportsHelper.SetTestStatusFail($"Web Element {element.Text} not Located or not Clickable");
            status.ErrorOccurred = true;
            status.ReturnedMessage = "Element not located";
            return this;
        }
        extentReportsHelper.SetStepStatusPass($"Web Element {element.Text} Located and is Clickable");
        status.ErrorOccurred = false;
        status.ReturnedMessage = "Page Loaded Successfuly";
        return this;

    }

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
            status.ReturnedMessage = "LogIn operation failed";
            return this;
        }


    }

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
                status.ReturnedMessage = "Abnormal Behaviour";
                return this;
        }

    }
}
