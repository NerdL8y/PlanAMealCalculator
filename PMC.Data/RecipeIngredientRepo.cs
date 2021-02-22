using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMC.Data
{
    public class RecipeIngredientRepo
    {
        DataContext DB;
        int userID;

        public RecipeIngredientRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }

        // TODO not sure if I am going to need this since I have a method to retrieve the ingredients within the RecipeRepo.
        public IEnumerable<RecipeIngredient> GetIngredientsByRecipeID(int RecipeID)
        {
            using (var connection = DB.PmcDB)
            {
                var ingredients = connection.Query<RecipeIngredient>(@"
                    EXECUTE [dbo].[_GetIngredientsByRecipeID]
                    @RecipeID
                    ", new { RecipeID });
                return ingredients;
            }
        }

        public RecipeIngredientRepo DeleteRecipeIngredientByRecipeIDIngredientIDUserID(int _riRecipeID, int _riIngredientID, int UserID)
        {
            using (var connection = DB.PmcDB)
            {
                var recipe = connection.QueryFirstOrDefault<RecipeIngredientRepo>(@"
                        EXECUTE [dbo].[_deleteRecipeIngredientByRecipeIDIngredientIDUserID]
                        @_riRecipeID,
                        @_riIngredientID,
                        @UserID
                        ", new  { _riRecipeID, _riIngredientID , UserID});
                return recipe;
            }
        }

        public RecipeIngredient InsertIngredientByRecipeID(int _riRecipeID, int _riIngredientID, string IngredientCondition, decimal IngredientQty, int UomID, int UserID)
        {
            using (var connection = DB.PmcDB)
            {
                var ingredient = connection.QueryFirstOrDefault<RecipeIngredient>(@"
                    EXECUTE [dbo].[_insertRecipeIngredient]
		            @_riRecipeID,
                    @_riIngredientID,
                    @ingredientCondition,
                    @IngredientQty,
                    @UomID,
                    @userID
   
                    ", new
                {
                    _riRecipeID,
                    _riIngredientID,
                    IngredientCondition,
                    IngredientQty,
                    UomID,
                    UserID
                });
                return ingredient;
            }
        }
        public IEnumerable<RecipeIngredient> GetPrepTimelineIngredientsRecipeIDByMealID(int MealID)
        {
            using (var connection = DB.PmcDB)
            {
                var ingredients = connection.Query<RecipeIngredient>(@"
                    EXECUTE [dbo].[_GetPrepTimelineIngredientsRecipeIDByMealID]
                    @MealID
                    ", new { MealID });
                return ingredients;
            }
        }
        public IEnumerable<RecipeIngredient> GetPrepTimelineIngredientsByMealID(int MealID)
        {
            using (var connection = DB.PmcDB)
            {
                var ingredients = connection.Query<RecipeIngredient>(@"
                    EXECUTE [dbo].[_GetPrepTimelineIngredientsByMealID]
                    @MealID
                    ", new { MealID });
                return ingredients;
            }
        }

        public RecipeIngredientRepo GetIngredientSingleByRecipeIDIngredientID(int _riRecipeID, int _riIngredientID)
        {
            using (var connection = DB.PmcDB)
            {
                var ingredient = connection.QueryFirstOrDefault<RecipeIngredientRepo>(@"
                    EXECUTE [dbo].[_GetIngredientSingleByRecipeIDIngredientID]
		            @_riRecipeID,
                    @_riIngredientID   
                    ", new { _riRecipeID, _riIngredientID });
                return ingredient;
            }
        }

        public RecipeIngredientRepo SetRecipeIngredientUOMByRecipeID(int _riRecipeID, int _riUOMID)
        {
            using (var connection = DB.PmcDB)
            {
                var ingredient = connection.QueryFirstOrDefault<RecipeIngredientRepo>(@"
                    EXECUTE [dbo].[_setRecipeIngredientUOMByRecipeID]
		            @_riRecipeID,
                    @_riUOMID
                    ", new { _riRecipeID, _riUOMID });
                return ingredient;
            }
        }

        public RecipeIngredientRepo SetRecipeIngredientQtyByRecipeID(int _riRecipeID, int _riIngredientID, decimal IngredientQty)
        {
            using (var connection = DB.PmcDB)
            {
                var ingredient = connection.QueryFirstOrDefault<RecipeIngredientRepo>(@"
                    EXECUTE [dbo].[_setRecipeIngredientQuantityByRecipeID]
		            @_riRecipeID,
		            @_riIngredientID,
                    @IngredientQty
                    ", new { _riRecipeID, _riIngredientID, IngredientQty });
                return ingredient;
            }
        }


    }
}
