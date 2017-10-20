using System;
using TechTalk.SpecFlow;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ShipCompliantCAVLTests
{

    class OpenBrowser
    {
        private const string PageUri = @"https://portal-staging.shipcompliant.com";
        
        [Test]
        public void StartApplication()
        {
           /* using (IWebDriver driver = new FirefoxDriver())
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl(PageUri);
                
            }*/
        }

    }
}
