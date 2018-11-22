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


        public void Add(params ApplicantSkillPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"insert into [JOB_PORTAL_DB].[dbo].[Applicant_Skills] values (@Applicant, @Skill, @Skill_Level, @Start_Month, @Start_Year, @End_Month, @End_Year, @Time_Stamp   ) where Id = @Id";


        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantSkillPoco> GetAll(params Expression<Func<ApplicantSkillPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            queryString = @"select * from [JOB_PORTAL_DB].[dbo].[Applicant_Skills]";



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

        public void Update(params ApplicantSkillPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"update [JOB_PORTAL_DB].[dbo].[Applicant_Skills] 
                            set  Applicant = @Applicant, Skill = @Skill,  Skill_Level= @Skill_Level, Start_Month = @Start_Month, Start_Year= @Start_Year, End_Month = @End_Month, End_Year = @End_Year, Time_Stamp = @Time_Stamp 
                            where Id =@Id"; 

        }
    }
}