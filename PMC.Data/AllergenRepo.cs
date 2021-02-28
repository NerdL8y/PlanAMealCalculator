using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMC.Data
{
    public class AllergenRepo
    {
        DataContext DB;
        protected int userID;

        public AllergenRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }
        public Allergen GetAllergenByAllergenID(int id)
        {
            using (var connection = DB.PmcDB)
            {
                var allergen = connection.QueryFirstOrDefault<Allergen>(@"
                    EXECUTE [dbo].[_GetAllergenByAllergenID]
                    @AllergenID
                    ", new { AllergenID = id });
                return allergen;
            }
        }

        public IEnumerable<Allergen> GetAllergenList()
        {
            using (var connection = DB.PmcDB)
            {
                var allergens = connection.Query<Allergen>(@"
                    EXECUTE [dbo].[_GetAllergenList]
                    ");
                return allergens;
            }
        }
        public Allergen SetAllergenDescription(int id, string desc)
        {
            using (var connection = DB.PmcDB)
            {
                var allergens = connection.QueryFirstOrDefault<Allergen>(@"
                        EXECUTE [dbo].[_setAllergenDesc]
                        @AllergenID,
                        @AllergenDesc
                        ", new { AllergenID = id, AllergenDesc = desc });
                return allergens;
            }
        }
    }
}

