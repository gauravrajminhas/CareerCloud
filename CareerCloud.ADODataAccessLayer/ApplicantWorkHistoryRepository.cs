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
        public IList<ApplicantWorkHistoryPoco> GetAll(params Expression<Func<ApplicantWorkHistoryPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            queryString = @"Select * from [JOB_PORTAL_DB].[dbo].[Applicant_Work_History]";
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

        public void Add(params ApplicantWorkHistoryPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"insert into [JOB_PORTAL_DB].[dbo].[Applicant_Work_History] 
                            values (@Id, @Applicant, @Company_Name,@Country_Code, @Location ,@Job_Title,@Job_Description, @Start_Month,@Start_Year,@End_Month,@End_Year, @Time_Stamp)";
        }

        public void Update(params ApplicantWorkHistoryPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"update [JOB_PORTAL_DB].[dbo].[Applicant_Work_History] 
                            set  Applicant=@Applicant, Company_Name=@Company_Name, Country_Code=@Country_Code, Location=@Location , Job_Title=@Job_Title,Job_Description=@Job_Description,Start_Month=@Start_Month, Start_Year=@Start_Year,End_Month=@End_Month,End_Year=@End_Year, Time_Stamp=@Time_Stamp 
                            where Id=@Id";
        }

        //completed
        public void Remove(params ApplicantWorkHistoryPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = "delete * from [JOB_PORTAL_DB].[dbo].[Applicant_Work_History]";
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