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
        public Guid Company { get; set; }

        [Column("Profile_Created")] public DateTime ProfileCreated { get; set; }

        [Column("Is_Inactive")] public Boolean IsInactive { get; set; }

        [Column("Is_Company_Hidden")] public Boolean IsCompanyHidden { get; set; }
         
        [Column("Time_Stamp")] public Byte[] TimeStamp { get; set; }


        //1 to many relationship between company jobs and Applicant_job_applications
        public virtual ApplicantJobApplicationPoco ApplicantJobApplications { get; set; }

        // 1 to 1 mapping between company job and company job description 
        public virtual CompanyJobDescriptionPoco CompanyJobDescriptions { get; set; }

        //// 1 to 1 mapping between company_job and company_jobEduacation
        public virtual CompanyJobEducationPoco ComapJobEducations { get; set; }

    }
}
