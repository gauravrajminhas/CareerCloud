using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyProfileRepository : BaseADO, IDataRepository<CompanyProfileRepository>
    {
        public void Add(params CompanyProfileRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyProfileRepository> GetAll(params Expression<Func<CompanyProfileRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyProfileRepository> GetList(Expression<Func<CompanyProfileRepository, bool>> where, params Expression<Func<CompanyProfileRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyProfileRepository GetSingle(Expression<Func<CompanyProfileRepository, bool>> where, params Expression<Func<CompanyProfileRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params CompanyProfileRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params CompanyProfileRepository[] items)
        {
            throw new NotImplementedException();
        }
    }
}