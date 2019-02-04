using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Work_History")]
    public class ApplicantWorkHistoryPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("ApplicantProfiles")]
        public Guid Applicant { get; set; }

        [Column("Company_Name")] public String CompanyName { get; set; }

        [ForeignKey("SystemCountryCodes")]
        [Column("Country_Code")]
        public String CountryCode { get; set; }

        public String Location { get; set; }

        [Column("Job_Title")] public String JobTitle { get; set; }

        [Column("Job_Description")] public String JobDescription { get; set; }

        [Column("Start_Month")] public Int16 StartMonth { get; set; }

        [Column("Start_Year")] public int StartYear { get; set; }

        [Column("End_Month")] public Int16 EndMonth { get; set; }

        [Column("End_Year")] public int EndYear { get; set; }

        [NotMapped]
        [Column("Time_Stamp")] public Byte[] TimeStamp { get; set; }


        //1 to many relationship of Applicantprofile and Applicant work education history
        public virtual ApplicantProfilePoco ApplicantProfiles { get; set; }

        //1 to many relatiosnhip of SystemcountryCode to Applicant Work history 
        public virtual SystemCountryCodePoco SystemCountryCodes { get; set; }
    }
}
