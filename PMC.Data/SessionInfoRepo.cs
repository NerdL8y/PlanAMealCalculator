using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.Data
{
    public class SessionInfoRepo
    {
        DataContext DB;
        int userID;

        public SessionInfoRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }

        public SessionInfo Authenticate(string UserName, string UserPassword)
        {
            using (var connection = DB.PmcDB)
            {
                var sessionInfo = connection.QueryFirstOrDefault<SessionInfo>(@"
                        EXECUTE [dbo].[spAuthenticate]
                        @UserName,
                        @UserPassword
                        ", new { UserName, UserPassword });
                return sessionInfo;
            }
        }
        public SessionInfo Logout(int UserID)
        {
            using (var connection = DB.PmcDB)
            {
                var sessionInfo = connection.QueryFirstOrDefault<SessionInfo>(@"
                        EXECUTE [dbo].[_userLogout]
                        @UserID
                        ", new { UserID});
                return sessionInfo;
            }
        }

    }
}
