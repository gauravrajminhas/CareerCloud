using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;

namespace CareerCloud.ADODataAccessLayer
{
    public class SystemCountryCodeRepository : BaseADO, IDataRepository<SystemCountryCodeRepository>
    {
        public void Add(params SystemCountryCodeRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<SystemCountryCodeRepository> GetAll(params Expression<Func<SystemCountryCodeRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<SystemCountryCodeRepository> GetList(Expression<Func<SystemCountryCodeRepository, bool>> where, params Expression<Func<SystemCountryCodeRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SystemCountryCodeRepository GetSingle(Expression<Func<SystemCountryCodeRepository, bool>> where, params Expression<Func<SystemCountryCodeRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params SystemCountryCodeRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params SystemCountryCodeRepository[] items)
        {
            throw new NotImplementedException();
        }
    }
}