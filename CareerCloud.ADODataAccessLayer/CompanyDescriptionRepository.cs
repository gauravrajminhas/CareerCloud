using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyDescriptionRepository : BaseADO, IDataRepository<CompanyDescriptionRepository>
    {
        public void Add(params CompanyDescriptionRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyDescriptionRepository> GetAll(params Expression<Func<CompanyDescriptionRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyDescriptionRepository> GetList(Expression<Func<CompanyDescriptionRepository, bool>> where, params Expression<Func<CompanyDescriptionRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyDescriptionRepository GetSingle(Expression<Func<CompanyDescriptionRepository, bool>> where, params Expression<Func<CompanyDescriptionRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params CompanyDescriptionRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params CompanyDescriptionRepository[] items)
        {
            throw new NotImplementedException();
        }
    }
}