using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Educations")]
    public class ApplicantEducationPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("ApplicantProfiles")]
        public Guid Applicant { get; set; }
        public String Major { get; set; }
        
        // BUG this could be null ?? yeah so Ref typ can be null !
        [Column("Certificate_Diploma")]
        public String CertificateDiploma { get; set; }

        [Column("Start_Date")]
        public DateTime? StartDate { get; set; }

        [Column("Completion_Date")]
        public DateTime? CompletionDate { get; set; }

        [Column("Completion_Percent")]
        public Byte? CompletionPercent { get; set; }

        [NotMapped]
        [Column("Time_Stamp")]
        public Byte[] TimeStamp { get; set; }
        
        //Navigation Properties In ORM
        //foriegn key relationship 
        //As 1 Applicant Education Poco point to the 1 ApplicantProfilePoco
        // this is virtual coz ER framework may provide Override the property and many provide impilmentation for the navigation. 
        public virtual ApplicantProfilePoco ApplicantProfiles { get; set; }
    }
}
