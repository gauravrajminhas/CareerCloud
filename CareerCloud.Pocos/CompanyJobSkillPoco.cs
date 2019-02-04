using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Job_Skills")]
    public class CompanyJobSkillPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("CompanyJobs")]
        public Guid Job { get; set; }

        public String Skill { get; set; }

        [Column("Skill_Level")]
        public String SkillLevel { get; set; }

        public int Importance { get; set; }

        [NotMapped]
        [Column("Time_Stamp")] public Byte[] TimeStamp { get; set; }

        //1 to many relationship of company_jobs and company_job_skills
        public virtual CompanyJobPoco CompanyJobs { get; set; }
        
    }
}
