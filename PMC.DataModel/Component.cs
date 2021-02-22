using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.DataModel
{
    public class Component
    {
        public int CompID { get; set; }
        public string CompName { get; set; }
        public int _cCompType { get; set; }
        public int _cUserID { get; set; }
        public string CompTypeDesc { get; set; }
        public int RowOdd { get; set; }
        public DateTime CompServeDateTime { get; set; }
        public IEnumerable<Recipe> Recipes { get; set; }
        //overrides
        public override string ToString()
        {
            return $"{CompID}\t{_cUserID}\t{CompName}\t\t{CompTypeDesc}"; 
        }
    }

}
