using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PMC.Data
{
    public class RecipeRepo
    {
        DataContext DB;
        int userID;

        public RecipeRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }

        public Recipe GetRecipeByRecipeID(int id)
        {
            using (var connection = DB.PmcDB)
            {
                var recipe = connection.QueryFirstOrDefault<Recipe>(@"
                    EXECUTE [dbo].[_GetRecipeByRecipeID]
                    @RecipeID
                    ", new { RecipeId = id });
                recipe.Ingredients = connection.Query<RecipeIngredient>(@"
                    EXECUTE [dbo].[_GetIngredientsByRecipeID]
                    @RecipeID
                    ", new { recipe.RecipeID });
                recipe.Instructions = connection.Query<Instruction>(@"
                    EXECUTE [dbo].[_GetInstructionsByRecipeID]
                    @RecipeID
                    ", new { recipe.RecipeID });
                return recipe;
            }
        }
        public IEnumerable<Recipe> GetRecipesByCompID(int CompID) 
        {
            using (var connection = DB.PmcDB)
            {
                var recipes = connection.Query<Recipe>(@"
                    EXECUTE [dbo].[_GetRecipesByComponentID]
                    @CompID
                    ", new { CompID });
                return recipes;
            }
        }
        public Recipe GetSingleRecipeByCompID(int CompID)
        {
            using (var connection = DB.PmcDB)
            {
                var recipes = connection.QueryFirstOrDefault<Recipe>(@"
                    EXECUTE [dbo].[_getRecipeSingleByComponentID]
                    @CompID
                    ", new { CompID });
                return recipes;
            }
        }

        public Recipe GetRecipeOnlyByRecipeID(int RecipeID)
        {
            using (var connection = DB.PmcDB)
            {
                var recipes = connection.QueryFirstOrDefault<Recipe>(@"
                    EXECUTE [dbo].[_GetRecipeOnlyByRecipeID]
                    @RecipeID
                    ", new { RecipeID });
                return recipes;
            }
        }

        public IEnumerable<Recipe> GetRecipesByUserID(int id)
        {
            using (var connection = DB.PmcDB)
            {
                var recipes = connection.Query<Recipe>(@"
                    EXECUTE [dbo].[_GetRecipesByUserID]
                    @UserID
                    ", new { UserID = id });
                return recipes;
            }
        }
        public IEnumerable<Recipe> GetRecipesByMealID(int MealID)
        {
            using (var connection = DB.PmcDB)
            {
                var recipes = connection.Query<Recipe>(@"
                    EXECUTE [dbo].[_GetRecipesByMealID]
                    @MealID
                    ", new { MealID });
                return recipes;
            }
        }


        public Recipe InsertRecipeByUserID(int UserID, string rcpName, int rcpServingsQty, int _rcpCookMethodID, int _rcpCookwareID)
        {
            using (var connection = DB.PmcDB)
            {
                var recipe = connection.QueryFirstOrDefault<Recipe>(@"
                    EXECUTE [dbo].[_insertRecipeByUserID]
                    @UserID,
                    @rcpName,
                    @rcpServingsQty,
                    @_rcpCookMethodID,
                    @_rcpCookwareID
                    ", new { UserID, rcpName, rcpServingsQty, _rcpCookMethodID, _rcpCookwareID } ) ;
                return recipe;
            }
        }

        public Recipe SetRecipeNameByRecipeID(int RecipeID, string RecipeName)
        {
            using (var connection = DB.PmcDB)
            {
                var recipe = connection.QueryFirstOrDefault<Recipe>(@"
                        EXECUTE [dbo].[_setRecipeNameByRecipeID]
                        @RecipeID,
                        @RecipeName
                        ", new { RecipeID, RecipeName });
                return recipe;
            }
        }

        public Recipe SetRecipeServingsByRecipeID(int RecipeID, int RcpServingsQty)
        {
            using (var connection = DB.PmcDB)
            {
                var recipe = connection.QueryFirstOrDefault<Recipe>(@"
                        EXECUTE [dbo].[_SetRecipeServingsByRecipeID]
                        @RecipeID,
                        @RcpServingsQty
                        ", new { RecipeID, RcpServingsQty });
                return recipe;
            }
        }
        public Recipe CheckRecipeNameByUserID(string RcpName, int UserID)
        {
            using (var connection = DB.PmcDB)
            {
                var recipe = connection.QueryFirstOrDefault<Recipe>(@"
                        EXECUTE [dbo].[_CheckRecipeNameByUserID]
                        @RcpName,
                        @UserID
                        ", new { RcpName, UserID });
                return recipe;
            }
        }
        public IEnumerable<Recipe> SearchRecipeNameByUserID(string RcpName, int UserID)
        {
            using (var connection = DB.PmcDB)
            {
                var recipes = connection.Query<Recipe>(@"
                        EXECUTE [dbo].[_SearchRecipesByUserID]
                        @RcpName,
                        @UserID
                        ", new { RcpName, UserID });
                return recipes;
            }
        }

        public Recipe GetRecipeIngredientCountByRecipeID(int RecipeID)
        {
            using (var connection = DB.PmcDB)
            {
                var recipes = connection.QueryFirstOrDefault<Recipe>(@"
                    EXECUTE [dbo].[_GetRecipeIngredientCountByRecipeID]
                    @RecipeID
                    ", new { RecipeID });
                return recipes;
            }
        }

        public Recipe GetRecipeInstructionCountByRecipeID(int RecipeID)
        {
            using (var connection = DB.PmcDB)
            {
                var recipes = connection.QueryFirstOrDefault<Recipe>(@"
                    EXECUTE [dbo].[_GetRecipeIntructionCountByRecipeID]
                    @RecipeID
                    ", new { RecipeID });
                return recipes;
            }
        }

    }

}

    

