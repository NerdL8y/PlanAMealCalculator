using System;
using System.Data.SqlClient;


namespace PMC.Data
{
    //PMC1002-01 
    //PMC1023-01 since all data is sent to SQL server as a variable, not plain text statements, input validation is handled by SQL Server.
    public class DataContext
    {
        protected readonly string pmcConnectionString = "Server=DROYSP;Database=dataPMC;Trusted_Connection=True;";
        public SqlConnection PmcDB { get { return new SqlConnection(pmcConnectionString); } }
    }
}
