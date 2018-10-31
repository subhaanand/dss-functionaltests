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
namespace NCS.DSS.FunctionalTests.Features.Interaction
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Post")]
    public partial class PostFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Post.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Post", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 5
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
#line 6
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
#line 10
 testRunner.And("I post a Customer with the following details:", ((string)(null)), table2, "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Valid Interaction with all Fields")]
        public virtual void PostValidInteractionWithAllFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Valid Interaction with all Fields", null, ((string[])(null)));
#line 15
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 this.FeatureBackground();
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
#line 16
  testRunner.Given("I post an Interaction with the following details:", ((string)(null)), table3, "Given ");
#line 22
  testRunner.Then("there should be a 201 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table4.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table4.AddRow(new string[] {
                        "Channel",
                        "2"});
            table4.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table4.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 23
  testRunner.And("the response body should contain:", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Interaction with missing Channel")]
        public virtual void PostInteractionWithMissingChannel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Interaction with missing Channel", null, ((string[])(null)));
#line 34
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table5.AddRow(new string[] {
                        "AdviserDetailsID",
                        "6eed4005-4364-4bcb-affb-170ee402d1aa"});
            table5.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table5.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table5.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 35
  testRunner.Given("I post an Interaction with the following details:", ((string)(null)), table5, "Given ");
#line 41
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Interaction with missing InteractionType")]
        public virtual void PostInteractionWithMissingInteractionType()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Interaction with missing InteractionType", null, ((string[])(null)));
#line 45
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table6.AddRow(new string[] {
                        "AdviserDetailsID",
                        "6eed4005-4364-4bcb-affb-170ee402d1aa"});
            table6.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table6.AddRow(new string[] {
                        "Channel",
                        "2"});
            table6.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 46
  testRunner.Given("I post an Interaction with the following details:", ((string)(null)), table6, "Given ");
#line 52
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Interaction with invalid AdviserDetailsID")]
        public virtual void PostInteractionWithInvalidAdviserDetailsID()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Interaction with invalid AdviserDetailsID", null, ((string[])(null)));
#line 56
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table7.AddRow(new string[] {
                        "AdviserDetailsID",
                        "6eed4005-4364-4bcb-affb-170ee"});
            table7.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table7.AddRow(new string[] {
                        "Channel",
                        "2"});
            table7.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table7.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 57
  testRunner.Given("I post an Interaction with the following details:", ((string)(null)), table7, "Given ");
#line 64
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Interaction with invalid DateandTimeOfInteraction")]
        public virtual void PostInteractionWithInvalidDateandTimeOfInteraction()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Interaction with invalid DateandTimeOfInteraction", null, ((string[])(null)));
#line 68
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table8.AddRow(new string[] {
                        "AdviserDetailsID",
                        "6eed4005-4364-4bcb-affb-170ee402d1aa"});
            table8.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2033-06-25T11:21:00Z"});
            table8.AddRow(new string[] {
                        "Channel",
                        "2"});
            table8.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table8.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 69
  testRunner.Given("I post an Interaction with the following details:", ((string)(null)), table8, "Given ");
#line 76
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Interaction with invalid Channel")]
        public virtual void PostInteractionWithInvalidChannel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Interaction with invalid Channel", null, ((string[])(null)));
#line 81
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table9.AddRow(new string[] {
                        "AdviserDetailsID",
                        "6eed4005-4364-4bcb-affb-170ee402d1aa"});
            table9.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table9.AddRow(new string[] {
                        "Channel",
                        "11"});
            table9.AddRow(new string[] {
                        "InteractionType",
                        "2"});
            table9.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 82
   testRunner.Given("I post an Interaction with the following details:", ((string)(null)), table9, "Given ");
#line 89
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Interaction with invalid InteractionType")]
        public virtual void PostInteractionWithInvalidInteractionType()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Interaction with invalid InteractionType", null, ((string[])(null)));
#line 93
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table10.AddRow(new string[] {
                        "AdviserDetailsID",
                        "6eed4005-4364-4bcb-affb-170ee402d1aa"});
            table10.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table10.AddRow(new string[] {
                        "Channel",
                        "1"});
            table10.AddRow(new string[] {
                        "InteractionType",
                        "55"});
            table10.AddRow(new string[] {
                        "LastModifiedDate",
                        "2018-06-22T16:52:10Z"});
#line 94
  testRunner.Given("I post an Interaction with the following details:", ((string)(null)), table10, "Given ");
#line 101
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post Interaction with invalid LastModifiedDate")]
        public virtual void PostInteractionWithInvalidLastModifiedDate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post Interaction with invalid LastModifiedDate", null, ((string[])(null)));
#line 106
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table11.AddRow(new string[] {
                        "AdviserDetailsID",
                        "6eed4005-4364-4bcb-affb-170ee402d1aa"});
            table11.AddRow(new string[] {
                        "DateandTimeOfInteraction",
                        "2018-06-25T11:21:00Z"});
            table11.AddRow(new string[] {
                        "Channel",
                        "1"});
            table11.AddRow(new string[] {
                        "InteractionType",
                        "55"});
            table11.AddRow(new string[] {
                        "LastModifiedDate",
                        "2033-06-22T16:52:10Z"});
#line 107
  testRunner.Given("I post an Interaction with the following details:", ((string)(null)), table11, "Given ");
#line 114
  testRunner.Then("there should be a 422 response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
