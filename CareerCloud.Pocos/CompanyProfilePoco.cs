using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Profiles")]
    public class CompanyProfilePoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        [Column("Registration_Date")] public DateTime RegistrationDate { get; set; }
        [Column("Company_Website")] public String CompanyWebsite { get; set; }
        [Column("Contact_Phone")] public String ContactPhone { get; set; }
        [Column("Contact_Name")] public String ContactName { get; set; }


        // how do i make this as not null ??
        [Column("Company_Logo")] public Byte[] CompanyLogo { get; set; }

        
        [Column("Time_Stamp")] public Byte[] TimeStamp { get; set; }

        //1 to many mapping between company_profiles and company_jobs
        public virtual CompanyJobPoco CompanyJobs { get; set; }

        // 1 to many relationship between company_profile and company_locations
        public virtual ICollection<CompanyLocationPoco> CompanyLocations { get; set; }

        //1 to many relationship between company_profile and company description  
        public virtual ICollection<CompanyDescriptionPoco> CompanyDescriptions { get; set; }


    }


}
