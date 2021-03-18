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
    [TechTalk.SpecRun.FeatureAttribute("Duty Charges Calculation", Description=@"	As a user I should be able to calculate the Duty Charges on the units billed to the ABC State Electricity Consumer based on the below calculation.
	U (Units for duty)
	F (Duty Charge)
	Slab Wise Duty (G) : G = U * F
    FCA on Duty (H) : H = G * 0.13
    Total Duty Charges (I) : I = G + H Sum of I is considered for final calculation", SourceFile="Features\\DutyCharges.feature", SourceLine=0)]
    public partial class DutyChargesCalculationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "DutyCharges.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Duty Charges Calculation", @"	As a user I should be able to calculate the Duty Charges on the units billed to the ABC State Electricity Consumer based on the below calculation.
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
        
        public virtual void CalculateTheDutyChargesForTheDomesticElectricityConsumerInAll4SlabsForConsumption(string units, string slabwisedutytotal, string fcadutytotal, string totalduty, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("units", units);
            argumentsOfScenario.Add("slabwisedutytotal", slabwisedutytotal);
            argumentsOfScenario.Add("fcadutytotal", fcadutytotal);
            argumentsOfScenario.Add("totalduty", totalduty);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculate the Duty Charges for the Domestic Electricity Consumer in all 4 Slabs f" +
                    "or consumption", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 9
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
#line 10
 testRunner.Given(string.Format("the consumer consumes {0} units of energy", units), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 11
 testRunner.When("the state ABC electricity bill gets generate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
 testRunner.Then(string.Format("the slabwise duty charges amounted to Rs {0}", slabwisedutytotal), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 13
 testRunner.Then(string.Format("the total FCA charges amounted to Rs {0}", fcadutytotal), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 14
 testRunner.And(string.Format("the Total Duty Charges amounted to Rs {0}", totalduty), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Calculate the Duty Charges for the Domestic Electricity Consumer in all 4 Slabs f" +
            "or consumption, 40", SourceLine=19)]
        public virtual void CalculateTheDutyChargesForTheDomesticElectricityConsumerInAll4SlabsForConsumption_40()
        {
#line 9
this.CalculateTheDutyChargesForTheDomesticElectricityConsumerInAll4SlabsForConsumption("40", "3.60", "0.468", "4.068", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Calculate the Duty Charges for the Domestic Electricity Consumer in all 4 Slabs f" +
            "or consumption, 95", SourceLine=19)]
        public virtual void CalculateTheDutyChargesForTheDomesticElectricityConsumerInAll4SlabsForConsumption_95()
        {
#line 9
this.CalculateTheDutyChargesForTheDomesticElectricityConsumerInAll4SlabsForConsumption("95", "11.40", "1.482", "12.882", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Calculate the Duty Charges for the Domestic Electricity Consumer in all 4 Slabs f" +
            "or consumption, 250", SourceLine=19)]
        public virtual void CalculateTheDutyChargesForTheDomesticElectricityConsumerInAll4SlabsForConsumption_250()
        {
#line 9
this.CalculateTheDutyChargesForTheDomesticElectricityConsumerInAll4SlabsForConsumption("250", "30.00", "3.9", "33.900", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Calculate the Duty Charges for the Domestic Electricity Consumer in all 4 Slabs f" +
            "or consumption, 700", SourceLine=19)]
        public virtual void CalculateTheDutyChargesForTheDomesticElectricityConsumerInAll4SlabsForConsumption_700()
        {
#line 9
this.CalculateTheDutyChargesForTheDomesticElectricityConsumerInAll4SlabsForConsumption("700", "84.00", "10.92", "94.92", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion