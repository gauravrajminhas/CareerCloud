using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.Pocos;
using CareerCloud.DataAccessLayer;



namespace CareerCloud.BusinessLogicLayer
{
    public class ApplicantEducationLogic : BaseLogic<ApplicantEducationPoco>
    {
        
        //private IDataRepository<ApplicantEducationPoco> _repositor;
        private List<ValidationException> _exceptions = new List<ValidationException>();


        public ApplicantEducationLogic(IDataRepository<ApplicantEducationPoco> repository) : base(repository)
        {
            // Abstract Class can do this 
           // _repositor = repository;
        }

        public override void Add(ApplicantEducationPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
            
        }


        public override void Update(ApplicantEducationPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }

        

        protected override void Verify(ApplicantEducationPoco[] pocos)
        {
            
            // each logic class needs to over ride this method ! 
            

            foreach (ApplicantEducationPoco poco in pocos)
            {
                if (poco.Major.Length < 3)
                {
                    _exceptions.Add(new ValidationException(700, $"Major for POCO ID {poco.Id} Cannot be empty or less than 3 characters"));
                } 
                
                if (poco.StartDate > DateTime.Today)
                {
                    _exceptions.Add(new ValidationException(108, "Start Date Cannot be greater than today"));
                }

                if (poco.CompletionDate < poco.StartDate)
                {
                    _exceptions.Add(new ValidationException(109, "CompletionDate cannot be earlier than StartDate"));
                }
            }
            
            if (_exceptions.Count > 0)
            {
                throw new AggregateException(_exceptions);
            }
            


        }



    }
}
