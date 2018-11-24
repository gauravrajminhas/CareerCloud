using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.ADODataAccessLayer
{
    public class ApplicantSkillRepository : BaseADO, IDataRepository<ApplicantSkillPoco>
    {
        //[JOB_PORTAL_DB].[dbo].[Applicant_Skills]

        // completed
        public void Add(params ApplicantSkillPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"INSERT INTO [JOB_PORTAL_DB].[dbo].[Applicant_Skills]
                                       ([Id]
                                       ,[Applicant]
                                       ,[Skill]
                                       ,[Skill_Level]
                                       ,[Start_Month]
                                       ,[Start_Year]
                                       ,[End_Month]
                                       ,[End_Year])
                                 VALUES
                                       (@Id
                                       ,@Applicant
                                       ,@Skill
                                       ,@Skill_Level
                                       ,@Start_Month
                                       ,@Start_Year
                                       ,@End_Month
                                       ,@End_Year)";
            using (connectionObject)
            {
                SqlCommand commandObject = new  SqlCommand(queryString,connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Applicant",row.Applicant);
                    commandObject.Parameters.AddWithValue("@Skill",row.Skill);
                    commandObject.Parameters.AddWithValue("@Skill_Level",row.SkillLevel);
                    commandObject.Parameters.AddWithValue("@Start_Month",row.StartMonth);
                    commandObject.Parameters.AddWithValue("@Start_Year",row.StartYear);
                    commandObject.Parameters.AddWithValue("@End_Month",row.EndMonth);
                    commandObject.Parameters.AddWithValue("@End_Year",row.EndYear);
                    //commandObject.Parameters.AddWithValue("@Time_Stamp", row.TimeStamp);

                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();
                }

            }

        }

        //completed
        public void Update(params ApplicantSkillPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"update [JOB_PORTAL_DB].[dbo].[Applicant_Skills] 
                            set  Applicant = @Applicant, Skill = @Skill,  Skill_Level= @Skill_Level, Start_Month = @Start_Month, Start_Year= @Start_Year, End_Month = @End_Month, End_Year = @End_Year 
                            where Id =@Id";

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Applicant", row.Applicant);
                    commandObject.Parameters.AddWithValue("@Skill", row.Skill);
                    commandObject.Parameters.AddWithValue("@Skill_Level", row.SkillLevel);
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
        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        // completed 
        public IList<ApplicantSkillPoco> GetAll(params Expression<Func<ApplicantSkillPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            queryString = @"select * from [JOB_PORTAL_DB].[dbo].[Applicant_Skills]";
            ApplicantSkillPoco[] pocos = new ApplicantSkillPoco[arraySize];
            position = 0;

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString,connectionObject);
                connectionObject.Open();
                SqlDataReader reader = commandObject.ExecuteReader();

                while (reader.Read())
                {
                    ApplicantSkillPoco poco = new ApplicantSkillPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Applicant = reader.GetGuid(1);
                    poco.Skill = reader.GetString(2);
                    poco.SkillLevel = reader.GetString(3);
                    poco.StartMonth = reader.GetByte(4);
                    poco.StartYear = reader.GetInt32(5);
                    poco.EndMonth = reader.GetByte(6);
                    poco.EndYear = reader.GetInt32(7);
                    poco.TimeStamp = (byte[]) reader[8];


                    pocos[position] = poco;
                    position++;

                }
                connectionObject.Close();
            }

            return pocos.Where(a => a != null).ToList();

        }

        public IList<ApplicantSkillPoco> GetList(Expression<Func<ApplicantSkillPoco, bool>> where, params Expression<Func<ApplicantSkillPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        //completed
        public ApplicantSkillPoco GetSingle(Expression<Func<ApplicantSkillPoco, bool>> where, params Expression<Func<ApplicantSkillPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            IQueryable<ApplicantSkillPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        //completed
        public void Remove(params ApplicantSkillPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"delete from [JOB_PORTAL_DB].[dbo].[Applicant_Skills] where Id = @Id";
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

       
    }
}