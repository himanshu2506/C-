using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebPageTest.Base
{
     public class Loader
    {
            public static IWebDriver driver;
            public void invoke()
            {
                driver = new ChromeDriver();
            }
            public void open()
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            }
            public void close()
            {
                driver.Close();
            }
           public string check(string id, string pass)
           {
            string exoutput = " ";
            if ((id == "") && (pass == ""))
            {
                exoutput = "An email address required.";
                return exoutput;
            }
            else if (pass == "")
            {
                exoutput = "Password is required.";
                return exoutput;
            }
            else if (id == "")
            {
                exoutput = "An email address required.";
                return exoutput;
            }
            else
            {
                exoutput = "Authentication failed.";
                return exoutput;
            }
        }
        }
}
