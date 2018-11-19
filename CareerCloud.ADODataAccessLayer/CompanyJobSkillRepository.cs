using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyJobSkillRepository : BaseADO, IDataRepository<CompanyJobSkillRepository>
    {
        public void Add(params CompanyJobSkillRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyJobSkillRepository> GetAll(params Expression<Func<CompanyJobSkillRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyJobSkillRepository> GetList(Expression<Func<CompanyJobSkillRepository, bool>> where, params Expression<Func<CompanyJobSkillRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyJobSkillRepository GetSingle(Expression<Func<CompanyJobSkillRepository, bool>> where, params Expression<Func<CompanyJobSkillRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params CompanyJobSkillRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params CompanyJobSkillRepository[] items)
        {
            throw new NotImplementedException();
        }
    }
}