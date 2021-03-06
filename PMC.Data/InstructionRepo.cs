using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMC.Data
{
    public class InstructionRepo
    {
        private readonly DataContext DB;
        protected int userID;

        public InstructionRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }

        public Instruction GetInstructionByInstructionID(int id)
        {
            using var connection = DB.PmcDB;
            var instruction = connection.QueryFirstOrDefault<Instruction>(@"
                        EXECUTE [dbo].[_GetInstructionByInstructionID]
                        @InstructionID
                        ", new { InstructionID = id });
            return instruction;
        }
        public IEnumerable<Instruction> GetInstructionsByRecipeID( int id)
        {
            using var connection = DB.PmcDB;
            var instructions = connection.Query<Instruction>(@"
                    EXECUTE [dbo].[_GetInstructionsByRecipeID]
                    @InstructionID
                    ", new { InstructionID = id });
            return instructions;
        }

        // Not working right to insert an SQL record
        
        public Instruction InsertInstructionByRecipeID(int instRecipeID, decimal instructionEstTime, int instUOTID, int instructionSortOrder, string instDescription, int userID)
        {
            using var connection = DB.PmcDB;
            var instruction = connection.QueryFirstOrDefault<Instruction>(@"
                    EXECUTE [dbo].[_insertInstructionByRecipeID]
		            @_instRecipeID,
		            @instructionEstTime,
		        	@_instUOTID,
			        @instructionSortOrder,
			        @instDescription,
			        @userID
                    ", new{ instRecipeID, instructionEstTime, instUOTID, instructionSortOrder, instDescription, userID});
            return instruction;
        }

        public Instruction SetInstructionDescription(int InstructionID, string Instdescription)
        {
            using var connection = DB.PmcDB;
            var instruction = connection.QueryFirstOrDefault<Instruction>(@"
                        EXECUTE [dbo].[_setInstDescription]
                        @InstructionID,
                        @InstDescription
                        ", new { InstructionID, Instdescription });
            return instruction;
        }

        public Instruction SetInstructionEstTime(int InstructionID, decimal InstructionEstTime)
        {
            using var connection = DB.PmcDB;
            var instruction = connection.QueryFirstOrDefault<Instruction>(@"
                        EXECUTE [dbo].[_setInstructionEstTime]
                        @InstructionID,
                        @instructionEstTime
                        ", new { InstructionID, InstructionEstTime });
            return instruction;
        }

        public Instruction SetInstructionUnitOfTime(int InstructionID, int _instUOTID)
        {
            using var connection = DB.PmcDB;
            var instruction = connection.QueryFirstOrDefault<Instruction>(@"
                        EXECUTE [dbo].[_setInstructionUOTID]
                        @InstructionID,
                        @_instUOTID
                        ", new { InstructionID, _instUOTID });
            return instruction;
        }
        public Instruction SetInstructionSortOrder(int InstructionID, int InstructionSortOrder)
        {
            using var connection = DB.PmcDB;
            var instruction = connection.QueryFirstOrDefault<Instruction>(@"
                        EXECUTE [dbo].[_setInstructionSortOrder]
                        @InstructionID,
                        @InstructionSortOrder
                        ", new { InstructionID, InstructionSortOrder });
            return instruction;
        }
        public IEnumerable<Instruction> GetPreparationTimelineByMealID(int MealID)
        {
            using var connection = DB.PmcDB;
            var prepTimeline = connection.Query<Instruction>(@"
                    EXECUTE [dbo].[_GetPrepTimelineInstructionsByMealID]
                    @MealID
                    ", new { MealID });
            return prepTimeline;
        }
        public IEnumerable<Instruction> GetPrepTimelineInstructionDatesByMealID(int MealID)
        {
            using var connection = DB.PmcDB;
            var prepTimeline = connection.Query<Instruction>(@"
                    EXECUTE [dbo].[_GetPrepTimelineInstructionDatesByMealID]
                    @MealID
                    ", new { MealID });
            return prepTimeline;
        }

        public InstructionRepo DeleteRecipeInstructionByRecipeIDInstructionIDUserID(int _instRecipeID, int InstructionID, int UserID)
        {
            using var connection = DB.PmcDB;
            var recipe = connection.QueryFirstOrDefault<InstructionRepo>(@"
                        EXECUTE [dbo].[_deleteRecipeInstructionByRecipeIDIstructionIDUserID]
                        @_instRecipeID,
                        @InstructionID,
                        @UserID
                        ", new { _instRecipeID, InstructionID, UserID });
            return recipe;
        }
        public Instruction SetInstructionSortOrderByInstructionID(int InstructionID, int InstructionSortOrder)
        {
            using var connection = DB.PmcDB;
            var instruction = connection.QueryFirstOrDefault<Instruction>(@"
                        EXECUTE [dbo].[_setReorderInstructionSortOrder]
                        @InstructionID,
                        @InstructionSortOrder
                        ", new { InstructionID, InstructionSortOrder });
            return instruction;
        }
    }
}
