using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.DataAccessLayer;

namespace CareerCloud.EntityFrameworkDataAccess
{
    public class EFGenericRepository<SourceType> : IDataRepository<SourceType>
        where SourceType : class
    {
        // CRUD operations but with generic implimentation 

        public void Add(params SourceType[] pocos)
        {
            throw new NotImplementedException();
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<SourceType> GetAll(params Expression<Func<SourceType, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public IList<SourceType> GetList(Expression<Func<SourceType, bool>> where, params Expression<Func<SourceType, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SourceType GetSingle(Expression<Func<SourceType, bool>> where, params Expression<Func<SourceType, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public void Remove(params SourceType[] pocos)
        {
            throw new NotImplementedException();
        }

        public void Update(params SourceType[] pocos)
        {
            throw new NotImplementedException();
        }
    }
}
