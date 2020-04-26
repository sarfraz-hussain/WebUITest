using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Report.Extent;
using Return.Status;
using System;
using System.Collections.Generic;

public class SearchErrorPage
{
    private Dictionary<string, string> data;
    private IWebDriver driver;
    private int timeout = 15;

    public Status status = new Status(false);
    private ExtentReportsHelper extentReportsHelper;

    public readonly string title = "Oops, something didn't work!";

    [FindsBy(How = How.Id, Using = "about")]
    [CacheLookup]
    private IWebElement about1;

    [FindsBy(How = How.CssSelector, Using = "#mobile-menu ul li:nth-of-type(4) a")]
    [CacheLookup]
    private IWebElement about2;

    [FindsBy(How = How.CssSelector, Using = "footer div.container div:nth-of-type(1) div:nth-of-type(5) div a:nth-of-type(1)")]
    [CacheLookup]
    private IWebElement aboutTineye;

    [FindsBy(How = How.CssSelector, Using = "a[href='http://blog.tineye.com']")]
    [CacheLookup]
    private IWebElement blog;

    [FindsBy(How = How.CssSelector, Using = "a[href='/extensions']")]
    [CacheLookup]
    private IWebElement browserExtensions;

    [FindsBy(How = How.CssSelector, Using = "a[href='/about#careers']")]
    [CacheLookup]
    private IWebElement careers;

    [FindsBy(How = How.CssSelector, Using = "a[href='https://services.tineye.com/contact']")]
    [CacheLookup]
    private IWebElement contactUs;

    [FindsBy(How = How.CssSelector, Using = "a[href='https://services.tineye.com/docs']")]
    [CacheLookup]
    private IWebElement documentation;

    [FindsBy(How = How.CssSelector, Using = "a[href='/faq']")]
    [CacheLookup]
    private IWebElement faqs;

    [FindsBy(How = How.CssSelector, Using = "a[href='https://help.tineye.com']")]
    [CacheLookup]
    private IWebElement helpCenter;

    [FindsBy(How = How.CssSelector, Using = "footer div.container div:nth-of-type(1) div:nth-of-type(1) p:nth-of-type(2) a")]
    [CacheLookup]
    private IWebElement howToUseTineye1;

    [FindsBy(How = How.CssSelector, Using = "footer div.container div:nth-of-type(1) div:nth-of-type(2) div a:nth-of-type(2)")]
    [CacheLookup]
    private IWebElement howToUseTineye2;

    [FindsBy(How = How.CssSelector, Using = "footer div.container div:nth-of-type(1) div:nth-of-type(2) div a:nth-of-type(1)")]
    [CacheLookup]
    private IWebElement imageSearch;

    [FindsBy(How = How.CssSelector, Using = "footer div.container div:nth-of-type(1) div:nth-of-type(1) p:nth-of-type(1) a")]
    [CacheLookup]
    private IWebElement imageSearchAndRecognitionCompany;

    [FindsBy(How = How.CssSelector, Using = "a[href='/terms']")]
    [CacheLookup]
    private IWebElement legal;

    [FindsBy(How = How.CssSelector, Using = "#mobile-menu ul li:nth-of-type(5) a")]
    [CacheLookup]
    private IWebElement logIn1;

    [FindsBy(How = How.CssSelector, Using = "header div.container div.row div.col-md-12 div:nth-of-type(3) a")]
    [CacheLookup]
    private IWebElement logIn2;

    [FindsBy(How = How.CssSelector, Using = "a[href='https://services.tineye.com/MatchEngine']")]
    [CacheLookup]
    private IWebElement matchengine;

    [FindsBy(How = How.CssSelector, Using = "a[href='https://services.tineye.com/MobileEngine']")]
    [CacheLookup]
    private IWebElement mobileengine;

    [FindsBy(How = How.CssSelector, Using = "a[href='https://services.tineye.com/MulticolorEngine']")]
    [CacheLookup]
    private IWebElement multicolorengine;

    [FindsBy(How = How.Id, Using = "upload_box")]
    [CacheLookup]
    private IWebElement oopsSomethingDidntWork1;

    [FindsBy(How = How.Id, Using = "url_box")]
    [CacheLookup]
    private IWebElement oopsSomethingDidntWork2;

    [FindsBy(How = How.Id, Using = "url_submit")]
    [CacheLookup]
    private IWebElement oopsSomethingDidntWork3;

    [FindsBy(How = How.Id, Using = "upload_box_drag")]
    [CacheLookup]
    private IWebElement oopsSomethingDidntWork4;

    [FindsBy(How = How.Id, Using = "file_submit")]
    [CacheLookup]
    private IWebElement oopsSomethingDidntWork5;

