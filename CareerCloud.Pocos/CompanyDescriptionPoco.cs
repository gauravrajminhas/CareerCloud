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

        [ForeignKey("CompanyProfiles")]
        public Guid Company { get; set; }

        [ForeignKey("SystemLanguageCodes")]
        public String LanguageId { get; set; }
        [Column("Company_Name")] public String CompanyName { get; set; }
        [Column("Company_Description")] public String CompanyDescription { get; set; }

        [NotMapped]
        [Column("Time_Stamp")] public Byte[] TimeStamp { get; set; }

        
        //1 to many relationship between System_Language_code and CompanyDescription 
        public virtual SystemLanguageCodePoco SystemLanguageCodes { get; set; }

        
        //1 to many relationship between company_profile and company description  
        public virtual CompanyProfilePoco CompanyProfiles { get; set; }


    }
}
