using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.DataModel
{
    public class CookMethod
    {
        public int CookMethodID { get; set; }
        public string CookMthdDesc { get; set; }

        //overrides
        public override string ToString()
        {
            return $"{CookMethodID} : {CookMthdDesc}";
        }
    }
}
