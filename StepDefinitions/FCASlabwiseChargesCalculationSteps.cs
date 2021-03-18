using BDDElectricityBillKata.Common;
using BDDElectricityBillKata.Models;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BDDElectricityBillKata.StepDefinitions
{
    [Binding]
    public class FCASlabwiseChargesCalculationSteps
    {
        string apiResponse;
        readonly CommonClass commonClass = new CommonClass();
        FCAChargesBilled expectedresult;
        double fcachargestotal;
        double SlabCharges;
        string webapi = "";

        [Given(@"I consumed (.*) units in a given month")]
        public void GivenIConsumedUnitsInAGivenMonth(int units)
        {
            webapi = webapi + "FCACharges/Calculation?units=" + units;
            apiResponse = commonClass.CallWebApi(webapi);
        }

        [When(@"the state XOZ electricity bill gets generated")]
        public void WhenTheStateXOZElectricityBillGetsGenerated()
        {
            expectedresult = JsonConvert.DeserializeObject<FCAChargesBilled>(apiResponse);
            fcachargestotal = expectedresult.fcachargestotal;
        } 
        [Then(@"the total fca charges as fca amounted to Rs(.*)")]
        public void ThenTheTotalFcaChargesAsFcaAmountedToRs(Decimal p0)
        {
            Assert.AreEqual(p0, fcachargestotal);
        } 

        [Then(@"I should be charged with an fca amount of Rs(.*) for Slab(.*)")]
        public void ThenIShouldBeChargedWithAnFcaAmountOfRsForSlab(Decimal charges, int slab)
        {
            //bool returnvalue = false;

            switch (slab)
            {
                case 1:
                    //returnvalue = charges.Equals(expectedresult.Slab1Charges);
                    SlabCharges = expectedresult.Slab1Charges;
                    break;
                case 2:
                    //returnvalue = charges.Equals(expectedresult.Slab2Charges);
                    SlabCharges = expectedresult.Slab2Charges;
                    break;
                case 3:
                    //returnvalue = charges.Equals(expectedresult.Slab3Charges);
                    SlabCharges = expectedresult.Slab3Charges;
                    break;
                case 4:
                    //returnvalue = charges.Equals(expectedresult.Slab4Charges);
                    SlabCharges = expectedresult.Slab4Charges;
                    break;
            }
            Assert.AreEqual(SlabCharges, charges);
        }
    }
}
