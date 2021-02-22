using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.DataModel
{
    public class Recipe
    {
        public int RecipeID { get; set; }
        public int UserID { get; set; }
        public string RcpName { get; set; }
        public int RcpServingsQty { get; set; }
        public int _rcpCookMethodID { get; set; }
        public string CookMethodDesc { get; set; }
        public int _rcpCookwareID { get; set; }
        public string CookwareName { get; set; }
        public int PrepInAdvanceHours { get; set; }
        public int CompID { get; set; }
        public int CompType { get; set; }
        public int MealID { get; set; }
        public int RecipeNameCount { get; set; }
        public int RecipeOddEven { get; set; }
        public int MaxRecipeNameSize { get; set; }
        public decimal RecipeTotalPrepTime { get; set; }
        public string RecipeTotalPrepTimeHHMM { get; set; }
        public int RecipeIngredientCount { get; set; }
        public int RecipeInstructionCount { get; set; }
        public IEnumerable<RecipeIngredient> Ingredients { get; set; }
        public IEnumerable<Instruction> Instructions { get; set; }

        //overrides
        public override string ToString()
        {
            return $"{RecipeID} : {RcpName} ";
        }
    }

}
