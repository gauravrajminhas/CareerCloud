using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;

namespace CareerCloud.ADODataAccessLayer
{
    public class ApplicantJobApplicationRepository : BaseADO, IDataRepository<ApplicantJobApplicationRepository>
    {
        public void Add(params ApplicantJobApplicationRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantJobApplicationRepository> GetAll(params Expression<Func<ApplicantJobApplicationRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantJobApplicationRepository> GetList(Expression<Func<ApplicantJobApplicationRepository, bool>> where, params Expression<Func<ApplicantJobApplicationRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantJobApplicationRepository GetSingle(Expression<Func<ApplicantJobApplicationRepository, bool>> where, params Expression<Func<ApplicantJobApplicationRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params ApplicantJobApplicationRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params ApplicantJobApplicationRepository[] items)
        {
            throw new NotImplementedException();
        }
    }
}