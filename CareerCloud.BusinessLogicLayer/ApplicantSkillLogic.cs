using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;

namespace CareerCloud.BusinessLogicLayer
{
    public class ApplicantSkillLogic : BaseLogic<ApplicantSkillPoco>
    {
        private List<ValidationException> _exceptions = new List<ValidationException>();
        public ApplicantSkillLogic(IDataRepository<ApplicantSkillPoco> repository) : base(repository)
        {
            
        }

        protected override void Verify(ApplicantSkillPoco[] pocos)
        {
            foreach (var poco in pocos)
            {
                if ((int)poco.StartMonth > 12)
                {
                    _exceptions.Add(new ValidationException(101, "Cannot be greater than 12"));
                }

                if ((int)poco.EndMonth > 12)
                {
                    _exceptions.Add(new ValidationException(102, "Cannot be greater than 12"));
                }

                if ((int)poco.StartYear < 1900)
                {
                    _exceptions.Add(new ValidationException(103, "Cannot be less then 1900"));
                }

                if ((int)poco.EndYear < poco.StartYear )
                {
                    _exceptions.Add(new ValidationException(104, "Cannot be less then StartYear"));
                }

            }

            if (_exceptions.Count >0)
            {
                throw new AggregateException(_exceptions);
            }


        }


        public override void Add(ApplicantSkillPoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(ApplicantSkillPoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }
    }
}
