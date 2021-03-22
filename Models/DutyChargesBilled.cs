using System;
using System.Collections.Generic;
using System.Text;

namespace BDDElectricityBillKata.Models
{
   public class DutyChargesBilled
    {
        public double Slab1Charges { get; set; }
        public double Slab2Charges { get; set; }
        public double Slab3Charges { get; set; }
        public double Slab4Charges { get; set; }

        public double Slab1DutyCharges { get; set; }
        public double Slab2DutyCharges { get; set; }
        public double Slab3DutyCharges { get; set; }
        public double Slab4DutyCharges { get; set; }

        public double SlabDutyCharges { get; set; }
        public double FcaDutyCharges { get; set; }
        public double TotalDutyCharges { get; set; }

    }
}
