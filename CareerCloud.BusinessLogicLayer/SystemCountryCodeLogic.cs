using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.ADODataAccessLayer;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    public class SystemCountryCodeLogic //: specialBaseLogic<SystemCountryCodePoco>
    {
        private List<ValidationException> _exceptions = new List<ValidationException>();

        //<<#doubt>> 
        protected IDataRepository<SystemCountryCodePoco> _repository = new SystemCountryCodeRepository();

        public SystemCountryCodeLogic(IDataRepository<SystemCountryCodePoco> repository) //: base(repository)
        {

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

    }


    



}
