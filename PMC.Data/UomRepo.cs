using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMC.Data
{
    public class UomRepo
    {
        DataContext DB;
        int userID;

        public UomRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }

        public Uom GetUomDescriptionByUomID(int id) 
        {
            using (var connection = DB.PmcDB)
            {
                var uom = connection.QueryFirstOrDefault<Uom>(@"
                        EXECUTE [dbo].[_GetUomByUomID]
                        @UomID
                        ", new { UomID = id });
                return uom;
            }
        }
        public IEnumerable<Uom> GetUomList()
        {
            using (var connection = DB.PmcDB)
            {
                var uom = connection.Query<Uom>(@"
                    EXECUTE [dbo].[_GetUomList]
                    ");
                return uom;
            }
        }

    }
}
