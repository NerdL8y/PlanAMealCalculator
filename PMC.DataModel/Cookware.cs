using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.DataModel
{
    public class Cookware
    {
        public int CookwareID { get; set; }
        public int UserID { get; set; }
        public string CookwareName { get; set; }

        //overrides
        public override string ToString()
        {
            return $"{CookwareID}\t{UserID}\t{CookwareName}";
        }
    }
}
