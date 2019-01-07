using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyDescriptionLogic : BaseLogic<CompanyDescriptionPoco>
    {
        private List<ValidationException> _exceptions = new List<ValidationException>();

        public CompanyDescriptionLogic(IDataRepository<CompanyDescriptionPoco> repository) : base(repository)
        {

        }

        public override void Add(CompanyDescriptionPoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(CompanyDescriptionPoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }


        protected override void Verify(CompanyDescriptionPoco[] pocos)
        {
            foreach (var poco in pocos)
            {
                // business Logic and validation
                if (String.IsNullOrEmpty(poco.CompanyDescription))
                {
                    _exceptions.Add(new ValidationException(107, "Company Description must be greater than 2 characters"));
                } 
                else if (poco.CompanyDescription.Length < 3)
                {
                    _exceptions.Add(new ValidationException(107, "Company Description must be greater than 2 characters"));
                }

                if (String.IsNullOrEmpty(poco.CompanyName))
                {
                    _exceptions.Add(new ValidationException(106, "CompanyName must be greater than 2 characters"));
                }
                else if (poco.CompanyName.Length < 3)
                {
                    _exceptions.Add(new ValidationException(106, "CompanyName must be greater than 2 characters"));
                }

            }

            if (_exceptions.Count > 0)
            {
                throw new AggregateException(_exceptions);
            }


        }


    }
}
