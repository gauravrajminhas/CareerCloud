using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        private CareerCloudContext _context;

        public EFGenericRepository(bool createProxy = true)
        {
            _context = new CareerCloudContext(createProxy);
            // = System.Diagnostics.Debug.WriteLine;
            // _context.Log = System.Console.Out;
        }

       

        // CRUD operations but with generic implimentation 

        public void Add(params SourceType[] pocos)
        {
            //<<#doubt>> : can we pass the SourceType[] is Entry()  and it can find the DbSet property and make chnages to the State ??

            foreach (SourceType poco in pocos)
            {
                _context.Entry(poco).State = EntityState.Added;
            }
           
            _context.SaveChanges();



        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        
        // EF generic Repository 
        public IList<SourceType> GetAll(params Expression<Func<SourceType, object>>[] navigationProperties)
        {
            IQueryable<SourceType> query = _context.Set<SourceType>();
            foreach (Expression<Func<SourceType, object>> navprop in navigationProperties)
            {
                query = query.Include<SourceType, object>(navprop);
            }

            return query.ToList();
        }

        public IList<SourceType> GetList(Expression<Func<SourceType, bool>> where, params Expression<Func<SourceType, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }



        public SourceType GetSingle(Expression<Func<SourceType, bool>> where, params Expression<Func<SourceType, object>>[] navigationProperties)
        {
            // how to call this function ?? 
            //EFGenericRepo<ApplicantProfile> apRepo = new EFGenericRepo<ApplicantProfile>();
            //ApplicantProfile  value = apRepo.getSingle ( a => a.where( a.City=="Toronto" ) ,  a => a.ApplicationEducation )

            IQueryable<SourceType> sourceTypesDbSet = _context.Set<SourceType>();

            //<<#doubt>> did not understand this :- Expression<Func<SourceType, object>>[]  what is this Array ??
            // Method to include all dbSets in the query
            foreach (Expression<Func<SourceType, object>> nav in navigationProperties)
            {
                sourceTypesDbSet.Include<SourceType,Object>(nav);
            }

          // Now i have the DBset Of <sourceType> and dbSets of all the related Tables; 
            return sourceTypesDbSet.FirstOrDefault(where);

        }

        public void Remove(params SourceType[] pocos)
        { 
            foreach (SourceType poco in pocos)
            {
                _context.Entry(poco).State = EntityState.Deleted;
            }
            
            _context.SaveChanges();
        }

        public void Update(params SourceType[] pocos)
        {
            foreach (SourceType poco in pocos)
            {
                _context.Entry(poco).State = EntityState.Modified;
            }
            
            _context.SaveChanges();
        }
    }
}
