using System;
using System.Configuration;
using System.Data.SqlClient;


namespace CareerCloud.ADODataAccessLayer
{
    public abstract class BaseADO
    {

        //public static String connectionString = @"Data Source=LAPTOP-RP1PV1SH\HUMBERBRIDGING;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        // Using configration manager 
        // also why do i have to again and again create a Connection Object ? 
        protected static String connectionString = ConfigurationManager.ConnectionStrings["myHumberDB"].ConnectionString;
        SqlConnection connectionObject = new SqlConnection(connectionString);
        protected String queryString;

        protected const int arraySize = 500;
        protected int position = 0, rowsAffected =0;
        
    }

}