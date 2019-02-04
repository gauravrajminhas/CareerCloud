using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Job_Educations")]
    public class CompanyJobEducationPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("CompanyJobs")] //name the navigation property
        public Guid Job { get; set; }
        public String Major { get; set; }

        public Int16 Importance { get; set; }
        
        [Column("Time_Stamp")] public Byte[] TimeStamp { get; set; }

        // 1 to 1 mapping between company_job and company_jobEduacation
        public virtual CompanyJobPoco CompanyJobs { get; set; }
    }
}
