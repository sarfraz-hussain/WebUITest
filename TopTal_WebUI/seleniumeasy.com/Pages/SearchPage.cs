using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Report.Extent;
using Return.Status;
using System;
using System.Collections.Generic;

public class SearchPage
{
    private Dictionary<string, string> data;
    private IWebDriver driver;
    private int timeout = 15;

    public Status status = new Status(false);
    private ExtentReportsHelper extentReportsHelper;

    public readonly string title =  "0 TinEye search results";

    [FindsBy(How = How.Id, Using = "about")]
    [CacheLookup]
    private IWebElement about1;

    [FindsBy(How = How.CssSelector, Using = "#mobile-menu ul li:nth-of-type(4) a")]
    [CacheLookup]
    private IWebElement about2;

    [FindsBy(How = How.CssSelector, Using = "footer div.container div:nth-of-type(1) div:nth-of-type(5) div a:nth-of-type(1)")]
    [CacheLookup]
    private IWebElement aboutTineye;

    [FindsBy(How = How.CssSelector, Using = "a.carbon-img")]
    [CacheLookup]
    private IWebElement adsViaCarbon1;

    [FindsBy(How = How.CssSelector, Using = "a.carbon-poweredby")]
    [CacheLookup]
    private IWebElement adsViaCarbon2;

    [FindsBy(How = How.CssSelector, Using = "#results-div div:nth-of-type(1) div.container div.row div.col-md-12 div:nth-of-type(2) h3 a")]
    [CacheLookup]
    private IWebElement billionImages409;

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

    [FindsBy(How = How.CssSelector, Using = "#match-summary div.row div:nth-of-type(1) div.results.row div.matches.col-sm-12 div.row div.no-results.col-sm-12 p:nth-of-type(3) a:nth-of-type(2)")]
    [CacheLookup]
    private IWebElement howTineyeWorks;

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

    [FindsBy(How = How.CssSelector, Using = "#results-div div:nth-of-type(1) div.container div.row div.col-md-12 div:nth-of-type(2) p.commercial-info a:nth-of-type(2)")]
    [CacheLookup]
    private IWebElement learnAboutOurTechnology;

    [FindsBy(How = How.CssSelector, Using = "a[href='/terms']")]
    [CacheLookup]
    private IWebElement legal;

    [FindsBy(How = How.CssSelector, Using = "a.carbon-text")]
    [CacheLookup]
    private IWebElement limitedTimeOfferGet10Free;

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

    [FindsBy(How = How.CssSelector, Using = "a[href='/clients']")]
    [CacheLookup]
    private IWebElement ourClients;

    [FindsBy(How = How.CssSelector, Using = "footer div.container div:nth-of-type(1) div:nth-of-type(4) div a:nth-of-type(1)")]
    [CacheLookup]
    private IWebElement ourTechnology;

    [FindsBy(How = How.CssSelector, Using = "footer div.container div:nth-of-type(1) div:nth-of-type(3) div a:nth-of-type(1)")]
    [CacheLookup]
    private IWebElement overview;

    private readonly string pageLoadedText = "Your image may be unique, and doesn't appear anywhere on the web";

    private readonly string pageUrl = "/search/ebbe5e85ccdd9534ff464397e9f247797ee71e20?page=1";

    [FindsBy(How = How.CssSelector, Using = "a[href='/faq#similar']")]
    [CacheLookup]
    private IWebElement peopleOrObjects;

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

    [FindsBy(How = How.CssSelector, Using = "#mobile-menu ul li:nth-of-type(1) a.active")]
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

    [FindsBy(How = How.CssSelector, Using = "#match-summary div.row div:nth-of-type(1) div.results.row div.matches.col-sm-12 div.row div.no-results.col-sm-12 p:nth-of-type(2) a")]
    [CacheLookup]
    private IWebElement tineyeIndex;

    [FindsBy(How = How.CssSelector, Using = "a[href='https://labs.tineye.com']")]
    [CacheLookup]
    private IWebElement tineyeLabs;

    [FindsBy(How = How.Id, Using = "file_submit")]
    [CacheLookup]
    private IWebElement uploadImage;

    [FindsBy(How = How.Id, Using = "upload_box")]
    [CacheLookup]
    private IWebElement weArentAbleToConnectTo1;

    [FindsBy(How = How.Id, Using = "url_box")]
    [CacheLookup]
    private IWebElement weArentAbleToConnectTo2;

