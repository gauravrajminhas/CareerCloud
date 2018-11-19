using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;

namespace CareerCloud.ADODataAccessLayer
{
    public class SystemLanguageCodeRepository : BaseADO, IDataRepository<SystemLanguageCodeRepository>
    {
        public void Add(params SystemLanguageCodeRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<SystemLanguageCodeRepository> GetAll(params Expression<Func<SystemLanguageCodeRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<SystemLanguageCodeRepository> GetList(Expression<Func<SystemLanguageCodeRepository, bool>> where, params Expression<Func<SystemLanguageCodeRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SystemLanguageCodeRepository GetSingle(Expression<Func<SystemLanguageCodeRepository, bool>> where, params Expression<Func<SystemLanguageCodeRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params SystemLanguageCodeRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params SystemLanguageCodeRepository[] items)
        {
            throw new NotImplementedException();
        }
    }
}