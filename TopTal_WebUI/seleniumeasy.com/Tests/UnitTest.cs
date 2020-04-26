using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace SeleniumEasy.COM
{
    [TestFixture]
    class UnitTest : TestBase
    {
        

        [Test]
        public void VerifyMainPage()
        {
            HomePage homepage = Pages.homePage;

            log(Pages.homePage.VerifyPageLoaded(), "Page Not Loaded");
            log(Pages.homePage.VerifyPageTitle(), "Page Title not Verified");
            log(Pages.homePage.VerifyPageElements(homepage.Technology), "Page Element 'Tehnology' not found");
            log(Pages.homePage.VerifyPageElements(homepage.Products), "Page Element 'Products' not found");
            log(Pages.homePage.VerifyPageElements(homepage.LogIn), "Page Element 'LogIn' not found");
            log(Pages.homePage.VerifyPageTitle(), "Page Title not Verified");
            log(Pages.homePage.VerifyPageElements(homepage.Search), "Page Element 'Search Image' not found");
            log(Pages.homePage.VerifyPageElements(homepage.UploadImage), "Page Element 'Upload Image Button ' not found");
            log(Pages.homePage.VerifyPageElements(homepage.ImageuUrlTxtBox), "Page Element 'url TextBox' not found");

        }

        [Test]
        public void UploadImage()
        {
            HomePage homepage = Pages.homePage;

            log(Pages.homePage.VerifyPageTitle(), "Page Title not Verified");
            log(Pages.homePage.ImageUpload(), "Image Could not be uploaded");


            log(Pages.searchPage.VerifyPageLoaded(), "Page Not Loaded");
            log(Pages.searchPage.VerifyPageTitle(), "Page Title not Verified");
            log(Pages.searchPage.verifySearchResults(), "Un expected happend");


        }

        [Test]
        public void SearchImage()
        {
            HomePage homepage = Pages.homePage;

            log(Pages.homePage.VerifyPageLoaded(), "Page Not Loaded");
            log(Pages.homePage.VerifyPageTitle(), "Page Title not Verified");
            log(Pages.homePage.searchImagebyURL(), "URL not uploaded");
            log(Pages.homePage.ClickSearchButton(), "Search button not clicked");

            log(Pages.errorPage.VerifyPageLoaded(), "Page Not Loaded");
            log(Pages.errorPage.VerifyPageTitle(), "Page Title not Verified");
            log(Pages.errorPage.verifySearchResults(), "Seacrh Functinality Not Working using URL");

        }

        [Test]
        public void SearchImageURL()
        {
            HomePage homepage = Pages.homePage;

            log(Pages.homePage.VerifyPageLoaded(), "Page Not Loaded");
            log(Pages.homePage.VerifyPageTitle(), "Page Title not Verified");
            //log(Pages.homePage.searchImagebyURL(), "URL not uploaded");
            log(Pages.homePage.ClickSearchButton(), "Search button not clicked");

            log(Pages.errorPage.VerifyPageLoaded(), "Page Not Loaded");
            log(Pages.errorPage.VerifyPageTitle(), "Page Title not Verified");
            log(Pages.errorPage.verifyBlankSearchResults(), "Seacrh Functinality Not Working, as expected");

        }

        [Test]
        public void InvalidLogIn()
        {
            LogInPage loginpage = Pages.loginPage;

            log(Pages.loginPage.OpenLogInPage(), "Page Not Loaded");
            log(Pages.loginPage.VerifyPageLoaded(), "Page Not Loaded");
            log(Pages.loginPage.VerifyPageTitle(), "Page Title not Verified");

            log(Pages.loginPage.VerifyPageElements(loginpage.Email), "Page Element 'Email' not found");
            log(Pages.loginPage.VerifyPageElements(loginpage.Password), "Page Element 'Password' not found");
            log(Pages.loginPage.VerifyPageElements(loginpage.LogIn), "Page Element 'LogIn' not found");
            log(Pages.loginPage.PerformLogIN("Admin","Admin"), "Log In Operations Failed");

            log(Pages.loginPage.VerifyPageTitle(), "Page Title not Verified");
            log(Pages.loginPage.verifyLogInErrorMessage(), "LogIn Behaviour is not as Desired");



        }



        private void log(HomePage page, string message)
        {
            Assert.IsFalse(page.status.ErrorOccurred, message);
        }
        private void log(SearchPage page, string message)
        {
            Assert.IsFalse(page.status.ErrorOccurred, message);
        }
        private void log(SearchErrorPage page, string message)
        {
            Assert.IsFalse(page.status.ErrorOccurred, message);
        }
        private void log(LogInPage page, string message)
        {
            Assert.IsFalse(page.status.ErrorOccurred, message);
        }

    }
}


/*
namespace SeleniumEasy.COM
{

    [TestFixture]
    class UnitTest
    {
       private static readonly IWebDriver driver = new ChromeDriver();
       TinEye mainPage = new TinEye(driver);

        [OneTimeSetUp]
        public void oneTimeSetup()
        {
            mainPage.navigate();
            mainPage.initPage();
            driver.Manage().Window.Maximize();

           // wait Configuration
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(39));
            //wait.Until(ExpectedConditions.ElementExists(By.Name("")));
            //wait.Until(ExpectedConditions.AlertIsPresent());
        }

        [SetUp]
        public void Setup ()
        {
            driver.Navigate().Refresh();
        }
        
        [Test]
        public void VerifyMainPage()
        {
            mainPage.searchByImageAndFindWhere1.Click();
        }

        [Test]
        public void VerifyMainPage2()
        {
            //mainPage.ClickInputForms2Link();
        }

        [TearDown]
        public void CloseAll()
        {
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            driver.Close();
        }


        
    }
}
*/
