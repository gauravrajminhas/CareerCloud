using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyProfileRepository : BaseADO, IDataRepository<CompanyProfilePoco>
    {
        //[JOB_PORTAL_DB].[dbo].[Company_Profiles]
        public IList<CompanyProfilePoco> GetAll(params Expression<Func<CompanyProfilePoco, object>>[] navigationProperties)
        {
            queryString = @"Select * from [JOB_PORTAL_DB].[dbo].[Company_Profiles]";
        }

        public IList<CompanyProfilePoco> GetList(Expression<Func<CompanyProfilePoco, bool>> @where, params Expression<Func<CompanyProfilePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        //completed ;
        public CompanyProfilePoco GetSingle(Expression<Func<CompanyProfilePoco, bool>> @where, params Expression<Func<CompanyProfilePoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            IQueryable<CompanyProfilePoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Add(params CompanyProfilePoco[] pocos)
        {
           // throw new NotImplementedException();
            queryString = @"INSERT INTO [JOB_PORTAL_DB].[dbo].[Company_Profiles]
                                       ([Id]
                                       ,[Registration_Date]
                                       ,[Company_Website]
                                       ,[Contact_Phone]
                                       ,[Contact_Name]
                                       ,[Company_Logo])
                                 VALUES
                                       (@Id
                                       ,@Registration_Date
                                       ,@Company_Website
                                       ,@Contact_Phone
                                       ,@Contact_Name
                                       ,@Company_Logo)";

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Registration_Date", row.RegistrationDate);
                    commandObject.Parameters.AddWithValue("@Company_Website", row.CompanyWebsite);
                    commandObject.Parameters.AddWithValue("@Contact_Phone", row.ContactPhone);
                    commandObject.Parameters.AddWithValue("@Contact_Name", row.ContactName);
                    commandObject.Parameters.AddWithValue("@Company_Logo", row.CompanyLogo);
                 

                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }
            }

        }

        public void Update(params CompanyProfilePoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"UPDATE [JOB_PORTAL_DB].[dbo].[Company_Profiles]
                               SET [Registration_Date] = @Registration_Date
                                  ,[Company_Website] = @Company_Website
                                  ,[Contact_Phone] = @Contact_Phone
                                  ,[Contact_Name] = @Contact_Name
                                  ,[Company_Logo] = @Company_Logo
                             WHERE [Id] = @Id";

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Registration_Date", row.RegistrationDate);
                    commandObject.Parameters.AddWithValue("@Company_Website", row.CompanyWebsite);
                    commandObject.Parameters.AddWithValue("@Contact_Phone", row.ContactPhone);
                    commandObject.Parameters.AddWithValue("@Contact_Name", row.ContactName);
                    commandObject.Parameters.AddWithValue("@Company_Logo", row.CompanyLogo);


                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }
            }


        }

        //completed 
        public void Remove(params CompanyProfilePoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"delete from [JOB_PORTAL_DB].[dbo].[Company_Profiles] where Id = @Id";

            using (SqlConnection connectionObject = new SqlConnection(connectionString))
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    connectionObject.Open();
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.ExecuteNonQuery();
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