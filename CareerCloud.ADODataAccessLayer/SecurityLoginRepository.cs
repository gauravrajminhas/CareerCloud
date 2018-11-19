using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;

namespace CareerCloud.ADODataAccessLayer
{
    public class SecurityLoginRepository : BaseADO, IDataRepository<SecurityLoginRepository>
    {
        public void Add(params SecurityLoginRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<SecurityLoginRepository> GetAll(params Expression<Func<SecurityLoginRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<SecurityLoginRepository> GetList(Expression<Func<SecurityLoginRepository, bool>> where, params Expression<Func<SecurityLoginRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SecurityLoginRepository GetSingle(Expression<Func<SecurityLoginRepository, bool>> where, params Expression<Func<SecurityLoginRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params SecurityLoginRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params SecurityLoginRepository[] items)
        {
            throw new NotImplementedException();
        }
    }
}