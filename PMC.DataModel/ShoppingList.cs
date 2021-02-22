using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.DataModel
{
    //for use with the stored procedure _GetShoppingListByUserIDDateRange
    public class ShoppingList
    {
        public decimal IngredientQty { get; set; }
        public string UnitOfMeasureDescription { get; set; }
        public string IngredientDescription { get; set; }
        public string FoodCategoryDescription { get; set; }
        public int IngredientID { get; set; }
        public int FoodCategoryID { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int UserID { get; set; }
        public string IngredientCondition { get; set; }
        public string RecipeName { get; set; }

        //overrides
        public override string ToString()
        {
            return $"{IngredientQty}\t{UnitOfMeasureDescription}\t{IngredientDescription}";
        }
    }
}
