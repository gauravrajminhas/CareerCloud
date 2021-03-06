﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Jobs_Descriptions")]
    public class CompanyJobDescriptionPoco :IPoco
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("CompanyJobs")]
        public Guid Job { get; set; }


        [Column("Job_Name")] public String JobName { get; set; }

        [Column("Job_Descriptions")] public String JobDescriptions { get; set; }

        [NotMapped]
        [Column("Time_Stamp")] public Byte[] TimeStamp { get; set; }


        // 1 to 1 mapping between company job and company job description
        public virtual CompanyJobPoco CompanyJobs { get; set; }



    }
}
