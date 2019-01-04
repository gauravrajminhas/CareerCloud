using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.Pocos;
using CareerCloud.DataAccessLayer;



namespace CareerCloud.BusinessLogicLayer
{
    public class ApplicantEducationLogic : BaseLogic<ApplicantEducationPoco>
    {
        private List<ValidationException> exceptions;
        

        public ApplicantEducationLogic(IDataRepository<ApplicantEducationPoco> repository) : base(repository)
        {
        
        }

        

        protected override void Verify(ApplicantEducationPoco[] pocos)
        {
            // each logic class needs to over ride this method ! 
            return;
        }



    }
}
