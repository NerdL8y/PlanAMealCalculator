using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PMC.DataModel
{
    public class Ingredient
    {
        public int IngredientID { get; set; }
        public string IngredientName { get; set; }
        public int FoodCatID { get; set; }
        public string FoodCatDesc { get; set; }
        public decimal IngredientQty { get; set; }
        public int UomID { get; set; }
        public string UomDesc { get; set; }
        public string IngredientCondition { get; set; }
        public DateTime RecipeStartTime { get; set; }
        public string RecipeName { get; set; }


        // Overrides
        public override string ToString()
        {
            return $"{IngredientID} : {IngredientName}";
        }
     

    }

}


