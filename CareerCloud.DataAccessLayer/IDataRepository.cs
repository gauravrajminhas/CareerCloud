using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace CareerCloud.DataAccessLayer
{
    public interface IDataRepository<T>
    {
        // Read and understand this Interface again !!!

        // Will be used by Business layer

        IList<T> GetAll(params Expression<Func<T, object>>[] navigationProperties);
        IList<T> GetList(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties);
        T GetSingle(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] navigationProperties);

        // will be used by WCF i.e SOAP or ReST
        // but will need to be validated  by a Valid() before doing a Add/Update at the business Logic Layer 
        // no validation should happen at data Access Layer 
        void Add(params T[] pocos);
        void Update(params T[] pocos);

        void Remove(params T[] pocos);
        void CallStoredProc(string name, params Tuple<string, string>[] parameters);
    }
}
