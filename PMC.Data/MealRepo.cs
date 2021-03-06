using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMC.Data
{
    public class MealRepo
    {
        private readonly DataContext DB;
        protected int userID;

        public MealRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }

        public Meal GetMealByMealID(int id)
        {
            using var connection = DB.PmcDB;
            var meal = connection.QueryFirstOrDefault<Meal>(@"
                    EXECUTE [dbo].[_GetMealByMealID]
                    @MealID
                    ", new { MealId = id });
            meal.Components = connection.Query<Component>(@"
                    EXECUTE [dbo].[_GetComponentByMealID]
                    @MealID
                   ", new { meal.MealID });
            return meal;
        }
        public List<Meal> GetMealsByMealTypeIDUserID(int _mealType, int UserID)
        {
            using var connection = DB.PmcDB;
            var meal = connection.Query<Meal>(@"
                    EXECUTE [dbo].[_GetMealsByMealTypeIDUserID]
                    @_mealType,
                    @UserID
                    ", new { _mealType, UserID }).ToList();
            return meal;
        }
        public IEnumerable<Meal> GetMealsByUserID(int id)
        {
            using var connection = DB.PmcDB;
            var meals = connection.Query<Meal>(@"
                    EXECUTE [dbo].[_GetMealsByUserID]
                    @MealID
                    ", new { MealID = id });
            return meals;
        }

        public IEnumerable<Meal> GetPlannedMealsByUserID(int id)
        {
            using var connection = DB.PmcDB;
            var meals = connection.Query<Meal>(@"
                    EXECUTE [dbo].[_GetPlannedMealsByUserID]
                    @MealID
                    ", new { MealID = id });
            return meals;
        }
        
        public Meal SetMealName(int id, string mealName)
        {
            using var connection = DB.PmcDB;
            var meal = connection.QueryFirstOrDefault<Meal>(@"
                        EXECUTE [dbo].[_setMealName]
                        @MealID,
                        @MealName
                        ", new { MealID = id, MealName = mealName });
            return meal;
        }

        public Meal SetMealDate(int MealID, DateTime MealDate)
        {
            using var connection = DB.PmcDB;
            var meal = connection.QueryFirstOrDefault<Meal>(@"
                        EXECUTE [dbo].[_setMealDate]
                        @MealID,
                        @MealDate
                        ", new { MealID, MealDate });
            return meal;
        }

        
        public Meal SetMealType(int MealID, int _mealType)
        {
            using var connection = DB.PmcDB;
            var meal = connection.QueryFirstOrDefault<Meal>(@"
                        EXECUTE [dbo].[_setMealTypeID]
                        @MealID,
                        @_mealType
                        ", new { MealID, _mealType });
            return meal;
        }

        public Meal SetMealNumberOfGuests(int MealID, int MealGuests)
        {
            using var connection = DB.PmcDB;
            var meal = connection.QueryFirstOrDefault<Meal>(@"
                        EXECUTE [dbo].[_setMealNumberOfGuests]
                        @MealID,
                        @MealGuests
                        ", new { MealID, MealGuests });
            return meal;
        }

        public Meal SetMealNumberOfPreparersByMealID(int MealID, int NumPreparers)
        {
            using var connection = DB.PmcDB;
            var meal = connection.QueryFirstOrDefault<Meal>(@"
                        EXECUTE [dbo].[_setMealNumPreparersByMealID]
                        @MealID,
                        @NumPreparers
                        ", new { MealID, NumPreparers });
            return meal;
        }

        public Meal InsertMealByUserID(string MealName, DateTime MealDate, int MealGuests, int _mealType, int NumPreparers, int UserID)
        {
            using var connection = DB.PmcDB;
            var meal = connection.QueryFirstOrDefault<Meal>(@"
                    EXECUTE [dbo].[_insertMealByUserID]
                    @MealName,
                    @MealDate,
                    @MealGuests,
                    @_mealType,
                    @NumPreparers,
                    @UserID
                    ", new { MealName, MealDate, MealGuests, _mealType, NumPreparers, UserID });
            return meal;
        }
        public Meal GetMealPrepTimelineByMealID(int MealID)
        {
            using var connection = DB.PmcDB;
            var meal = connection.QueryFirstOrDefault<Meal>(@"
                    EXECUTE [dbo].[_GetMealByMealID]
                    @MealID
                    ", new { MealID });
            meal.MealIngredients = connection.Query<RecipeIngredient>(@"
                    EXECUTE [dbo].[_GetPrepTimelineIngredientsByMealID]
                    @MealID
                   ", new { meal.MealID });
            meal.MealInstructions = connection.Query<Instruction>(@"
                    EXECUTE [dbo].[_GetPrepTimelineInstructionsByMealID]
                    @MealID
                   ", new { meal.MealID });

            return meal;
        }
        public IEnumerable<Meal> GetMealTypesForMealsByUserID(int UserID)
        {
            using var connection = DB.PmcDB;
            var meals = connection.Query<Meal>(@"
                    EXECUTE [dbo].[_GetMealTypesForMealsByUserID]
                    @UserID
                    ", new { UserID });
            return meals;
        }
        public Meal CheckMealNameByUserID(string MealName, int UserID)
        {
            using var connection = DB.PmcDB;
            var meal = connection.QueryFirstOrDefault<Meal>(@"
                        EXECUTE [dbo].[_CheckMealNameByUserID]
                        @MealName,
                        @UserID
                        ", new { MealName, UserID });
            return meal;
        }

    }
}
