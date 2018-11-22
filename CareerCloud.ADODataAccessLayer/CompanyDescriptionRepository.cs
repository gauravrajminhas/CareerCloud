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
        public IList<CompanyDescriptionPoco> GetAll(params Expression<Func<CompanyDescriptionPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            queryString = @"Select * from [JOB_PORTAL_DB].[dbo].[Company_Descriptions]";
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
            queryString = @"insert into [JOB_PORTAL_DB].[dbo].[Company_Descriptions]
                            values (@Id,@Company,@LanguageID, @Company_Name, @Company_Description,Time_Stamp)";
        }

        // check if the query is adding any carriage return or escape character 
        public void Update(params CompanyDescriptionPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"update [JOB_PORTAL_DB].[dbo].[Company_Descriptions] set Company=@Company, LanguageID=@LanguageID, Company_Name=@Company_Name, Company_Description=@Company_Description,Time_Stamp=@Time_Stamp
                            where Id=@Id ";

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