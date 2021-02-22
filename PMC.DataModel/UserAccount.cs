using System;
using System.Collections;

//PMC1093-01 PMC1093-02 PMC1093-03 PMC1093-04 PMC1093-05 
namespace PMC.DataModel
{
    public class UserAccount
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserState { get; set; }
        public int UserNumFamMembers { get; set; }
        public string UserEmail { get; set; }
        public byte[] UserPassword { get; set; }
        public int UserRole { get; set; }
        public string UserActive { get; set; }
        public int EmailCount { get; set; }
        public int UserCount { get; set; }
        public int ShowHelpOnStartUp { get; set; }
               
    }
}
