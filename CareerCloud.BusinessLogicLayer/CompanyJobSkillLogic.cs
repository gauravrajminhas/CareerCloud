using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class CompanyJobSkillLogic :BaseLogic<CompanyJobSkillPoco>
    {
        private List<ValidationException> _exceptions = new List<ValidationException>();

        public CompanyJobSkillLogic(IDataRepository<CompanyJobSkillPoco> repository) : base(repository)
        {

        }

        public override void Add(CompanyJobSkillPoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(CompanyJobSkillPoco[] pocos)
        {
            this.Verify(pocos);
            base.Add(pocos);
        }


        protected override void Verify(CompanyJobSkillPoco[] pocos)
        {
            foreach (var poco in pocos)
            {
                // business Logic and validation 
                if (poco.Importance < 0)
                {
                    _exceptions.Add(new ValidationException(400, "Importance cannot be less than 0"));
                }


            }

            if (_exceptions.Count > 0)
            {
                throw new AggregateException(_exceptions);
            }


        }

    }
}
