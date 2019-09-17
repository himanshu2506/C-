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
namespace REST_Assignment.FeatureFile
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("REST Feature")]
    public partial class RESTFeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Feature.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "REST Feature", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Register a  User with valid Username and password")]
        [NUnit.Framework.TestCaseAttribute("eve.holt@reqres.in", "pistol", null)]
        public virtual void RegisterAUserWithValidUsernameAndPassword(string usernam, string passwor, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Register a  User with valid Username and password", null, exampleTags);
#line 3
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
testRunner.When("user sends a request", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 5
testRunner.And(string.Format("Register a  User with \'{0}\'  and \'{1}\'", usernam, passwor), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 6
testRunner.Then("Registration is successful", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 7
testRunner.And("Token is generated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Register a new user with Invalid combination")]
        [NUnit.Framework.TestCaseAttribute("vibhum.2506@gmail.m", "pistol", null)]
        [NUnit.Framework.TestCaseAttribute("httl.rept@reqres.in", "", null)]
        public virtual void RegisterANewUserWithInvalidCombination(string username, string password, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Register a new user with Invalid combination", null, exampleTags);
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 14
testRunner.When("user sends a request", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
testRunner.And(string.Format("Register a new user with \'{0}\' and \'{1}\'", username, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
testRunner.Then("Registration is not successful", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
testRunner.And("Token is not generated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("List of all users")]
        public virtual void ListOfAllUsers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("List of all users", null, ((string[])(null)));
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 25
testRunner.When("user sends a request on users", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
testRunner.Then("user will get list of users", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
