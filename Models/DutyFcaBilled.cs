using System;
using System.Collections.Generic;
using System.Text;

namespace BDDElectricityBillKata.Models
{
    public class DutyFcaBilled
    {
        public DutyChargesBilled DutyChargesBilled { get; set; }
        public FCAChargesBilled FCAChargesBilled { get; set; }
    }
}
