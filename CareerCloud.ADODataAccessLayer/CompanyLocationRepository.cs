using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyLocationRepository : BaseADO, IDataRepository<CompanyLocationPoco>
    {
        public IList<CompanyLocationPoco> GetAll(params Expression<Func<CompanyLocationPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            queryString = @"SELECT * FROM [JOB_PORTAL_DB].[dbo].[Company_Locations]";
            position = 0;

            CompanyLocationPoco[] pocos = new CompanyLocationPoco[arraySize];
            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString,connectionObject);
                connectionObject.Open();
                SqlDataReader reader = commandObject.ExecuteReader();

                while (reader.Read())
                {
                    CompanyLocationPoco poco = new CompanyLocationPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Company = reader.GetGuid(1);
                    poco.CountryCode = reader.GetString(2);
                    poco.Province = reader.GetString(3);
                    poco.Street = reader.GetString(4);
                    if ((!reader.IsDBNull(5)))
                    {
                        poco.City = reader.GetString(5);
                    }
                    else
                    {
                        poco.City = null;
                    }
                    if (!reader.IsDBNull(6))
                    {
                        poco.PostalCode = reader.GetString(6);
                    }
                    else
                    {
                        poco.PostalCode = null;
                    }
                    poco.TimeStamp = (byte[]) reader[7];


                    pocos[position] = poco;
                    position++;
                }
                connectionObject.Close();

            }

            return pocos.Where(a => a != null).ToList();
        }

        public IList<CompanyLocationPoco> GetList(Expression<Func<CompanyLocationPoco, bool>> @where, params Expression<Func<CompanyLocationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyLocationPoco GetSingle(Expression<Func<CompanyLocationPoco, bool>> @where, params Expression<Func<CompanyLocationPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            //throw new NotImplementedException();
            IQueryable<CompanyLocationPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        //completed 
        public void Add(params CompanyLocationPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"INSERT INTO [JOB_PORTAL_DB].[dbo].[Company_Locations]
                                       ([Id]
                                       ,[Company]
                                       ,[Country_Code]
                                       ,[State_Province_Code]
                                       ,[Street_Address]
                                       ,[City_Town]
                                       ,[Zip_Postal_Code])
                                 VALUES
                                       (@Id
                                       ,@Company
                                       ,@Country_Code
                                       ,@State_Province_Code
                                       ,@Street_Address
                                       ,@City_Town
                                       ,@Zip_Postal_Code)";

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString,connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id",row.Id);
                    commandObject.Parameters.AddWithValue("@Company",row.Company);
                    commandObject.Parameters.AddWithValue("@Country_Code",row.CountryCode);
                    commandObject.Parameters.AddWithValue("@State_Province_Code",row.Province);
                    commandObject.Parameters.AddWithValue("@Street_Address",row.Street);
                    commandObject.Parameters.AddWithValue("@City_Town",row.City);
                    commandObject.Parameters.AddWithValue("@Zip_Postal_Code",row.PostalCode);
                    //commandObject.Parameters.AddWithValue("@Time_Stamp", row.TimeStamp);


                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }
            }

        } 
        
        // doubt : is there any carriage return and funky stuff ?
        //completed
        public void Update(params CompanyLocationPoco[] pocos)
        {
            //w new NotImplementedException();
            queryString = @"UPDATE [JOB_PORTAL_DB].[dbo].[Company_Locations]
                              SET [Company] = @Company
                              ,[Country_Code] = @Country_Code
                              ,[State_Province_Code] = @State_Province_Code
                              ,[Street_Address] = @Street_Address
                              ,[City_Town] = @City_Town
                              ,[Zip_Postal_Code] = @Zip_Postal_Code
                              WHERE [Id] = @Id";

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Company", row.Company);
                    commandObject.Parameters.AddWithValue("@Country_Code", row.CountryCode);
                    commandObject.Parameters.AddWithValue("@State_Province_Code", row.Province);
                    commandObject.Parameters.AddWithValue("@Street_Address", row.Street);
                    commandObject.Parameters.AddWithValue("@City_Town", row.City);
                    commandObject.Parameters.AddWithValue("@Zip_Postal_Code", row.PostalCode);

                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }
            }


        }

        //completed 
        public void Remove(params CompanyLocationPoco[] pocos)
        {
            
            queryString = @"delete from [JOB_PORTAL_DB].[dbo].[Company_Locations] where Id = @Id";
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