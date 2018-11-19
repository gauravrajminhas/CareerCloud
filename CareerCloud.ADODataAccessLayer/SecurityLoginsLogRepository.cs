using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CareerCloud.DataAccessLayer;

namespace CareerCloud.ADODataAccessLayer
{
    public class SecurityLoginsLogRepository : BaseADO, IDataRepository<SecurityLoginsLogRepository>
    {
        public void Add(params SecurityLoginsLogRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<SecurityLoginsLogRepository> GetAll(params Expression<Func<SecurityLoginsLogRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<SecurityLoginsLogRepository> GetList(Expression<Func<SecurityLoginsLogRepository, bool>> where, params Expression<Func<SecurityLoginsLogRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SecurityLoginsLogRepository GetSingle(Expression<Func<SecurityLoginsLogRepository, bool>> where, params Expression<Func<SecurityLoginsLogRepository, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params SecurityLoginsLogRepository[] items)
        {
            throw new NotImplementedException();
        }

        public void Update(params SecurityLoginsLogRepository[] items)
        {
            throw new NotImplementedException();
        }
    }
}