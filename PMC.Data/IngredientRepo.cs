using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.Data
{
    public class IngredientRepo
    {
        DataContext DB;
        int userID;

        public IngredientRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }
        
        public Ingredient GetIngredientByIngredientID(int id )
        {
            using (var connection = DB.PmcDB)
            {

                System.Console.WriteLine("IngredientRepo.cs just before call to SQL");
                var ingredient = connection.QueryFirstOrDefault<Ingredient>(@"
                        EXECUTE [dbo].[_getIngredientByIngredientID]
                        @IngredientID
                        ", new { IngredientID = id });
                return ingredient;
            }
        }
        public IEnumerable<Ingredient> GetIngredients()
        {
            using (var connection = DB.PmcDB)
            {
                var ingredients = connection.Query<Ingredient>(@"
                    EXECUTE [dbo].[_GetIngredients]
                    ");
                return ingredients;
            }
        }

        public IEnumerable<Ingredient> SearchIngredients(string IngredientName)
        {
            using (var connection = DB.PmcDB)
            {
                var ingredients = connection.Query<Ingredient>(@"
                    EXECUTE [dbo].[_SearchIngredients]
                    @IngredientName
                    ", new { IngredientName});
                return ingredients;
            }
        }
        public IEnumerable<Ingredient> GetPreparationTimelineIngredientsByMealID(int MealID)
        {
            using (var connection = DB.PmcDB)
            {
                var prepTimelineIngredients = connection.Query<Ingredient>(@"
                    EXECUTE [dbo].[_GetPrepTimelineIngredientsByMealID]
                    @MealID
                    ", new { MealID });
                return prepTimelineIngredients;
            }
        }
       

    }
}
