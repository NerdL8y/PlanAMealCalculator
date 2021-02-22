using System;
using System.Collections.Generic;
using System.Text;

//PMC1052-03
namespace PMC.DataModel
{
    public class Meal
    {
        public int MealID { get; set; }
        public int _mealUserID { get; set; }
        public string MealName { get; set; }
        public DateTime MealDate { get; set; }
        public int MealGuests { get; set; }
        public int _mealType { get; set; }
        public string MealTypeDesc { get; set; }
        public int NumPreparers { get; set; }
        public int MealNameCount { get; set; }
        public DateTime ServeTime { get; set; }
        public DateTime StartStepDay { get; set; }
        public DateTime MealStartPrepNLT { get; set; }
        public IEnumerable<Component> Components { get; set; }
        // Overrides
        //public IEnumerable<PreparationTimeline> PreparationTimelineInstructionsList { get; set; }
        public IEnumerable<Instruction> MealInstructions { get; set; }
        public IEnumerable<RecipeIngredient> MealIngredients { get; set; }
        //public IEnumerable<PreparationTimelineIngredients> PreparationTimelineIngredientsList { get; set; }
        public override string ToString()
        {
            return $"{MealTypeDesc} {MealID} {MealName} {MealDate} {MealGuests} {NumPreparers}";
        }
    }

}
