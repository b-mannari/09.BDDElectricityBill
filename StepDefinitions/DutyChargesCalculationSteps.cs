using BDDElectricityBillKata.Common;
using BDDElectricityBillKata.Models;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace BDDElectricityBillKata.StepDefinitions
{
    [Binding]
    public class DutyChargesCalculationSteps
    {
        readonly CommonClass commonClass = new CommonClass();
        string apiResponse;
        DutyChargesBilled expectedresult;
        double totaldutycharges;
        private double slabdutycharges = 0;
        private double fcadutycharges = 0;
        string webapi = "";

        [Given(@"consumer consumed (.*) units of energy")]
        public void GivenConsumerConsumedUnitsOfEnergy(int units)
        {
            webapi = webapi + "DutyCharges/Calculation?units=" + units;
            apiResponse = commonClass.CallWebApi(webapi);
        }

        [When(@"the state ABDY electricity bill generated")]
        public void WhenTheStateABCElectricityBillGenerated()
        {
            expectedresult = JsonConvert.DeserializeObject<DutyChargesBilled>(apiResponse);
            totaldutycharges = expectedresult.totaldutycharges;
            slabdutycharges = expectedresult.slabdutycharges;
            fcadutycharges = expectedresult.fcadutycharges;
        }

        [Then(@"the slabwise duty charges amounted to Rs (.*)")]
        public void ThenTheSlabwiseDutyChargesAmountedToRs(Decimal charges)
        {
            Assert.AreEqual(charges, slabdutycharges);
        }

        [Then(@"the total FCA charges amounted to Rs (.*)")]
        public void ThenTheTotalFCAChargesAmountedToRs(Decimal charges)
        {
            Assert.AreEqual(charges, fcadutycharges);
        }

        [Then(@"the Total Duty Charges amounted to Rs (.*)")]
        public void ThenTheTotalDutyChargesAmountedToRs(Decimal charges)
        {
            Assert.AreEqual(charges, totaldutycharges);
        }
    }
}
