using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMC.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMC.Data.Tests
{
    [TestClass()]
    public class TermsRepoTests
    {
        [TestMethod()]
        public void TermsRepoTest()
        {
            // arrange
            string testUserName = "dlroy";
            string testPassword = "1234567";

            Data.RepoFactory repoFactory = new Data.RepoFactory();
            var sessionRepo = repoFactory.Get<Data.SessionInfoRepo>();
            var currentSessionID = sessionRepo.Authenticate(testUserName, testPassword);

            repoFactory.SessionId = currentSessionID.SsID;
            var userRepo = repoFactory.Get<Data.UserRepo>();
            var currentUser = userRepo.GetUserBySessionID(repoFactory.SessionId);
            repoFactory.UserID = currentUser.UserID;

            // act
            var repo = repoFactory.Get<Data.TermsRepo>();
            var singleTerm = repo.GetTermByTermID(1);
            System.Console.WriteLine(singleTerm.TermWord.ToString());
            Assert.AreEqual("Bake", singleTerm.TermWord.ToString());
            //Assert.Fail();
        }
    }
}