using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.ADODataAccessLayer
{
    //[JOB_PORTAL_DB].[dbo].[System_Country_Codes]

    public class SecurityRoleRepository : BaseADO, IDataRepository<SecurityRolePoco>
    {
        public IList<SecurityRolePoco> GetAll(params Expression<Func<SecurityRolePoco, object>>[] navigationProperties)
        {
            //throw new NotImplementedException();
            queryString = @"SELECT * FROM [JOB_PORTAL_DB].[dbo].[Security_Roles]";
        }

        public IList<SecurityRolePoco> GetList(Expression<Func<SecurityRolePoco, bool>> @where, params Expression<Func<SecurityRolePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SecurityRolePoco GetSingle(Expression<Func<SecurityRolePoco, bool>> @where, params Expression<Func<SecurityRolePoco, object>>[] navigationProperties)
        {
            // throw new NotImplementedException();
            IQueryable<SecurityRolePoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Add(params SecurityRolePoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"INSERT INTO [JOB_PORTAL_DB].[dbo].[Security_Roles]
                                       ([Id]
                                       ,[Role]
                                       ,[Is_Inactive])
                                 VALUES
                                       (@Id
                                       ,@Role
                                       ,@Is_Inactive)";
            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Role", row.Role);
                    commandObject.Parameters.AddWithValue("@Is_Inactive", row.IsInactive);


                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }
            }
        }

        public void Update(params SecurityRolePoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"UPDATE [JOB_PORTAL_DB].[dbo].[Security_Roles]
                               SET [Role] = @Role
                                  ,[Is_Inactive] = @Is_Inactive
                             WHERE [Id] = @Id";
            using (connectionObject)
            {
                SqlCommand commandObject = new SqlCommand(queryString, connectionObject);
                foreach (var row in pocos)
                {
                    commandObject.Parameters.AddWithValue("@Id", row.Id);
                    commandObject.Parameters.AddWithValue("@Role", row.Role);
                    commandObject.Parameters.AddWithValue("@Is_Inactive", row.IsInactive);

                    connectionObject.Open();
                    commandObject.ExecuteNonQuery();
                    connectionObject.Close();

                }
            }

        }

        public void Remove(params SecurityRolePoco[] pocos)
        {
            //throw new NotImplementedException();
            queryString = @"delete from [JOB_PORTAL_DB].[dbo].[Security_Roles] where Id = @Id";

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