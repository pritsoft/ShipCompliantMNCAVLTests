﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ShipCompliantTestSite
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AVL")]
    public partial class AVLFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AVL.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AVL", "\tIn order to valid compliance \r\n\tAs a supplier\r\n\tI want to import shipments so th" +
                    "ey can be validated", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Aggregate Volume Limits validated")]
        public virtual void AggregateVolumeLimitsValidated()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Aggregate Volume Limits validated", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("I am on the login screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
  testRunner.And("I enter an avl email address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
  testRunner.And("I enter an avl password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
  testRunner.And("I submit my credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
  testRunner.And("I am on the the home screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
  testRunner.And("I go to the import new order file page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
  testRunner.And("I upload an avl sales order file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
  testRunner.And("I choose a spreadsheet mapping", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
  testRunner.And("I choose the order source", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
  testRunner.And("I choose an import detail", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
  testRunner.And("I overwrite existing sales orders", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
  testRunner.And("I expand advance options", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
  testRunner.And("I set a ship date", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
  testRunner.And("I set a fulfillment location", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
  testRunner.And("I set a fulfillment type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
  testRunner.And("I set a sale type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
  testRunner.And("I set a license relationship", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
  testRunner.And("I set a shipping service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.When("I submit my settings", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.Then("I should see the pending order imports page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.And("I should see the number of passed address checks is 12", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("I should see the number of passed product checks is 12", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("I should see the number of passed compliance checks is 9", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("I should see the number of failed compliance checks is 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("I should see an aggregate volume limit compliance failure", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("I display the results grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("I should see the associated sales order key", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("I should see the associated customer", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("I should see the associated failed status", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("I cancel the import", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("I close the confirmation popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("I close the application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("I close the browser", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
