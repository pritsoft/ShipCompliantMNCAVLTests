using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ShipCompliantCAVLTests
{
    public class HomePage
    {
        private readonly IWebDriver _driver;
        
        
        public HomePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public string CompanyName => _driver.FindElement(By.Id("pageHeader_mainMenuBar_ContextSwitcherHeader1_lbl")).Text;

        
    }
}
