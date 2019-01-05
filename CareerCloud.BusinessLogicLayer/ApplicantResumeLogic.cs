using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    public class ApplicantResumeLogic : BaseLogic<ApplicantResumePoco>
    {
        private List<ValidationException> _exceptions = new List<ValidationException>();
        public ApplicantResumeLogic(IDataRepository<ApplicantResumePoco> repository) : base(repository)
        {

        }

        protected override void Verify(ApplicantResumePoco[] pocos)
        {
            foreach (var poco in pocos)
            {
                if (poco.Resume.Length < 1)
                {
                    _exceptions.Add(new ValidationException(113, "Resume cannot be empty"));
                }
            }

            if (_exceptions.Count > 0)
            {
                throw new AggregateException(_exceptions);
            }
        }

        public override void Add(ApplicantResumePoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(ApplicantResumePoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }


    }
}
