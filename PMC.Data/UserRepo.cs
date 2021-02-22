using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.Data
{
    public class UserRepo
    {
        DataContext DB;
        int userID;

        public UserRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }

        public UserAccount GetUserByUserID(int id)
        {
            using (var connection = DB.PmcDB)
            {
                var user = connection.QueryFirstOrDefault<UserAccount>(@"
                    EXECUTE [dbo].[_GetUserbyUserID]
                    @UserID
                    ", new { UserId = id });
                return user;
            }
        }

        public UserAccount GetUserBySessionID(Guid sessionID)
        {
            using (var connection = DB.PmcDB)
            {
                var user = connection.QueryFirstOrDefault<UserAccount>(@"
                    EXECUTE [dbo].[_GetUserbySessionID]
                    @SessionID
                    ", new { SessionID = sessionID });
                return user;
            }
        }
        public UserAccount GetSessionByUserID(int UserID)
        {
            using (var connection = DB.PmcDB)
            {
                var user = connection.QueryFirstOrDefault<UserAccount>(@"
                    EXECUTE [dbo].[_GetSessionIDByUserID]
                    @UserID
                    ", new { UserID });
                return user;
            }
        }
        public UserAccount GetUserFirstNameByUserID(int UserID)
        {
            using (var connection = DB.PmcDB)
            {
                var user = connection.QueryFirstOrDefault<UserAccount>(@"
                    EXECUTE [dbo].[_GetUserFirstNamebyUserID]
                    @UserID
                    ", new { UserID });
                return user;
            }
        }
        public UserAccount InsertUserAccount(string UserName, string UserFirstName, string UserLastName, string UserState, int? UserNumFamMembers, string UserEmail, byte[] UserPassword, int UserRole)
        {
            using (var connection = DB.PmcDB)
            {
                var user = connection.QueryFirstOrDefault<UserAccount>(@"
                    EXECUTE [dbo].[_insertUserAccount]
                    @UserName,
                    @UserFirstName,
                    @UserLastName,
                    @UserState,
                    @UserNumFamMembers,
                    @UserEmail,
                    @UserPassword,
                    @UserRole
                    ", new { UserName, UserFirstName, UserLastName, UserState, UserNumFamMembers, UserEmail, UserPassword, UserRole });
                return user;
            }
        }

        public UserAccount SetUserEmailByUserID(int UserID, string UserEmail)
        {
            using (var connection = DB.PmcDB)
            {
                var userAccount = connection.QueryFirstOrDefault<UserAccount>(@"
                        EXECUTE [dbo].[_setUserEmailByUserID]
                        @UserID,
                        @UserEmail
                        ", new { UserID, UserEmail });
                return userAccount;
            }
        }

        public UserAccount SetUserFirstNameByUserID(int UserID, string UserFirstName)
        {
            using (var connection = DB.PmcDB)
            {
                var userAccount = connection.QueryFirstOrDefault<UserAccount>(@"
                        EXECUTE [dbo].[_setUserFirstNameByUserID]
                        @UserID,
                        @UserFirstName
                        ", new { UserID, UserFirstName });
                return userAccount;
            }
        }

        public UserAccount SetUserLastNameByUserID(int UserID, string UserLastName)
        {
            using (var connection = DB.PmcDB)
            {
                var userAccount = connection.QueryFirstOrDefault<UserAccount>(@"
                        EXECUTE [dbo].[_setUserLastNameByUserID]
                        @UserID,
                        @UserLastName
                        ", new { UserID, UserLastName });
                return userAccount;
            }
        }

        public UserAccount SetUserNameByUserID(int UserID, string UserName)
        {
            using (var connection = DB.PmcDB)
            {
                var userAccount = connection.QueryFirstOrDefault<UserAccount>(@"
                        EXECUTE [dbo].[_setUserNameByUserID]
                        @UserID,
                        @UserName
                        ", new { UserID, UserName });
                return userAccount;
            }
        }
        public UserAccount SetUserNumberOfFamilyMembersByUserID(int UserID, int UserNumFamMembers)
        {
            using (var connection = DB.PmcDB)
            {
                var userAccount = connection.QueryFirstOrDefault<UserAccount>(@"
                        EXECUTE [dbo].[_setUserNumFamMembersByUserID]
                        @UserID,
                        @UserNumFamMembers
                        ", new { UserID, UserNumFamMembers });
                return userAccount;
            }
        }

        public UserAccount SetUserPasswordByUserID(int UserID, string UserPassword)
        {
            using (var connection = DB.PmcDB)
            {
                var userAccount = connection.QueryFirstOrDefault<UserAccount>(@"
                        EXECUTE [dbo].[_setUserPasswordByUserID]
                        @UserID,
                        @UserPassword
                        ", new { UserID, UserPassword });
                return userAccount;
            }
        }

        public UserAccount SetUserStateByUserID(int UserID, string UserState)
        {
            using (var connection = DB.PmcDB)
            {
                var userAccount = connection.QueryFirstOrDefault<UserAccount>(@"
                        EXECUTE [dbo].[_setUserStateByUserID]
                        @UserID,
                        @UserState
                        ", new { UserID, UserState });
                return userAccount;
            }
        }
        public UserAccount CheckUserName(string UserName)
        {
            using (var connection = DB.PmcDB)
            {
                var userAccount = connection.QueryFirstOrDefault<UserAccount>(@"
                        EXECUTE [dbo].[_CheckUserName]
                        @UserName
                        ", new { UserName });
                return userAccount;
            }
        }
        public UserAccount CheckEmailAddress(string UserEmail)
        {
            using (var connection = DB.PmcDB)
            {
                var userAccount = connection.QueryFirstOrDefault<UserAccount>(@"
                        EXECUTE [dbo].[_CheckEmailAddress]
                        @UserEmail
                        ", new { UserEmail });
                return userAccount;
            }
        }
        public UserAccount SetUserShowHelpOnStartUp(int UserID)
        {
            using (var connection = DB.PmcDB)
            {
                var userAccount = connection.QueryFirstOrDefault<UserAccount>(@"
                        EXECUTE [dbo].[_setUserShowHelpOnStartUp]
                        @UserID
                        ", new { UserID});
                return userAccount;
            }
        }

        public UserAccount SetUserHideShowHelpOnStartUp(int UserID)
        {
            using (var connection = DB.PmcDB)
            {
                var userAccount = connection.QueryFirstOrDefault<UserAccount>(@"
                        EXECUTE [dbo].[_setUserHideHelpOnStartUp]
                        @UserID
                        ", new { UserID });
                return userAccount;
            }
        }

    }
}
