using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.DataModel
{
    public class Instruction
    {
        public int InstructionID { get; set; }
        public int _instRecipeID { get; set; }
        public decimal InstructionEstTime { get; set; }
        public int _instUOTID { get; set; }
        public string UotDesc { get; set; }
        public int InstructionSortOrder { get; set; }
        public string InstDescription { get; set; }
        public DateTime StepStartTime { get; set; }
        public DateTime StartStepDay { get; set; }
        public int PrepInAdvanceMinutes { get; set; }
        public string RecipeName { get; set; }
        public int UserID { get; set; }
        //overrides
        public override string ToString()
        {
            return $"{InstructionSortOrder} : {InstDescription}";
        }
    }
}
