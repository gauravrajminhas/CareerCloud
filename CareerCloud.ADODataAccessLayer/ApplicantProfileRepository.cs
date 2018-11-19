using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;

namespace CareerCloud.ADODataAccessLayer
{
    public class ApplicantProfileRepository : BaseADO, IDataRepository<ApplicantProfileRepository>
    {
        public void Add(params ApplicantProfileRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantProfileRepository> GetAll(params Expression<Func<ApplicantProfileRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantProfileRepository> GetList(Expression<Func<ApplicantProfileRepository, bool>> where, params Expression<Func<ApplicantProfileRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantProfileRepository GetSingle(Expression<Func<ApplicantProfileRepository, bool>> where, params Expression<Func<ApplicantProfileRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params ApplicantProfileRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params ApplicantProfileRepository[] items)
        {
            throw new NotImplementedException();
        }
    }
}