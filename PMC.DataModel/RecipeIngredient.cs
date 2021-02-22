using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.DataModel
{
    public class RecipeIngredient
    {
        public int _riRecipeID { get; set; }
        public int _riIngredientID { get; set; }
        public string IngredientCondition { get; set; }
        public decimal IngredientQty { get; set; }
        public decimal SingularIngredientQty { get; set; }
        public int _riUOMID { get; set; }
        public string UomDesc { get; set; }
        public string RecipeName { get; set; }
        public int MealID { get; set; }
        public int CompID { get; set; }
        public int UserID { get; set; }
        public string IngredientName { get; set; }
        public decimal QtyMultiplier { get; set; }
        public int MealGuests { get; set; }
        public int rcpServingsQty { get; set; }
        public string RecipeOddEven { get; set; }


    }
}
