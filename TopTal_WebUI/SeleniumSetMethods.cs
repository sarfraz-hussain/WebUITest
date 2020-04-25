using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Return.Status;


namespace Selenium.Core.CSharp
{

     static class SeleniumSetMethods
    {

        public static Status EnterText(this IWebElement element, string value)
        {
            Status status = new Status(false);
            try
            {
                element.SendKeys(value);
                return status;
            }
            catch (Exception e)
            {
                status.ErrorOccurred = true;
                status.ReturnedMessage += e.StackTrace;
                status.ReturnedValue = 1;
                return status;
                //throw;
            }

        }

        public static Status click(this IWebElement element)
        {
            Status status = new Status(false);
            try
            {
                element.Click();
                return status;
            }
            catch (Exception e)
            {
                status.ErrorOccurred = true;
                status.ReturnedMessage += e.StackTrace;
                status.ReturnedValue = 1;
                return status;
                //throw;
            }
        }

        public static Status SelectDropDown(this IWebElement element, string value)
        {
            Status status = new Status(false);
            try
            {
                new SelectElement(element).SelectByValue(value);
                return status;
            }
            catch (Exception e)
            {
                status.ErrorOccurred = true;
                status.ReturnedMessage += e.StackTrace;
                status.ReturnedValue = 1;
                return status;
                //throw;
            } 
        }
    }

    //public class Status
    //{
    //    public bool ErrorOccurred { get; set; }
    //    public String ErrorMessage { get; set; }
    //    public int ErrorValue{ get; set; }


    //    public Status()
    //    {
    //        this.ErrorOccurred = false;
    //        this.ErrorMessage = null;
    //        this.ErrorValue = 0;

    //    }

    //}
}

