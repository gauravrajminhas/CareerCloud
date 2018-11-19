using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyJobRepository : BaseADO, IDataRepository<CompanyJobRepository>
    {
        public void Add(params CompanyJobRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyJobRepository> GetAll(params Expression<Func<CompanyJobRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyJobRepository> GetList(Expression<Func<CompanyJobRepository, bool>> where, params Expression<Func<CompanyJobRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyJobRepository GetSingle(Expression<Func<CompanyJobRepository, bool>> where, params Expression<Func<CompanyJobRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params CompanyJobRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params CompanyJobRepository[] items)
        {
            throw new NotImplementedException();
        }
    }
}