using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.DataModel
{
    public class MealType
    {
        public int MealTypeID { get; set; }
        public string MealTypeDesc { get; set; }

        //overrides
        public override string ToString()
        {
            return $"{MealTypeID} : {MealTypeDesc}";
        }
    }
}
