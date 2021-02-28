using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PMC.Data
{
    public class CitationRepo
    {

        DataContext DB;
        protected int userID;

        public CitationRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }

        public IEnumerable<Citation> GetCitationList()
        {
            using (var connection = DB.PmcDB)
            {
                var citation = connection.Query<Citation>(@"
                    EXECUTE [dbo].[_GetCitationList]
                    ");
                return citation;
            }
        }
    }
}
