using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.WCF
{
    [ServiceContract]
    interface ICompany
    {

        [OperationContract]
        void AddCompanyJobDescription(CompanyJobDescriptionPoco[] poco);

        [OperationContract]
        List<CompanyJobDescriptionPoco> GetAllCompanyJobDescription();

        [OperationContract]
        CompanyJobDescriptionPoco GetSingleCompanyJobDescription(string id);

        [OperationContract]
        void RemoveCompanyJobDescription(CompanyJobDescriptionPoco[] pocos);

        [OperationContract]
        void UpdateCompanyJobDescription(CompanyJobDescriptionPoco[] pocos);


        [OperationContract]
        void AddCompanyProfile(CompanyProfilePoco[] poco);

        [OperationContract]
        List<CompanyProfilePoco> GetAllCompanyProfile();

        [OperationContract]
        CompanyProfilePoco GetSingleCompanyProfile(String id);

        [OperationContract]
        void RemoveCompanyProfile(CompanyProfilePoco[] pocos);

        [OperationContract]
        void UpdateCompanyProfile(CompanyProfilePoco[] pocos);


        [OperationContract]
        void AddCompanyLocation(CompanyLocationPoco[] poco);

        [OperationContract]
        List<CompanyLocationPoco> GetAllCompanyLocation();

        [OperationContract]
        CompanyLocationPoco GetSingleCompanyLocation(string id);

        [OperationContract]
        void RemoveCompanyLocation(CompanyLocationPoco[] pocos);

        [OperationContract]
        void UpdateCompanyLocation(CompanyLocationPoco[] pocos);


        [OperationContract]
        void AddCompanyJobSkill(CompanyJobSkillPoco[] poco);

        [OperationContract]
        List<CompanyJobSkillPoco> GetAllCompanyJobSkill();

        [OperationContract]
        CompanyJobSkillPoco GetSingleCompanyJobSkill(string id);

        [OperationContract]
        void RemoveCompanyJobSkill(CompanyJobSkillPoco[] pocos);

        [OperationContract]
        void UpdateCompanyJobSkill(CompanyJobSkillPoco[] pocos);



        [OperationContract]
        void AddCompanyJob(CompanyJobPoco[] poco);

        [OperationContract]
        List<CompanyJobPoco> GetAllCompanyJob();

        [OperationContract]
        CompanyJobPoco GetSingleCompanyJob(string id);

        [OperationContract]
        void RemoveCompanyJob(CompanyJobPoco[] pocos);

        [OperationContract]
        void UpdateCompanyJob(CompanyJobPoco[] pocos);



        [OperationContract]
        void AddCompanyJobEducation(CompanyJobEducationPoco[] poco);

        [OperationContract]
        List<CompanyJobEducationPoco> GetAllCompanyJobEducation();

        [OperationContract]
        CompanyJobEducationPoco GetSingleCompanyJobEducation(string id);

        [OperationContract]
        void RemoveCompanyJobEducation(CompanyJobEducationPoco[] pocos);

        [OperationContract]
        void UpdateCompanyJobEducation(CompanyJobEducationPoco[] pocos);


        [OperationContract]
        void AddCompanyDescription(CompanyDescriptionPoco[] poco);

        [OperationContract]
        List<CompanyDescriptionPoco> GetAllCompanyDescription();

        [OperationContract]
        CompanyDescriptionPoco GetSingleCompanyDescription(string id);

        [OperationContract]
        void RemoveCompanyDescription(CompanyDescriptionPoco[] pocos);

        [OperationContract]
        void UpdateCompanyDescription(CompanyDescriptionPoco[] pocos);




    }
}
