using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMC.Data
{
    public class MealComponentRepo
    {
        private readonly DataContext DB;
        protected int userID;

        public MealComponentRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }

        public MealComponent GetMealComponentByMealIDComponentID(int mealID, int compID)
        {
            using var connection = DB.PmcDB;
            var mealComponent = connection.QueryFirstOrDefault<MealComponent>(@"
                    EXECUTE [dbo].[_GetMealComponentByMealIDComponentID]
                    @_mcMealID,
                    @_mcCompID
                    ", new { _mcMealID = mealID, _mcCompID = compID });
            return mealComponent;
        }

        public IEnumerable<MealComponent> GetMealComponentsByMealID(int MealID)
        {
            using var connection = DB.PmcDB;
            var mealComponents = connection.Query<MealComponent>(@"
                    EXECUTE [dbo].[_GetMealComponentsByMealID]
                    @MealID
                    ", new { MealID });
            return mealComponents;
        }

        public MealComponent InsertMealComponentByMealIDCompID(int _mcMealID, int _mcCompID, DateTime CompServeDateTime, int UserID)
        {
            using var connection = DB.PmcDB;
            var mealComponent = connection.QueryFirstOrDefault<MealComponent>(@"
                    EXECUTE [dbo].[_insertMealComponentByMealIDCompID]
                    @_mcMealID,
                    @_mcCompID,
                    @CompServeDateTime,
                    @UserID
                    ", new { _mcMealID, _mcCompID, CompServeDateTime, UserID });
            return mealComponent;
        }
    }
}
