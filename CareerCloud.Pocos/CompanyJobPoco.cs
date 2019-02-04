using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Jobs")]
    public class CompanyJobPoco :IPoco
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("CompanyProfiles")]
        public Guid Company { get; set; }

        [Column("Profile_Created")] public DateTime ProfileCreated { get; set; }

        [Column("Is_Inactive")] public Boolean IsInactive { get; set; }

        [Column("Is_Company_Hidden")] public Boolean IsCompanyHidden { get; set; }

        [NotMapped]
        [Column("Time_Stamp")] public Byte[] TimeStamp { get; set; }


        //1 to many relationship between company_jobs and Applicant_job_applications
        public virtual ICollection<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }

        //<<#doubt>> according to the data there is only 1-1 mapping here 
        // 1 to 1 mapping between company_job and company job description 
        //public virtual CompanyJobDescriptionPoco CompanyJobDescriptions { get; set; }
        public virtual ICollection<CompanyJobDescriptionPoco> CompanyJobDescriptions { get; set; }

        //<<#doubt>> according to the data in the tables there is only 1-1 record; 
        // 1 to 1 mapping between company_job and company_jobEduacation
        //public virtual CompanyJobEducationPoco CompanyJobEducations { get; set; }
        public virtual  ICollection<CompanyJobEducationPoco> CompanyJobEducations { get; set; }


        //<<#doubt>>
        //1 to many mapping between company_profiles and company_jobs
        //
        public virtual CompanyProfilePoco CompanyProfiles { get; set; }

        //1 to many relationship of company_jobs and company_job_skills
        public virtual ICollection<CompanyJobSkillPoco> CompanyJobSkills { get; set; }

    }
}
