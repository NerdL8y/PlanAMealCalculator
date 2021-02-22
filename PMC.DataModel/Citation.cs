using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.DataModel
{
    public class Citation
    {
        public int CiteID { get; set; }
        public string CiteName { get; set; }
        public string CiteURL { get; set; }

        //overrides
        public override string ToString()
        {
            return $"{CiteName}\n\t{CiteURL} ";
        }
    }
}
