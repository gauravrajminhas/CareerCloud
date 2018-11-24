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
    public class ApplicantResumeRepository : BaseADO, IDataRepository<ApplicantResumePoco>
    {
        //[JOB_PORTAL_DB].[dbo].[Applicant_Resumes]

        //completed ! 
        public void Add(params ApplicantResumePoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"insert into [JOB_PORTAL_DB].[dbo].[Applicant_Resumes] values (@Id, @Applicant, @Resume, @Last_Updated)";
            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString,connectionObject);

                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Applicant",row.Applicant);
                    commandObject.Parameters.AddWithValue("@Resume",row.Resume);
                    commandObject.Parameters.AddWithValue("@Last_Updated",row.LastUpdated);
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

        // completed 
        // added lambda expression
        public IList<ApplicantResumePoco> GetAll(params Expression<Func<ApplicantResumePoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            queryString = "select * from [JOB_PORTAL_DB].[dbo].[Applicant_Resumes]";
            ApplicantResumePoco[] pocos = new ApplicantResumePoco[arraySize];
            
            position = 0;
            using (SqlConnection connectionObject = new SqlConnection(connectionString))
            {
                SqlCommand commandObject = new SqlCommand(queryString,connectionObject);
                
                connectionObject.Open();
                SqlDataReader reader = commandObject.ExecuteReader();

                while (reader.Read())
                {
                    ApplicantResumePoco poco = new ApplicantResumePoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Applicant = reader.GetGuid(1);
                    poco.Resume = reader.GetString(2);

                    if (!reader.IsDBNull(3))
                    {
                        poco.LastUpdated = reader.GetDateTime(3);
                    }
                    else
                    {
                        poco.LastUpdated = null; 
                    }


                    pocos[position] = poco;
                    position++;
                }

                connectionObject.Close();
                return pocos.Where(a => a != null).ToList();

            }
        }

        public IList<ApplicantResumePoco> GetList(Expression<Func<ApplicantResumePoco, bool>> where, params Expression<Func<ApplicantResumePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        //completed ! 
        public ApplicantResumePoco GetSingle(Expression<Func<ApplicantResumePoco, bool>> where, params Expression<Func<ApplicantResumePoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            IQueryable<ApplicantResumePoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }


        //Completed 
        public void Remove(params ApplicantResumePoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"delete from [JOB_PORTAL_DB].[dbo].[Applicant_Resumes] where Id = @Id";
            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString,connectionObject);

                foreach (var rows in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", rows.Id);

                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();
                }
            }
        }


        // completed ! 
        public void Update(params ApplicantResumePoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"update [JOB_PORTAL_DB].[dbo].[Applicant_Resumes] set Applicant = @Applicant, Resume = @Resume, Last_Updated =@Last_Updated  where  Id = @Id";

            SqlCommand commandObject = new SqlCommand(queryString,connectionObject);

            foreach (var rows in pocos)
            {
                commandObject.Parameters.AddWithValue("@Id",rows.Id);
                commandObject.Parameters.AddWithValue("@Applicant",rows.Applicant);
                commandObject.Parameters.AddWithValue("@Resume",rows.Resume);
                commandObject.Parameters.AddWithValue("@Last_Updated", rows.LastUpdated);

                connectionObject.Open();
                commandObject.ExecuteNonQuery();
                connectionObject.Close();

            }

            
        }
    }
}