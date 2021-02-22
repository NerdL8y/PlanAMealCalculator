using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMC.Data
{
    public class UotRepo
    {
        DataContext DB;
        int userID;

        public UotRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }

        public Uot GetUotByUotID(int id)
        {
            using (var connection = DB.PmcDB)
            {

                System.Console.WriteLine("IngredientRepo.cs just before call to SQL");
                var uot = connection.QueryFirstOrDefault<Uot>(@"
                        EXECUTE [dbo].[_GetUotByUotID]
                        @UotID
                        ", new { UotID = id });
                return uot;
            }
        }
        public IEnumerable<Uot> GetUotList()
        {
            using (var connection = DB.PmcDB)
            {
                var uots = connection.Query<Uot>(@"
                    EXECUTE [dbo].[_GetUotList]
                    ");
                return uots;
            }
        }
    }
}
