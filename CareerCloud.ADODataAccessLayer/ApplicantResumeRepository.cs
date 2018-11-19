using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;

namespace CareerCloud.ADODataAccessLayer
{
    public class ApplicantResumeRepository : BaseADO, IDataRepository<ApplicantResumeRepository>
    {
        public void Add(params ApplicantResumeRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantResumeRepository> GetAll(params Expression<Func<ApplicantResumeRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantResumeRepository> GetList(Expression<Func<ApplicantResumeRepository, bool>> where, params Expression<Func<ApplicantResumeRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantResumeRepository GetSingle(Expression<Func<ApplicantResumeRepository, bool>> where, params Expression<Func<ApplicantResumeRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params ApplicantResumeRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params ApplicantResumeRepository[] items)
        {
            throw new NotImplementedException();
        }
    }
}