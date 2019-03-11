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
    interface IApplicant
    {
        [OperationContract]
        void AddApplicantWorkHistory(ApplicantWorkHistoryPoco[] poco);

        [OperationContract]
        List<ApplicantWorkHistoryPoco> GetAllApplicantWorkHistory();

        [OperationContract]
        ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(string id);

        [OperationContract]
        void RemoveApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos);

        [OperationContract]
        void UpdateApplicantWorkHistory(ApplicantWorkHistoryPoco[] pocos);

        [OperationContract]
        void AddApplicantSkill(ApplicantSkillPoco[] poco);

        [OperationContract]
        List<ApplicantSkillPoco> GetAllApplicantSkill();

        [OperationContract]
        ApplicantSkillPoco GetSingleApplicantSkill(string id);

        [OperationContract]
        void RemoveApplicantSkill(ApplicantSkillPoco[] pocos);

        [OperationContract]
        void UpdateApplicantSkill(ApplicantSkillPoco[] pocos);


        [OperationContract]
        void AddApplicantResume(ApplicantResumePoco[] poco);

        [OperationContract]
        List<ApplicantResumePoco> GetAllApplicantResume();

        [OperationContract]
        ApplicantResumePoco GetSingleApplicantResume(string id);

        [OperationContract]
        void RemoveApplicantResume(ApplicantResumePoco[] pocos);

        [OperationContract]
        void UpdateApplicantResume(ApplicantResumePoco[] pocos);



        [OperationContract]
        void AddApplicantEducation(ApplicantEducationPoco[] poco);

        [OperationContract]
        List<ApplicantEducationPoco> GetAllApplicantEducation();

        [OperationContract]
        ApplicantEducationPoco GetSingleApplicantEducation(string id);

        [OperationContract]
        void RemoveApplicantEducation(ApplicantEducationPoco[] pocos);

        [OperationContract]
        void UpdateApplicantEducation(ApplicantEducationPoco[] pocos);




        [OperationContract]
        void AddApplicantJobApplication(ApplicantJobApplicationPoco[] poco);

        [OperationContract]
        List<ApplicantJobApplicationPoco> GetAllApplicantJobApplication();

        [OperationContract]
        ApplicantJobApplicationPoco GetSingleApplicantJobApplication(string id);

        [OperationContract]
        void RemoveApplicantJobApplication(ApplicantJobApplicationPoco[] pocos);

        [OperationContract]
        void UpdateApplicantJobApplication(ApplicantJobApplicationPoco[] pocos);



        [OperationContract]
        void AddApplicantProfile(ApplicantProfilePoco[] poco);

        [OperationContract]
        List<ApplicantProfilePoco> GetAllApplicantProfile();

        [OperationContract]
        ApplicantProfilePoco GetSingleApplicantProfile(string id);

        [OperationContract]
        void RemoveApplicantProfile(ApplicantProfilePoco[] pocos);

        [OperationContract]
        void UpdateApplicantProfile(ApplicantProfilePoco[] pocos);












    }
}
