using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.ADODataAccessLayer
{
    public class SystemLanguageCodeRepository : BaseADO, IDataRepository<SystemLanguageCodePoco>
    {
        //[JOB_PORTAL_DB].[dbo].[System_Language_Codes]

        //completed 
        public void Add(params SystemLanguageCodePoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"INSERT INTO [JOB_PORTAL_DB].[dbo].[System_Language_Codes]
                                       ([LanguageID]
                                       ,[Name]
                                       ,[Native_Name])
                                 VALUES
                                       (@LanguageID
                                       ,@Name
                                       ,@Native_Name)";

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Name", row.Name);
                    commandObject.Parameters.AddWithValue("@Native_Name", row.NativeName);
                    commandObject.Parameters.AddWithValue("@LanguageID", row.LanguageID);


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
        public IList<SystemLanguageCodePoco> GetAll(params Expression<Func<SystemLanguageCodePoco, object>>[] navigationProperties)
        {
         //   throw new NotImplementedException();
            queryString = @"Select * from [JOB_PORTAL_DB].[dbo].[System_Language_Codes]";
            position = 0;

            SystemLanguageCodePoco[] pocos = new SystemLanguageCodePoco[arraySize];
            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                connectionObject.Open();
                SqlDataReader reader = commandObject.ExecuteReader();

                while (reader.Read())
                {
                    SystemLanguageCodePoco poco = new SystemLanguageCodePoco();
                    poco.LanguageID = reader.GetString(0);
                    poco.Name = reader.GetString(1);
                    poco.NativeName = reader.GetString(2);
                   

                    pocos[position] = poco;
                    position++;
                }

                connectionObject.Close();
            }

            return pocos.Where(a => a != null).ToList();
        }

        public IList<SystemLanguageCodePoco> GetList(Expression<Func<SystemLanguageCodePoco, bool>> where, params Expression<Func<SystemLanguageCodePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        //comleted 
        public SystemLanguageCodePoco GetSingle(Expression<Func<SystemLanguageCodePoco, bool>> where, params Expression<Func<SystemLanguageCodePoco, object>>[] navigationProperties)
        {
            // throw new NotImplementedException();
            IQueryable<SystemLanguageCodePoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        //completed 
        public void Remove(params SystemLanguageCodePoco[] pocos)
        {
            // throw new NotImplementedException();
            queryString = @"delete from [JOB_PORTAL_DB].[dbo].[System_Language_Codes] where LanguageID = @LanguageID";

            using (SqlConnection connectionObject = new SqlConnection(connectionString))
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    connectionObject.Open();
                    commandObject.Parameters.AddWithValue("@LanguageID", row.LanguageID);
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();
                }
            }
        }

        //completed
        public void Update(params SystemLanguageCodePoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"UPDATE [JOB_PORTAL_DB].[dbo].[System_Language_Codes]
                               SET [Name] = @Name
                                  ,[Native_Name] = @Native_Name
                            WHERE [LanguageID] = @LanguageID";

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Name", row.Name);
                    commandObject.Parameters.AddWithValue("@Native_Name", row.NativeName);
                   commandObject.Parameters.AddWithValue("@LanguageID", row.LanguageID);
                   

                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }
            }





        }
    }
}