using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using Report.Extent;
using Return.Status;
using System.IO;
using System.Reflection;

public class HomePage
{
    #region Declaration

    private Dictionary<string, string> data;
    private IWebDriver driver;
    private readonly int timeout = 15;
    public  Status status = new Status(false);
    private ExtentReportsHelper extentReportsHelper;
    public readonly string title = "TinEye Reverse Image Search";
    public  int PageLoadTimeOut = 60; //Seconds
    public  int ElementLoadTimeOut = 30; //Seconds

    #endregion

    #region Locators

    /// <summary>
    /// Auto Generated Locators, Selenium Page Object Generator ver. 1.3.1, is used
    /// </summary>

    [FindsBy(How = How.CssSelector, Using = "footer div.container div:nth-of-type(1) div:nth-of-type(2) div a:nth-of-type(1)")]
    [CacheLookup]
    private IWebElement imageSearch;

    [FindsBy(How = How.CssSelector, Using = "div:nth-of-type(1) header div.container div.row div.col-md-12 div:nth-of-type(2) a:nth-of-type(3)")]
    [CacheLookup]
    public IWebElement LogIn;

    [FindsBy(How = How.Id, Using = "products")]
    [CacheLookup]
    public IWebElement Products;

    [FindsBy(How = How.ClassName, Using = "submit-button")]
    [CacheLookup]
    public IWebElement Search;

    [FindsBy(How = How.Id, Using = "upload_box")]
    [CacheLookup]
    public IWebElement UploadImageFile;

    [FindsBy(How = How.Id, Using = "upload-button")]
    [CacheLookup]
    public IWebElement UploadImage;

    [FindsBy(How = How.Id, Using = "url_box")]
    [CacheLookup]
    public IWebElement ImageuUrlTxtBox;

    [FindsBy(How = How.Id, Using = "technology")]
    [CacheLookup]
    public IWebElement Technology;


    #endregion

    #region Constructors

    public HomePage()
        : this(default(IWebDriver), new Dictionary<string, string>(), 15)
    {
    }

    public HomePage(IWebDriver driver, ExtentReportsHelper reportsHelper)
    {
        this.driver = driver;
        extentReportsHelper = reportsHelper;

    }

    public HomePage(IWebDriver driver, Dictionary<string, string> data, int timeout)
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
    /// <returns>The HomePage class instance.</returns>
    public HomePage VerifyPageLoaded() 
    {
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(PageLoadTimeOut));
        try 
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(imageSearch));
        }
        catch(Exception e)
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
    /// Verify that the page Title.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage VerifyPageTitle()
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
    /// Verify Page elements.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage VerifyPageElements(IWebElement element)
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
    /// Click on Upload Image Button.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ImageUpload()
    {
        string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        try
        {
            UploadImageFile.SendKeys(path + "\\Image.png");
            extentReportsHelper.SetStepStatusPass($"Image.png  uploaded successfully ");
            status.ErrorOccurred = false;
            status.ReturnedMessage = "Page Loaded Successfuly";
            return this;;
        }
        catch (Exception e)
        {
            extentReportsHelper.SetTestStatusFail($"Image Not uploaded ");
            status.ErrorOccurred = true;
            status.ReturnedMessage = "Image not uplocated" +e.Message;
            return this;
        }

    }

    /// <summary>
    /// Upload Image from KNown location to Web
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage searchImagebyURL()
    {
        string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        try
        {
            ImageuUrlTxtBox.SendKeys(path + "\\Image.png");
            extentReportsHelper.SetStepStatusPass($"Image.png  uploaded successfully ");
            status.ErrorOccurred = false;
            status.ReturnedMessage = "Page Loaded Successfuly";
            return this;
        }
        catch (Exception e)
        {
            extentReportsHelper.SetTestStatusFail($"Image Not uploaded ");
            status.ErrorOccurred = true;
            status.ReturnedMessage = "Image not uplocated" + e.Message;
            return this;
        }

    }

    /// <summary>
    /// Click on Search Button.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickSearchButton()
    {
        try
        {
            Search.Click();
            extentReportsHelper.SetStepStatusPass($"Web Element 'Search' Clicked");
            status.ErrorOccurred = false;
            status.ReturnedMessage = "Element Clicked";
            return this;
        }
        catch (Exception e)
        {
            extentReportsHelper.SetTestStatusFail($"Web Element 'Search' Not Clicked");
            status.ErrorOccurred = true;
            status.ReturnedMessage = "Element Not Clicked" + e.Message;
            return this;

        }
    }

    #endregion
}
