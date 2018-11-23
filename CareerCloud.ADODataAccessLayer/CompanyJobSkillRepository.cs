using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyJobSkillRepository : BaseADO, IDataRepository<CompanyJobSkillPoco>
    {
        public IList<CompanyJobSkillPoco> GetAll(params Expression<Func<CompanyJobSkillPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            queryString = @"SELECT * FROM [JOB_PORTAL_DB].[dbo].[Company_Job_Skills]";
            position = 0;

            CompanyJobSkillPoco[] pocos = new CompanyJobSkillPoco[arraySize];
            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                SqlDataReader reader = commandObject.ExecuteReader();

                while (reader.HasRows)
                {
                    CompanyJobSkillPoco poco = new CompanyJobSkillPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Job = reader.GetGuid(1);
                    poco.Skill = reader.GetString(2);
                    poco.SkillLevel = reader.GetString(3);
                    poco.Importance = reader.GetInt32(4);
                    poco.TimeStamp = (byte[])reader[7];


                    pocos[position] = poco;
                    position++;
                }


            }

            return pocos.Where(a => a != null).ToList();
        }

        public IList<CompanyJobSkillPoco> GetList(Expression<Func<CompanyJobSkillPoco, bool>> @where, params Expression<Func<CompanyJobSkillPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        //completed 
        public CompanyJobSkillPoco GetSingle(Expression<Func<CompanyJobSkillPoco, bool>> @where, params Expression<Func<CompanyJobSkillPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            IQueryable<CompanyJobSkillPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Add(params CompanyJobSkillPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"INSERT INTO [JOB_PORTAL_DB].[dbo].[Company_Job_Skills]
           ([Id]
           ,[Job]
           ,[Skill]
           ,[Skill_Level]
           ,[Importance])
     VALUES
           (@Id
           ,@Job
           ,@Skill
           ,@Skill_Level
           ,@Importance)";

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Job", row.Job);
                    commandObject.Parameters.AddWithValue("@Skill", row.Skill);
                    commandObject.Parameters.AddWithValue("@Skill_Level", row.SkillLevel);
                    commandObject.Parameters.AddWithValue("@Importance", row.Importance);
                   

                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }
            }


        }

        public void Update(params CompanyJobSkillPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"UPDATE [JOB_PORTAL_DB].[dbo].[Company_Job_Skills]
               SET Job = @Job
                  ,Skill = @Skill
                  ,Skill_Level = @Skill_Level
                  ,Importance = @Importance
               WHERE Id = @Id";

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Job", row.Job);
                    commandObject.Parameters.AddWithValue("@Skill", row.Skill);
                    commandObject.Parameters.AddWithValue("@Skill_Level", row.SkillLevel);
                    commandObject.Parameters.AddWithValue("@Importance", row.Importance);


                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }
            }

        }

        //completed
        public void Remove(params CompanyJobSkillPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"delete from [JOB_PORTAL_DB].[dbo].[Company_Job_Skills] where Id = @Id";
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