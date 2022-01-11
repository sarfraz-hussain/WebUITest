using NUnit.Framework
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
        /// Test Objective: To verify If if no image is selected and search is performed, app displays error message
        /// Test Steps:
        ///     Naviate to Main Page
        ///         Verify Page loaded
        ///         Verify Page Title
        ///    Click Search Image button, without uploading any image
        ///         Verify page is navigated to search page
        ///         Verify Error Message is shown
        ///         
        /// </summary>


        [Test]
        public void Search_Without_Image_Selection()
        {
            HomePage homepage = Pages.homePage;
            //verify page is loaded and title is verifed
            log(Pages.homePage.VerifyPageLoaded(), "Page Not Loaded");
            log(Pages.homePage.VerifyPageTitle(), "Page Title not Verified");
            
            //Perform search without uploading any image
            log(Pages.homePage.ClickSearchButton(), "Search button not clicked");

            //verify serch page is shown with error message
            log(Pages.errorPage.VerifyPageLoaded(), "Page Not Loaded");
            log(Pages.errorPage.VerifyPageTitle(), "Page Title not Verified");
            log(Pages.errorPage.verifyBlankSearchResults(), "Seacrh Functinality Not Working, as expected");

        }


    }
}
