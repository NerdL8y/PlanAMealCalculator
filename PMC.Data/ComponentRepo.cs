using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMC.Data
{
    public class ComponentRepo
    {
        DataContext DB;
        int userID;

        public ComponentRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }
        public Component GetComponentByCompID(int id)
        {
            using (var connection = DB.PmcDB)
            {
                var component = connection.QueryFirstOrDefault<Component>(@"
                    EXECUTE [dbo].[_GetComponentSingleByCompID]
                    @ComponentID
                    ", new { ComponentID = id });
                return component;
            }
        }

        public IEnumerable<Component> GetComponentsByUserID(int id)
        {
            using (var connection = DB.PmcDB)
            {
                var components = connection.Query<Component>(@"
                    EXECUTE [dbo].[_GetComponentByUserID]
                    @ComponentID
                    ", new { ComponentID = id });
                return components;
            }
        }


        public IEnumerable<Component> GetComponentAppetizersByUserID(int id)
        {
            using (var connection = DB.PmcDB)
            {
                var components = connection.Query<Component>(@"
                    EXECUTE [dbo].[_GetComponentAppetizersByUserID]
                    @ComponentID
                    ", new { ComponentID = id });
                return components;
            }
        }
        public IEnumerable<Component> GetComponentEntreesByUserID(int id)
        {
            using (var connection = DB.PmcDB)
            {
                var components = connection.Query<Component>(@"
                    EXECUTE [dbo].[_GetComponentEntreesByUserID]
                    @ComponentID
                    ", new { ComponentID = id });
                return components;
            }
        }
        public IEnumerable<Component> GetComponentDessertsByUserID(int id)
        {
            using (var connection = DB.PmcDB)
            {
                var components = connection.Query<Component>(@"
                    EXECUTE [dbo].[_GetComponentDessertsByUserID]
                    @ComponentID
                    ", new { ComponentID = id });
                return components;
            }
        }

        public IEnumerable<Component> GetComponentsByMealID(int id)
        {
            using (var connection = DB.PmcDB)
            {
                var components = connection.Query<Component>(@"
                    EXECUTE [dbo].[_GetComponentByMealID]
                    @ComponentID
                    ", new { ComponentID = id });
                return components;
            }
        }

        public Component SetComponentName(int CompID, string CompName)
        {
            using (var connection = DB.PmcDB)
            {
                var component = connection.QueryFirstOrDefault <Component>(@"
                        EXECUTE [dbo].[_setCompName]
                        @CompID,
                        @CompName
                        ", new { CompID, CompName });
                return component;
            }
        }
        public Component SetComponentType(int CompID, int _cCompType)
        {
            using (var connection = DB.PmcDB)
            {
                var component = connection.QueryFirstOrDefault<Component>(@"
                        EXECUTE [dbo].[_setComponentTypeID]
                        @CompID,
                        @_cCompType
                        ", new { CompID, _cCompType });
                return component;
            }
        }

        public Component SetComponentUserID(int CompID, int _cUserID)
        {
            using (var connection = DB.PmcDB)
            {
                var component = connection.QueryFirstOrDefault<Component>(@"
                        EXECUTE [dbo].[_setComponentUserID]
                        @CompID,
                        @_cUserID
                        ", new { CompID, _cUserID });
                return component;
            }
        }

        public Component InsertComponentByUserID(string CompName, int _cCompType, int _cUserID) 
        {
            using (var connection = DB.PmcDB)
            {
                var component = connection.QueryFirstOrDefault<Component>(@"
                        EXECUTE [dbo].[_insertComponentByUserID]
                        @CompName,
                        @_cCompType,
                        @_cUserID
                        ", new { CompName, _cCompType , _cUserID });
                return component;
            }
        }
        public Component GetRecipesByComponentID(int CompID)
        {
            using (var connection = DB.PmcDB)
            {
                var components = connection.QueryFirstOrDefault<Component>(@"
                    EXECUTE [dbo].[_GetComponentByCompID]
                    @CompID
                    ", new { CompID });
                components.Recipes = connection.Query<Recipe>(@"
                    EXECUTE [dbo].[_GetRecipesByComponentID]
                    @CompID
                    ", new { components.CompID});
                return components;
            }
        }
    }
}