using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Applicant_Profiles")]
    public class ApplicantProfilePoco : IPoco
    {
        [Key]

        public Guid Id { get; set; }

        public Guid Login { get; set; }

        [Column("Current_Salary")]
        public Decimal? CurrentSalary { get; set; }

        [Column("Current_Rate")]
        public Decimal? CurrentRate { get; set; }

        //Bug Not null currency :- can this Work ?  the String is ref type and can take null value 
        public String Currency { get; set; }

        [Column("Country_Code")]
        public string Country { get; set; }

       // [Column("Country")]
       // public string Country { get; set; }

        [Column("State_Province_Code")]
        public String Province { get; set; }

        [Column("Street_Address")]
        public string Street { get; set; }

        [Column("City_Town")] public String City { get; set; }

        [Column("Zip_Postal_Code")] public String PostalCode { get; set; }

        [Column("Time_Stamp")] public Byte[] TimeStamp { get; set; }


        // as 1 Applicant profile poco points to many applicant education pocos ; thus the collection
        public virtual ICollection<ApplicantEducationPoco> ApplicantEducations { get; set; }

        //Applicant Skills is 1 to many
        public virtual ICollection<ApplicantSkillPoco> ApplicantSkills { get; set; }

        //applicantResume is 1-1 mapping 
        public virtual ApplicantResumePoco ApplicantResumes { get; set; }

       // many to 1 relationship with Applicant Profiles and system country code 
        public virtual SystemCountryCodePoco SystemCountryCodes { get; set; }

        //1 to many relationship of Applicantprofile and Applicant work education history
        public virtual ICollection<ApplicantWorkHistoryPoco> ApplicantWorkHistorys { get; set; }

        //1 to 1 relationship between applicant profies and security logins 
        public virtual SecurityLoginPoco SecurityLogins { get; set; }

        //1 to many relatioship between Applicant and Applicant Job Applicants 
        public virtual ICollection<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }



    }
}