    [FindsBy(How = How.Id, Using = "url_submit")]
    [CacheLookup]
    private IWebElement weArentAbleToConnectTo3;

    [FindsBy(How = How.Id, Using = "upload_box_drag")]
    [CacheLookup]
    private IWebElement weArentAbleToConnectTo4;

    [FindsBy(How = How.Id, Using = "file_submit")]
    [CacheLookup]
    private IWebElement weArentAbleToConnectTo5;

    [FindsBy(How = How.Id, Using = "url_box_drag")]
    [CacheLookup]
    private IWebElement weArentAbleToConnectTo6;

    [FindsBy(How = How.Id, Using = "url_submit")]
    [CacheLookup]
    private IWebElement weArentAbleToConnectTo7;

    [FindsBy(How = How.Id, Using = "g-recaptcha-response-100000")]
    [CacheLookup]
    private IWebElement weArentAbleToConnectTo8;

    [FindsBy(How = How.CssSelector, Using = "a[href='/faq#uploading']")]
    [CacheLookup]
    private IWebElement weDoNotSaveYourSearch;

    [FindsBy(How = How.CssSelector, Using = "a[href='https://services.tineye.com/WineEngine']")]
    [CacheLookup]
    private IWebElement wineengine;

    public SearchPage()
        : this(default(IWebDriver), new Dictionary<string, string>(), 15)
    {
    }

    public SearchPage(IWebDriver driver)
        : this(driver, new Dictionary<string, string>(), 15)
    {
    }

    public SearchPage(IWebDriver driver, ExtentReportsHelper reportsHelper)
    {
        this.driver = driver;
        extentReportsHelper = reportsHelper;

    }

    public SearchPage(IWebDriver driver, Dictionary<string, string> data)
        : this(driver, data, 15)
    {
    }

    public SearchPage(IWebDriver driver, Dictionary<string, string> data, int timeout)
    {
        this.driver = driver;
        this.data = data;
        this.timeout = timeout;
    }

    /// <summary>
    /// Click on About Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickAbout1Link() 
    {
        about1.Click();
        return this;
    }

    /// <summary>
    /// Click on About Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickAbout2Link() 
    {
        about2.Click();
        return this;
    }

    /// <summary>
    /// Click on About Tineye Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickAboutTineyeLink() 
    {
        aboutTineye.Click();
        return this;
    }

    /// <summary>
    /// Click on Ads Via Carbon Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickAdsViaCarbon1Link() 
    {
        adsViaCarbon1.Click();
        return this;
    }

    /// <summary>
    /// Click on Ads Via Carbon Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickAdsViaCarbon2Link() 
    {
        adsViaCarbon2.Click();
        return this;
    }

    /// <summary>
    /// Click on 40.9 Billion Images Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickBillionImagesLink409() 
    {
        billionImages409.Click();
        return this;
    }

    /// <summary>
    /// Click on Blog Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickBlogLink() 
    {
        blog.Click();
        return this;
    }

    /// <summary>
    /// Click on Browser Extensions Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickBrowserExtensionsLink() 
    {
        browserExtensions.Click();
        return this;
    }

    /// <summary>
    /// Click on Careers Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickCareersLink() 
    {
        careers.Click();
        return this;
    }

    /// <summary>
    /// Click on Contact Us Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickContactUsLink() 
    {
        contactUs.Click();
        return this;
    }

    /// <summary>
    /// Click on Documentation Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickDocumentationLink() 
    {
        documentation.Click();
        return this;
    }

    /// <summary>
    /// Click on Faqs Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickFaqsLink() 
    {
        faqs.Click();
        return this;
    }

    /// <summary>
    /// Click on Help Center Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickHelpCenterLink() 
    {
        helpCenter.Click();
        return this;
    }

    /// <summary>
    /// Click on How Tineye Works Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickHowTineyeWorksLink() 
    {
        howTineyeWorks.Click();
        return this;
    }

    /// <summary>
    /// Click on How To Use Tineye Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickHowToUseTineye1Link() 
    {
        howToUseTineye1.Click();
        return this;
    }

    /// <summary>
    /// Click on How To Use Tineye Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickHowToUseTineye2Link() 
    {
        howToUseTineye2.Click();
        return this;
    }

