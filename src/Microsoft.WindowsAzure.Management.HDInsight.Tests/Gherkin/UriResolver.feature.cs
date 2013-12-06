﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34003
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Microsoft.WindowsAzure.Management.HDInsight.Tests.Gherkin
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class StorageAccountAbstractionFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UriResolver.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "StorageAccountAbstraction", "In order to interact with a Hadoop cluster from the SDK\r\nAs a developer\r\nI want t" +
                    "o have a way to interact with storage", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "StorageAccountAbstraction")))
            {
                Microsoft.WindowsAzure.Management.HDInsight.Tests.Gherkin.StorageAccountAbstractionFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("I can not delete a container")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StorageAccountAbstraction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("CheckIn")]
        public virtual void ICanNotDeleteAContainer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can not delete a container", new string[] {
                        "CheckIn"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I apply storage abstraction simulation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
   testRunner.And("I have the Windows Azure Blob storage abstraction for the account \'default@tststg" +
                    "00hdxcibld02a.blob.core.windows.net\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
  testRunner.When("I try to delete the path \'wabs://default@tststg00hdxcibld02a.blob.core.windows.ne" +
                    "t\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
  testRunner.Then("an \'InvalidOperationException\' is thrown containing the message \'Containers can n" +
                    "ot be deleted via this API\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("I can not store data without a path")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StorageAccountAbstraction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("CheckIn")]
        public virtual void ICanNotStoreDataWithoutAPath()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can not store data without a path", new string[] {
                        "CheckIn"});
#line 14
this.ScenarioSetup(scenarioInfo);
#line 15
    testRunner.Given("I apply storage abstraction simulation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
   testRunner.And("I have the Windows Azure Blob storage abstraction for the account \'default@tststg" +
                    "00hdxcibld02a.blob.core.windows.net\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
  testRunner.When("I write the data \"data\" to the path \'wabs://default@tststg00hdxcibld02a.blob.core" +
                    ".windows.net\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
  testRunner.Then("an \'InvalidOperationException\' is thrown containing the message \'without a path\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("I can read content I previously wrote to storage")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StorageAccountAbstraction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("CheckIn")]
        public virtual void ICanReadContentIPreviouslyWroteToStorage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can read content I previously wrote to storage", new string[] {
                        "CheckIn"});
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
   testRunner.Given("I apply storage abstraction simulation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
   testRunner.And("I have the Windows Azure Blob storage abstraction for the account \'default@tststg" +
                    "00hdxcibld02a.blob.core.windows.net\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
  testRunner.When("I write the data \"data\" to the path \'wabs://default@tststg00hdxcibld02a.blob.core" +
                    ".windows.net/list2/item1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
   testRunner.And("I read the data from the path \'wabs://default@tststg00hdxcibld02a.blob.core.windo" +
                    "ws.net/list2/item1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
  testRunner.Then("the value of the data should be \"data\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
   testRunner.And("no error should be returned from the storage abstraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("I can list the items in the account")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StorageAccountAbstraction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("CheckIn")]
        public virtual void ICanListTheItemsInTheAccount()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can list the items in the account", new string[] {
                        "CheckIn"});
#line 30
this.ScenarioSetup(scenarioInfo);
#line 31
   testRunner.Given("I apply storage abstraction simulation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 32
   testRunner.And("I have the Windows Azure Blob storage abstraction for the account \'default@tststg" +
                    "00hdxcibld02a.blob.core.windows.net\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
  testRunner.When("I write the data \"data\" to the path \'wabs://default@tststg00hdxcibld02a.blob.core" +
                    ".windows.net/list1/item1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
   testRunner.And("I list the items under the path \'wabs://default@tststg00hdxcibld02a.blob.core.win" +
                    "dows.net/list1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
  testRunner.Then("the number of items returned should be 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
   testRunner.And("no error should be returned from the storage abstraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Listing the items in an empty directory returns no items")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StorageAccountAbstraction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("CheckIn")]
        public virtual void ListingTheItemsInAnEmptyDirectoryReturnsNoItems()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Listing the items in an empty directory returns no items", new string[] {
                        "CheckIn"});
#line 39
this.ScenarioSetup(scenarioInfo);
#line 40
   testRunner.Given("I apply storage abstraction simulation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 41
   testRunner.And("I have the Windows Azure Blob storage abstraction for the account \'default@tststg" +
                    "00hdxcibld02a.blob.core.windows.net\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
  testRunner.When("I list the items under the path \'wabs://default@tststg00hdxcibld02a.blob.core.win" +
                    "dows.net/doesNotExist\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
  testRunner.Then("the number of items returned should be 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
   testRunner.And("no error should be returned from the storage abstraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("I can list the items under a directory recursively")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StorageAccountAbstraction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("CheckIn")]
        public virtual void ICanListTheItemsUnderADirectoryRecursively()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I can list the items under a directory recursively", new string[] {
                        "CheckIn"});
#line 47
this.ScenarioSetup(scenarioInfo);
#line 48
   testRunner.Given("I apply storage abstraction simulation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
   testRunner.And("I have the Windows Azure Blob storage abstraction for the account \'default@tststg" +
                    "00hdxcibld02a.blob.core.windows.net\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
  testRunner.When("I write the data \"data\" to the path \'wabs://default@tststg00hdxcibld02a.blob.core" +
                    ".windows.net/list3/item1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
   testRunner.And("I write the data \"data\" to the path \'wabs://default@tststg00hdxcibld02a.blob.core" +
                    ".windows.net/list3/sub1/item1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
   testRunner.And("I write the data \"data\" to the path \'wabs://default@tststg00hdxcibld02a.blob.core" +
                    ".windows.net/list3/sub1/item2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
   testRunner.And("I write the data \"data\" to the path \'wabs://default@tststg00hdxcibld02a.blob.core" +
                    ".windows.net/list3/sub2/item1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
   testRunner.And("I write the data \"data\" to the path \'wabs://default@tststg00hdxcibld02a.blob.core" +
                    ".windows.net/list3/sub2/item2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
   testRunner.And("I write the data \"data\" to the path \'wabs://default@tststg00hdxcibld02a.blob.core" +
                    ".windows.net/list3/sub3/item1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
   testRunner.And("I write the data \"data\" to the path \'wabs://default@tststg00hdxcibld02a.blob.core" +
                    ".windows.net/list3/sub3/item2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
   testRunner.And("I write the data \"data\" to the path \'wabs://default@tststg00hdxcibld02a.blob.core" +
                    ".windows.net/list3/sub3/item3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
   testRunner.And("I list the items under the path \'wabs://default@tststg00hdxcibld02a.blob.core.win" +
                    "dows.net/list3\' recursively", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
  testRunner.Then("the number of items returned should be 12", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
   testRunner.And("no error should be returned from the storage abstraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When I delete a directory all child items and directories are removed (delete is " +
            "recursive)")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StorageAccountAbstraction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("CheckIn")]
        public virtual void WhenIDeleteADirectoryAllChildItemsAndDirectoriesAreRemovedDeleteIsRecursive()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When I delete a directory all child items and directories are removed (delete is " +
                    "recursive)", new string[] {
                        "CheckIn"});
#line 63
this.ScenarioSetup(scenarioInfo);
#line 64
   testRunner.Given("I apply storage abstraction simulation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 65
   testRunner.And("I have the Windows Azure Blob storage abstraction for the account \'default@tststg" +
                    "00hdxcibld02a.blob.core.windows.net\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
  testRunner.When("I write the data \"data\" to the path \'wabs://default@tststg00hdxcibld02a.blob.core" +
                    ".windows.net/list4/item1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
   testRunner.And("I write the data \"data\" to the path \'wabs://default@tststg00hdxcibld02a.blob.core" +
                    ".windows.net/list4/sub1/item1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
   testRunner.And("I write the data \"data\" to the path \'wabs://default@tststg00hdxcibld02a.blob.core" +
                    ".windows.net/list4/sub1/item2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
   testRunner.And("I write the data \"data\" to the path \'wabs://default@tststg00hdxcibld02a.blob.core" +
                    ".windows.net/list4/sub2/item1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
   testRunner.And("I write the data \"data\" to the path \'wabs://default@tststg00hdxcibld02a.blob.core" +
                    ".windows.net/list4/sub2/item2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
   testRunner.And("I write the data \"data\" to the path \'wabs://default@tststg00hdxcibld02a.blob.core" +
                    ".windows.net/list4/sub3/item1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
   testRunner.And("I write the data \"data\" to the path \'wabs://default@tststg00hdxcibld02a.blob.core" +
                    ".windows.net/list4/sub3/item2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
   testRunner.And("I write the data \"data\" to the path \'wabs://default@tststg00hdxcibld02a.blob.core" +
                    ".windows.net/list4/sub3/item3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
   testRunner.And("I try to delete the path \'wabs://default@tststg00hdxcibld02a.blob.core.windows.ne" +
                    "t/list4/sub3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
   testRunner.And("I list the items under the path \'wabs://default@tststg00hdxcibld02a.blob.core.win" +
                    "dows.net/list4\' recursively", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
  testRunner.Then("the number of items returned should be 8", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 77
   testRunner.And("no error should be returned from the storage abstraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When I check for the existence of an item that does not exist a false value is re" +
            "turned")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StorageAccountAbstraction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("CheckIn")]
        public virtual void WhenICheckForTheExistenceOfAnItemThatDoesNotExistAFalseValueIsReturned()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When I check for the existence of an item that does not exist a false value is re" +
                    "turned", new string[] {
                        "CheckIn"});
#line 80
this.ScenarioSetup(scenarioInfo);
#line 81
   testRunner.Given("I apply storage abstraction simulation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 82
   testRunner.And("I have the Windows Azure Blob storage abstraction for the account \'default@tststg" +
                    "00hdxcibld02a.blob.core.windows.net\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
  testRunner.When("I check existence of the path \'wabs://default@tststg00hdxcibld02a.blob.core.windo" +
                    "ws.net/list4/sub3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
  testRunner.Then("the existence check should return false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 85
   testRunner.And("no error should be returned from the storage abstraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When I check for the existence of an item that does exist a true value is returne" +
            "d")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "StorageAccountAbstraction")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("CheckIn")]
        public virtual void WhenICheckForTheExistenceOfAnItemThatDoesExistATrueValueIsReturned()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When I check for the existence of an item that does exist a true value is returne" +
                    "d", new string[] {
                        "CheckIn"});
#line 88
this.ScenarioSetup(scenarioInfo);
#line 89
   testRunner.Given("I apply storage abstraction simulation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 90
   testRunner.And("I have the Windows Azure Blob storage abstraction for the account \'default@tststg" +
                    "00hdxcibld02a.blob.core.windows.net\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
  testRunner.When("I write the data \"data\" to the path \'wabs://default@tststg00hdxcibld02a.blob.core" +
                    ".windows.net/list5/sub1/sub2/item1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 92
   testRunner.And("I check existence of the path \'wabs://default@tststg00hdxcibld02a.blob.core.windo" +
                    "ws.net/list5/sub1/sub2/item1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
  testRunner.Then("the existence check should return true", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 94
   testRunner.And("no error should be returned from the storage abstraction", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion