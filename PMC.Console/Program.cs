using PMC.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PMC.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            string testUserName = "dlroy";
            string testPassword = "1234";
            string v1 = "cucumber";
            
            
            Data.RepoFactory repoFactory = new Data.RepoFactory();
            var sessionRepo = repoFactory.Get<Data.SessionInfoRepo>();
            var currentSessionID = sessionRepo.Authenticate(testUserName, testPassword);
            
            repoFactory.SessionId = currentSessionID.SsID;
            var userRepo = repoFactory.Get<Data.UserRepo>();
            var currentUser = userRepo.GetUserBySessionID(repoFactory.SessionId);
            repoFactory.UserID = currentUser.UserID;
            
            var repo = repoFactory.Get<Data.InstructionRepo>();
            var currentRepo = repo.GetPrepTimelineInstructionDatesByMealID(1).ToList();
            foreach (object o in currentRepo)
            {
                System.Console.WriteLine(o);
            }
            

            System.Console.WriteLine("stop here");

        }
    }
}
