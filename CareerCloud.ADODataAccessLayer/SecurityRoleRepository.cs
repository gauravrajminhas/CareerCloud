using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;

namespace CareerCloud.ADODataAccessLayer
{
    public class SecurityRoleRepository : BaseADO, IDataRepository<SecurityRoleRepository>
    {
        public void Add(params SecurityRoleRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<SecurityRoleRepository> GetAll(params Expression<Func<SecurityRoleRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<SecurityRoleRepository> GetList(Expression<Func<SecurityRoleRepository, bool>> where, params Expression<Func<SecurityRoleRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SecurityRoleRepository GetSingle(Expression<Func<SecurityRoleRepository, bool>> where, params Expression<Func<SecurityRoleRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params SecurityRoleRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params SecurityRoleRepository[] items)
        {
            throw new NotImplementedException();
        }
    }
}