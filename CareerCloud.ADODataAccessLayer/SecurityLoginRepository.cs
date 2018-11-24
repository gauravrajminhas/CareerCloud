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
            position = 0;

            SecurityLoginPoco[] pocos = new SecurityLoginPoco[arraySize];
            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                connectionObject.Open();
                SqlDataReader reader = commandObject.ExecuteReader();

                while (reader.Read())
                {
                    SecurityLoginPoco poco = new SecurityLoginPoco();
                    poco.Id = reader.GetGuid(0);
                    poco.Login = reader.GetString(1);
                    poco.Password = reader.GetString(2);
                    poco.Created = reader.GetDateTime(3);

                    if (!reader.IsDBNull(4))
                    {
                        poco.PasswordUpdate = reader.GetDateTime(4);
                    }
                    else
                    {
                        poco.PasswordUpdate = null;
                    }

                    if (!reader.IsDBNull(5))
                    {
                        poco.AgreementAccepted = reader.GetDateTime(5);
                    }
                    else
                    {
                        poco.AgreementAccepted = null;
                    }

                    poco.IsLocked = reader.GetBoolean(6);
                    poco.IsInactive = reader.GetBoolean(7);
                    poco.EmailAddress = reader.GetString(8);
                    if (!reader.IsDBNull(9))
                    {
                        poco.PhoneNumber = reader.GetString(9);
                    }
                    else
                    {
                        poco.PhoneNumber = null;
                    }

                    poco.FullName = reader.GetString(10);
                    poco.ForceChangePassword = reader.GetBoolean(11);
                    if (!reader.IsDBNull(12))
                    {   
                        poco.PrefferredLanguage = reader.GetString(12);
                    }
                    else
                    {
                        poco.PrefferredLanguage = null;
                    }

                poco.TimeStamp = (byte[])reader[13];


                    pocos[position] = poco;
                    position++;
                }

                connectionObject.Close();
            }

            return pocos.Where(a => a != null).ToList();

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
                                        ([Id]
                                       ,[Login]
                                       ,[Password]
                                       ,[Created_Date]
                                       ,[Password_Update_Date]
                                       ,[Agreement_Accepted_Date]
                                       ,[Is_Locked]
                                       ,[Is_Inactive]
                                       ,[Email_Address]
                                       ,[Phone_Number]
                                       ,[Full_Name]
                                       ,[Force_Change_Password]
                                       ,[Prefferred_Language])
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