    /// <summary>
    /// Click on Image Search And Recognition Company Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickImageSearchAndRecognitionCompanyLink() 
    {
        imageSearchAndRecognitionCompany.Click();
        return this;
    }

    /// <summary>
    /// Click on Image Search Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickImageSearchLink() 
    {
        imageSearch.Click();
        return this;
    }

    /// <summary>
    /// Click on Learn About Our Technology Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickLearnAboutOurTechnologyLink() 
    {
        learnAboutOurTechnology.Click();
        return this;
    }

    /// <summary>
    /// Click on Legal Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickLegalLink() 
    {
        legal.Click();
        return this;
    }

    /// <summary>
    /// Click on Limited Time Offer Get 10 Free Adobe Stock Images. Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickLimitedTimeOfferGet10FreeLink() 
    {
        limitedTimeOfferGet10Free.Click();
        return this;
    }

    /// <summary>
    /// Click on Log In Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickLogIn1Link() 
    {
        logIn1.Click();
        return this;
    }

    /// <summary>
    /// Click on Log In Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickLogIn2Link() 
    {
        logIn2.Click();
        return this;
    }

    /// <summary>
    /// Click on Matchengine Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickMatchengineLink() 
    {
        matchengine.Click();
        return this;
    }

    /// <summary>
    /// Click on Mobileengine Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickMobileengineLink() 
    {
        mobileengine.Click();
        return this;
    }

    /// <summary>
    /// Click on Multicolorengine Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickMulticolorengineLink() 
    {
        multicolorengine.Click();
        return this;
    }

    /// <summary>
    /// Click on Our Clients Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickOurClientsLink() 
    {
        ourClients.Click();
        return this;
    }

    /// <summary>
    /// Click on Our Technology Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickOurTechnologyLink() 
    {
        ourTechnology.Click();
        return this;
    }

    /// <summary>
    /// Click on Overview Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickOverviewLink() 
    {
        overview.Click();
        return this;
    }

    /// <summary>
    /// Click on People Or Objects Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickPeopleOrObjectsLink() 
    {
        peopleOrObjects.Click();
        return this;
    }

    /// <summary>
    /// Click on Press Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickPressLink() 
    {
        press.Click();
        return this;
    }

    /// <summary>
    /// Click on Products Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickProducts1Link() 
    {
        products1.Click();
        return this;
    }

    /// <summary>
    /// Click on Products Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickProducts2Link() 
    {
        products2.Click();
        return this;
    }

    /// <summary>
    /// Click on Register Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickRegisterLink() 
    {
        register.Click();
        return this;
    }

    /// <summary>
    /// Click on Search Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickSearch1Link() 
    {
        search1.Click();
        return this;
    }

    /// <summary>
    /// Click on Search Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickSearch2Link() 
    {
        search2.Click();
        return this;
    }

    /// <summary>
    /// Click on Support Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickSupportLink() 
    {
        support.Click();
        return this;
    }

    /// <summary>
    /// Click on Technology Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickTechnology1Link() 
    {
        technology1.Click();
        return this;
    }

