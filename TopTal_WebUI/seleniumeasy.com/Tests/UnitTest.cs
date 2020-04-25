using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Pages.mPaige.ClickInputForms1Link();
            Pages.mPaige.ClickSimpleFormDemo1Link();
            //Pages.basicForm.FillAndSubmit();

        }
        [Test]
        public void VerifyMainPage2()
        {
            Pages.mPaige.ClickInputForms1Link();
            Pages.mPaige.ClickSimpleFormDemo1Link();

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
