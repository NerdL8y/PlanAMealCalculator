using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMC.Data
{
    public class MealTypeRepo
    {
        private readonly DataContext DB;
        protected int userID;

        public MealTypeRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }

        public MealType GetMealTypeByMealTypeIDUserID(int MealTypeID)
        {
            using var connection = DB.PmcDB;
            var mealType = connection.QueryFirstOrDefault<MealType>(@"
                    EXECUTE [dbo].[_GetMealTypeByMealTypeID]
                    @MealTypeID
                    ", new { MealTypeID });
            return mealType;
        }

        public IEnumerable<MealType> GetMealTypes()
        {
            using var connection = DB.PmcDB;
            var mealTypes = connection.Query<MealType>(@"
                    EXECUTE [dbo].[_GetMealTypes]
                    ");
            return mealTypes;
        }

    }
}
