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
    private Dictionary<string, string> data;
    private IWebDriver driver;
    private int timeout = 15;

    public  Status status = new Status(false);
    private ExtentReportsHelper extentReportsHelper;

    public readonly string title = "TinEye Reverse Image Search";

    #region Locators

    [FindsBy(How = How.CssSelector, Using = "#mobile-menu ul li:nth-of-type(4) a")]
    [CacheLookup]
    public IWebElement About;

    [FindsBy(How = How.CssSelector, Using = "footer div.container div:nth-of-type(1) div:nth-of-type(5) div a:nth-of-type(1)")]
    [CacheLookup]
    public IWebElement aboutTineye;

    [FindsBy(How = How.CssSelector, Using = "a[href='http://blog.tineye.com']")]
    [CacheLookup]
    private IWebElement blog;

    [FindsBy(How = How.CssSelector, Using = "a[href='/extensions']")]
    [CacheLookup]
    private IWebElement browserExtensions;

    [FindsBy(How = How.CssSelector, Using = "a[href='/about#careers']")]
    [CacheLookup]
    public IWebElement Careers;

    [FindsBy(How = How.CssSelector, Using = "a[href='https://services.tineye.com/contact']")]
    [CacheLookup]
    public IWebElement ContactUs;

    [FindsBy(How = How.CssSelector, Using = "a[href='https://services.tineye.com/docs']")]
    [CacheLookup]
    private IWebElement documentation;

    [FindsBy(How = How.CssSelector, Using = "a[href='/faq']")]
    [CacheLookup]
    private IWebElement faqs;

    [FindsBy(How = How.CssSelector, Using = "a[href='https://help.tineye.com']")]
    [CacheLookup]
    private IWebElement helpCenter;

    [FindsBy(How = How.CssSelector, Using = "div:nth-of-type(1) div.search-container div.search.container div:nth-of-type(2) div.col-xs-12 a.md")]
    [CacheLookup]
    private IWebElement howToUseTineye1;

    [FindsBy(How = How.CssSelector, Using = "footer div.container div:nth-of-type(1) div:nth-of-type(1) p:nth-of-type(2) a")]
    [CacheLookup]
    private IWebElement howToUseTineye2;

    [FindsBy(How = How.CssSelector, Using = "footer div.container div:nth-of-type(1) div:nth-of-type(2) div a:nth-of-type(2)")]
    [CacheLookup]
    private IWebElement howToUseTineye3;

    [FindsBy(How = How.CssSelector, Using = "footer div.container div:nth-of-type(1) div:nth-of-type(2) div a:nth-of-type(1)")]
    [CacheLookup]
    private IWebElement imageSearch;

    [FindsBy(How = How.CssSelector, Using = "footer div.container div:nth-of-type(1) div:nth-of-type(1) p:nth-of-type(1) a")]
    [CacheLookup]
    private IWebElement imageSearchAndRecognitionCompany;

    [FindsBy(How = How.CssSelector, Using = "div:nth-of-type(3) div.container div.col-sm-12 a.md")]
    [CacheLookup]
    private IWebElement learnAboutTineyesTechnologyAndApis;

    [FindsBy(How = How.CssSelector, Using = "div:nth-of-type(2) div.container div:nth-of-type(2) div.col-sm-12.col-sm-offset-0.col-md-10.col-md-offset-1.col-lg-8.col-lg-offset-2 a.md")]
    [CacheLookup]
    private IWebElement learnMoreAboutTineyeAlerts;

    [FindsBy(How = How.CssSelector, Using = "a[href='/terms']")]
    [CacheLookup]
    private IWebElement legal;

    [FindsBy(How = How.CssSelector, Using = "#mobile-menu ul li:nth-of-type(5) a")]
    [CacheLookup]
    private IWebElement logIn1;

    [FindsBy(How = How.CssSelector, Using = "div:nth-of-type(1) header div.container div.row div.col-md-12 div:nth-of-type(2) a:nth-of-type(3)")]
    [CacheLookup]
    public IWebElement LogIn;

    [FindsBy(How = How.CssSelector, Using = "a[href='https://services.tineye.com/MatchEngine']")]
    [CacheLookup]
    private IWebElement matchengine;

    [FindsBy(How = How.CssSelector, Using = "a[href='https://services.tineye.com/MobileEngine']")]
    [CacheLookup]
    private IWebElement mobileengine;

    [FindsBy(How = How.CssSelector, Using = "a[href='https://services.tineye.com/MulticolorEngine']")]
    [CacheLookup]
    private IWebElement multicolorengine;

    [FindsBy(How = How.CssSelector, Using = "a[href='/clients']")]
    [CacheLookup]
    private IWebElement ourClients;

    [FindsBy(How = How.CssSelector, Using = "footer div.container div:nth-of-type(1) div:nth-of-type(4) div a:nth-of-type(1)")]
    [CacheLookup]
    private IWebElement ourTechnology;

    [FindsBy(How = How.CssSelector, Using = "footer div.container div:nth-of-type(1) div:nth-of-type(3) div a:nth-of-type(1)")]
    [CacheLookup]
    private IWebElement overview;

    private readonly string pageLoadedText = "We are experts in computer vision, pattern recognition, neural networks, and machine learning";

    private readonly string pageUrl = "/";

    [FindsBy(How = How.CssSelector, Using = "a[href='/press']")]
    [CacheLookup]
    private IWebElement press;

    [FindsBy(How = How.CssSelector, Using = "#mobile-menu ul li:nth-of-type(3) a")]
    [CacheLookup]
    private IWebElement products1;

    [FindsBy(How = How.Id, Using = "products")]
    [CacheLookup]
    public IWebElement Products;

    [FindsBy(How = How.Id, Using = "url_form")]
    [CacheLookup]
    public IWebElement Form;


    [FindsBy(How = How.CssSelector, Using = "a[href='/register']")]
    [CacheLookup]
    private IWebElement register;

    [FindsBy(How = How.CssSelector, Using = "a.active")]
    [CacheLookup]
    private IWebElement search;

    [FindsBy(How = How.Id, Using = "upload_box")]
    [CacheLookup]
    private IWebElement searchByImageAndFindWhere1;

    [FindsBy(How = How.Id, Using = "url_box")]
    [CacheLookup]
    private IWebElement searchByImageAndFindWhere2;

    [FindsBy(How = How.Id, Using = "url_submit")]
    [CacheLookup]
    private IWebElement searchByImageAndFindWhere3;

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


    [FindsBy(How = How.Id, Using = "upload_box_drag")]
    [CacheLookup]
    private IWebElement searchByImageAndFindWhere4;

    [FindsBy(How = How.Id, Using = "file_submit")]
    [CacheLookup]
    private IWebElement searchByImageAndFindWhere5;

    [FindsBy(How = How.Id, Using = "url_box_drag")]
    [CacheLookup]
    private IWebElement searchByImageAndFindWhere6;

    [FindsBy(How = How.Id, Using = "url_submit")]
    [CacheLookup]
    private IWebElement searchByImageAndFindWhere7;

    [FindsBy(How = How.CssSelector, Using = "a[href='https://services.tineye.com/support']")]
    [CacheLookup]
    private IWebElement support;

    [FindsBy(How = How.CssSelector, Using = "#mobile-menu ul li:nth-of-type(2) a")]
    [CacheLookup]
    private IWebElement technology1;

    [FindsBy(How = How.Id, Using = "technology")]
    [CacheLookup]
    public IWebElement Technology;

    [FindsBy(How = How.CssSelector, Using = "div:nth-of-type(1) header div.container div.row div.col-md-12 h1 a")]
    [CacheLookup]
    private IWebElement tineye1;

    [FindsBy(How = How.CssSelector, Using = "footer div.container div:nth-of-type(1) div:nth-of-type(1) h1 a")]
    [CacheLookup]
    private IWebElement tineye2;

    [FindsBy(How = How.CssSelector, Using = "footer div.container div:nth-of-type(1) div:nth-of-type(3) div a:nth-of-type(5)")]
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

    [FindsBy(How = How.CssSelector, Using = "a[href='https://services.tineye.com/WineEngine']")]
    [CacheLookup]
    private IWebElement wineengine;

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

    public HomePage(IWebDriver driver)
        : this(driver, new Dictionary<string, string>(), 15)
    {
    }

    public HomePage(IWebDriver driver, Dictionary<string, string> data)
        : this(driver, data, 15)
    {
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
    /// Click on About Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickAboutLink() 
    {
        About.Click();
        return this;
    }

    /// <summary>
    /// Click on About Tineye Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickAboutTineyeLink() 
    {
        aboutTineye.Click();
        return this;
    }

    /// <summary>
    /// Click on Blog Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickBlogLink() 
    {
        blog.Click();
        return this;
    }

    /// <summary>
    /// Click on Browser Extensions Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickBrowserExtensionsLink() 
    {
        browserExtensions.Click();
        return this;
    }

    /// <summary>
    /// Click on Careers Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickCareersLink() 
    {
        Careers.Click();
        return this;
    }

    /// <summary>
    /// Click on Contact Us Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickContactUsLink() 
    {
        ContactUs.Click();
        return this;
    }

    /// <summary>
    /// Click on Documentation Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickDocumentationLink() 
    {
        documentation.Click();
        return this;
    }

    /// <summary>
    /// Click on Faqs Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickFaqsLink() 
    {
        faqs.Click();
        return this;
    }

    /// <summary>
    /// Click on Help Center Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickHelpCenterLink() 
    {
        helpCenter.Click();
        return this;
    }

    /// <summary>
    /// Click on How To Use Tineye Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickHowToUseTineye1Link() 
    {
        howToUseTineye1.Click();
        return this;
    }

    /// <summary>
    /// Click on How To Use Tineye Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickHowToUseTineye2Link() 
    {
        howToUseTineye2.Click();
        return this;
    }

    /// <summary>
    /// Click on How To Use Tineye Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickHowToUseTineye3Link() 
    {
        howToUseTineye3.Click();
        return this;
    }

    /// <summary>
    /// Click on Image Search And Recognition Company Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickImageSearchAndRecognitionCompanyLink() 
    {
        imageSearchAndRecognitionCompany.Click();
        return this;
    }

    /// <summary>
    /// Click on Image Search Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickImageSearchLink() 
    {
        imageSearch.Click();
        return this;
    }

    /// <summary>
    /// Click on Learn About Tineyes Technology And Apis Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickLearnAboutTineyesTechnologyAndApisLink() 
    {
        learnAboutTineyesTechnologyAndApis.Click();
        return this;
    }

    /// <summary>
    /// Click on Learn More About Tineye Alerts Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickLearnMoreAboutTineyeAlertsLink() 
    {
        learnMoreAboutTineyeAlerts.Click();
        return this;
    }

    /// <summary>
    /// Click on Legal Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickLegalLink() 
    {
        legal.Click();
        return this;
    }

    /// <summary>
    /// Click on Log In Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickLogIn1Link() 
    {
        logIn1.Click();
        return this;
    }

    /// <summary>
    /// Click on Log In Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickLogIn2Link() 
    {
        LogIn.Click();
        return this;
    }

    /// <summary>
    /// Click on Matchengine Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickMatchengineLink() 
    {
        matchengine.Click();
        return this;
    }

    /// <summary>
    /// Click on Mobileengine Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickMobileengineLink() 
    {
        mobileengine.Click();
        return this;
    }

    /// <summary>
    /// Click on Multicolorengine Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickMulticolorengineLink() 
    {
        multicolorengine.Click();
        return this;
    }

    /// <summary>
    /// Click on Our Clients Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickOurClientsLink() 
    {
        ourClients.Click();
        return this;
    }

    /// <summary>
    /// Click on Our Technology Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickOurTechnologyLink() 
    {
        ourTechnology.Click();
        return this;
    }

    /// <summary>
    /// Click on Overview Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickOverviewLink() 
    {
        overview.Click();
        return this;
    }

    /// <summary>
    /// Click on Press Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickPressLink() 
    {
        press.Click();
        return this;
    }

    /// <summary>
    /// Click on Products Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickProducts1Link() 
    {
        products1.Click();
        return this;
    }

    /// <summary>
    /// Click on Products Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickProducts2Link() 
    {
        Products.Click();
        return this;
    }

    /// <summary>
    /// Click on Register Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickRegisterLink() 
    {
        register.Click();
        return this;
    }

    /// <summary>
    /// Click on Search By Image And Find Where That Image Appears Online Button.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickSearchByImageAndFindWhere3Button() 
    {
        searchByImageAndFindWhere3.Click();
        return this;
    }

    /// <summary>
    /// Click on Search By Image And Find Where That Image Appears Online Button.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickSearchByImageAndFindWhere5Button() 
    {
        searchByImageAndFindWhere5.Click();
        return this;
    }

    /// <summary>
    /// Click on Search By Image And Find Where That Image Appears Online Button.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickSearchByImageAndFindWhere7Button() 
    {
        searchByImageAndFindWhere7.Click();
        return this;
    }

    /// <summary>
    /// Click on Search Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickSearchLink() 
    {
        search.Click();
        return this;
    }

    /// <summary>
    /// Click on Support Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickSupportLink() 
    {
        support.Click();
        return this;
    }

    /// <summary>
    /// Click on Technology Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickTechnology1Link() 
    {
        technology1.Click();
        return this;
    }

    /// <summary>
    /// Click on Technology Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickTechnology2Link() 
    {
        Technology.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickTineye1Link() 
    {
        tineye1.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickTineye2Link() 
    {
        tineye2.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Alerts Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickTineyeAlertsLink() 
    {
        tineyeAlerts.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Api Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickTineyeApiLink() 
    {
        tineyeApi.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Labs Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickTineyeLabsLink() 
    {
        tineyeLabs.Click();
        return this;
    }

    /// <summary>
    /// Click on Upload Image Button.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickUploadImageButton() 
    {
        uploadImage.Click();
        return this;
    }

    /// <summary>
    /// Click on Wineengine Link.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickWineengineLink() 
    {
        wineengine.Click();
        return this;
    }

    /// <summary>
    /// Fill every fields in the page.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage Fill() 
    {
        SetSearchByImageAndFindWhere2TextField();
        SetSearchByImageAndFindWhere6TextField();
        return this;
    }

    /// <summary>
    /// Fill every fields in the page and submit it to target page.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage FillAndSubmit() 
    {
        Fill();
        return Submit();
    }

    /// <summary>
    /// Set default value to Search By Image And Find Where That Image Appears Online Text field.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage SetSearchByImageAndFindWhere1TextField() 
    {
        return SetSearchByImageAndFindWhere1TextField(data["SEARCH_BY_IMAGE_AND_FIND_WHERE_1"]);
    }

    /// <summary>
    /// Set value to Search By Image And Find Where That Image Appears Online Text field.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage SetSearchByImageAndFindWhere1TextField(string searchByImageAndFindWhere1Value)
    {
        return this;
    }

    /// <summary>
    /// Set default value to Search By Image And Find Where That Image Appears Online Text field.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage SetSearchByImageAndFindWhere2TextField() 
    {
        return SetSearchByImageAndFindWhere2TextField(data["SEARCH_BY_IMAGE_AND_FIND_WHERE_2"]);
    }

    /// <summary>
    /// Set value to Search By Image And Find Where That Image Appears Online Text field.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage SetSearchByImageAndFindWhere2TextField(string searchByImageAndFindWhere2Value)
    {
        searchByImageAndFindWhere2.SendKeys(searchByImageAndFindWhere2Value);
        return this;
    }

    /// <summary>
    /// Set Search By Image And Find Where That Image Appears Online File field.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage SetSearchByImageAndFindWhere4FileField() 
    {
        return this;
    }

    /// <summary>
    /// Set default value to Search By Image And Find Where That Image Appears Online Text field.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage SetSearchByImageAndFindWhere6TextField() 
    {
        return SetSearchByImageAndFindWhere6TextField(data["SEARCH_BY_IMAGE_AND_FIND_WHERE_6"]);
    }

    /// <summary>
    /// Set value to Search By Image And Find Where That Image Appears Online Text field.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage SetSearchByImageAndFindWhere6TextField(string searchByImageAndFindWhere6Value)
    {
        searchByImageAndFindWhere6.SendKeys(searchByImageAndFindWhere6Value);
        return this;
    }

    /// <summary>
    /// Submit the form to target page.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage Submit() 
    {
        //ClickSearchByImageAndFindWhereThatImageAppearsOnlineButton();
        return this;
    }

    /// <summary>
    /// Verify that the page loaded completely.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage VerifyPageLoaded() 
    {
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        try 
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(imageSearch));
        }
        catch(Exception e)
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
            status.ReturnedMessage = "Page title Not Verified";
            return this;
        }


    }

    /// <summary>
    /// Verify that current page URL matches the expected URL.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage VerifyPageUrl() 
    {
        new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until<bool>((d) =>
        {
            return d.Url.Contains(pageUrl);
        });
        return this;
    }

    /// <summary>
    /// Verify Page elements.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage VerifyPageElements(IWebElement element)
    {

        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
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




    /// <summary>
    /// Click on Upload Image Button.
    /// </summary>
    /// <returns>The HomePage class instance.</returns>
    public HomePage ClickUploadImageBtn()
    {
        UploadImage.Click();
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
            status.ReturnedMessage = "Image not uplocated";
            return this;
        }

    }

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
            status.ReturnedMessage = "Image not uplocated";
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
            status.ReturnedMessage = "Element Not Clicked";
            return this;

        }
    }





    #endregion
}
