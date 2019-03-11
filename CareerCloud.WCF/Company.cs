using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;

namespace CareerCloud.WCF
{
    public class Company : ICompany
    {
        private CompanyDescriptionLogic _CompanyDescriptionLogic;
        private CompanyJobEducationLogic _CompanyJobEducationLogic;
        private CompanyJobLogic _CompanyJobLogic;
        private CompanyJobSkillLogic _CompanyJobSkillLogic;
        private CompanyLocationLogic _CompanyLocationLogic;
        private CompanyProfileLogic _CompanyProfileLogic;
        private CompanyJobDescriptionLogic _CompanyJobDescriptionLogic;

        public Company()
        {
            _CompanyDescriptionLogic = new CompanyDescriptionLogic(new EFGenericRepository<CompanyDescriptionPoco>(false));
            _CompanyJobEducationLogic = new CompanyJobEducationLogic(new EFGenericRepository<CompanyJobEducationPoco>(false));
            _CompanyJobLogic = new CompanyJobLogic(new EFGenericRepository<CompanyJobPoco>(false));
            _CompanyJobSkillLogic = new CompanyJobSkillLogic(new EFGenericRepository<CompanyJobSkillPoco>(false));
            _CompanyLocationLogic = new CompanyLocationLogic(new EFGenericRepository<CompanyLocationPoco>(false));
            _CompanyProfileLogic = new CompanyProfileLogic(new EFGenericRepository<CompanyProfilePoco>(false));
            _CompanyJobDescriptionLogic = new CompanyJobDescriptionLogic(new EFGenericRepository<CompanyJobDescriptionPoco>(false));

        }

        public void AddCompanyJobDescription(CompanyJobDescriptionPoco[] pocos)
        {
            _CompanyJobDescriptionLogic.Add(pocos);
        }

        public List<CompanyJobDescriptionPoco> GetAllCompanyJobDescription()
        {
            return _CompanyJobDescriptionLogic.GetAll();
        }
        // ToString ToGUID
        public CompanyJobDescriptionPoco GetSingleCompanyJobDescription(string id)
        {
            return _CompanyJobDescriptionLogic.Get(Guid.Parse(id));
        }

        public void RemoveCompanyJobDescription(CompanyJobDescriptionPoco[] pocos)
        {
            _CompanyJobDescriptionLogic.Delete(pocos);
        }


        public void UpdateCompanyJobDescription(CompanyJobDescriptionPoco[] pocos)
        {
            _CompanyJobDescriptionLogic.Update(pocos);
        }



        public void AddCompanyProfile(CompanyProfilePoco[] pocos)
        {
            _CompanyProfileLogic.Add(pocos);
        }

        public List<CompanyProfilePoco> GetAllCompanyProfile()
        {
            return _CompanyProfileLogic.GetAll();
        }

        public CompanyProfilePoco GetSingleCompanyProfile(string id)
        {
            return _CompanyProfileLogic.Get(Guid.Parse(id));
        }

        public void RemoveCompanyProfile(CompanyProfilePoco[] pocos)
        {
            _CompanyProfileLogic.Delete(pocos);
        }


        public void UpdateCompanyProfile(CompanyProfilePoco[] pocos)
        {
            _CompanyProfileLogic.Update(pocos);
        }


        public void AddCompanyLocation(CompanyLocationPoco[] pocos)
        {
            _CompanyLocationLogic.Add(pocos);
        }

        public List<CompanyLocationPoco> GetAllCompanyLocation()
        {
            return _CompanyLocationLogic.GetAll();
        }

        public CompanyLocationPoco GetSingleCompanyLocation(string id)
        {
            return _CompanyLocationLogic.Get(Guid.Parse(id));
        }

        public void RemoveCompanyLocation(CompanyLocationPoco[] pocos)
        {
            _CompanyLocationLogic.Delete(pocos);
        }


        public void UpdateCompanyLocation(CompanyLocationPoco[] pocos)
        {
            _CompanyLocationLogic.Update(pocos);
        }

        public void AddCompanyJobSkill(CompanyJobSkillPoco[] pocos)
        {
            _CompanyJobSkillLogic.Add(pocos);
        }

        public List<CompanyJobSkillPoco> GetAllCompanyJobSkill()
        {
            return _CompanyJobSkillLogic.GetAll();
        }

        public CompanyJobSkillPoco GetSingleCompanyJobSkill(string id)
        {
            return _CompanyJobSkillLogic.Get(Guid.Parse(id));
        }

        public void RemoveCompanyJobSkill(CompanyJobSkillPoco[] pocos)
        {
            _CompanyJobSkillLogic.Delete(pocos);
        }


        public void UpdateCompanyJobSkill(CompanyJobSkillPoco[] pocos)
        {
            _CompanyJobSkillLogic.Update(pocos);
        }

        public void AddCompanyJob(CompanyJobPoco[] pocos)
        {
            _CompanyJobLogic.Add(pocos);
        }

        public List<CompanyJobPoco> GetAllCompanyJob()
        {
            return _CompanyJobLogic.GetAll();
        }

        public CompanyJobPoco GetSingleCompanyJob(string id)
        {
            return _CompanyJobLogic.Get(Guid.Parse(id));
        }

        public void RemoveCompanyJob(CompanyJobPoco[] pocos)
        {
            _CompanyJobLogic.Delete(pocos);
        }


        public void UpdateCompanyJob(CompanyJobPoco[] pocos)
        {
            _CompanyJobLogic.Update(pocos);
        }




        public void AddCompanyJobEducation(CompanyJobEducationPoco[] pocos)
        {
            _CompanyJobEducationLogic.Add(pocos);
        }

        public List<CompanyJobEducationPoco> GetAllCompanyJobEducation()
        {
            return _CompanyJobEducationLogic.GetAll();
        }

        public CompanyJobEducationPoco GetSingleCompanyJobEducation(string id)
        {
            return _CompanyJobEducationLogic.Get(Guid.Parse(id));
        }

        public void RemoveCompanyJobEducation(CompanyJobEducationPoco[] pocos)
        {
            _CompanyJobEducationLogic.Delete(pocos);
        }


        public void UpdateCompanyJobEducation(CompanyJobEducationPoco[] pocos)
        {
            _CompanyJobEducationLogic.Update(pocos);
        }

        public void AddCompanyDescription(CompanyDescriptionPoco[] pocos)
        {
            _CompanyDescriptionLogic.Add(pocos);
        }

        public List<CompanyDescriptionPoco> GetAllCompanyDescription()
        {
            return _CompanyDescriptionLogic.GetAll();
        }

        public CompanyDescriptionPoco GetSingleCompanyDescription(string id)
        {
            return _CompanyDescriptionLogic.Get(Guid.Parse(id));
        }

        public void RemoveCompanyDescription(CompanyDescriptionPoco[] pocos)
        {
            _CompanyDescriptionLogic.Delete(pocos);
        }


        public void UpdateCompanyDescription(CompanyDescriptionPoco[] pocos)
        {
            _CompanyDescriptionLogic.Update(pocos);
        }


    }
}