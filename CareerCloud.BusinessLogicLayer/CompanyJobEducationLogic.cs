using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyJobEducationLogic : BaseLogic<CompanyJobEducationPoco>
    {
        public CompanyJobEducationLogic(IDataRepository<CompanyJobEducationPoco> repository) : base(repository)
        {
            
        }

        public override void Add(CompanyJobEducationPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(CompanyJobEducationPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        protected override void Verify(CompanyJobEducationPoco[] pocos)
        {
            List<ValidationException> _exceptions = new List<ValidationException>();

            foreach (CompanyJobEducationPoco poco in pocos)
            {
                if (poco.Importance < 0)
                {
                    _exceptions.Add(new ValidationException(201, "Importance cannot be less than 0 "));
                }

                if (String.IsNullOrEmpty(poco.Major))
                {
                    _exceptions.Add(new ValidationException(200, "Major must be at least 2 characters"));
                }
                else if (poco.Major.Length < 2)
                {
                    _exceptions.Add(new ValidationException(200, "Major must be at least 2 characters"));
                }

                if (_exceptions.Count > 0)
                {
                    throw new AggregateException(_exceptions);
                }
            }

        }
    }
}