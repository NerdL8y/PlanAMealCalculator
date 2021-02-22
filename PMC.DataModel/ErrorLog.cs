using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.DataModel
{
    public class ErrorLog
    {
        public int ErrorID { get; set; }
        public string ErrorDesc { get; set; }
        public int ErrorUserID { get; set; }
        public string ErrorFrom { get; set; }
        public DateTime ErrorDate { get; set; }
    }
}
