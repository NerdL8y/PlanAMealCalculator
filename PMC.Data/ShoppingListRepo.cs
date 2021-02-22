using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PMC.Data
{
    public class ShoppingListRepo
    {
        DataContext DB;
        int userID;

        public ShoppingListRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }
        public IEnumerable<ShoppingList> GetShoppingListByUserIDDateRange(int UserID, DateTime FromDate, DateTime ToDate)
        {
            using (var connection = DB.PmcDB)
            {
                var shoppingListRecipes = connection.Query<ShoppingList>(@"
                    EXECUTE [dbo].[_GetShoppingListByUserIDDateRange]
                    @UserID, 
                    @FromDate, 
                    @ToDate
                    ", new { UserID, FromDate, ToDate });
                return shoppingListRecipes;
            }
        }

        public IEnumerable<ShoppingList> GetShoppingListRecipesByUserIDDateRange(int UserID, DateTime FromDate, DateTime ToDate)
        {
            using (var connection = DB.PmcDB)
            {
                var shoppingListItems = connection.Query<ShoppingList>(@"
                    EXECUTE [dbo].[_GetShoppingListRecipesByUserIDDateRange]
                    @UserID, 
                    @FromDate, 
                    @ToDate
                    ", new { UserID, FromDate, ToDate });
                return shoppingListItems;
            }
        }

    }
}
