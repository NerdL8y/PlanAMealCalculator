using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.DataModel
{
    public class PreparationTimeline
    {
        //this data model is for use with stored procedure _GetPrepTimelineInstructionsByMealID
        public int MealID { get; set; }
        public int ComponentID { get; set; }
        public int RecipeID { get; set; }
        public DateTime ComponentServeDateTime { get; set; }
        public DateTime StepStartTime { get; set; }
        public int InstructionSortOrder { get; set; }
        public int InstructionEstimatedTime { get; set; }
        public string UnitOfTimeDescription { get; set; }
        public string InstructionDescription { get; set; }
        public decimal PrepInAdvanceMinutes { get; set; }
        public string RecipeName { get; set; }

        //overrides
        public override string ToString()
        {
            return $"{StepStartTime.ToString("ddd")} {StepStartTime.ToString("h:mm tt")} {InstructionDescription} ";
        }
    }
}
