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
     partial class  UnitTest : TestBase
    {
        /// <summary>
        /// 
        /// Test Objective: Upload imae from local stoorage and verify a Unique Image is uploaded
        /// Test Steps:
        ///     Naviate to Main Page
        ///         Verify Page loaded
        ///         Verify Page Title 
        ///         
        ///     Upload a Unique Image
        ///         Verify Imae is uploaded and Page navigated to Search page
        ///         Verify Unique image message is displayed
        ///         
        /// </summary>

        [Test]
        public void Upload_Image_By_File_Selection()
        {
            HomePage homepage = Pages.homePage;
            
            //Navigate to main page and verify page title
            log(Pages.homePage.VerifyPageTitle(), "Page Title not Verified");

            // Upload Image from local storage
            log(Pages.homePage.ImageUpload(), "Image Could not be uploaded");

            //verify Search Page is navigated
            log(Pages.searchPage.VerifyPageLoaded(), "Page Not Loaded");
            log(Pages.searchPage.VerifyPageTitle(), "Page Title not Verified");

            //Verify Unique image messae is displayed
            log(Pages.searchPage.verifySearchResults(), "Un expected happend");

        }


        private void log(SearchPage page, string message)
        {
            Assert.IsFalse(page.status.ErrorOccurred, message);
        }

    }
}
