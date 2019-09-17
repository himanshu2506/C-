using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebPageTestSearch.Base;

namespace WebPageTestSearch.BusinessLogic
{
   public class Logic
    {
       
        Loader obj = new Loader();
        public static IWebDriver driver;
        public void invoke()
        {
            driver = new ChromeDriver();
        }
        public void open()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.expedia.com/");
        }
        public void close()
        {
            driver.Close();
        }
        public bool selectFlight()
        {
            try
            {
                IWebElement flight = driver.FindElement(By.Id("tab-flight-tab-hp"));
                obj.click(flight);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool selectMultiCity()
        {
            try
            {
                IWebElement MultiCity= driver.FindElement(By.Id("flight-type-multi-dest-label-hp-flight"));
                obj.click(MultiCity);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool AddAnotherFlight()
        {
            try
            {
                IWebElement add= driver.FindElement(By.Id("add-flight-leg-hp-flight"));
                obj.click(add);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool fillData(string FirstStation, string SecondStation, string ThirdStation, string FirstDate, string SecondDate, string ThirdDate, string number)
        {
            try
            {
                IWebElement station1 = driver.FindElement(By.Id("flight-origin-hp-flight"));
                obj.click(station1);
                obj.typetext(station1, FirstStation);
                IWebElement station2= driver.FindElement(By.Id("flight-destination-hp-flight"));
                obj.click(station2);
                obj.typetext(station2, SecondStation);
                IWebElement Date1= driver.FindElement(By.Id("flight-departing-single-hp-flight"));
                obj.click(Date1);
                obj.typetext(Date1, FirstDate);
                IWebElement Travelers= driver.FindElement(By.Id("traveler-selector-hp-flight"));
                obj.click(Travelers);
                IWebElement trav= driver.FindElement(By.XPath("(//button[@class='uitk-step-input-button uitk-step-input-plus'])[1]"));
                for (int i = 1; i < int.Parse(number); i++)
                {
                    obj.click(trav);
                }
                IWebElement AdultSelectorCloseBtn=driver.FindElement(By.XPath("//div[@id='traveler-selector-hp-flight']//button[@class ='close btn-text']"));
                obj.click(AdultSelectorCloseBtn);
                IWebElement station3= driver.FindElement(By.Id("flight-2-origin-hp-flight"));
                obj.click(station3);
                obj.typetext(station3, SecondStation);
                IWebElement station4= driver.FindElement(By.Id("flight-2-destination-hp-flight"));
                obj.click(station4);
                obj.typetext(station4, ThirdStation);
                IWebElement Date2= driver.FindElement(By.Id("flight-2-departing-hp-flight"));
                obj.click(Date2);
                obj.typetext(Date2, SecondDate);
                IWebElement station5= driver.FindElement(By.Id("flight-3-origin-hp-flight"));
                obj.click(station5);
                obj.typetext(station5, ThirdStation);
                IWebElement station6= driver.FindElement(By.Id("flight-3-destination-hp-flight"));
                obj.click(station6);
                obj.typetext(station6, FirstStation);
                IWebElement Date3= driver.FindElement(By.Id("flight-3-departing-hp-flight"));
                obj.click(Date3);
                obj.typetext(Date3, ThirdDate);
                return true;
            }
            catch (Exception e)
            {

                return false;
                throw e;

            }
        }
        public bool selectSearch()
        {
            try
            {
                IWebElement search= driver.FindElement(By.XPath("//form[@id = 'gcw-flights-form-hp-flight']//button[@type='submit']"));
                obj.click(search);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void select()
        {
            IWebElement select=driver.FindElement(By.XPath("//ul[@id='flightModuleList']//li[1]//button"));
           
            Thread.Sleep(2000);
            select = driver.FindElement(By.XPath("//ul[@id='flightModuleList']//li[1]//button"));
            obj.click(select);

            Thread.Sleep(2000);
            select = driver.FindElement(By.XPath("//ul[@id='flightModuleList']//li[1]//button"));
            obj.click(select);

            Thread.Sleep(2000);
            select = driver.FindElement(By.XPath("//ul[@id='flightModuleList']//li[1]//button"));
            obj.click(select);

        }
      
    }
}
