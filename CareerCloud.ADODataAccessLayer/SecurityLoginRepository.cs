using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.ADODataAccessLayer
{
    public class SecurityLoginRepository : BaseADO, IDataRepository<SecurityLoginPoco>
    {
        public IList<SecurityLoginPoco> GetAll(params Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException()
            queryString = @"Select * from [JOB_PORTAL_DB].[dbo].[Security_Logins]";
        }

        public IList<SecurityLoginPoco> GetList(Expression<Func<SecurityLoginPoco, bool>> @where, params Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SecurityLoginPoco GetSingle(Expression<Func<SecurityLoginPoco, bool>> @where, params Expression<Func<SecurityLoginPoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            IQueryable<SecurityLoginPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Add(params SecurityLoginPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"INSERT INTO [JOB_PORTAL_DB].[dbo].[Security_Logins]
                                 VALUES
                                       (@Id
                                       ,@Login
                                       ,@Password
                                       ,@Created_Date
                                       ,@Password_Update_Date
                                       ,@Agreement_Accepted_Date
                                       ,@Is_Locked
                                       ,@Is_Inactive
                                       ,@Email_Address
                                       ,@Phone_Number
                                       ,@Full_Name
                                       ,@Force_Change_Password
                                       ,@Prefferred_Language)";

            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Login", row.Login);
                    commandObject.Parameters.AddWithValue("@Password", row.Password);
                    commandObject.Parameters.AddWithValue("@Created_Date", row.Created);
                    commandObject.Parameters.AddWithValue("@Password_Update_Date", row.PasswordUpdate);
                    commandObject.Parameters.AddWithValue("@Agreement_Accepted_Date", row.AgreementAccepted);
                    commandObject.Parameters.AddWithValue("@Is_Locked", row.IsLocked);
                    commandObject.Parameters.AddWithValue("@Is_Inactive", row.IsInactive);
                    commandObject.Parameters.AddWithValue("@Email_Address", row.EmailAddress);
                    commandObject.Parameters.AddWithValue("@Phone_Number", row.PhoneNumber);
                    commandObject.Parameters.AddWithValue("@Full_Name", row.FullName);
                    commandObject.Parameters.AddWithValue("@Force_Change_Password", row.ForceChangePassword);
                    commandObject.Parameters.AddWithValue("@Prefferred_Language", row.PrefferredLanguage);
           

                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }
            }


        }

        public void Update(params SecurityLoginPoco[] pocos)
        {
            //throw new NotImplementedException();\
            queryString = @"UPDATE [JOB_PORTAL_DB].[dbo].[Security_Logins]
                               SET [Login] = @Login
                                  ,[Password] = @Password
                                  ,[Created_Date] = @Created_Date
                                  ,[Password_Update_Date] = @Password_Update_Date
                                  ,[Agreement_Accepted_Date] = @Agreement_Accepted_Date
                                  ,[Is_Locked] = @Is_Locked
                                  ,[Is_Inactive] = @Is_Inactive
                                  ,[Email_Address] = @Email_Address
                                  ,[Phone_Number] = @Phone_Number
                                  ,[Full_Name] = @Full_Name
                                  ,[Force_Change_Password] = @Force_Change_Password
                                  ,[Prefferred_Language] = @Prefferred_Language
                             WHERE [Id] = @Id";


            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Login", row.Login);
                    commandObject.Parameters.AddWithValue("@Password", row.Password);
                    commandObject.Parameters.AddWithValue("@Created_Date", row.Created);
                    commandObject.Parameters.AddWithValue("@Password_Update_Date", row.PasswordUpdate);
                    commandObject.Parameters.AddWithValue("@Agreement_Accepted_Date", row.AgreementAccepted);
                    commandObject.Parameters.AddWithValue("@Is_Locked", row.IsLocked);
                    commandObject.Parameters.AddWithValue("@Is_Inactive", row.IsInactive);
                    commandObject.Parameters.AddWithValue("@Email_Address", row.EmailAddress);
                    commandObject.Parameters.AddWithValue("@Phone_Number", row.PhoneNumber);
                    commandObject.Parameters.AddWithValue("@Full_Name", row.FullName);
                    commandObject.Parameters.AddWithValue("@Force_Change_Password", row.ForceChangePassword);
                    commandObject.Parameters.AddWithValue("@Prefferred_Language", row.PrefferredLanguage);

                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }
            }
        }

        public void Remove(params SecurityLoginPoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"delete from [JOB_PORTAL_DB].[dbo].[Security_Logins] where Id = @Id";

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