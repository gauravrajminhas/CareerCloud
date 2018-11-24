using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Runtime.InteropServices.WindowsRuntime;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyDescriptionRepository : BaseADO, IDataRepository<CompanyDescriptionPoco>
    {
        //[JOB_PORTAL_DB].[dbo].[Company_Descriptions]

        //completed
        public IList<CompanyDescriptionPoco> GetAll(params Expression<Func<CompanyDescriptionPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            queryString = @"Select * from [JOB_PORTAL_DB].[dbo].[Company_Descriptions]";
            CompanyDescriptionPoco[] pocos = new CompanyDescriptionPoco[arraySize];
            position = 0;

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                connectionObject.Open();
                SqlDataReader reader = commandObject.ExecuteReader();

                while (reader.Read())
                {
                    CompanyDescriptionPoco poco = new CompanyDescriptionPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Company = reader.GetGuid(1);
                    poco.LanguageId = reader.GetString(2);
                    poco.CompanyName = reader.GetString(3);
                    poco.CompanyDescription = reader.GetString(4);
                    poco.TimeStamp = (byte[])reader[5];

                    pocos[position] = poco;
                    position++;

                }
                connectionObject.Close();
            }

            return pocos.Where(a => a != null).ToList();
        }

        public IList<CompanyDescriptionPoco> GetList(Expression<Func<CompanyDescriptionPoco, bool>> @where, params Expression<Func<CompanyDescriptionPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        // completed
        public CompanyDescriptionPoco GetSingle(Expression<Func<CompanyDescriptionPoco, bool>> @where, params Expression<Func<CompanyDescriptionPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyDescriptionPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        // check if the query is adding any carriage return or escape character 
        public void Add(params CompanyDescriptionPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"INSERT INTO [JOB_PORTAL_DB].[dbo].[Company_Descriptions]
                                       ([Id]
                                       ,[Company]
                                       ,[LanguageID]
                                       ,[Company_Name]
                                       ,[Company_Description])
                                 VALUES
                                       (@Id
                                       ,@Company
                                       ,@LanguageID
                                       ,@Company_Name
                                       ,@Company_Description)";

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Company", row.Company);
                    commandObject.Parameters.AddWithValue("@LanguageID", row.LanguageId);
                    commandObject.Parameters.AddWithValue("@Company_Name", row.CompanyName);
                    commandObject.Parameters.AddWithValue("@Company_Description", row.CompanyDescription);
                   // commandObject.Parameters.AddWithValue("@Time_Stamp", row.TimeStamp);

                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }

            }
        }

        // bug check if the query is adding any carriage return or escape character 
        // completed 
        public void Update(params CompanyDescriptionPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString =
                @"update [JOB_PORTAL_DB].[dbo].[Company_Descriptions] set Company=@Company, LanguageID=@LanguageID, Company_Name=@Company_Name, Company_Description=@Company_Description
                            where Id=@Id ";

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Company", row.Company);
                    commandObject.Parameters.AddWithValue("@LanguageID", row.LanguageId);
                    commandObject.Parameters.AddWithValue("@Company_Name", row.CompanyName);
                    commandObject.Parameters.AddWithValue("@Company_Description", row.CompanyDescription);
                    //commandObject.Parameters.AddWithValue("@Time_Stamp", row.TimeStamp);

                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }

            }
        }

        //completed
        public void Remove(params CompanyDescriptionPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"delete from [JOB_PORTAL_DB].[dbo].[Company_Descriptions] where Id=@Id";
            using (SqlConnection connectionObject = new SqlConnection(connectionString))
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    connectionObject.Open();
                    commandObject.ExecuteReader();
                    connectionObject.Close();
                }
            }
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}