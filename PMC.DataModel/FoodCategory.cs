using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.DataModel
{
    public class FoodCategory
    {
        public int FoodCatID { get; set; }
        public string FoodCatDesc { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public int UserID { get; set; }

        //overrides
        public override string ToString()
        {
            return $"{FoodCatID} : {FoodCatDesc}";
        }
    }

}
