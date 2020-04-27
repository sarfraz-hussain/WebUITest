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
        /// Test Objective: Verify Landing Page lists Required Elements
        /// Test Steps:
        ///     Naviate to Main Page
        ///         Verify Page loaded
        ///         Verify Page Title 
        ///         Verify Page lists Technology, Products and LogIN option
        ///         Verify to Serch image, Page lists TextBox for Image Link
        ///         Verify to Search image, a button is provided to upload file
        ///         Verify User can click on Search button to start search
        ///         
        /// </summary>
 

        [Test]
        public void Verify_Main_Page_Elements()
        {
            HomePage homepage = Pages.homePage;

            //Verification of page load and title
            log(Pages.homePage.VerifyPageLoaded(), "Page Not Loaded");
            log(Pages.homePage.VerifyPageTitle(), "Page Title not Verified");

            //Verification of page elemens
            log(Pages.homePage.VerifyPageElements(homepage.Technology), "Page Element 'Tehnology' not found");
            log(Pages.homePage.VerifyPageElements(homepage.Products), "Page Element 'Products' not found");
            log(Pages.homePage.VerifyPageElements(homepage.LogIn), "Page Element 'LogIn' not found");
 
            //verification of page search elements
            log(Pages.homePage.VerifyPageElements(homepage.Search), "Page Element 'Search Image' not found");
            log(Pages.homePage.VerifyPageElements(homepage.UploadImage), "Page Element 'Upload Image Button ' not found");
            log(Pages.homePage.VerifyPageElements(homepage.ImageuUrlTxtBox), "Page Element 'url TextBox' not found");
        }

        private void log(HomePage page, string message)
        {
            Assert.IsFalse(page.status.ErrorOccurred, message);
        }

    }
}
