using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.DataModel
{
    public class Term
    {
        public int TermID { get; set; }
        public string TermWord { get; set; }
        public string TermDefinition { get; set; }
        public override string ToString()
        {
            return $"{TermWord} : {TermDefinition}";
        }
    }
}
