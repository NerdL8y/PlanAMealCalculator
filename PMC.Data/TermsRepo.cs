using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.Data
{
    public class TermsRepo
    {
        private readonly DataContext DB;
        protected int userID;

        public TermsRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }

        public IEnumerable<Term> GetTerms()
        {
            using var connection = DB.PmcDB;
            var terms = connection.Query<Term>(@"
                    EXECUTE [dbo].[_GetTerms]
                    ");
            return terms;
        }
        public Term GetTermByTermID(int TermID)
        {
            using var connection = DB.PmcDB;
            var term = connection.QueryFirstOrDefault<Term>(@"
                    EXECUTE [dbo].[_GetTermByTermID]
                    @TermID
                    ", new { TermID });
            return term;
        }
    }
}
