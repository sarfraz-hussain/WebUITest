using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

public class TinEye
{
    private Dictionary<string, string> data;
    private IWebDriver driver;
    private int timeout = 15;


    #region Locators

    [FindsBy(How = How.CssSelector, Using = "#mobile-menu ul li:nth-of-type(4) a")]
    [CacheLookup]
    private IWebElement about;

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
    private IWebElement products2;

    [FindsBy(How = How.CssSelector, Using = "a[href='/register']")]
    [CacheLookup]
    private IWebElement register;

    [FindsBy(How = How.CssSelector, Using = "a.active")]
    [CacheLookup]
    private IWebElement search;

    [FindsBy(How = How.Id, Using = "upload_box")]
    [CacheLookup]
    public IWebElement searchByImageAndFindWhere1;

    [FindsBy(How = How.Id, Using = "url_box")]
    [CacheLookup]
    private IWebElement searchByImageAndFindWhere2;

    [FindsBy(How = How.Id, Using = "url_submit")]
    [CacheLookup]
    private IWebElement searchByImageAndFindWhere3;

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
    private IWebElement technology2;

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

    #region Operations

    public TinEye()
        : this(default(IWebDriver), new Dictionary<string, string>(), 15)
    {
    }

    public TinEye(IWebDriver driver)
    {
        this.driver = driver;
    }
    public TinEye navigate()
    {
        this.driver.Url = "https://tineye.com/";
        this.driver.Navigate();
        return this;
    }
    public TinEye initPage()
    {
        PageFactory.InitElements(this.driver, this);
        return this;
    }

    public TinEye(IWebDriver driver, Dictionary<string, string> data)
        : this(driver, data, 15)
    {
    }

    public TinEye(IWebDriver driver, Dictionary<string, string> data, int timeout)
    {
        this.driver = driver;
        this.data = data;
        this.timeout = timeout;
    }

    /// <summary>
    /// Click on About Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickAboutLink() 
    {
        about.Click();
        return this;
    }

    /// <summary>
    /// Click on About Tineye Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickAboutTineyeLink() 
    {
        aboutTineye.Click();
        return this;
    }

    /// <summary>
    /// Click on Blog Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickBlogLink() 
    {
        blog.Click();
        return this;
    }

    /// <summary>
    /// Click on Browser Extensions Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickBrowserExtensionsLink() 
    {
        browserExtensions.Click();
        return this;
    }

    /// <summary>
    /// Click on Careers Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickCareersLink() 
    {
        careers.Click();
        return this;
    }

    /// <summary>
    /// Click on Contact Us Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickContactUsLink() 
    {
        contactUs.Click();
        return this;
    }

    /// <summary>
    /// Click on Documentation Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickDocumentationLink() 
    {
        documentation.Click();
        return this;
    }

    /// <summary>
    /// Click on Faqs Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickFaqsLink() 
    {
        faqs.Click();
        return this;
    }

    /// <summary>
    /// Click on Help Center Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickHelpCenterLink() 
    {
        helpCenter.Click();
        return this;
    }

    /// <summary>
    /// Click on How To Use Tineye Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickHowToUseTineye1Link() 
    {
        howToUseTineye1.Click();
        return this;
    }

    /// <summary>
    /// Click on How To Use Tineye Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickHowToUseTineye2Link() 
    {
        howToUseTineye2.Click();
        return this;
    }

    /// <summary>
    /// Click on How To Use Tineye Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickHowToUseTineye3Link() 
    {
        howToUseTineye3.Click();
        return this;
    }

    /// <summary>
    /// Click on Image Search And Recognition Company Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickImageSearchAndRecognitionCompanyLink() 
    {
        imageSearchAndRecognitionCompany.Click();
        return this;
    }

    /// <summary>
    /// Click on Image Search Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickImageSearchLink() 
    {
        imageSearch.Click();
        return this;
    }

    /// <summary>
    /// Click on Learn About Tineyes Technology And Apis Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickLearnAboutTineyesTechnologyAndApisLink() 
    {
        learnAboutTineyesTechnologyAndApis.Click();
        return this;
    }

    /// <summary>
    /// Click on Learn More About Tineye Alerts Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickLearnMoreAboutTineyeAlertsLink() 
    {
        learnMoreAboutTineyeAlerts.Click();
        return this;
    }

    /// <summary>
    /// Click on Legal Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickLegalLink() 
    {
        legal.Click();
        return this;
    }

    /// <summary>
    /// Click on Log In Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickLogIn1Link() 
    {
        logIn1.Click();
        return this;
    }

    /// <summary>
    /// Click on Log In Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickLogIn2Link() 
    {
        logIn2.Click();
        return this;
    }

    /// <summary>
    /// Click on Matchengine Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickMatchengineLink() 
    {
        matchengine.Click();
        return this;
    }

    /// <summary>
    /// Click on Mobileengine Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickMobileengineLink() 
    {
        mobileengine.Click();
        return this;
    }

    /// <summary>
    /// Click on Multicolorengine Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickMulticolorengineLink() 
    {
        multicolorengine.Click();
        return this;
    }

    /// <summary>
    /// Click on Our Clients Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickOurClientsLink() 
    {
        ourClients.Click();
        return this;
    }

    /// <summary>
    /// Click on Our Technology Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickOurTechnologyLink() 
    {
        ourTechnology.Click();
        return this;
    }

