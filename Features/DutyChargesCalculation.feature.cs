﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.7.0.0
//      SpecFlow Generator Version:3.7.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BDDElectricityBillKata.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.7.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Duty Charges Calculation", Description=@"As a user I should be able to calculate the Duty Charges on the units billed to the ABC State Electricity Consumer based on the below calculation.
	U (Units for duty)
	F (Duty Charge)
	Slab Wise Duty (G) : G = U * F
    FCA on Duty (H) : H = G * 0.13
    Total Duty Charges (I) : I = G + H Sum of I is considered for final calculation", SourceFile="Features\\DutyChargesCalculation.feature", SourceLine=0)]
    public partial class DutyChargesCalculationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "DutyChargesCalculation.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Duty Charges Calculation", @"As a user I should be able to calculate the Duty Charges on the units billed to the ABC State Electricity Consumer based on the below calculation.
	U (Units for duty)
	F (Duty Charge)
	Slab Wise Duty (G) : G = U * F
    FCA on Duty (H) : H = G * 0.13
    Total Duty Charges (I) : I = G + H Sum of I is considered for final calculation", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void CalculateTheDutyChargesForTheDomesticElectricityConsumerInAll4SlabsForConsumption1(string units, string slabdutycharges, string fcadutycharges, string totaldutycharges, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("units", units);
            argumentsOfScenario.Add("slabdutycharges", slabdutycharges);
            argumentsOfScenario.Add("fcadutycharges", fcadutycharges);
            argumentsOfScenario.Add("totaldutycharges", totaldutycharges);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculate the Duty Charges for the Domestic Electricity Consumer in all 4 Slabs f" +
                    "or consumption1", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 10
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 11
 testRunner.Given(string.Format("consumer consumed {0} units of energy", units), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 12
 testRunner.When("the state ABDY electricity bill generated", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.Then(string.Format("the slabwise duty charges amounted to Rs {0}", slabdutycharges), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 14
 testRunner.And(string.Format("the total FCA charges amounted to Rs {0}", fcadutycharges), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And(string.Format("the Total Duty Charges amounted to Rs {0}", totaldutycharges), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Calculate the Duty Charges for the Domestic Electricity Consumer in all 4 Slabs f" +
            "or consumption1, 40", new string[] {
                "mytag"}, SourceLine=18)]
        public virtual void CalculateTheDutyChargesForTheDomesticElectricityConsumerInAll4SlabsForConsumption1_40()
        {
#line 10
this.CalculateTheDutyChargesForTheDomesticElectricityConsumerInAll4SlabsForConsumption1("40", "3.60", "0.468", "4.068", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Calculate the Duty Charges for the Domestic Electricity Consumer in all 4 Slabs f" +
            "or consumption1, 95", new string[] {
                "mytag"}, SourceLine=18)]
        public virtual void CalculateTheDutyChargesForTheDomesticElectricityConsumerInAll4SlabsForConsumption1_95()
        {
#line 10
this.CalculateTheDutyChargesForTheDomesticElectricityConsumerInAll4SlabsForConsumption1("95", "9.90", "1.287", "11.187", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Calculate the Duty Charges for the Domestic Electricity Consumer in all 4 Slabs f" +
            "or consumption1, 250", new string[] {
                "mytag"}, SourceLine=18)]
        public virtual void CalculateTheDutyChargesForTheDomesticElectricityConsumerInAll4SlabsForConsumption1_250()
        {
#line 10
this.CalculateTheDutyChargesForTheDomesticElectricityConsumerInAll4SlabsForConsumption1("250", "28.50", "3.705", "32.205", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Calculate the Duty Charges for the Domestic Electricity Consumer in all 4 Slabs f" +
            "or consumption1, 700", new string[] {
                "mytag"}, SourceLine=18)]
        public virtual void CalculateTheDutyChargesForTheDomesticElectricityConsumerInAll4SlabsForConsumption1_700()
        {
#line 10
this.CalculateTheDutyChargesForTheDomesticElectricityConsumerInAll4SlabsForConsumption1("700", "82.50", "10.725", "93.225", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion