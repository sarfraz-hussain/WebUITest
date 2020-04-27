using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Report.Extent;
using Return.Status;
using System;
using System.Collections.Generic;

public class SearchPage
{
    #region Declaration
    private Dictionary<string, string> data;
    private IWebDriver driver;
    private int timeout = 15;
    public Status status = new Status(false);
    private ExtentReportsHelper extentReportsHelper;
    public readonly string title =  "0 TinEye search results";
    public int PageLoadTimeOut = 60; //Seconds
    private readonly string pageLoadedText = "Your image may be unique, and doesn't appear anywhere on the web";
    #endregion

    #region Locators

    /// <summary>
    /// Auto Generated Locators, Selenium Page Object Generator ver. 1.3.1, is used
    /// </summary>

    [FindsBy(How = How.CssSelector, Using = "footer div.container div:nth-of-type(1) div:nth-of-type(2) div a:nth-of-type(1)")]
    [CacheLookup]
    private IWebElement imageSearch;

    #endregion

    #region Constructors

    public SearchPage()
        : this(default(IWebDriver), new Dictionary<string, string>(), 15)
    {
    }

    public SearchPage(IWebDriver driver, ExtentReportsHelper reportsHelper)
    {
        this.driver = driver;
        extentReportsHelper = reportsHelper;

    }

    public SearchPage(IWebDriver driver, Dictionary<string, string> data, int timeout)
    {
        this.driver = driver;
        this.data = data;
        this.timeout = timeout;
    }
    #endregion

    #region Operations

    /// <summary>
    /// Verify that the page loaded completely.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage VerifyPageLoaded()
    {
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(PageLoadTimeOut));
        try
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(imageSearch));
        }
        catch (Exception e)
        {
            extentReportsHelper.SetTestStatusFail($"Page URL [{driver.Url}] not Loaded");
            status.ErrorOccurred = true;
            status.ReturnedMessage = "Page Not Loaded" + e.Message;
            return this;
        }
        extentReportsHelper.SetStepStatusPass($"Page URL [{driver.Url}] loaded successfully.");
        status.ErrorOccurred = false;
        status.ReturnedMessage = "Page Loaded Successfuly";
        return this;

    }

    /// <summary>
    /// Verify that the Page Title
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage VerifyPageTitle()
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
    /// Verify that the Image result is as expected
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage verifySearchResults()
    {
        try
        {

            if (this.driver.PageSource.Contains(pageLoadedText))
            {
                extentReportsHelper.SetStepStatusPass($"Page Loaded, No such Imae Found");
                status.ErrorOccurred = false;
                status.ReturnedMessage = "No such image found";
                return this;
            }

            else
            {
                extentReportsHelper.SetTestStatusFail($"Page Loaded, relvent images found");
                status.ErrorOccurred = true;
                status.ReturnedMessage = "Images found";
                return this;
            }

        }
        catch (Exception e)
        {
            extentReportsHelper.SetTestStatusFail($"Page Loaded, relvent images found");
            status.ErrorOccurred = true;
            status.ReturnedMessage = "Images found" + e.Message;
            return this;
        }

    }

    #endregion
}