    /// <summary>
    /// Click on Technology Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickTechnology2Link() 
    {
        technology2.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickTineye1Link() 
    {
        tineye1.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickTineye2Link() 
    {
        tineye2.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Alerts Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickTineyeAlertsLink() 
    {
        tineyeAlerts.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Api Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickTineyeApiLink() 
    {
        tineyeApi.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Index Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickTineyeIndexLink() 
    {
        tineyeIndex.Click();
        return this;
    }

    /// <summary>
    /// Click on Tineye Labs Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickTineyeLabsLink() 
    {
        tineyeLabs.Click();
        return this;
    }

    /// <summary>
    /// Click on Upload Image Button.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickUploadImageButton() 
    {
        uploadImage.Click();
        return this;
    }

    /// <summary>
    /// Click on We Arent Able To Connect To Google Recaptcha Button.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickWeArentAbleToConnectTo3Button() 
    {
        weArentAbleToConnectTo3.Click();
        return this;
    }

    /// <summary>
    /// Click on We Arent Able To Connect To Google Recaptcha Button.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickWeArentAbleToConnectTo5Button() 
    {
        weArentAbleToConnectTo5.Click();
        return this;
    }

    /// <summary>
    /// Click on We Arent Able To Connect To Google Recaptcha Button.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickWeArentAbleToConnectTo7Button() 
    {
        weArentAbleToConnectTo7.Click();
        return this;
    }

    /// <summary>
    /// Click on We Do Not Save Your Search Images Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickWeDoNotSaveYourSearchLink() 
    {
        weDoNotSaveYourSearch.Click();
        return this;
    }

    /// <summary>
    /// Click on Wineengine Link.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage ClickWineengineLink() 
    {
        wineengine.Click();
        return this;
    }

    /// <summary>
    /// Fill every fields in the page.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage Fill() 
    {
        SetWeArentAbleToConnectTo2TextField();
        SetWeArentAbleToConnectTo6TextField();
        SetWeArentAbleToConnectTo8TextareaField();
        return this;
    }

    /// <summary>
    /// Fill every fields in the page and submit it to target page.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage FillAndSubmit() 
    {
        Fill();
        return Submit();
    }

    /// <summary>
    /// Set default value to We Arent Able To Connect To Google Recaptcha Text field.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage SetWeArentAbleToConnectTo1TextField() 
    {
        return SetWeArentAbleToConnectTo1TextField(data["WE_ARENT_ABLE_TO_CONNECT_TO_1"]);
    }

    /// <summary>
    /// Set value to We Arent Able To Connect To Google Recaptcha Text field.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage SetWeArentAbleToConnectTo1TextField(string weArentAbleToConnectTo1Value)
    {
        return this;
    }

    /// <summary>
    /// Set default value to We Arent Able To Connect To Google Recaptcha Text field.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage SetWeArentAbleToConnectTo2TextField() 
    {
        return SetWeArentAbleToConnectTo2TextField(data["WE_ARENT_ABLE_TO_CONNECT_TO_2"]);
    }

    /// <summary>
    /// Set value to We Arent Able To Connect To Google Recaptcha Text field.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage SetWeArentAbleToConnectTo2TextField(string weArentAbleToConnectTo2Value)
    {
        weArentAbleToConnectTo2.SendKeys(weArentAbleToConnectTo2Value);
        return this;
    }

    /// <summary>
    /// Set We Arent Able To Connect To Google Recaptcha File field.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage SetWeArentAbleToConnectTo4FileField() 
    {
        return this;
    }

    /// <summary>
    /// Set default value to We Arent Able To Connect To Google Recaptcha Text field.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage SetWeArentAbleToConnectTo6TextField() 
    {
        return SetWeArentAbleToConnectTo6TextField(data["WE_ARENT_ABLE_TO_CONNECT_TO_6"]);
    }

    /// <summary>
    /// Set value to We Arent Able To Connect To Google Recaptcha Text field.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage SetWeArentAbleToConnectTo6TextField(string weArentAbleToConnectTo6Value)
    {
        weArentAbleToConnectTo6.SendKeys(weArentAbleToConnectTo6Value);
        return this;
    }

    /// <summary>
    /// Set default value to We Arent Able To Connect To Google Recaptcha Textarea field.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage SetWeArentAbleToConnectTo8TextareaField() 
    {
        return SetWeArentAbleToConnectTo8TextareaField(data["WE_ARENT_ABLE_TO_CONNECT_TO_8"]);
    }

    /// <summary>
    /// Set value to We Arent Able To Connect To Google Recaptcha Textarea field.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage SetWeArentAbleToConnectTo8TextareaField(string weArentAbleToConnectTo8Value)
    {
        weArentAbleToConnectTo8.SendKeys(weArentAbleToConnectTo8Value);
        return this;
    }

    /// <summary>
    /// Submit the form to target page.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage Submit() 
    {
        //ClickWeArentAbleToConnectToGoogleRecaptchaButton();
        return this;
    }

    /// <summary>
    /// Verify that the page loaded completely.
    /// </summary>
    /// <returns>The SearchPage class instance.</returns>
    //public SearchPage VerifyPageLoaded() 
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
    /// <returns>The SearchPage class instance.</returns>
    public SearchPage VerifyPageUrl() 
    {
        new WebDriverWait(driver, TimeSpan.FromSeconds(timeout)).Until<bool>((d) =>
        {
            return d.Url.Contains(pageUrl);
        });
        return this;
    }


    public SearchPage VerifyPageLoaded()
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
            status.ReturnedMessage = "Page title Not Verified";
            return this;
        }


    }

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
            status.ReturnedMessage = "Images found";
            return this;
        }

    }
}
