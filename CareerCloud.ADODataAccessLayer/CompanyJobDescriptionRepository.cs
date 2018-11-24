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
    public class CompanyJobDescriptionRepository : BaseADO, IDataRepository<CompanyJobDescriptionPoco>
    {
        //[JOB_PORTAL_DB].[dbo].[Company_Jobs_Descriptions]

        // completed 
        public IList<CompanyJobDescriptionPoco> GetAll(params Expression<Func<CompanyJobDescriptionPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            queryString = @"Select * from [JOB_PORTAL_DB].[dbo].[Company_Jobs_Descriptions]";
            CompanyJobDescriptionPoco[] pocos = new CompanyJobDescriptionPoco[arraySize];
            position = 0;

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                connectionObject.Open();
                SqlDataReader reader = commandObject.ExecuteReader();

                while (reader.Read())
                {
                    CompanyJobDescriptionPoco poco = new CompanyJobDescriptionPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Job = reader.GetGuid(1);
                    poco.JobName = reader.GetString(2);
                    poco.JobDescriptions = reader.GetString(3);
                    if (!reader.IsDBNull(4))
                    {
                        poco.TimeStamp = (byte[]) reader[4];
                    }
                    else
                    {
                        poco.TimeStamp = null;
                    }

                    pocos[position] = poco;
                    position++;

                }
                connectionObject.Close();
            }

            return pocos.Where(a => a != null).ToList();
        }

        public IList<CompanyJobDescriptionPoco> GetList(Expression<Func<CompanyJobDescriptionPoco, bool>> @where, params Expression<Func<CompanyJobDescriptionPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        //completed
        public CompanyJobDescriptionPoco GetSingle(Expression<Func<CompanyJobDescriptionPoco, bool>> @where, params Expression<Func<CompanyJobDescriptionPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyJobDescriptionPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Add(params CompanyJobDescriptionPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"INSERT INTO [JOB_PORTAL_DB].[dbo].[Company_Jobs_Descriptions]
                                       ([Id]
                                       ,[Job]
                                       ,[Job_Name]
                                       ,[Job_Descriptions])
                                 VALUES
                                       (@Id
                                       ,@Job
                                       ,@Job_Name
                                       ,@Job_Descriptions)";

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Job", row.Job);
                    commandObject.Parameters.AddWithValue("@Job_Name", row.JobName);
                    commandObject.Parameters.AddWithValue("@Job_Descriptions", row.JobDescriptions);
                    //commandObject.Parameters.AddWithValue("@Time_Stamp", row.TimeStamp);

                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }
            }
        }


        //Completed 
        public void Update(params CompanyJobDescriptionPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString =
                @"update [JOB_PORTAL_DB].[dbo].[Company_Jobs_Descriptions] set Job=@Job, Job_Name=@Job_Name, Job_Descriptions=@Job_Descriptions where Id =@Id";

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Job", row.Job);
                    commandObject.Parameters.AddWithValue("@Job_Name", row.JobName);
                    commandObject.Parameters.AddWithValue("@Job_Descriptions", row.JobDescriptions);
                    //commandObject.Parameters.AddWithValue("@Time_Stamp", row.TimeStamp);

                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }
            }
        }


        //completed
        public void Remove(params CompanyJobDescriptionPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"delete from [JOB_PORTAL_DB].[dbo].[Company_Jobs_Descriptions] where Id =@Id";
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