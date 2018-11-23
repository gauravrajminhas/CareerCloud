using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyJobEducationRepository : BaseADO, IDataRepository<CompanyJobEducationPoco>
    {
        //completed 
        public IList<CompanyJobEducationPoco> GetAll(params Expression<Func<CompanyJobEducationPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            queryString = @"SELECT * FROM [JOB_PORTAL_DB].[dbo].[Company_Job_Educations]";
            position = 0;

            CompanyJobEducationPoco[] pocos = new CompanyJobEducationPoco[arraySize];
            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                SqlDataReader reader = commandObject.ExecuteReader();

                while (reader.HasRows)
                {
                    CompanyJobEducationPoco poco = new CompanyJobEducationPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Job = reader.GetGuid(1);
                    poco.Major = reader.GetString(2);
                    poco.Importance = reader.GetInt16(3);
                    poco.TimeStamp = (byte[])reader[7];
                    
                    pocos[position] = poco;
                    position++;
                }

            }

            return pocos.Where(a => a != null).ToList();



        }


        public IList<CompanyJobEducationPoco> GetList(Expression<Func<CompanyJobEducationPoco, bool>> @where, params Expression<Func<CompanyJobEducationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }
        

        //completed
        public CompanyJobEducationPoco GetSingle(Expression<Func<CompanyJobEducationPoco, bool>> @where, params Expression<Func<CompanyJobEducationPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            IQueryable<CompanyJobEducationPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }


        //completed
        public void Add(params CompanyJobEducationPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"INSERT INTO [JOB_PORTAL_DB].[dbo].[Company_Job_Educations]
                                       ([Id]
                                       ,[Job]
                                       ,[Major]
                                       ,[Importance])
                                 VALUES
                                       (@Id
                                       ,@Job
                                       ,@Major
                                       ,@Importance)";

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Job", row.Job);
                    commandObject.Parameters.AddWithValue("@Major", row.Major);
                    commandObject.Parameters.AddWithValue("@Importance", row.Importance);
                 
                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }
            }


        }


        //completed
        public void Update(params CompanyJobEducationPoco[] pocos)
        {
           // throw new NotImplementedException();
            queryString = @"UPDATE [JOB_PORTAL_DB].[dbo].[Company_Job_Educations]
                               SET [Job] = @Job
                                  ,[Major] = @Major
                                  ,[Importance] = @Importance
                             WHERE [Id] = @Id";

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Job", row.Job);
                    commandObject.Parameters.AddWithValue("@Major", row.Major);
                    commandObject.Parameters.AddWithValue("@Importance", row.Importance);

                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }
            }

        }

        //Completed 
        public void Remove(params CompanyJobEducationPoco[] pocos)
        {
           // throw new NotImplementedException();
            queryString = @"delete from [JOB_PORTAL_DB].[dbo].[Company_Job_Educations] where Id = @Id";
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