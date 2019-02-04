using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Resumes")]
    public class ApplicantResumePoco :IPoco
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("ApplicantProfiles")]
        public Guid Applicant { get; set; }

        public String Resume { get; set; }
        [Column("Last_Updated")] public DateTime? LastUpdated { get; set; }

        // 1 Applicant has only 1 resume ? 
        //<#doubt>> 1-many relationship betwwen Applicant_profile and applicant_resume
        public virtual ApplicantProfilePoco ApplicantProfiles { get; set; }
    }
}
