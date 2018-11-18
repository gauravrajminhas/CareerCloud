using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

    }
}
