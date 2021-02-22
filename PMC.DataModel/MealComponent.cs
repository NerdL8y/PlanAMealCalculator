using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.DataModel
{
    public class MealComponent
    {
        public int _mcMealID { get; set; }
        public int _mcCompID { get; set; }
        public DateTime CompServeDateTime { get; set; }
        public string CompTypeDesc { get; set; }
        public int CompTypeID { get; set; }
        public string CompName { get; set; }

        //overrides
        public override string ToString()
        {
            return $"{_mcMealID} : {_mcCompID} : {CompServeDateTime} ";
        }
    }

}
