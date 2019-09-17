using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebPageTestSearch.Base
{
   public class Loader
    {
        public static IWebDriver driver=new ChromeDriver();
        
        public void click(IWebElement element)
        {
            element.Click();
        }
        public void typetext(IWebElement element, string value)
        {
            element.SendKeys(value);
        }
    }
}
