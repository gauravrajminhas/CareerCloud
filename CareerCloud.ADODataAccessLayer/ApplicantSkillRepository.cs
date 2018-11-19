using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;

namespace CareerCloud.ADODataAccessLayer
{
    public class ApplicantSkillRepository : BaseADO, IDataRepository<ApplicantSkillRepository>
    {
        public void Add(params ApplicantSkillRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantSkillRepository> GetAll(params Expression<Func<ApplicantSkillRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantSkillRepository> GetList(Expression<Func<ApplicantSkillRepository, bool>> where, params Expression<Func<ApplicantSkillRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantSkillRepository GetSingle(Expression<Func<ApplicantSkillRepository, bool>> where, params Expression<Func<ApplicantSkillRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params ApplicantSkillRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params ApplicantSkillRepository[] items)
        {
            throw new NotImplementedException();
        }
    }
}