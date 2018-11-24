using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyJobRepository : BaseADO, IDataRepository<CompanyJobPoco>
    {
        public IList<CompanyJobPoco> GetAll(params Expression<Func<CompanyJobPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            queryString = @"SELECT * FROM [JOB_PORTAL_DB].[dbo].[Company_Jobs]";
            position = 0;

            CompanyJobPoco[] pocos = new CompanyJobPoco[arraySize];
            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                connectionObject.Open();
                SqlDataReader reader = commandObject.ExecuteReader();

                while (reader.Read())
                {
                    CompanyJobPoco poco = new CompanyJobPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Company = reader.GetGuid(1);
                    poco.ProfileCreated = reader.GetDateTime(2);
                    poco.IsInactive = reader.GetBoolean(3);
                    poco.IsCompanyHidden = reader.GetBoolean(4);

                    if (!reader.IsDBNull(5))
                    {
                        poco.TimeStamp = (byte[]) reader[5];
                    }
                    else
                    {
                        poco.TimeStamp = null;
                    }

                    pocos[position] = poco;
                    position++;
                }

                connectionObject.Close();
            }

            return pocos.Where(a => a != null).ToList();
        }

        public IList<CompanyJobPoco> GetList(Expression<Func<CompanyJobPoco, bool>> @where, params Expression<Func<CompanyJobPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyJobPoco GetSingle(Expression<Func<CompanyJobPoco, bool>> @where, params Expression<Func<CompanyJobPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            IQueryable<CompanyJobPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Add(params CompanyJobPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"INSERT INTO [JOB_PORTAL_DB].[dbo].[Company_Jobs]
                                   ([Id]
                                   ,[Company]
                                   ,[Profile_Created]
                                   ,[Is_Inactive]
                                   ,[Is_Company_Hidden])
                             VALUES
                                   (@Id
                                   ,@Company
                                   ,@Profile_Created
                                   ,@Is_Inactive
                                   ,@Is_Company_Hidden)";

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Company", row.Company);
                    commandObject.Parameters.AddWithValue("@Profile_Created", row.ProfileCreated);
                    commandObject.Parameters.AddWithValue("@Is_Inactive", row.IsInactive);
                    commandObject.Parameters.AddWithValue("@Is_Company_Hidden", row.IsCompanyHidden);


                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }
            }


        }

        public void Update(params CompanyJobPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"UPDATE [JOB_PORTAL_DB].[dbo].[Company_Jobs]
                               SET [Company] = @Company
                                  ,[Profile_Created] = @Profile_Created
                                  ,[Is_Inactive] = @Is_Inactive
                                  ,[Is_Company_Hidden] = @Is_Company_Hidden
                             WHERE [Id] = @Id";

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Company", row.Company);
                    commandObject.Parameters.AddWithValue("@Profile_Created", row.ProfileCreated);
                    commandObject.Parameters.AddWithValue("@Is_Inactive", row.IsInactive);
                    commandObject.Parameters.AddWithValue("@Is_Company_Hidden", row.IsCompanyHidden);


                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }
            }

        }

        //Completed     
        public void Remove(params CompanyJobPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"delete from [JOB_PORTAL_DB].[dbo].[Company_Jobs] where Id = @Id";
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