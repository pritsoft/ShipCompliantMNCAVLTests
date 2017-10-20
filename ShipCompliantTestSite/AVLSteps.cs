using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using ShipCompliantTestSite;

namespace ShipCompliantTestSite
{
    [Binding]
    public class AVLSteps
    {
        private readonly IWebDriver _driver;


        [Given(@"I enter an avl email address")]
        public void GivenIEnterAnAvlEmailAddress()
        {
            
            _loginPage.EmailAddress = "avl@six88.com";
        }

        [Given(@"I enter an avl password")]
        public void GivenIEnterAnAvlPassword()
        {
            _loginPage.UserPassword = "Ship1Test";
        }

        [Given(@"I upload an avl sales order file")]
        public void GivenIUploadAnAvlSalesOrderFile()
        {
            _driver.FindElement(By.XPath("//input[@id='ctl00_ctl00_PageMainContent_Main_import_txtFile']")).Click();
            Thread.Sleep(3000);
            String pathToFile = "O:\\QA\\SC\\CAVL_AVL_SalesOrder_Files\\AVL Sales Files\\All_States_AVL_SalesOrders Post 2011 - Copy.xls";
            System.Windows.Forms.SendKeys.SendWait("^a");
            Thread.Sleep(3000);
            System.Windows.Forms.SendKeys.SendWait("{BACKSPACE}");
            Thread.Sleep(3000);
            System.Windows.Forms.SendKeys.SendWait(pathToFile);
            Thread.Sleep(3000);
            System.Windows.Forms.SendKeys.SendWait("{ENTER}");
            Thread.Sleep(3000);
        }

        [Then(@"I should see an aggregate volume limit compliance failure")]
        public void ThenIShouldSeeAnAggregateVolumeLimitComplianceFailure()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
