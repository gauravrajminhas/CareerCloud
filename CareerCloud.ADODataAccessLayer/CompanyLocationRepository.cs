using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyLocationRepository : BaseADO, IDataRepository<CompanyLocationRepository>
    {
        public void Add(params CompanyLocationRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyLocationRepository> GetAll(params Expression<Func<CompanyLocationRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyLocationRepository> GetList(Expression<Func<CompanyLocationRepository, bool>> where, params Expression<Func<CompanyLocationRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyLocationRepository GetSingle(Expression<Func<CompanyLocationRepository, bool>> where, params Expression<Func<CompanyLocationRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params CompanyLocationRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params CompanyLocationRepository[] items)
        {
            throw new NotImplementedException();
        }
    }
}