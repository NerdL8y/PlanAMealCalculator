using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMC.Data
{
    public class CookMethodRepo
    {
        private readonly DataContext DB;
        protected int userID;

        public CookMethodRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }

        public CookMethod GetCookMethodByCookMethodID(int id)
        {
            using var connection = DB.PmcDB;
            var cookMethod = connection.QueryFirstOrDefault<CookMethod>(@"
                    EXECUTE [dbo].[_GetCookMethodByCookMethodID]
                    @CookMethodID
                    ", new { CookMethodID = id});
            return cookMethod;
        }

        public IEnumerable<CookMethod> GetCookMethods()
        {
            using var connection = DB.PmcDB;
            var cookMethod = connection.Query<CookMethod>(@"
                    EXECUTE [dbo].[_GetCookMethods]
                    ");
            return cookMethod;
        }

    }
}
