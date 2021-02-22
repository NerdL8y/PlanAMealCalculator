using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.Data
{
    public class CookwareRepo
    {
        DataContext DB;
        int userID;

        public CookwareRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }

        public IEnumerable<Cookware> GetCookwareList()
        {
            using (var connection = DB.PmcDB)
            {
                var cookware = connection.Query<Cookware>(@"
                    EXECUTE [dbo].[_GetCookwareList]
                    ");
                return cookware;
            }
        }
        
        public Cookware GetCookwareByCookwareID(int id)
        {
            using (var connection = DB.PmcDB)
            {
                var cookware = connection.QueryFirstOrDefault<Cookware>(@"
                    EXECUTE [dbo].[_GetCookwareByCookwareID]
                    @CookwareID
                    ", new { CookwareID = id });
                return cookware;
            }
        }

        public IEnumerable<Cookware> GetCookwareByUserID(int UserID)
        {
            using (var connection = DB.PmcDB)
            {
                var cookware = connection.Query<Cookware>(@"
                    EXECUTE [dbo].[_GetCookwareByUserID]
                    @UserID
                    ", new { UserID });
                return cookware;
            }

        }

        public Cookware SetCookwareNameByCookwareID(int CookwareID, string CookwareName)
        {
            using (var connection = DB.PmcDB)
            {
                var cookware = connection.QueryFirstOrDefault<Cookware>(@"
                        EXECUTE [dbo].[_setCookwareNameByCookwareID]
                        @CookwareID,
                        @CookwareName
                        ", new { CookwareID, CookwareName });
                return cookware;
            }
        }

        public Cookware InsertCookwareByUserID(string CookwareName, int UserID)
        {
            using (var connection = DB.PmcDB)
            {
                var cookware = connection.QueryFirstOrDefault<Cookware>(@"
                    EXECUTE [dbo].[_insertCookwareByUserID]
                    @CookwareName,
                    @UserID
                    ", new { CookwareName, UserID });
                return cookware;
            }
        }
    }
}
