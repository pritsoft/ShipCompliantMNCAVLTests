using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Windows.Forms;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ShipCompliantCAVLTests
{
    [Binding]
    public class CAVLSteps2
    {
        public Loginpage _loginPage;
        public IWebDriver _driver;
        

        [Given(@"I am on the login screen")]
        public void GivenIAmOnTheLoginScreen()
        {
            _driver = new FirefoxDriver();
            Loginpage.NavigateTo(_driver);
            _loginPage = new Loginpage(_driver);
            Thread.Sleep(3000);
        }
        
        [Given(@"I enter an email address")]
        public void GivenIEnterAnEmailAddress()
        {
            _loginPage.EmailAddress = "cavl@six88.com";
        }
        
        [Given(@"I enter a password")]
        public void GivenIEnterAPassword()
        {
            _loginPage.UserPassword = "Ship1Test";
        }

        [Given(@"I enter a Supersupplier email address")]
        public void GivenIEnterASupersupplierEmailAddress()
        {
            _loginPage.EmailAddress = "cavlavl@six88.com";
        }

        [Given(@"I enter a Supersupplier password")]
        public void GivenIEnterASupersupplierPassword()
        {
            _loginPage.UserPassword = "Ship1Test";
        }


        [Given(@"I submit my credentials")]
        public void GivenISubmitMyCredentials()
        {
            _loginPage.SubmitCredentials();
        }
        
        [Given(@"I am on the the home screen")]
        public void GivenIAmOnTheTheHomeScreen()
        {
            Thread.Sleep(2000);
            IWebElement _title = _driver.FindElement(By.Id("pageHeader_mainMenuBar_ContextSwitcherHeader1_lbl"));
            Assert.AreEqual(_title.Text, "Test Auto CAVL Supplier");  
        }

        [Given(@"I am on the the Supersupplier home screen")]
        public void GivenIAmOnTheTheSupersupplierHomeScreen()
        {
            Thread.Sleep(2000);
            IWebElement _title = _driver.FindElement(By.Id("pageHeader_mainMenuBar_ContextSwitcherHeader1_lbl"));
            Assert.AreEqual(_title.Text, "Test Auto CAVL AVL Super Supp...");
        }


        [Given(@"I go to the import new order file page")]
        public void GivenIGoToTheImportNewOrderFilePage()
        {
            _driver.Navigate().GoToUrl("https://portal-staging.shipcompliant.com/Web/OrderEntry/Bulk2/BulkOrderCreateOperation.aspx");
            
        }
        
        [Given(@"I upload sales order file")]
        public void GivenIUploadSalesOrderFile()
        {
            _driver.FindElement(By.XPath("//input[@id='ctl00_ctl00_PageMainContent_Main_import_txtFile']")).Click();
            Thread.Sleep(3000);
            String pathToFile = "O:\\QA\\SC\\CAVL_AVL_SalesOrder_Files\\CAVL Sales Files\\All_States_CAVL_AVL_SalesOrders Post 2011 NH Updated.xls";
            System.Windows.Forms.SendKeys.SendWait("^a");
            Thread.Sleep(3000);
            System.Windows.Forms.SendKeys.SendWait("{BACKSPACE}");
            Thread.Sleep(3000);
            System.Windows.Forms.SendKeys.SendWait(pathToFile);
            Thread.Sleep(3000);
            System.Windows.Forms.SendKeys.SendWait("{ENTER}");
            Thread.Sleep(3000);
        }

        [Given(@"I upload MN sales order file")]
        public void GivenIUploadMNSalesOrderFile()
        {
            _driver.FindElement(By.XPath("//input[@id='ctl00_ctl00_PageMainContent_Main_import_txtFile']")).Click();
            Thread.Sleep(3000);
            String pathToFile = "O:\\QA\\SC\\CAVL_AVL_SalesOrder_Files\\CAVL Sales Files\\MN_CAVL_SalesOrders2014.xls";
            System.Windows.Forms.SendKeys.SendWait("^a");
            Thread.Sleep(3000);
            System.Windows.Forms.SendKeys.SendWait("{BACKSPACE}");
            Thread.Sleep(3000);
            System.Windows.Forms.SendKeys.SendWait(pathToFile);
            Thread.Sleep(3000);
            System.Windows.Forms.SendKeys.SendWait("{ENTER}");
            Thread.Sleep(3000);
        }

        [Given(@"I upload Restrictive sales order file")]
        public void GivenIUploadRestrictiveSalesOrderFile()
        {
            _driver.FindElement(By.XPath("//input[@id='ctl00_ctl00_PageMainContent_Main_import_txtFile']")).Click();
            Thread.Sleep(3000);
            String pathToFile = "O:\\QA\\SC\\CAVL_AVL_SalesOrder_Files\\CAVL Sales Files\\Restrictive_CAVL_SalesOrders 2013.xls";
            System.Windows.Forms.SendKeys.SendWait("^a");
            Thread.Sleep(3000);
            System.Windows.Forms.SendKeys.SendWait("{BACKSPACE}");
            Thread.Sleep(3000);
            System.Windows.Forms.SendKeys.SendWait(pathToFile);
            Thread.Sleep(3000);
            System.Windows.Forms.SendKeys.SendWait("{ENTER}");
            Thread.Sleep(3000);
        }


        [Given(@"I choose a spreadsheet mapping")]
        public void GivenIChooseASpreadsheetMapping()
        {
        }
        
        [Given(@"I choose the order source")]
        public void GivenIChooseTheOrderSource()
        {
            Thread.Sleep(2000);
            _driver.FindElement(By.Id("rblOrderSource_0")).Click();
        }
        
        [Given(@"I choose an import detail")]
        public void GivenIChooseAnImportDetail()
        {
            _driver.FindElement(By.Id("ctl00_ctl00_PageMainContent_Main_import_rblActions_2")).Click();
        }
        
        [Given(@"I overwrite existing sales orders")]
        public void GivenIOverwriteExistingSalesOrders()
        {
            IWebElement objChecked;

            objChecked = _driver.FindElement(By.Id("ctl00_ctl00_PageMainContent_Main_import_cbxOverrideCommitted"));
            if (objChecked.Selected is false)
            {
                objChecked.Click();
            }
            //_driver.FindElement(By.Id("ctl00_ctl00_PageMainContent_Main_import_cbxOverrideCommitted")).Click();
        }
        
        [Given(@"I expand advance options")]
        public void GivenIExpandAdvanceOptions()
        {
            _driver.FindElement(By.ClassName("expand-indicator")).Click();
        }
        
        [Given(@"I set a ship date")]
        public void GivenISetAShipDate()
        {
            
        }
        
        [Given(@"I set a fulfillment location")]
        public void GivenISetAFulfillmentLocation()
        {
            
        }
        
        [Given(@"I set a fulfillment type")]
        public void GivenISetAFulfillmentType()
        {
            
        }
        
        [Given(@"I set a sale type")]
        public void GivenISetASaleType()
        {
            
        }
        
        [Given(@"I set a license relationship")]
        public void GivenISetALicenseRelationship()
        {
           // _driver.FindElement(By.Id("ctl00_ctl00_PageMainContent_Main_import_ddlLicenseRelationshipSelector_ddl")).Click();
           // _driver.FindElement()
        }
        
        [Given(@"I set a shipping service")]
        public void GivenISetAShippingService()
        {
            
        }
        
        [When(@"I submit my settings")]
        public void WhenISubmitMySettings()
        {
            _driver.FindElement(By.Id("ctl00_ctl00_PageMainContent_Main_import_btnNext")).Click();
        }
        
        [Then(@"I should see the pending order imports page")]
        public void ThenIShouldSeeThePendingOrderImportsPage()
        {
            Thread.Sleep(16000);
            String _addressChecks = _driver.FindElement(By.CssSelector("table.grid-table:nth-child(4) > tbody:nth-child(1) > tr:nth-child(1) > th:nth-child(2)")).Text;
            Assert.AreEqual(_addressChecks, "Address Checks");
        }
        
        [Then(@"I should see the number of passed address checks is (.*)")]
        public void ThenIShouldSeeTheNumberOfPassedAddressChecksIs(int p0)
        {
            String _addressChecksPassed =  _driver.FindElement(By.Id("b2a30")).Text;
            Assert.AreEqual(_addressChecksPassed, p0.ToString());
        }
        
        [Then(@"I should see the number of passed product checks is (.*)")]
        public void ThenIShouldSeeTheNumberOfPassedProductChecksIs(int p0)
        {
            Thread.Sleep(4000);
            String _productChecksPassed = _driver.FindElement(By.Id("b2p30")).Text;
            Assert.AreEqual(_productChecksPassed, p0.ToString());

        }

        [Then(@"I should see the number of passed compliance checks is (.*)")]
        public void ThenIShouldSeeTheNumberOfPassedComplianceChecksIs(int p0)
        {
            Thread.Sleep(12000);
            String _complianceChecksPassed = _driver.FindElement(By.Id("b2c30")).Text;
            Assert.AreEqual(_complianceChecksPassed, p0.ToString());
        }

        [Then(@"I should see the number of failed compliance checks is (.*)")]
        public void ThenIShouldSeeTheNumberOfFailedComplianceChecksIs(int p0)
        {
            String _complianceChecksFailed = _driver.FindElement(By.Id("b2c20")).Text;
            Assert.AreEqual(p0.ToString(),_complianceChecksFailed);

        }

        [Then(@"I display the results grid")]
        public void ThenIDisplayTheResultsGrid()
        {
            Thread.Sleep(20000);
            _driver.FindElement(By.XPath("//input[@id='ctl00_ctl00_PageMainContent_Modal_open_rpt_ctl00_fix_btnRefresh']")).Click();
        }

        [Then(@"I set actions to compliance check only")]
        public void ThenISetActionsToComplianceCheckOnly()
        {
            Thread.Sleep(5000);
            _driver.FindElement(By.XPath("//input[@id='ctl00_ctl00_PageMainContent_Modal_open_rpt_ctl00_rbl_2']")).Click();
        }


        [Then(@"I should see a customer aggregate volume limit compliance failure")]
        public void ThenIShouldSeeACustomerAggregateVolumeLimitComplianceFailure()
        {
            Thread.Sleep(2000);
           // String _cavlRuleFailed = _driver.FindElement(By.Id("ctl00_ctl00_PageMainContent_Modal_open_rpt_ctl00_fix_cf_ctrlFix_lblErrorCount")).Text;
           // Assert.AreEqual(_cavlRuleFailed, "18 Failed Compliance Checks Found");

        }


        [Then(@"I should see the associated sales order key")]
        public void ThenIShouldSeeTheAssociatedSalesOrderKey()
        {
            Thread.Sleep(2000);
        }
        
        [Then(@"I should see the associated customer")]
        public void ThenIShouldSeeTheAssociatedCustomer()
        {
            
        }
        
        [Then(@"I should see the associated failed status")]
        public void ThenIShouldSeeTheAssociatedFailedStatus()
        {
            
        }
        [Then(@"I cancel the import")]
        public void ThenICancelTheImport()
        {
            _driver.FindElement(By.Name("ctl00$ctl00$PageMainContent$Modal$open$rpt$ctl00$btnCommit")).Click();
            Thread.Sleep(3000);
        }

        [Then(@"I close the confirmation popup")]
        public void ThenICloseTheConfirmationPopup()
        {
            SendKeys.SendWait("OK{ENTER}");
        }

        [Then(@"I close the application")]
        public void ThenICloseTheApplication()
        {
            //_driver.FindElement(By.CssSelector(".icon-gear")).Click();
            //Thread.Sleep(1000);

            //_driver.FindElement(By.CssSelector(".logout-link")).Click();
        }

        [Then(@"I close the browser")]
        public void ThenICloseTheBrowser()
        {
            _driver.Quit();
        }

    }
}
