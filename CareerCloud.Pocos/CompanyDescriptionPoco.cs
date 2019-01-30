using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Company_Descriptions")]
    public class CompanyDescriptionPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }
        public Guid Company { get; set; }
        public String LanguageId { get; set; }
        [Column("Company_Name")] public String CompanyName { get; set; }
        [Column("Company_Description")] public String CompanyDescription { get; set; }
        [Column("Time_Stamp")] public Byte[] TimeStamp { get; set; }

        //many to many relationship between company_description and langunage Id 
        public virtual ICollection<SystemLanguageCodePoco> SystemLanguageCodes { get; set; }

        //1 to many relationship between company_profile and company description  
        public virtual CompanyProfilePoco CompanyProfiles { get; set; }


    }
}
