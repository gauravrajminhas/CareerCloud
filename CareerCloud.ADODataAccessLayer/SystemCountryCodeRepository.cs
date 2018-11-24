using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.ADODataAccessLayer
{
    //[JOB_PORTAL_DB].[dbo].[System_Country_Codes]


    //completed 
    public class SystemCountryCodeRepository : BaseADO, IDataRepository<SystemCountryCodePoco>
    {
        public void Add(params SystemCountryCodePoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"INSERT INTO [JOB_PORTAL_DB].[dbo].[System_Country_Codes]
                                       ([Code]
                                       ,[Name])
                                 VALUES
                                       (@Code
                                       ,@Name)";
            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Code", row.Code);
                    commandObject.Parameters.AddWithValue("@Name", row.Name);

                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }
            }

        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        //completed 
        public IList<SystemCountryCodePoco> GetAll(params Expression<Func<SystemCountryCodePoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            queryString = @"select * from [JOB_PORTAL_DB].[dbo].[System_Country_Codes]";

            position = 0;

            SystemCountryCodePoco[] pocos = new SystemCountryCodePoco[arraySize];
            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                connectionObject.Open();
                SqlDataReader reader = commandObject.ExecuteReader();

                while (reader.Read())
                {
                    SystemCountryCodePoco poco = new SystemCountryCodePoco();
                    poco.Code = reader.GetString(0);
                    poco.Name = reader.GetString(1);

                    pocos[position] = poco;
                    position++;
                }

                connectionObject.Close();
            }

            return pocos.Where(a => a != null).ToList();
        }

        public IList<SystemCountryCodePoco> GetList(Expression<Func<SystemCountryCodePoco, bool>> where, params Expression<Func<SystemCountryCodePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        //completed 
        public SystemCountryCodePoco GetSingle(Expression<Func<SystemCountryCodePoco, bool>> where, params Expression<Func<SystemCountryCodePoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            IQueryable<SystemCountryCodePoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        //completed 
        public void Remove(params SystemCountryCodePoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"DELETE FROM [JOB_PORTAL_DB].[dbo].[System_Country_Codes]
                                    WHERE [Code] = @Code";

            using (SqlConnection connectionObject = new SqlConnection(connectionString))
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    connectionObject.Open();
                    commandObject.Parameters.AddWithValue("@Code", row.Code);
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();
                }
            }
        }


        //completed 
        public void Update(params SystemCountryCodePoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"UPDATE [JOB_PORTAL_DB].[dbo].[System_Country_Codes]
                               SET [Name] = @Name
                             WHERE [Code] = @Code";
            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Code", row.Code);
                    commandObject.Parameters.AddWithValue("@Name", row.Name);


                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }
            }
        }
    }
}