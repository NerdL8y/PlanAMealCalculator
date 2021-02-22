using Dapper;
using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMC.Data
{
    public class PreparationTimelineRepo
    {
        DataContext DB;
        int userID;


        public PreparationTimelineRepo(int userID, DataContext db)
        {
            this.DB = db;
            this.userID = userID;
        }

        public IEnumerable<PreparationTimeline> GetPreparationTimelineByMealID(int id)
        {
            using (var connection = DB.PmcDB)
            {
                var prepTimeline = connection.Query<PreparationTimeline>(@"
                    EXECUTE [dbo].[_GetPrepTimelineInstructionsByMealID]
                    @MealID
                    ", new { MealID = id  });
                return prepTimeline;
            }
        }

        

    }
}