    [FindsBy(How = How.Id, Using = "url_box_drag")]
    [CacheLookup]
    private IWebElement oopsSomethingDidntWork6;

    [FindsBy(How = How.Id, Using = "url_submit")]
    [CacheLookup]
    private IWebElement oopsSomethingDidntWork7;

    [FindsBy(How = How.CssSelector, Using = "a[href='/clients']")]
    [CacheLookup]
    private IWebElement ourClients;

    [FindsBy(How = How.CssSelector, Using = "footer div.container div:nth-of-type(1) div:nth-of-type(4) div a:nth-of-type(1)")]
    [CacheLookup]
    private IWebElement ourTechnology;

    [FindsBy(How = How.CssSelector, Using = "footer div.container div:nth-of-type(1) div:nth-of-type(3) div a:nth-of-type(1)")]
    [CacheLookup]
    private IWebElement overview;

    private readonly string pageLoadedText = "Oops, something didn't work!";

    private readonly string pageUrl = "/search";

    [FindsBy(How = How.CssSelector, Using = "a[href='/press']")]
    [CacheLookup]
    private IWebElement press;

    [FindsBy(How = How.Id, Using = "products")]
    [CacheLookup]
    private IWebElement products1;

    [FindsBy(How = How.CssSelector, Using = "#mobile-menu ul li:nth-of-type(3) a")]
    [CacheLookup]
    private IWebElement products2;

    [FindsBy(How = How.CssSelector, Using = "a[href='/register']")]
    [CacheLookup]
    private IWebElement register;

    [FindsBy(How = How.Id, Using = "search")]
    [CacheLookup]
    private IWebElement search1;

    [FindsBy(How = How.CssSelector, Using = "#mobile-menu ul li:nth-of-type(1) a")]
    [CacheLookup]
    private IWebElement search2;

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

    [FindsBy(How = How.CssSelector, Using = "footer div.container div:nth-of-type(1) div:nth-of-type(1) h1 a")]
    [CacheLookup]
    private IWebElement tineye2;

    [FindsBy(How = How.CssSelector, Using = "a[href='https://services.tineye.com/TinEyeAlerts']")]
    [CacheLookup]
    private IWebElement tineyeAlerts;

    [FindsBy(How = How.CssSelector, Using = "a[href='https://services.tineye.com/TinEyeAPI']")]
    [CacheLookup]
    private IWebElement tineyeApi;

    [FindsBy(How = How.CssSelector, Using = "a[href='https://labs.tineye.com']")]
    [CacheLookup]
    private IWebElement tineyeLabs;

    [FindsBy(How = How.Id, Using = "file_submit")]
    [CacheLookup]
    private IWebElement uploadImage;

    [FindsBy(How = How.CssSelector, Using = "#article-content div.feature-content div.container div.row div:nth-of-type(1) p a")]
    [CacheLookup]
    private IWebElement uploadingItDirectly;

    [FindsBy(How = How.CssSelector, Using = "a[href='https://services.tineye.com/WineEngine']")]
    [CacheLookup]
    private IWebElement wineengine;

    public SearchErrorPage()
        : this(default(IWebDriver), new Dictionary<string, string>(), 15)
    {
    }

    public SearchErrorPage(IWebDriver driver)
        : this(driver, new Dictionary<string, string>(), 15)
    {
    }

    public SearchErrorPage(IWebDriver driver, Dictionary<string, string> data)
        : this(driver, data, 15)
    {
    }

    public SearchErrorPage(IWebDriver driver, Dictionary<string, string> data, int timeout)
    {
        this.driver = driver;
        this.data = data;
        this.timeout = timeout;
    }

    public SearchErrorPage(IWebDriver driver, ExtentReportsHelper reportsHelper)
    {
        this.driver = driver;
        extentReportsHelper = reportsHelper;

    }

    /// <summary>
    /// Click on About Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickAbout1Link() 
    {
        about1.Click();
        return this;
    }

    /// <summary>
    /// Click on About Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickAbout2Link() 
    {
        about2.Click();
        return this;
    }

    /// <summary>
    /// Click on About Tineye Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickAboutTineyeLink() 
    {
        aboutTineye.Click();
        return this;
    }

    /// <summary>
    /// Click on Blog Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickBlogLink() 
    {
        blog.Click();
        return this;
    }

    /// <summary>
    /// Click on Browser Extensions Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickBrowserExtensionsLink() 
    {
        browserExtensions.Click();
        return this;
    }

    /// <summary>
    /// Click on Careers Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickCareersLink() 
    {
        careers.Click();
        return this;
    }

