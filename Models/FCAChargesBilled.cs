using System;
using System.Collections.Generic;
using System.Text;

namespace BDDElectricityBillKata.Models
{
    public class FCAChargesBilled
    {
        public double Slab1Charges { get; set; }
        public double Slab2Charges { get; set; }
        public double Slab3Charges { get; set; }
        public double Slab4Charges { get; set; }


        public double Slab1FcaCharges { get; set; }
        public double Slab2FcaCharges { get; set; }
        public double Slab3FcaCharges { get; set; }
        public double Slab4FcaCharges { get; set; }

        public double FcaChargesTotal { get; set; }
    }
}
