using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMC.Data
{
    public class ComponentRecipeRepo
    {
        DataContext DB;
        int userID;

        public ComponentRecipeRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }

            public ComponentRecipeRepo InsertComponentRecipeByCompIDRecipeID(int _crCompID, int _crRecipeID, decimal PrepInAdvTime, int UserID)
        {
            using (var connection = DB.PmcDB)
            {
                var component = connection.QueryFirstOrDefault<ComponentRecipeRepo>(@"
                    EXECUTE [dbo].[_insertComponentRecipeByCompIDRecipeID]
                    @_crCompID,
                    @_crRecipeID,
                    @prepInAdvTime,
                    @userID
                    ", new { _crCompID, _crRecipeID, PrepInAdvTime, UserID });
                return component;
            }
        }


    }
}
