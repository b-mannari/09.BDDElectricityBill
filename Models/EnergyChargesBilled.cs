﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BDDElectricityBillKata.Models
{
    public class EnergyChargesBilled
    {
        public int Units { get; set; }
        public double Slab1Charges { get; set; }
        public double Slab2Charges { get; set; }
        public double Slab3Charges { get; set; }
        public double Slab4Charges { get; set; }
        public double TotalEnergyCharges { get; set; }

        public int Slab { get; set; }


    }
}