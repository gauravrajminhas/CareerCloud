using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyJobDescriptionLogic : BaseLogic<CompanyJobDescriptionPoco>
    {
        private List<ValidationException> _exceptions = new List<ValidationException>();

        public CompanyJobDescriptionLogic(IDataRepository<CompanyJobDescriptionPoco> repository) : base(repository)
        {

        }

        public override void Add(CompanyJobDescriptionPoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(CompanyJobDescriptionPoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }


        protected override void Verify(CompanyJobDescriptionPoco[] pocos)
        {
            foreach (var poco in pocos)
            {
                // business Logic and validation 
                if (String.IsNullOrEmpty(poco.JobName))
                {
                    _exceptions.Add(new ValidationException(300, "JobName cannot be empty"));
                }

                if (String.IsNullOrEmpty(poco.JobDescriptions))
                {
                    _exceptions.Add(new ValidationException(301, "JobDescriptions cannot be empty"));
                }
            }

            if (_exceptions.Count > 0)
            {
                throw new AggregateException(_exceptions);
            }


        }

    }
}
