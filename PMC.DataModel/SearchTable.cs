using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.DataModel
{
    //may not need this if I can create filtered search in code
    public class SearchTable
    {
        public string SearchName { get; set; }
        public int _userID { get; set; }
        public int searchID { get; set; }

        //overrides
        public override string ToString()
        {
            return $"{SearchName}";
        }
    }

}
