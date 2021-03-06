using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMC.Data
{
    public class PreparationTimelineIngredientsRepo
    {
        private readonly DataContext DB;
        protected int userID;

        public PreparationTimelineIngredientsRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }

        public IEnumerable<PreparationTimelineIngredients> GetPreparationTimelineIngredientsByMealID(int id)
        {
            using var connection = DB.PmcDB;
            var prepTimelineIngredients = connection.Query<PreparationTimelineIngredients>(@"
                    EXECUTE [dbo].[_GetPrepTimelineIngredientsByMealID]
                    @MealID
                    ", new { MealID = id });
            return prepTimelineIngredients;
        }
        


    }
}
