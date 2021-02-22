using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMC.Data
{
    public class ComponentTypeRepo
    {
        DataContext DB;
        int userID;

        public ComponentTypeRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }

        public IEnumerable<ComponentType> GetComponentTypes()
        {
            using (var connection = DB.PmcDB)
            {
                var compTypes = connection.Query<ComponentType>(@"
                    EXECUTE [dbo].[_GetComponentTypes]
                    ");
                return compTypes;
            }
        }

    }

}