    /// <summary>
    /// Click on Contact Us Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickContactUsLink() 
    {
        contactUs.Click();
        return this;
    }

    /// <summary>
    /// Click on Documentation Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickDocumentationLink() 
    {
        documentation.Click();
        return this;
    }

    /// <summary>
    /// Click on Faqs Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickFaqsLink() 
    {
        faqs.Click();
        return this;
    }

    /// <summary>
    /// Click on Help Center Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickHelpCenterLink() 
    {
        helpCenter.Click();
        return this;
    }

    /// <summary>
    /// Click on How To Use Tineye Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickHowToUseTineye1Link() 
    {
        howToUseTineye1.Click();
        return this;
    }

    /// <summary>
    /// Click on How To Use Tineye Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickHowToUseTineye2Link() 
    {
        howToUseTineye2.Click();
        return this;
    }

    /// <summary>
    /// Click on Image Search And Recognition Company Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickImageSearchAndRecognitionCompanyLink() 
    {
        imageSearchAndRecognitionCompany.Click();
        return this;
    }

    /// <summary>
    /// Click on Image Search Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickImageSearchLink() 
    {
        imageSearch.Click();
        return this;
    }

    /// <summary>
    /// Click on Legal Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickLegalLink() 
    {
        legal.Click();
        return this;
    }

    /// <summary>
    /// Click on Log In Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickLogIn1Link() 
    {
        logIn1.Click();
        return this;
    }

    /// <summary>
    /// Click on Log In Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickLogIn2Link() 
    {
        logIn2.Click();
        return this;
    }

    /// <summary>
    /// Click on Matchengine Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickMatchengineLink() 
    {
        matchengine.Click();
        return this;
    }

    /// <summary>
    /// Click on Mobileengine Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickMobileengineLink() 
    {
        mobileengine.Click();
        return this;
    }

    /// <summary>
    /// Click on Multicolorengine Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickMulticolorengineLink() 
    {
        multicolorengine.Click();
        return this;
    }

    /// <summary>
    /// Click on Oops Something Didnt Work Button.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickOopsSomethingDidntWork3Button() 
    {
        oopsSomethingDidntWork3.Click();
        return this;
    }

    /// <summary>
    /// Click on Oops Something Didnt Work Button.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickOopsSomethingDidntWork5Button() 
    {
        oopsSomethingDidntWork5.Click();
        return this;
    }

    /// <summary>
    /// Click on Oops Something Didnt Work Button.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickOopsSomethingDidntWork7Button() 
    {
        oopsSomethingDidntWork7.Click();
        return this;
    }

    /// <summary>
    /// Click on Our Clients Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickOurClientsLink() 
    {
        ourClients.Click();
        return this;
    }

    /// <summary>
    /// Click on Our Technology Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickOurTechnologyLink() 
    {
        ourTechnology.Click();
        return this;
    }

    /// <summary>
    /// Click on Overview Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickOverviewLink() 
    {
        overview.Click();
        return this;
    }

    /// <summary>
    /// Click on Press Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickPressLink() 
    {
        press.Click();
        return this;
    }

    /// <summary>
    /// Click on Products Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickProducts1Link() 
    {
        products1.Click();
        return this;
    }

    /// <summary>
    /// Click on Products Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickProducts2Link() 
    {
        products2.Click();
        return this;
    }

    /// <summary>
    /// Click on Register Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickRegisterLink() 
    {
        register.Click();
        return this;
    }

    /// <summary>
    /// Click on Search Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickSearch1Link() 
    {
        search1.Click();
        return this;
    }

    /// <summary>
    /// Click on Search Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickSearch2Link() 
    {
        search2.Click();
        return this;
    }

    /// <summary>
    /// Click on Support Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickSupportLink() 
    {
        support.Click();
        return this;
    }

    /// <summary>
    /// Click on Technology Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickTechnology1Link() 
    {
        technology1.Click();
        return this;
    }

