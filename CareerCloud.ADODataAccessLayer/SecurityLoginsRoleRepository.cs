using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;

namespace CareerCloud.ADODataAccessLayer
{
    public class SecurityLoginsRoleRepository : BaseADO, IDataRepository<SecurityLoginsRoleRepository>
    {
        public void Add(params SecurityLoginsRoleRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<SecurityLoginsRoleRepository> GetAll(params Expression<Func<SecurityLoginsRoleRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<SecurityLoginsRoleRepository> GetList(Expression<Func<SecurityLoginsRoleRepository, bool>> where, params Expression<Func<SecurityLoginsRoleRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SecurityLoginsRoleRepository GetSingle(Expression<Func<SecurityLoginsRoleRepository, bool>> where, params Expression<Func<SecurityLoginsRoleRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params SecurityLoginsRoleRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params SecurityLoginsRoleRepository[] items)
        {
            throw new NotImplementedException();
        }
    }
}