using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.DataModel
{
    public class Uot
    {
        public int UotID { get; set; }
        public string UotDesc { get; set; }
        public decimal CvtMultiplierToMin { get; set; }

        //overrides
        public override string ToString()
        {
            return $"{UotDesc} : {CvtMultiplierToMin}";
        }
    }
}
