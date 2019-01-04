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
        public ApplicantProfileLogic(IDataRepository<ApplicantProfilePoco> repository): base(repository)
        {

        }

        protected override void Verify(ApplicantProfilePoco[] pocos)
        {

        }

        public override void Add(ApplicantProfilePoco[] pocos)
        {

        }

        public override void 


    }
}
