using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.DataAccessLayer;
using CareerCloud.EntityFrameworkDataAccess;

namespace CareerCloud.BusinessLogicLayer
{
    public class ApplicantJobApplicationLogic : BaseLogic<ApplicantJobApplicationPoco>
    {
        // Doubt :- why do i have to write the constructor this way ? what forces us to pass argumesnts or use this signature, for the  constructors ?
        // inject the repository to BaseLogic 
        


        public  ApplicantJobApplicationLogic(IDataRepository<ApplicantJobApplicationPoco> _repository) :base(_repository)
        {
            //_repository = new EFGenericRepository<ApplicantJobApplicationPoco>();
            //nothing special to be done in the contructore 
        }

        protected override void Verify(ApplicantJobApplicationPoco[] pocos)
        {
            // verification logic goes here 
             List<ValidationException> exceptions= new List<ValidationException>();


            foreach (var poco in pocos)
            {
                if (poco.ApplicationDate > DateTime.Today)
                {
                    exceptions.Add(new ValidationException(110, "ApplicationDate cannot be greater than today"));
                }
            }

            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }


        public override void Add(ApplicantJobApplicationPoco[] pocos)
        { 
            // override the Add method to call Varification method 
            this.Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(ApplicantJobApplicationPoco[] pocos)
        {
            // override the Add method to call Varification method \
            this.Verify(pocos);
            base.Update(pocos);
        }




    }
}
