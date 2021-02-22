using System;
using System.Collections.Generic;
using System.Text;

//PMC1012-01 PMC1012-02 
namespace PMC.DataModel
{
    public class Allergen
    {
        public int AllergenID { get; set; }
        public string AllergenDesc { get; set; }

        //overrides
        public override string ToString()
        {
            return $"{AllergenID} : {AllergenDesc}";
        }
    }
}
