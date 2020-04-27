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
namespace TopTal.WebUI
{
    [TestFixture]
    partial class UnitTest : TestBase
    {
        /// <summary>
        /// 
        /// Test Objective: To verify if Image URL is iven , app is able to find the image
        /// Test Steps:
        ///     Naviate to Main Page
        ///         Verify Page loaded
        ///         Verify Page Title 
        ///     
        ///     Insert Image URL in search Box
        ///         Verify Page is naviated to search page
        ///         Verify image is searched without any eror
        ///         
        /// </summary>

        [Test]
        public void Search_Image_By_URL()
        {
            HomePage homepage = Pages.homePage;

            //Navigatet to Main page and verify pae Load and title
            log(Pages.homePage.VerifyPageLoaded(), "Page Not Loaded");
            log(Pages.homePage.VerifyPageTitle(), "Page Title not Verified");

            //Insert Image Url in SearchBox and Click to start search
            log(Pages.homePage.searchImagebyURL(), "URL not uploaded");
            log(Pages.homePage.ClickSearchButton(), "Search button not clicked");

            //Verify Search page is shown with rsults
            log(Pages.errorPage.VerifyPageLoaded(), "Page Not Loaded");
            log(Pages.errorPage.VerifyPageTitle(), "Page Title not Verified");
            log(Pages.errorPage.verifySearchResults(), "Seacrh Functinality Not Working using URL");

        }

        private void log(SearchErrorPage page, string message)
        {
            Assert.IsFalse(page.status.ErrorOccurred, message);
        }

    }
}
