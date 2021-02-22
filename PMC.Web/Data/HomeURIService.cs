using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;


namespace PMC.Web.Data
{

    public class HomeURIService
    {
        private string _homeUri;
        public string homeUri
        {
            get
            {
                return "https://localhost:44311/";
            }
            set
            {
                _homeUri = "https://localhost:44311/";
            }
        }
    }
}
