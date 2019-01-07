using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    public class SystemLanguageCodeLogic : BaseLogic<SystemLanguageCodePoco>
    {
        private List<ValidationException> _exceptions = new List<ValidationException>();

        public SystemLanguageCodeLogic(IDataRepository<SystemLanguageCodePoco> repository) : base(repository)
        {

        }

        public override void Add(SystemLanguageCodePoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(SystemLanguageCodePoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }


        protected override void Verify(SystemLanguageCodePoco[] pocos)
        {
            foreach (var poco in pocos)
            {
                // business Logic and validation 
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
