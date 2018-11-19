using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace CareerCloud.DataAccessLayer
{
    public interface IDataRepository<T>
    {
        IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);
        IList<T> GetList(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties);
        T GetSingle(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties);
        void Add(params T[] pocos);
        void Update(params T[] pocos);
        void Remove(params T[] pocos);
        void CallStoredProc(string name, params Tuple<string, string>[] parameters);
    }
}
