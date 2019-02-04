using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("System_Language_Codes")]
    public class SystemLanguageCodePoco //: IPoco   // Does not need to inhert from this field 
    {
        [Key]
        public String LanguageID { get; set; }
        public String Name { get; set; }

        [Column("Native_Name")]
        public String NativeName { get; set; }

        //BUG :- this Property does not exist  for this poco 
        //public Guid Id {    get ;   set ; }


        //1 to many relationship between SystemLanguageCode and CompanyDescription
       public virtual ICollection<CompanyDescriptionPoco> CompanyDescriptions { get; set; }



    }
}
