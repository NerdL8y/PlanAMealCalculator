using Microsoft.AspNetCore.Components;
using PMC.Data;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMC.Web
{
    public class SelectListItem
    {
        public int Value;
        public string Text;

        public List<SelectListItem> Options { get; set; }       
        
        public void OnGet()
        {
            var recipeRepo = Data.DataContext.repoFactory.Get<PMC.Data.RecipeRepo>();
            var rList = recipeRepo.GetRecipesByUserID(Data.DataContext.repoFactory.UserID);
            Options = rList.Select(a => 
                new SelectListItem 
                { 
                    Value = a.RecipeID, 
                    Text = a.RcpName 
                }).ToList();
        }



    }
    

}
