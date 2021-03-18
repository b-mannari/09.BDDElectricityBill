using BDDElectricityBillKata.Common;
using BDDElectricityBillKata.Models;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BDDElectricityBillKata.StepDefinitions
{
    [Binding]
    public class EnergyChargesCalculationSteps
    {
        readonly CommonClass commonClass = new CommonClass();
        string apiResponse;
        EnergyChargesBilled expectedresult;
        double totalenergycharges;
        double SlabCharges;
        string webapi = "";
       
        [Given(@"I consumed (.*) units in a month")]
        public void GivenIConsumedUnitsInAMonth(int units)
        {
            webapi = webapi + "EnergyCharges/Calculation?units=" + units;
            apiResponse = commonClass.CallWebApi(webapi);
        }

        [When(@"the state ABDY electricity bill gets generated")]
        public void WhenTheStateABDYElectricityBillGetsGenerated()
        {
            expectedresult = JsonConvert.DeserializeObject<EnergyChargesBilled>(apiResponse);
            totalenergycharges = expectedresult.TotalEnergyCharges;
        }

        [Then(@"the total energy charges as amounted to Rs(.*)")]
        public void ThenTheTotalEnergyChargesAsAmountedToRs(Decimal charges)
        {
            Assert.AreEqual(charges, totalenergycharges);
        }

        [Then(@"I should be charged with an amount of Rs(.*) for Slab (.*)")]
        public void ThenIShouldBeChargedWithAnAmountOfRsForSlab(Decimal charges, int slab)
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
            Assert.AreEqual(SlabCharges,charges);
        }
    }
}
