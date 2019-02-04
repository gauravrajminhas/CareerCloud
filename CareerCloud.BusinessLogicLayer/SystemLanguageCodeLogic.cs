using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    //SystemLanguagePoco does not have ID property !! 
    //thus cannot extend base logic class as it has generic paramerter that extends from IPOCO
    //
    public class SystemLanguageCodeLogic //: BaseLogic<SystemLanguageCodePoco>
    {
        private List<ValidationException> _exceptions = new List<ValidationException>();
        
        //creating my very own _repository
        private IDataRepository<SystemLanguageCodePoco> _repository;

        public SystemLanguageCodeLogic(IDataRepository<SystemLanguageCodePoco> repository) //: base(repository)
        {

        }

        //business logic is applied only for Add and Update functions. 
        // no logic for remove, getSingle etc ......
        public void Add(SystemLanguageCodePoco[] pocos)
        {
            this.Verify(pocos);
            _repository.Add(pocos);
        }

        public void Update(SystemLanguageCodePoco[] pocos)
        {
            this.Verify(pocos);
            _repository.Add(pocos);
        }


        protected void Verify(SystemLanguageCodePoco[] pocos)
        {
            foreach (var poco in pocos)
            {
                // Validation of Primary Key property in this poco ! 
                // this should not be Null ! 
                if (String.IsNullOrEmpty(poco.LanguageID))
                {
                    _exceptions.Add(new ValidationException(1000, "Cannot be empty"));
                }

                if (String.IsNullOrEmpty(poco.Name))
                {
                    _exceptions.Add(new ValidationException(1001, "Cannot be empty"));
                }

                if (String.IsNullOrEmpty(poco.NativeName))
                {
                    _exceptions.Add(new ValidationException(1002, "Cannot be empty"));
                }

            }

            if (_exceptions.Count > 0)
            {
                throw new AggregateException(_exceptions);
            }


        }

    }
}
