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
    //[JOB_PORTAL_DB].[dbo].[Applicant_Job_Applications]
    public class ApplicantJobApplicationRepository : BaseADO, IDataRepository<ApplicantJobApplicationPoco>
    {
        //completed : added Time stamp !
        public void Add(params ApplicantJobApplicationPoco[] pocos)
        {
            //throw new NotImplementedException();
            using (SqlConnection connectionObject = new SqlConnection(connectionString))
            {
                queryString = @"insert into [JOB_PORTAL_DB].[dbo].[Applicant_Job_Applications]" +
                              @"values (@Id, @Applicant, @Job, @Application_Date, @Time_Stamp)";

                foreach (var rows  in pocos)
                {
                    SqlCommand commandObject = new SqlCommand(queryString,connectionObject);
                    commandObject.Parameters.AddWithValue("@Id",rows.Id);
                    commandObject.Parameters.AddWithValue("@Applicant",rows.Applicant);
                    commandObject.Parameters.AddWithValue("@Job",rows.Job);
                    commandObject.Parameters.AddWithValue("@Application_Date",rows.ApplicationDate);
                    commandObject.Parameters.AddWithValue("@Time_Stamp", rows.TimeStamp);

                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }

            }

        }

        //completed
        public IList<ApplicantJobApplicationPoco> GetAll(params Expression<Func<ApplicantJobApplicationPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();

            ApplicantJobApplicationPoco[] pocos = new ApplicantJobApplicationPoco[arraySize];

            using (SqlConnection connectionObject = new SqlConnection(connectionString))
            {
                queryString = @"select * from [JOB_PORTAL_DB].[dbo].[Applicant_Job_Applications]";
                position = 0;

                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                SqlDataReader reader = commandObject.ExecuteReader();

               while (reader.Read())
                {
                    ApplicantJobApplicationPoco poco = new ApplicantJobApplicationPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Applicant = reader.GetGuid(1);
                    poco.Job = reader.GetGuid(2);
                    poco.ApplicationDate = reader.GetDateTime(3);
                    poco.TimeStamp = (byte[])reader[4];

                    pocos[position] = poco;
                    position++;

                }


               connectionObject.Close();
               return pocos.ToList();
            }



        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantJobApplicationPoco> GetList(Expression<Func<ApplicantJobApplicationPoco, bool>> where, params Expression<Func<ApplicantJobApplicationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        // completed
        public ApplicantJobApplicationPoco GetSingle(Expression<Func<ApplicantJobApplicationPoco, bool>> where, params Expression<Func<ApplicantJobApplicationPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            IQueryable<ApplicantJobApplicationPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        // completed 
        public void Remove(params ApplicantJobApplicationPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"delete from [JOB_PORTAL_DB].[dbo].[Applicant_Job_Applications] where Id = @Id";

            using (SqlConnection connectionObject = new SqlConnection(connectionString))
            {
                SqlCommand commandObject = new SqlCommand(queryString,connectionObject);
                foreach (var row in pocos)
                {
                    connectionObject.Open();
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();
                }
            }

        }

        //completed
        // are we updating the time stamp ? here 
        //i havent done it.
        public void Update(params ApplicantJobApplicationPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"update [JOB_PORTAL_DB].[dbo].[Applicant_Job_Applications]  set Applicant = @Applicant, Job = @Job, Application_Date = @Application_Date where Id =@Id";

            using (SqlConnection connectionObject = new SqlConnection())
            {
                SqlCommand commandObject = new SqlCommand(queryString,connectionObject);

                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Applicant", row.Applicant);
                    commandObject.Parameters.AddWithValue("@Job", row.Job);
                    commandObject.Parameters.AddWithValue("@Application_Date", row.ApplicationDate);

                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();
                   
                }

            }


        }
    }
}