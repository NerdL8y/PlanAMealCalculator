using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMC.Test
{
    public class IngredientTest
    {
        public IngredientTest() 
        {
            
        }

        public int TestIngredientNameLength(Data.RepoFactory rpf)
        {
            Data.RepoFactory repoFactory = rpf;
            var ingrRepo = repoFactory.Get<Data.IngredientRepo>();
            //var currentIngr = ingrRepo.GetIngredients().ToList();
            var currentIngr = ingrRepo.GetIngredientByID(one);
            System.Console.WriteLine(currentIngr.IngredientName);
            //var mySubIngredients = currentIngr.Where(i=> i.FoodCatID == 33).ToList();
            //var currentIngr = ingrRepo.GetIngredientsByRecipeID(rcpID).ToList();
            /*foreach (object o in currentIngr)
            {
                System.Console.WriteLine(o);
            }
            */
            return;
        }

    }
}
