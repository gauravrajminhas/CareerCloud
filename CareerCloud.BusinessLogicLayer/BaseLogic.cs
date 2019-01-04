using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CareerCloud.BusinessLogicLayer
{
    public abstract class BaseLogic<TPoco>
        where TPoco : IPoco
    {
        //_repository is a reference to IDataRepository<Type IPoco>
        protected IDataRepository<TPoco> _repository;

        // constructor 
        public BaseLogic(IDataRepository<TPoco> repository)
        {
            _repository = repository;
        }

        // Over ride this method to Validae all the rules 
        protected virtual void Verify(TPoco[] pocos)
        {
            // each logic class needs to over ride this method ! 
            return;
        }

        // Get Data from the Data base
        public virtual TPoco Get(Guid id)
        {
            return _repository.GetSingle(c => c.Id == id);
        }

        // Get Data from the Data base
        public virtual List<TPoco> GetAll()
        {
            return _repository.GetAll().ToList();
        }


        // Validation of data then only Add 
        public virtual void Add(TPoco[] pocos)
        {
            foreach (TPoco poco in pocos)
            {
                if (poco.Id == Guid.Empty)
                {
                    poco.Id = Guid.NewGuid();
                }
            }

            _repository.Add(pocos);
        }

        // Validation of data only then update  
        public virtual void Update(TPoco[] pocos)
        {
            _repository.Update(pocos);
        }


        // if the validation fails then we delete the pocos 
        // there 
        public void Delete(TPoco[] pocos)
        {
            _repository.Remove(pocos);
        }
    }
}