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
   static class SeleniumGetMethods
    {
        public static Status GetText(this IWebElement element)
        {
            Status status = new Status(false);
            try
            {
                 //status.CustomMessage = element.GetAttribute("text");
                status.CustomMessage = element.Text;
                return status;
            }
            catch (Exception e)
            {
                status.ErrorOccurred = true;
                status.ReturnedMessage += e.StackTrace;
                status.ReturnedValue = 1;
                return status;
                /*throw*/;
            }
            
        }
        public static Status GetTextFromDDL(this IWebElement element)
        {
            Status status = new Status(false);
            try
            {
                status.CustomMessage = new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
                return status;
            }
            catch (Exception e)
            {
                status.ErrorOccurred = true;
                status.ReturnedMessage += e.StackTrace;
                status.ReturnedValue = 1;
                return status;
                /*throw*/;
            }
            
        }

     }
}
