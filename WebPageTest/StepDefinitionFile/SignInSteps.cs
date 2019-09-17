using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using WebPageTest.Base;

namespace WebPageTest.StepDefinitionFile
{
    [Binding]
    public class SignInSteps : Loader
    {
        string output = " ";
        
        [When(@"Click on Sign In")]
        public void WhenClickOnSignIn()
        {
            invoke();
            driver.Manage().Window.Maximize();
            open();
            driver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]/a")).Click();
        }

        [When(@"User enter (.*) and (.*)")]
        public void WhenUserEnterAnd(string p0, string p1)
        {
            driver.FindElement(By.Id("email")).SendKeys(p0);
            driver.FindElement(By.Id("passwd")).SendKeys(p1);
            output = check(p0, p1);
        }
        
        [When(@"user Click on Sign In Button")]
        public void WhenUserClickOnSignInButton()
        {
            driver.FindElement(By.Id("SubmitLogin")).Click();
        }
        
        [Then(@"An email address required should be visible")]
        public void ThenAnEmailAddressRequiredShouldBeVisible()
        {
            IWebElement element = driver.FindElement(By.XPath(" //*[@id='center_column']/div[1]/ol/li"));
            string actualoutput = element.GetAttribute("innerHTML");
            Assert.AreEqual(output, actualoutput);
            driver.Quit();
        }
    }
}
