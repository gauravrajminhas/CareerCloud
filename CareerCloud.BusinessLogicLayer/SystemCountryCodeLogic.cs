using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.ADODataAccessLayer;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
//using CareerCloud.EntityFrameworkDataAccess;

namespace CareerCloud.BusinessLogicLayer
{
    public class SystemCountryCodeLogic //: specialBaseLogic<SystemCountryCodePoco>
    {
        private List<ValidationException> _exceptions = new List<ValidationException>();
        private IDataRepository<SystemCountryCodePoco> _repository;

        //<<#doubt>> this will create a ADO repository not a EF repository 
        //protected IDataRepository<SystemCountryCodePoco> _repository = new SystemCountryCodeRepository();
        //private IDataRepository<SystemCountryCodePoco> _repository = new EntityFrameworkDataAccess.EFGenericRepository<SystemCountryCodePoco>();


        public SystemCountryCodeLogic(IDataRepository<SystemCountryCodePoco> repository) //: base(repository)
        {
            _repository = repository;

        }

        public void Add(SystemCountryCodePoco[] pocos)
        {
            this.Verify(pocos);
            _repository.Add(pocos);
            //base.Add(pocos);
        }

        public void Update(SystemCountryCodePoco[] pocos)
        {
            this.Verify(pocos);
            _repository.Update(pocos);
            //base.Add(pocos);
        }


        protected  void Verify(SystemCountryCodePoco[] pocos)
        {
            foreach (var poco in pocos)
            {
                // business Logic and validation 

                if (String.IsNullOrEmpty(poco.Name))
                {
                    _exceptions.Add(new ValidationException(900, "Cannot be empty"));
                }

                // Validation of Primary key property ! 
                // cannot be null ! 
                if (String.IsNullOrEmpty(poco.Code))
                {
                    _exceptions.Add(new ValidationException(901, "Cannot be empty"));
                }

            }

            if (_exceptions.Count > 0)
            {
                throw new AggregateException(_exceptions);
            }


        }


        public List<SystemCountryCodePoco> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public SystemCountryCodePoco Get(string Code)
        {
            return _repository.GetSingle(c => c.Code == Code);
        }


        public void Delete(SystemCountryCodePoco[] pocos)
        {
            _repository.Remove(pocos);
        }




    }


    



}
