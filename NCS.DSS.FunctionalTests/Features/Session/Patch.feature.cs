﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace NCS.DSS.FunctionalTests.Features.Session
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Patch")]
    public partial class PatchFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Patch.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Patch", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
 #line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "AdviserName",
                        "BillyAdviser"});
            table1.AddRow(new string[] {
                        "AdviserContactNumber",
                        "98798678967967"});
#line 7
 testRunner.Given("I post an adviser with the following details:", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "GivenName",
                        "Bob"});
            table2.AddRow(new string[] {
                        "FamilyName",
                        "Customer"});
#line 11
 testRunner.And("I post a Customer with the following details:", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table3.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table3.AddRow(new string[] {
                        "Channel",
                        "2"});
            table3.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table3.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 15
 testRunner.And("I post an Interaction with the following details:", ((string)(null)), table3, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch DateandTimeOfSession")]
        public virtual void PatchDateandTimeOfSession()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch DateandTimeOfSession", null, ((string[])(null)));
#line 24
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table4.AddRow(new string[] {
                        "DateandTimeOfSession",
                        "2018-06-21T14:45:00Z"});
            table4.AddRow(new string[] {
                        "VenuePostCode",
                        "NN1 2NN"});
            table4.AddRow(new string[] {
                        "SessionAttended",
                        "true"});
#line 25
 testRunner.Given("I post a session with the following details:", ((string)(null)), table4, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "DateandTimeOfSession",
                        "2018-06-22T14:45:00Z"});
#line 30
  testRunner.When("I patch the following:", ((string)(null)), table5, "When ");
#line 33
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "DateandTimeOfSession",
                        "2018-06-22T14:45:00Z"});
            table6.AddRow(new string[] {
                        "VenuePostCode",
                        "NN1 2NN"});
            table6.AddRow(new string[] {
                        "SessionAttended",
                        "true"});
#line 34
  testRunner.And("the response body should contain:", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch VenuePostCode")]
        public virtual void PatchVenuePostCode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch VenuePostCode", null, ((string[])(null)));
#line 40
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table7.AddRow(new string[] {
                        "DateandTimeOfSession",
                        "2018-06-21T14:45:00Z"});
            table7.AddRow(new string[] {
                        "VenuePostCode",
                        "NN1 2NN"});
            table7.AddRow(new string[] {
                        "SessionAttended",
                        "true"});
#line 41
 testRunner.Given("I post a session with the following details:", ((string)(null)), table7, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table8.AddRow(new string[] {
                        "VenuePostCode",
                        "NN1 2NQ"});
#line 46
  testRunner.When("I patch the following:", ((string)(null)), table8, "When ");
#line 49
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "DateandTimeOfSession",
                        "2018-06-21T14:45:00Z"});
            table9.AddRow(new string[] {
                        "VenuePostCode",
                        "NN1 2NQ"});
            table9.AddRow(new string[] {
                        "SessionAttended",
                        "true"});
#line 50
  testRunner.And("the response body should contain:", ((string)(null)), table9, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Patch SessionAttended")]
        public virtual void PatchSessionAttended()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Patch SessionAttended", null, ((string[])(null)));
#line 57
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table10.AddRow(new string[] {
                        "DateandTimeOfSession",
                        "2018-06-21T14:45:00Z"});
            table10.AddRow(new string[] {
                        "VenuePostCode",
                        "NN1 2NN"});
            table10.AddRow(new string[] {
                        "SessionAttended",
                        "true"});
#line 58
 testRunner.Given("I post a session with the following details:", ((string)(null)), table10, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "SessionAttended",
                        "false"});
#line 63
  testRunner.When("I patch the following:", ((string)(null)), table11, "When ");
#line 66
  testRunner.Then("there should be a 200 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table12.AddRow(new string[] {
                        "DateandTimeOfSession",
                        "2018-06-21T14:45:00Z"});
            table12.AddRow(new string[] {
                        "VenuePostCode",
                        "NN1 2NN"});
            table12.AddRow(new string[] {
                        "SessionAttended",
                        "false"});
#line 67
  testRunner.And("the response body should contain:", ((string)(null)), table12, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
