using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.ADODataAccessLayer
{
    public class ApplicantEducationRepository : BaseADO, IDataRepository<ApplicantEducationPoco>
    {

        // Completed : with doubts  ! 
        public IList<ApplicantEducationPoco> GetAll(params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            //Are we returning the values by creating a new Application Education Poco ?
            ApplicantEducationPoco[] pocos = new ApplicantEducationPoco[arraySize];
            using (SqlConnection connObject = new SqlConnection(connectionString))
            {

                try
                {
                    queryString = @"Select * from [JOB_PORTAL_DB].[dbo].[Applicant_Educations]";

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

                        if (!dataReader.IsDBNull(6))
                        {
                            myPoco.CompletionPercent = dataReader.GetByte(6);
                        }
                        else
                        {
                            myPoco.CompletionPercent = null;
                        }

                        myPoco.TimeStamp = (byte[])dataReader[7];

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
            // why did we do this ?
            return pocos.ToList();
        }

        // completed with doubts ! 
        public void Update(params ApplicantEducationPoco[] pocos)
        {
            using (SqlConnection connectionObject = new SqlConnection(connectionString))
            {

                try
                {

                    foreach (var record in pocos)
                    {
                        queryString = @"update [JOB_PORTAL_DB].[dbo].[Applicant_Educations]" +
                        "set Applicant = @Applicant, Major = @Major , Certificate_Diploma = @Certificate_Diploma, Start_Date= @Start_Date, Completion_Date =@Completion_Date, Completion_Percent = @Completion_Percent where Id = @Id;";
                        SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                        commandObject.Parameters.AddWithValue("@Id", record.Id);
                        commandObject.Parameters.AddWithValue("@Applicant", record.Applicant);
                        commandObject.Parameters.AddWithValue("@Major", record.Major);
                        commandObject.Parameters.AddWithValue("@Certificate_Diploma", record.CertificateDiploma);
                        commandObject.Parameters.AddWithValue("@Start_Date", record.StartDate);
                        commandObject.Parameters.AddWithValue("@Completion_Date", record.CompletionDate);
                        commandObject.Parameters.AddWithValue("@Completion_Percent", record.CompletionPercent);

                        connectionObject.Open();
                        rowsAffected = commandObject.ExecuteNonQuery();
                        System.Console.WriteLine("number of Rows affected " + rowsAffected);
                        connectionObject.Close();
                    }



                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e);
                }

                finally
                {
                    connectionObject.Close();
                }
            }

        }

        // completed with doubts !
        public void Add(params ApplicantEducationPoco[] pocos)
        {
            //throw new NotImplementedException();
            using (SqlConnection connObject = new SqlConnection(connectionString))
            {
                
                foreach (var record in pocos)
                {

                    queryString = @"insert into [JOB_PORTAL_DB].[dbo].[Applicant_Educations] ( Id, Applicant, Major, Certificate_Diploma, Start_Date, Completion_Date, Completion_Percent, Time_Stamp)" +
                                  "values(@Id, @Applicant, @Major, @Certificate_Diploma, @Start_Date, @Completion_Date, @Completion_Percent, @Time_Stamp)";

                    //bug parametrize this query
                    //Doubt can we add parameters in the command object after we pass the query string ?
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
                    rowsAffected = commandObject.ExecuteNonQuery();
                    connObject.Close();
                }

            }
            
        }

        // completed : to be confirmed ! 
        public void Remove(params ApplicantEducationPoco[] pocos)
        {


            using (SqlConnection connectionObject = new SqlConnection(connectionString))
            {

                try
                {
                    queryString = @"delete from [JOB_PORTAL_DB].[dbo].[Applicant_Educations] where Id = @Id";
                    SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                    connectionObject.Open();

                    foreach (var row in pocos)
                    {
                        commandObject.Parameters.AddWithValue("@Id", row.Id);
                        commandObject.ExecuteReader();
                    }

                }
                catch (Exception e)
                {
                    System.Console.Write(e.Message);
                    System.Console.Write(e);
                }
                finally
                {
                    connectionObject.Close();
                }
            }

        }

        // implementation is Wrong; just copy what john has mentioned 
        public ApplicantEducationPoco GetSingle(Expression<Func<ApplicantEducationPoco, bool>> where, params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {

            IQueryable<ApplicantEducationPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();


            ////throw new NotImplementedException();
            //ApplicantEducationPoco myPoco = new ApplicantEducationPoco();
            //using (SqlConnection mySqlConnection = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        mySqlConnection.Open();
            //        // have to parameterize this ! 
            //        queryString = @"select * from [JOB_PORTAL_DB].[dbo].[Applicant_Educations] where Id = @ID";

            //        SqlCommand commandObj = new SqlCommand(queryString, mySqlConnection);
            //        SqlDataReader dataReader = commandObj.ExecuteReader();

            //        myPoco.Id = dataReader.GetGuid(0);
            //        myPoco.Applicant = dataReader.GetGuid(1);
            //        myPoco.Major = dataReader.GetString(2);
            //        myPoco.CertificateDiploma = dataReader.GetString(3);
            //        myPoco.StartDate = dataReader.GetDateTime(4);
            //        myPoco.CompletionDate = dataReader.GetDateTime(5);
            //        myPoco.CompletionPercent = dataReader.GetByte(6);

            //    }
            //    catch (Exception e)
            //    {
            //        System.Console.WriteLine(e.Message);
            //    }
            //    finally
            //    {
            //        mySqlConnection.Close();
            //    }


            //}

            //return myPoco;


        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantEducationPoco> GetList(Expression<Func<ApplicantEducationPoco, bool>> where, params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

       
    }
}