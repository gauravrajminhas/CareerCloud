﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Job_Applications")]
    public class ApplicantJobApplicationPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("ApplicantProfiles")]
        public Guid Applicant { get; set; }

        [ForeignKey("CompanyJobs")]
        public Guid Job { get; set; }

        [Column("Application_Date")]
        public DateTime ApplicationDate { get; set; }

        [NotMapped]
        [Column("Time_Stamp")] public Byte[] TimeStamp { get; set; }

        // 1 to many relationship between Applicant Profile and Applicant job Applications 
        public virtual ApplicantProfilePoco ApplicantProfiles { get; set; }

        //1 to many relationship between company_jobs and Applicant_job_applications
        public virtual CompanyJobPoco CompanyJobs { get; set; }

      


    }
}
