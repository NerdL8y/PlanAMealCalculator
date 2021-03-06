using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;


namespace PMC.Web.Data
{

    public class HomeURIService
    {
        private readonly string _homeUri = "https://localhost:44311/";
               
        public string HomeUri
        {
            get
            {
                return _homeUri;
            }
            set
            {
                //_homeUri = "https://localhost:44311/";
            }
        }
    }
}
