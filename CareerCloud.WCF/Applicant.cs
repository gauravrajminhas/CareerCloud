using System;
using System.Collections.Generic;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;

namespace CareerCloud.WCF
{
    public class Applicant : IApplicant

    {
        private ApplicantEducationLogic _applicantEducationLogic;
        private ApplicantJobApplicationLogic _ApplicantJobApplicationLogic;
        private ApplicantProfileLogic _ApplicantProfileLogic;
        private ApplicantResumeLogic _ApplicantResumeLogic;
        private ApplicantSkillLogic _ApplicantSkillLogic;
        private ApplicantWorkHistoryLogic _ApplicantWorkHistoryLogic;

        public Applicant()
        {
            _applicantEducationLogic = new ApplicantEducationLogic(new EFGenericRepository<ApplicantEducationPoco>(false));
            _ApplicantJobApplicationLogic = new ApplicantJobApplicationLogic(new EFGenericRepository<ApplicantJobApplicationPoco>(false));
            _ApplicantProfileLogic = new ApplicantProfileLogic(new EFGenericRepository<ApplicantProfilePoco>(false));
            _ApplicantResumeLogic = new ApplicantResumeLogic(new EFGenericRepository<ApplicantResumePoco>(false));
            _ApplicantSkillLogic = new ApplicantSkillLogic(new EFGenericRepository<ApplicantSkillPoco>(false));
            _ApplicantWorkHistoryLogic = new ApplicantWorkHistoryLogic(new EFGenericRepository<ApplicantWorkHistoryPoco>(false));
        }

        public void AddApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos)
        {
            _ApplicantWorkHistoryLogic.Add(pocos);
        }

        public List<ApplicantWorkHistoryPoco> GetAllApplicantWorkHistory()
        {
            return _ApplicantWorkHistoryLogic.GetAll();
        }

        public ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(string id)
        {
            return _ApplicantWorkHistoryLogic.Get(Guid.Parse(id));
        }

        public void RemoveApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos)
        {
            _ApplicantWorkHistoryLogic.Delete(pocos);
        }


        public void UpdateApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos)
        {
            _ApplicantWorkHistoryLogic.Update(pocos);
        }

        public void AddApplicantSkill(ApplicantSkillPoco[] pocos)
        {
            _ApplicantSkillLogic.Add(pocos);
        }

        public List<ApplicantSkillPoco> GetAllApplicantSkill()
        {
            return _ApplicantSkillLogic.GetAll();
        }

        public ApplicantSkillPoco GetSingleApplicantSkill(string id)
        {
            return _ApplicantSkillLogic.Get(Guid.Parse(id));
        }

        public void RemoveApplicantSkill(ApplicantSkillPoco[] pocos)
        {
            _ApplicantSkillLogic.Delete(pocos);
        }


        public void UpdateApplicantSkill(ApplicantSkillPoco[] pocos)
        {
            _ApplicantSkillLogic.Update(pocos);
        }

        public void AddApplicantResume(ApplicantResumePoco[] pocos)
        {
            _ApplicantResumeLogic.Add(pocos);
        }

        public List<ApplicantResumePoco> GetAllApplicantResume()
        {
            return _ApplicantResumeLogic.GetAll();
        }

        public ApplicantResumePoco GetSingleApplicantResume(string id)
        {
            return _ApplicantResumeLogic.Get(Guid.Parse(id));
        }

        public void RemoveApplicantResume(ApplicantResumePoco[] pocos)
        {
            _ApplicantResumeLogic.Delete(pocos);
        }


        public void UpdateApplicantResume(ApplicantResumePoco[] pocos)
        {
            _ApplicantResumeLogic.Update(pocos);
        }


        public void AddApplicantProfile(ApplicantProfilePoco[] pocos)
        {
            _ApplicantProfileLogic.Add(pocos);
        }

        public List<ApplicantProfilePoco> GetAllApplicantProfile()
        {
            return _ApplicantProfileLogic.GetAll();
        }

        public ApplicantProfilePoco GetSingleApplicantProfile(string id)
        {
            return _ApplicantProfileLogic.Get(Guid.Parse(id));
        }

        public void RemoveApplicantProfile(ApplicantProfilePoco[] pocos)
        {
            _ApplicantProfileLogic.Delete(pocos);
        }


        public void UpdateApplicantProfile(ApplicantProfilePoco[] pocos)
        {
            _ApplicantProfileLogic.Update(pocos);
        }




        public void AddApplicantEducation(ApplicantEducationPoco[] pocos)
        {
            _applicantEducationLogic.Add(pocos);
        }

        public List<ApplicantEducationPoco> GetAllApplicantEducation()
        {
            return _applicantEducationLogic.GetAll();
        }

        public ApplicantEducationPoco GetSingleApplicantEducation(string id)
        {
            return _applicantEducationLogic.Get(Guid.Parse(id));
        }

        public void RemoveApplicantEducation(ApplicantEducationPoco[] pocos)
        {
            _applicantEducationLogic.Delete(pocos);
        }

        public void UpdateApplicantEducation(ApplicantEducationPoco[] pocos)
        {
            _applicantEducationLogic.Update(pocos);
        }





        public void AddApplicantJobApplication(ApplicantJobApplicationPoco[] pocos)
        {
            _ApplicantJobApplicationLogic.Add(pocos);
        }

        public List<ApplicantJobApplicationPoco> GetAllApplicantJobApplication()
        {
            return _ApplicantJobApplicationLogic.GetAll();
        }

        public ApplicantJobApplicationPoco GetSingleApplicantJobApplication(string id)
        {
            return _ApplicantJobApplicationLogic.Get(Guid.Parse(id));
        }

        public void RemoveApplicantJobApplication(ApplicantJobApplicationPoco[] pocos)
        {
            _ApplicantJobApplicationLogic.Delete(pocos);
        }



        public void UpdateApplicantJobApplication(ApplicantJobApplicationPoco[] pocos)
        {
            _ApplicantJobApplicationLogic.Update(pocos);
        }







    }
}