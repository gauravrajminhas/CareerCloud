using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;

namespace CareerCloud.ADODataAccessLayer
{
    public class ApplicantWorkHistoryRepository : BaseADO, IDataRepository<ApplicantWorkHistoryRepository>
    {
        public void Add(params ApplicantWorkHistoryRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantWorkHistoryRepository> GetAll(params Expression<Func<ApplicantWorkHistoryRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantWorkHistoryRepository> GetList(Expression<Func<ApplicantWorkHistoryRepository, bool>> where, params Expression<Func<ApplicantWorkHistoryRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantWorkHistoryRepository GetSingle(Expression<Func<ApplicantWorkHistoryRepository, bool>> where, params Expression<Func<ApplicantWorkHistoryRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params ApplicantWorkHistoryRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params ApplicantWorkHistoryRepository[] items)
        {
            throw new NotImplementedException();
        }
    }
}