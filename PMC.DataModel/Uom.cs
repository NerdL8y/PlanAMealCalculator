using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.DataModel
{
    public class Uom
    {
        public int UomID { get; set; }
        public string UomDesc { get; set; }
        public string UomType { get; set; }
        public decimal CvtMultiplier { get; set; }
        public string CvtToDesc { get; set; }

        //override
        public override string ToString()
        {
            return $"{UomID} : {UomDesc} : {CvtMultiplier}";
        }
    }

}
