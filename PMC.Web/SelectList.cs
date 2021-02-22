using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMC.Web
{
    public class SelectList
    {
        public SelectList Options { get; set; }
        //public List<SelectListItem> menuitems = new List<SelectListItem>();
        
        public void OnGet()
       {
            Options = new SelectList();
            
        }

        public static implicit operator SelectList(List<SelectListItem> v)
        {
            throw new NotImplementedException();
        }
    }
}
