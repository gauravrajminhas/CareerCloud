using System;
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
        public void Add(params ApplicantEducationPoco[] items)
        {
            //throw new NotImplementedException();

            String addQuery;
               addQuery = "insert into Applicant_Educations ( Applicant, Major, Certificate_Diploma,Start_Date, Completion_Date, Completion_Percent)" +
                               "values()";

            using (SqlConnection connObject = new SqlConnection(connectionString))
            {
                SqlCommand commandObject = new SqlCommand(addQuery,connObject);

                foreach (var row in items)
                {

                    addQuery = "insert into Applicant_Educations ( Applicant, Major, Certificate_Diploma,Start_Date, Completion_Date, Completion_Percent)" +
                               "values()";
                    

                    connObject.Open();
                    writerObject.Execute(addQuery);
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
            ApplicantEducationPoco[] pocos = new ApplicantEducationPoco[500];
            int position = 0;

            using (SqlConnection connObject = new SqlConnection(connectionString))
            {

                string selectAllQuery = "Select * from Applicant_Educations";
                connObject.Open();

                SqlCommand selectAllCommandObject = new SqlCommand(selectAllQuery,connObject);
                SqlDataReader dataReader = selectAllCommandObject.ExecuteReader();

                while(dataReader.Read())
                {
                    pocos[position].Id = dataReader.GetGuid(0);
                    position++;
                }

                connObject.Close();

            }
            return pocos;




        }

        public IList<ApplicantEducationPoco> GetList(Expression<Func<ApplicantEducationPoco, bool>> where, params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantEducationPoco GetSingle(Expression<Func<ApplicantEducationPoco, bool>> where, params Expression<Func<ApplicantEducationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
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