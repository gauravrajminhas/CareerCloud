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
    public class ApplicantProfileLogic : BaseLogic<ApplicantProfilePoco>
    {
        private List<ValidationException> _exception = new List<ValidationException>();

        public ApplicantProfileLogic(IDataRepository<ApplicantProfilePoco> repository): base(repository)
        {
            // nothing to be done here 
            // just inject IDataRepository with generic type Pocos to the baseLogic class 
            // ivoke the baseLogic object and inject the dpendency 
        }

        protected override void Verify(ApplicantProfilePoco[] pocos)
        {
            foreach (var poco in pocos)
            {
                if (poco.CurrentSalary < 0)
                {
                    _exception.Add(new ValidationException(111, "CurrentSalary cannot be negative"));
                }

                if (poco.CurrentRate < 0)
                {
                    _exception.Add(new ValidationException(112, "CurrentRate cannot be negative"));
                }
            }

            if (_exception.Count < 0)
            {
                // throw a new exception 
                throw new AggregateException(_exception);
            }


        }

        public override void Add(ApplicantProfilePoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(ApplicantProfilePoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }


    }
}