    /// <summary>
    /// Click on Overview Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickOverviewLink() 
    {
        overview.Click();
        return this;
    }

    /// <summary>
    /// Click on Press Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickPressLink() 
    {
        press.Click();
        return this;
    }

    /// <summary>
    /// Click on Products Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickProducts1Link() 
    {
        products1.Click();
        return this;
    }

    /// <summary>
    /// Click on Products Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickProducts2Link() 
    {
        products2.Click();
        return this;
    }

    /// <summary>
    /// Click on Register Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickRegisterLink() 
    {
        register.Click();
        return this;
    }

    /// <summary>
    /// Click on Search By Image And Find Where That Image Appears Online Button.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickSearchByImageAndFindWhere3Button() 
    {
        searchByImageAndFindWhere3.Click();
        return this;
    }

    /// <summary>
    /// Click on Search By Image And Find Where That Image Appears Online Button.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickSearchByImageAndFindWhere5Button() 
    {
        searchByImageAndFindWhere5.Click();
        return this;
    }

    /// <summary>
    /// Click on Search By Image And Find Where That Image Appears Online Button.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickSearchByImageAndFindWhere7Button() 
    {
        searchByImageAndFindWhere7.Click();
        return this;
    }

    /// <summary>
    /// Click on Search Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickSearchLink() 
    {
        search.Click();
        return this;
    }

    /// <summary>
    /// Click on Support Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickSupportLink() 
    {
        support.Click();
        return this;
    }

    /// <summary>
    /// Click on Technology Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickTechnology1Link() 
    {
        technology1.Click();
        return this;
    }

    /// <summary>
    /// Click on Technology Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickTechnology2Link() 
    {
        technology2.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickTineye1Link() 
    {
        tineye1.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickTineye2Link() 
    {
        tineye2.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Alerts Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickTineyeAlertsLink() 
    {
        tineyeAlerts.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Api Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickTineyeApiLink() 
    {
        tineyeApi.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Labs Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickTineyeLabsLink() 
    {
        tineyeLabs.Click();
        return this;
    }

    /// <summary>
    /// Click on Upload Image Button.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickUploadImageButton() 
    {
        uploadImage.Click();
        return this;
    }

    /// <summary>
    /// Click on Wineengine Link.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye ClickWineengineLink() 
    {
        wineengine.Click();
        return this;
    }

    /// <summary>
    /// Fill every fields in the page.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye Fill() 
    {
        SetSearchByImageAndFindWhere2TextField();
        SetSearchByImageAndFindWhere6TextField();
        return this;
    }

    /// <summary>
    /// Fill every fields in the page and submit it to target page.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye FillAndSubmit() 
    {
        Fill();
        return Submit();
    }

    /// <summary>
    /// Set default value to Search By Image And Find Where That Image Appears Online Text field.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye SetSearchByImageAndFindWhere1TextField() 
    {
        return SetSearchByImageAndFindWhere1TextField(data["SEARCH_BY_IMAGE_AND_FIND_WHERE_1"]);
    }

    /// <summary>
    /// Set value to Search By Image And Find Where That Image Appears Online Text field.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye SetSearchByImageAndFindWhere1TextField(string searchByImageAndFindWhere1Value)
    {
        return this;
    }

    /// <summary>
    /// Set default value to Search By Image And Find Where That Image Appears Online Text field.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye SetSearchByImageAndFindWhere2TextField() 
    {
        return SetSearchByImageAndFindWhere2TextField(data["SEARCH_BY_IMAGE_AND_FIND_WHERE_2"]);
    }

    /// <summary>
    /// Set value to Search By Image And Find Where That Image Appears Online Text field.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye SetSearchByImageAndFindWhere2TextField(string searchByImageAndFindWhere2Value)
    {
        searchByImageAndFindWhere2.SendKeys(searchByImageAndFindWhere2Value);
        return this;
    }

    /// <summary>
    /// Set Search By Image And Find Where That Image Appears Online File field.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye SetSearchByImageAndFindWhere4FileField() 
    {
        return this;
    }

    /// <summary>
    /// Set default value to Search By Image And Find Where That Image Appears Online Text field.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye SetSearchByImageAndFindWhere6TextField() 
    {
        return SetSearchByImageAndFindWhere6TextField(data["SEARCH_BY_IMAGE_AND_FIND_WHERE_6"]);
    }

    /// <summary>
    /// Set value to Search By Image And Find Where That Image Appears Online Text field.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye SetSearchByImageAndFindWhere6TextField(string searchByImageAndFindWhere6Value)
    {
        searchByImageAndFindWhere6.SendKeys(searchByImageAndFindWhere6Value);
        return this;
    }

    /// <summary>
    /// Submit the form to target page.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye Submit() 
    {
        //ClickSearchByImageAndFindWhereThatImageAppearsOnlineButton();
        return this;
    }

    /// <summary>
    /// Verify that the page loaded completely.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye VerifyPageLoaded() 
    {
        new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until<bool>((d) =>
        {
            return d.PageSource.Contains(pageLoadedText);
        });
        return this;
    }

    /// <summary>
    /// Verify that current page URL matches the expected URL.
    /// </summary>
    /// <returns>The TinEye class instance.</returns>
    public TinEye VerifyPageUrl() 
    {
        new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until<bool>((d) =>
        {
            return d.Url.Contains(pageUrl);
        });
        return this;
    }
    #endregion
}
