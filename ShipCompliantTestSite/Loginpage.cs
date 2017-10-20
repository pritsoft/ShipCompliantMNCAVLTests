using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace ShipCompliantCAVLTests
{
    
    public class Loginpage
    {
        private readonly IWebDriver _driver;
        private const string PageUri = @"https://portal-staging.shipcompliant.com";

 
        public Loginpage(IWebDriver driver)
        {
            _driver = driver;
        }

        public static Loginpage NavigateTo(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(PageUri);

            return new Loginpage(driver);
        }

        
        public string EmailAddress
        {
            set
            {
                _driver.FindElement(By.Id("inUsername")).SendKeys(value);
            }


        }
        public string UserPassword
        {
            set
            {
                _driver.FindElement(By.Id("inPassword")).SendKeys(value);
            }
        }
        
        
        public void SubmitCredentials()
        {
            _driver.FindElement(By.Id("btnSubmit")).Click();

            //return new HomePage(_driver);
        }
        

   
    }
}
