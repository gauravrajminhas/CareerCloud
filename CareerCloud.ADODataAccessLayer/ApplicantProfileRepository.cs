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
    //[JOB_PORTAL_DB].[dbo].[Applicant_Profiles]
    public class ApplicantProfileRepository : BaseADO, IDataRepository<ApplicantProfilePoco>
    {
        // I don't have to handle nulls As the pocos value types will give a null Value; 
        // Completed: doubt
        public void Add(params ApplicantProfilePoco[] pocos)
        {
            queryString = @"INSERT INTO [JOB_PORTAL_DB].[dbo].[Applicant_Profiles]
                                       ([Id]
                                       ,[Login]
                                       ,[Current_Salary]
                                       ,[Current_Rate]
                                       ,[Currency]
                                       ,[Country_Code]
                                       ,[State_Province_Code]
                                       ,[Street_Address]
                                       ,[City_Town]
                                       ,[Zip_Postal_Code])
                                 VALUES
                                       (@Id
                                       ,@Login
                                       ,@Current_Salary
                                       ,@Current_Rate
                                       ,@Currency
                                       ,@Country_Code
                                       ,@State_Province_Code
                                       ,@Street_Address
                                       ,@City_Town
                                       ,@Zip_Postal_Code)";

            using (SqlConnection connectionObject = new SqlConnection(connectionString))
            {
                SqlCommand commandObject = new SqlCommand(queryString,connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id",row.Id);
                    commandObject.Parameters.AddWithValue("@Login",row.Login);
                    commandObject.Parameters.AddWithValue("@Current_Salary",row.CurrentSalary);
                    commandObject.Parameters.AddWithValue("@Current_Rate",row.CurrentRate);
                    commandObject.Parameters.AddWithValue("@Currency",row.Currency);
                    commandObject.Parameters.AddWithValue("@Country_Code",row.Country);
                    commandObject.Parameters.AddWithValue("@State_Province_Code",row.Province);
                    commandObject.Parameters.AddWithValue("@Street_Address",row.Street);
                    commandObject.Parameters.AddWithValue("@City_Town",row.City);
                    commandObject.Parameters.AddWithValue("@Zip_Postal_Code",row.PostalCode);
                    //commandObject.Parameters.AddWithValue("@Time_Stamp",row.TimeStamp);

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

        //completed: handled nulls for value type ! 
        public IList<ApplicantProfilePoco> GetAll(params Expression<Func<ApplicantProfilePoco, object>>[] navigationProperties)
        {
            queryString = @"Select * from [JOB_PORTAL_DB].[dbo].[Applicant_Profiles] ";
            position = 0;
            ApplicantProfilePoco[] pocos = new ApplicantProfilePoco[arraySize];

            using (SqlConnection connectionObject = new SqlConnection(connectionString))
            {
                connectionObject.Open();

                SqlCommand commandObject = new SqlCommand(queryString,connectionObject);
                SqlDataReader reader = commandObject.ExecuteReader();

                while (reader.Read())
                {
                    ApplicantProfilePoco poco = new ApplicantProfilePoco();

                    poco.Id = reader.GetGuid(0);
                    poco.Login = reader.GetGuid(1);

                    //this null value in datatype works only because of decimal? 
                    //Doubt
                    if (!reader.IsDBNull(2))
                    {
                        poco.CurrentSalary = reader.GetDecimal(2);
                    }
                    else
                    {
                        poco.CurrentSalary = null;
                    }


                    if (!reader.IsDBNull(3))
                    {
                        var abc = reader[4];
                        poco.CurrentRate = reader.GetDecimal(3);
                    }
                    else
                    {
                        poco.CurrentRate = null;
                    }

                    // dont have to handle NULL for reference types !! SWEET ! 
                    poco.Currency = reader.GetString(4);
                    poco.Country = reader.GetString(5);
                    poco.Province = reader.GetString(6);
                    poco.Street = reader.GetString(7);
                    poco.City = reader.GetString(8);
                    poco.PostalCode = reader.GetString(9);
                    poco.TimeStamp = (byte[]) reader[10];

                    pocos[position] = poco;
                    position++;
                }

                connectionObject.Close();
            }

            return pocos.Where( a=>a!=null).ToList();

        }

        public IList<ApplicantProfilePoco> GetList(Expression<Func<ApplicantProfilePoco, bool>> where, params Expression<Func<ApplicantProfilePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        //completed as per the instructions from John;
        //but dont know what the hell is going here ! 
        public ApplicantProfilePoco GetSingle(Expression<Func<ApplicantProfilePoco, bool>> where, params Expression<Func<ApplicantProfilePoco, object>>[] navigationProperties)
        {
            IQueryable<ApplicantProfilePoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        // Completed
        public void Remove(params ApplicantProfilePoco[] pocos)
        {
            queryString = @"delete from [JOB_PORTAL_DB].[dbo].[Applicant_Profiles] where Id = @Id";
            using (SqlConnection connectionObject = new SqlConnection(connectionString))
            {
                SqlCommand commandObject = new SqlCommand(queryString,connectionObject);
                
                    foreach (var row in pocos)
                    {
                        commandObject.Parameters.AddWithValue("@Id", row.Id);
                        connectionObject.Open();
                        commandObject.ExecuteNonQuery();
                        connectionObject.Close();

                    }
                
            }

        }


        // Completed :  doubt not updating the time stamp !  
        // doubt : will use the commandObject from base class ! 
        public void Update(params ApplicantProfilePoco[] pocos)
        {
            queryString = @"update [JOB_PORTAL_DB].[dbo].[Applicant_Profiles] 
            set Login = @Login, Current_Salary = @Current_Salary, Current_Rate = @Current_Rate, Currency = @Currency, Country_Code = @Country_Code, State_Province_Code = @State_Province_Code, Street_Address = @Street_Address, City_Town = @City_Town, Zip_Postal_Code = @Zip_Postal_Code where Id = @Id";
            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString,connectionObject);
                

                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Login",row.Login);
                    commandObject.Parameters.AddWithValue("@Current_Salary",row.CurrentSalary);
                    commandObject.Parameters.AddWithValue("@Current_Rate",row.CurrentRate);
                    commandObject.Parameters.AddWithValue("@Currency",row.Currency);
                    commandObject.Parameters.AddWithValue("@Country_Code",row.Country);
                    commandObject.Parameters.AddWithValue("@State_Province_Code",row.Province);
                    commandObject.Parameters.AddWithValue("@Street_Address",row.Street);
                    commandObject.Parameters.AddWithValue("@City_Town",row.City);
                    commandObject.Parameters.AddWithValue("@Zip_Postal_Code",row.PostalCode);
                    commandObject.Parameters.AddWithValue("@Id",row.Id);

                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }

            }

        }
    }
}