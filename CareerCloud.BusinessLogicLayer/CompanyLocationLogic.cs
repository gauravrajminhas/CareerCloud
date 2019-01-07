using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyLocationLogic : BaseLogic<CompanyLocationPoco>
    {
        private List<ValidationException> _exceptions = new List<ValidationException>();

        public CompanyLocationLogic(IDataRepository<CompanyLocationPoco> repository) : base(repository)
        {

        }

        public override void Add(CompanyLocationPoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(CompanyLocationPoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }


        protected override void Verify(CompanyLocationPoco[] pocos)
        {
            foreach (var poco in pocos)
            {
                // business Logic and validation 
                if (String.IsNullOrEmpty(poco.CountryCode))
                {
                    _exceptions.Add(new ValidationException(500, "CountryCode cannot be empty"));
                }

                if (String.IsNullOrEmpty(poco.Province))
                {
                    _exceptions.Add(new ValidationException(501, "Province cannot be empty"));
                }

                if (String.IsNullOrEmpty(poco.Street))
                {
                    _exceptions.Add(new ValidationException(502, "Street cannot be empty"));
                }

                if (String.IsNullOrEmpty(poco.PostalCode))
                {
                    _exceptions.Add(new ValidationException(504, "PostalCode cannot be empty"));
                }


                if (String.IsNullOrEmpty(poco.City))
                {
                    _exceptions.Add(new ValidationException(503, "City cannot be empty"));
                }

            }

            if (_exceptions.Count > 0)
            {
                throw new AggregateException(_exceptions);
            }


        }

    }
}
