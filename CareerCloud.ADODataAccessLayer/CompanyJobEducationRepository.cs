using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyJobEducationRepository : BaseADO, IDataRepository<CompanyJobEducationRepository>
    {
        public void Add(params CompanyJobEducationRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyJobEducationRepository> GetAll(params Expression<Func<CompanyJobEducationRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyJobEducationRepository> GetList(Expression<Func<CompanyJobEducationRepository, bool>> where, params Expression<Func<CompanyJobEducationRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyJobEducationRepository GetSingle(Expression<Func<CompanyJobEducationRepository, bool>> where, params Expression<Func<CompanyJobEducationRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params CompanyJobEducationRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params CompanyJobEducationRepository[] items)
        {
            throw new NotImplementedException();
        }
    }
}