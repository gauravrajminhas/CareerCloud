using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class ApplicantWorkHistoryLogic : BaseLogic<ApplicantWorkHistoryPoco>
    {

        private List<ValidationException> _exceptions = new List<ValidationException>();

        public ApplicantWorkHistoryLogic(IDataRepository<ApplicantWorkHistoryPoco> repository) : base(repository)
        {

        }

        public override void Add(ApplicantWorkHistoryPoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(ApplicantWorkHistoryPoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }


        protected override void Verify(ApplicantWorkHistoryPoco[] pocos)
        {
            foreach (var poco in pocos)
            {
                // business Logic and validation 
                if (poco.CompanyName.Length < 3)
                {
                    _exceptions.Add(new ValidationException(105, "Must be greater then 2 characters"));
                }

            }

            if (_exceptions.Count > 0)
            {
                throw new AggregateException(_exceptions);
            }


        }



    }
}
