using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyJobDescriptionRepository : BaseADO, IDataRepository<CompanyJobDescriptionRepository>
    {
        public void Add(params CompanyJobDescriptionRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyJobDescriptionRepository> GetAll(params Expression<Func<CompanyJobDescriptionRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyJobDescriptionRepository> GetList(Expression<Func<CompanyJobDescriptionRepository, bool>> where, params Expression<Func<CompanyJobDescriptionRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyJobDescriptionRepository GetSingle(Expression<Func<CompanyJobDescriptionRepository, bool>> where, params Expression<Func<CompanyJobDescriptionRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params CompanyJobDescriptionRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params CompanyJobDescriptionRepository[] items)
        {
            throw new NotImplementedException();
        }
    }
}