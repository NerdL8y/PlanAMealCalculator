using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.DataModel
{
    public class SessionInfo
    {
        public Guid SsID { get; set; }
        public int UserID { get; set; }
        public DateTime DateCreated { get; set; }

        //overrides 
        public override string ToString()
        {
            return $"{SsID}\t{DateCreated}\t{UserID}";
        }
    }
}
