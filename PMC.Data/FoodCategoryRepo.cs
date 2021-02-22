using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMC.Data
{
    public class FoodCategoryRepo
    {
        DataContext DB;
        int userID;

        public FoodCategoryRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }
        public FoodCategory GetFoodCategoryByCategoryID(int id)
        {
            using (var connection = DB.PmcDB)
            {
                var foodCategory = connection.QueryFirstOrDefault<FoodCategory>(@"
                    EXECUTE [dbo].[_GetFoodCategoryByCategoryID]
                    @FoodCategoryID
                    ", new { FoodCategoryID = id });
                return foodCategory;
            }
        }

        public IEnumerable<FoodCategory> GetFoodCategories()
        {
            using (var connection = DB.PmcDB)
            {
                var foodCategories = connection.Query<FoodCategory>(@"
                    EXECUTE [dbo].[_GetFoodCategories]
                    ");
                return foodCategories;
            }
        }
        public IEnumerable<FoodCategory> GetShoppingListFoodCateogoriesByUserIDMealDateRange(int UserID, DateTime FromDate, DateTime ToDate)
        {
            using (var connection = DB.PmcDB)
            {
                var foodCategories = connection.Query<FoodCategory>(@"
                    EXECUTE [dbo].[_GetShoppingListFoodCateogoriesByUserIDMealDateRange]
                    @UserID,
                    @fromDate,
                    @toDate", new {UserID, FromDate, ToDate });
                return foodCategories;
            }
        }

    }
}
