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
    public class ApplicantWorkHistoryRepository : BaseADO, IDataRepository<ApplicantWorkHistoryPoco>
    {
        //[JOB_PORTAL_DB].[dbo].[Applicant_Work_History]


        //completed 
        public IList<ApplicantWorkHistoryPoco> GetAll(params Expression<Func<ApplicantWorkHistoryPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            queryString = @"Select * from [JOB_PORTAL_DB].[dbo].[Applicant_Work_History]";
            ApplicantWorkHistoryPoco[] pocos = new ApplicantWorkHistoryPoco[arraySize];
            position = 0;

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                connectionObject.Open();
                SqlDataReader reader = commandObject.ExecuteReader();

                while (reader.Read())
                {
                    ApplicantWorkHistoryPoco poco = new ApplicantWorkHistoryPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Applicant = reader.GetGuid(1);
                    poco.CompanyName = reader.GetString(2);
                    poco.CountryCode = reader.GetString(3);
                    poco.Location = reader.GetString(4);
                    poco.JobTitle = reader.GetString(5);
                    poco.JobDescription = reader.GetString(6);
                    poco.StartMonth = reader.GetInt16(7);
                    poco.StartYear = reader.GetInt32(8);
                    poco.EndMonth = reader.GetInt16(9);
                    poco.EndYear = reader.GetInt32(10);
                    poco.TimeStamp = (byte[])reader[11];

                    pocos[position] = poco;
                    position++;

                }
                connectionObject.Close();
            }

            return pocos.Where(a => a != null).ToList();

        }

        public IList<ApplicantWorkHistoryPoco> GetList(Expression<Func<ApplicantWorkHistoryPoco, bool>> @where, params Expression<Func<ApplicantWorkHistoryPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }
        //completed
        public ApplicantWorkHistoryPoco GetSingle(Expression<Func<ApplicantWorkHistoryPoco, bool>> @where, params Expression<Func<ApplicantWorkHistoryPoco, object>>[] navigationProperties)
        {
            IQueryable<ApplicantWorkHistoryPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        // completed 
        public void Add(params ApplicantWorkHistoryPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"INSERT INTO [JOB_PORTAL_DB].[dbo].[Applicant_Work_History]
                                       ([Id]
                                       ,[Applicant]
                                       ,[Company_Name]
                                       ,[Country_Code]
                                       ,[Location]
                                       ,[Job_Title]
                                       ,[Job_Description]
                                       ,[Start_Month]
                                       ,[Start_Year]
                                       ,[End_Month]
                                       ,[End_Year])
                                 VALUES
                                       (@Id
                                       ,@Applicant
                                       ,@Company_Name
                                       ,@Country_Code
                                       ,@Location
                                       ,@Job_Title
                                       ,@Job_Description
                                       ,@Start_Month
                                       ,@Start_Year
                                       ,@End_Month
                                       ,@End_Year)";


            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Applicant", row.Applicant);
                    commandObject.Parameters.AddWithValue("@Company_Name", row.CompanyName);
                    commandObject.Parameters.AddWithValue("@Country_Code", row.CountryCode);
                    commandObject.Parameters.AddWithValue("@Location", row.Location);
                    commandObject.Parameters.AddWithValue("@Job_Title", row.JobTitle);
                    commandObject.Parameters.AddWithValue("@Job_Description", row.JobDescription);
                    commandObject.Parameters.AddWithValue("@Start_Month", row.StartMonth);
                    commandObject.Parameters.AddWithValue("@Start_Year", row.StartYear);
                    commandObject.Parameters.AddWithValue("@End_Month", row.EndMonth);
                    commandObject.Parameters.AddWithValue("@End_Year", row.EndYear);
                    //commandObject.Parameters.AddWithValue("@Time_Stamp", row.TimeStamp);

                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }


            }
        }

        //completed 
        public void Update(params ApplicantWorkHistoryPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"update [JOB_PORTAL_DB].[dbo].[Applicant_Work_History] 
                            set  Applicant=@Applicant, Company_Name=@Company_Name, Country_Code=@Country_Code, Location=@Location , Job_Title=@Job_Title,Job_Description=@Job_Description,Start_Month=@Start_Month, Start_Year=@Start_Year,End_Month=@End_Month,End_Year=@End_Year 
                            where Id=@Id";

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Applicant", row.Applicant);
                    commandObject.Parameters.AddWithValue("@Company_Name", row.CompanyName);
                    commandObject.Parameters.AddWithValue("@Country_Code", row.CountryCode);
                    commandObject.Parameters.AddWithValue("@Location", row.Location);
                    commandObject.Parameters.AddWithValue("@Job_Title", row.JobTitle);
                    commandObject.Parameters.AddWithValue("@Job_Description", row.JobDescription);
                    commandObject.Parameters.AddWithValue("@Start_Month", row.StartMonth);
                    commandObject.Parameters.AddWithValue("@Start_Year", row.StartYear);
                    commandObject.Parameters.AddWithValue("@End_Month", row.EndMonth);
                    commandObject.Parameters.AddWithValue("@End_Year", row.EndYear);
                    //commandObject.Parameters.AddWithValue("@Time_Stamp", row.TimeStamp);

                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }


            }

        }

        //completed
        public void Remove(params ApplicantWorkHistoryPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = "delete from [JOB_PORTAL_DB].[dbo].[Applicant_Work_History] where Id = @Id";
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