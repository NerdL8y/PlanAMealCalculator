using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.DataModel
{
    public class PreparationTimelineIngredients
    {
		//this model used with stored procedure _GetPrepTimelineIngredientsByMealID
		public int MealID { get; set; }
		public int ComponentID { get; set; }
		public int RecipeID { get; set; }
		public string RecipeName { get; set; }
		public DateTime RecipeStartTime { get; set; }
		public decimal IngredientQty { get; set; }
		public string UnitOfMeasureDescription { get; set; }
		public string IngredientDescription { get; set; }

		//overrides
		public override string ToString()
        {
			return $"{RecipeStartTime.ToString("h:mm tt")} {IngredientQty} {UnitOfMeasureDescription}\t{IngredientDescription}";
		}

    }
}
