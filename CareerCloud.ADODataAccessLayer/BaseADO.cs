using System;
using System.Configuration;


namespace CareerCloud.ADODataAccessLayer
{
    public abstract class BaseADO
    {

        //public static String connectionString = @"Data Source=LAPTOP-RP1PV1SH\HUMBERBRIDGING;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        // Using configration manager 
        protected String connectionString = ConfigurationManager.ConnectionStrings["myHumberDB"].ConnectionString;

        protected const int arraySize = 500;
        protected int position = 0, rowsAffected =0;
        protected String queryString;
    }

}