    /// <summary>
    /// Click on Technology Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickTechnology2Link() 
    {
        technology2.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickTineye1Link() 
    {
        tineye1.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickTineye2Link() 
    {
        tineye2.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Alerts Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickTineyeAlertsLink() 
    {
        tineyeAlerts.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Api Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickTineyeApiLink() 
    {
        tineyeApi.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Labs Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickTineyeLabsLink() 
    {
        tineyeLabs.Click();
        return this;
    }

    /// <summary>
    /// Click on Upload Image Button.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickUploadImageButton() 
    {
        uploadImage.Click();
        return this;
    }

    /// <summary>
    /// Click on Uploading It Directly Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickUploadingItDirectlyLink() 
    {
        uploadingItDirectly.Click();
        return this;
    }

    /// <summary>
    /// Click on Wineengine Link.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage ClickWineengineLink() 
    {
        wineengine.Click();
        return this;
    }

    /// <summary>
    /// Fill every fields in the page.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage Fill() 
    {
        SetOopsSomethingDidntWork2TextField();
        SetOopsSomethingDidntWork6TextField();
        return this;
    }

    /// <summary>
    /// Fill every fields in the page and submit it to target page.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage FillAndSubmit() 
    {
        Fill();
        return Submit();
    }

    /// <summary>
    /// Set default value to Oops Something Didnt Work Text field.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage SetOopsSomethingDidntWork1TextField() 
    {
        return SetOopsSomethingDidntWork1TextField(data["OOPS_SOMETHING_DIDNT_WORK_1"]);
    }

    /// <summary>
    /// Set value to Oops Something Didnt Work Text field.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage SetOopsSomethingDidntWork1TextField(string oopsSomethingDidntWork1Value)
    {
        return this;
    }

    /// <summary>
    /// Set default value to Oops Something Didnt Work Text field.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage SetOopsSomethingDidntWork2TextField() 
    {
        return SetOopsSomethingDidntWork2TextField(data["OOPS_SOMETHING_DIDNT_WORK_2"]);
    }

    /// <summary>
    /// Set value to Oops Something Didnt Work Text field.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage SetOopsSomethingDidntWork2TextField(string oopsSomethingDidntWork2Value)
    {
        oopsSomethingDidntWork2.SendKeys(oopsSomethingDidntWork2Value);
        return this;
    }

    /// <summary>
    /// Set Oops Something Didnt Work File field.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage SetOopsSomethingDidntWork4FileField() 
    {
        return this;
    }

    /// <summary>
    /// Set default value to Oops Something Didnt Work Text field.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage SetOopsSomethingDidntWork6TextField() 
    {
        return SetOopsSomethingDidntWork6TextField(data["OOPS_SOMETHING_DIDNT_WORK_6"]);
    }

    /// <summary>
    /// Set value to Oops Something Didnt Work Text field.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage SetOopsSomethingDidntWork6TextField(string oopsSomethingDidntWork6Value)
    {
        oopsSomethingDidntWork6.SendKeys(oopsSomethingDidntWork6Value);
        return this;
    }

    /// <summary>
    /// Submit the form to target page.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage Submit() 
    {
       // ClickOopsSomethingDidntWorkButton();
        return this;
    }

    /// <summary>
    /// Verify that the page loaded completely.
    /// </summary>
    /// <returns>The SearchErrorPage class instance.</returns>
    //public SearchErrorPage VerifyPageLoaded() 
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
    /// <returns>The SearchErrorPage class instance.</returns>
    public SearchErrorPage VerifyPageUrl() 
    {
        new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until<bool>((d) =>
        {
            return d.Url.Contains(pageUrl);
        });
        return this;
    }





    public SearchErrorPage VerifyPageLoaded()
    {
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
        try
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(imageSearch));
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

    public SearchErrorPage VerifyPageTitle()
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

    public SearchErrorPage verifySearchResults()
    {
        try
        {

            if (this.driver.PageSource.Contains(pageLoadedText))
            {
                extentReportsHelper.SetStepStatusPass($"Page Loaded, No such Iage Found");
                status.ErrorOccurred = true;
                status.ReturnedMessage = "No such image found";
                return this;
            }

            else
            {
                extentReportsHelper.SetTestStatusFail($"Page Loaded, relvent images found");
                status.ErrorOccurred = false;
                status.ReturnedMessage = "Images found";
                return this;
            }

        }
        catch (Exception e)
        {
            extentReportsHelper.SetTestStatusFail($"Page Loaded, relvent images found");
            status.ErrorOccurred = false;
            status.ReturnedMessage = "Images found";
            return this;
        }

    }

    public SearchErrorPage verifyBlankSearchResults()
    {
        try
        {

            if (this.driver.PageSource.Contains(pageLoadedText))
            {
                extentReportsHelper.SetStepStatusPass($"Oops, something didn't work!, as expected");
                status.ErrorOccurred = false;
                status.ReturnedMessage = "Normal Behaviour";
                return this;
            }

            else
            {
                extentReportsHelper.SetTestStatusFail($"Blank serach, returend some results");
                status.ErrorOccurred = true;
                status.ReturnedMessage = "Abnormal behaviour";
                return this;
            }

        }
        catch (Exception e)
        {
            extentReportsHelper.SetTestStatusFail($"Blank serach, returend some results");
            status.ErrorOccurred = true;
            status.ReturnedMessage = "Abnormal behaviour";
            return this;
        }

    }
}
