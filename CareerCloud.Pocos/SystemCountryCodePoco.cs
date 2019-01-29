using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("System_Country_Codes")]
    public class SystemCountryCodePoco :IPoco
    {
        [Key]
        public String Code { get; set; }
        public String Name { get; set; }
        public Guid Id { get ; set ; }


        // many to 1 relationship with Applicant Profiles   and system country code 
        public virtual ICollection<ApplicantProfilePoco> ApplicantProfiles { get; set; }

        //1 to many relatiosnhip of SystemcountryCode to Applicant Work history 
        public virtual ICollection<ApplicantWorkHistoryPoco> ApplicantWorkHistorys { get; set; }
    }
}
