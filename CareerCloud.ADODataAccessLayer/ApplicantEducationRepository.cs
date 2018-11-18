﻿using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Sockets;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.ADODataAccessLayer
{
    public class ApplicantEducationRepository : BaseADO, IDataRepository<ApplicantEducationPoco>
    {
        public void Add(params ApplicantEducationPoco[] pocos)
        {
            //throw new NotImplementedException();
            using (SqlConnection connObject = new SqlConnection(connectionString))
            {
                //BUG parameterize this query
                position = 0;

                foreach (var record in pocos)
                {

                    queryString = @"insert into Applicant_Educations ( Id, Applicant, Major, Certificate_Diploma, Start_Date, Completion_Date, Completion_Percent, Time_Stamp)" +
                                  "values(@Id, @Applicant, @Major, @Certificate_Diploma, @Start_Date, @Completion_Date, @Completion_Percent, @Time_Stamp)";

                    SqlCommand commandObject = new SqlCommand(queryString, connObject);
                    commandObject.Parameters.AddWithValue("@Id", record.Id);
                    commandObject.Parameters.AddWithValue("@Applicant", record.Applicant);
                    commandObject.Parameters.AddWithValue("@Major", record.Major);
                    commandObject.Parameters.AddWithValue("@Certificate_Diploma", record.CertificateDiploma);
                    commandObject.Parameters.AddWithValue("@Start_Date", record.StartDate);
                    commandObject.Parameters.AddWithValue("@Completion_Date", record.CompletionDate);
                    commandObject.Parameters.AddWithValue("@Completion_Percent", record.CompletionPercent);
                    commandObject.Parameters.AddWithValue("@Time_Stamp", record.TimeStamp);

                    connObject.Open();
                    writerObject.Execute(queryString);
                    connObject.Close();
                }

            }
            
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantEducationPoco> GetAll(params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            //Are we returning the values by creating a new Application Education Poco ?
            ApplicantEducationPoco[] pocos = new ApplicantEducationPoco[arraySize];
            using (SqlConnection connObject = new SqlConnection(connectionString))
            {

                try
                {
                    queryString = @"Select * from Applicant_Educations";

                    connObject.Open();

                    SqlCommand selectAllCommandObject = new SqlCommand(queryString, connObject);
                    SqlDataReader dataReader = selectAllCommandObject.ExecuteReader();

                    position = 0;

                    while (dataReader.Read())
                    {
                        ApplicantEducationPoco myPoco = new ApplicantEducationPoco();

                       
                        myPoco.Id = dataReader.GetGuid(0);
                        myPoco.Applicant = dataReader.GetGuid(1);
                        myPoco.Major = dataReader.GetString(2);
                        myPoco.CertificateDiploma = dataReader.GetString(3);

                        // BUG-Fixed ! handle the not nulls ! 
                        if (!dataReader.IsDBNull(4))
                        {
                            myPoco.StartDate = dataReader.GetDateTime(4);
                        }
                        else
                        {
                            myPoco.StartDate = null;
                        }

                        if (!dataReader.IsDBNull(5))
                        {
                            myPoco.CompletionDate = dataReader.GetDateTime(5);
                        }
                        else
                        {
                            myPoco.CompletionDate = null;
                        }

                        if (!dataReader.GetByte(6))
                        {
                            myPoco.CompletionPercent = dataReader.GetByte(6);
                        }
                        else
                        {
                            myPoco.CompletionPercent = null;
                        }

                        myPoco.TimeStamp = (byte[]) dataReader[7];

                        pocos[position] = myPoco;
                        position++;
                    }
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
                finally
                {
                    connObject.Close();
                }
            }
            return pocos;
        }

        public IList<ApplicantEducationPoco> GetList(Expression<Func<ApplicantEducationPoco, bool>> where, params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantEducationPoco GetSingle(Expression<Func<ApplicantEducationPoco, bool>> where, params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            ApplicantEducationPoco myPoco = new ApplicantEducationPoco();
            using (SqlConnection mySqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    mySqlConnection.Open();
                    // have to parameterize this ! 
                    queryString = @"select * from Applicant_Educations where Id = @ID";
                    
                    SqlCommand commandObj = new SqlCommand(queryString, mySqlConnection);
                    SqlDataReader dataReader = commandObj.ExecuteReader();

                    myPoco.Id = dataReader.GetGuid(0);
                    myPoco.Applicant = dataReader.GetGuid(1);
                    myPoco.Major = dataReader.GetString(2);
                    myPoco.CertificateDiploma = dataReader.GetString(3);
                    myPoco.StartDate = dataReader.GetDateTime(4);
                    myPoco.CompletionDate = dataReader.GetDateTime(5);
                    myPoco.CompletionPercent = dataReader.GetByte(6);

                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
                finally
                {
                    mySqlConnection.Close();
                }


            }

            return myPoco;

        }

        public void Remove(params ApplicantEducationPoco[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params ApplicantEducationPoco[] items)
        {
            throw new NotImplementedException();
        }
    }
}