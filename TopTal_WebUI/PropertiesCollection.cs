using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_CSharp
{
    public class propertiesCollection
    {
        public static IWebDriver driver { get; set; }
    }

    enum PropertyType
    {
        ID,
        Name,
        LinkText,
        CSSName,
        ClassName
    }
}
