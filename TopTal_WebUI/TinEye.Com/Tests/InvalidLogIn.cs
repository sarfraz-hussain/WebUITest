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
        /// Test Objective: LogIn attempt with invalid UserName  Password is Rejected with error message
        /// 
        /// Test Steps:
        ///     Naviate to LogIn Page
        ///         Verify Page loaded
        ///         Verify Page Title 
        ///         Verify Page lists Email, Password and LogIN Button
        ///         
        ///     Perform LogIn Operation with invalid Username and Password
        ///         Verify page remain same
        ///         Verify attempt failed messgae is geneated
        ///         
        /// </summary>

        [Test]
        public void LogIn_With_Invalid_Credentials()
        {
            LogInPage loginpage = Pages.loginPage;

            //Navigate to LogIn Page & verify Page title
            log(Pages.loginPage.OpenLogInPage(), "Page Not Loaded");
            log(Pages.loginPage.VerifyPageLoaded(), "Page Not Loaded");
            log(Pages.loginPage.VerifyPageTitle(), "Page Title not Verified");

            //Vaerify LogIn page lists, email, password and LogIn Button
            log(Pages.loginPage.VerifyPageElements(loginpage.Email), "Page Element 'Email' not found");
            log(Pages.loginPage.VerifyPageElements(loginpage.Password), "Page Element 'Password' not found");
            log(Pages.loginPage.VerifyPageElements(loginpage.LogIn), "Page Element 'LogIn' not found");

            //Perform LogIn with nvalid User name amd Pasword
            log(Pages.loginPage.PerformLogIN("Admin", "Admin"), "Log In Operations Failed");

            //Verify Page is not navigaed and Error Messae is sown
            log(Pages.loginPage.VerifyPageTitle(), "Page Title not Verified");
            log(Pages.loginPage.verifyLogInErrorMessage(), "LogIn Behaviour is not as Desired");
        }


        private void log(LogInPage page, string message)
            {
                Assert.IsFalse(page.status.ErrorOccurred, message);
            }

        }
}
