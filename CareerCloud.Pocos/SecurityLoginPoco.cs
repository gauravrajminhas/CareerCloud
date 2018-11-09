using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Security_Logins")]
    class SecurityLoginPoco : IPoco
    {
        [Key] public Guid Id { get; set; }

        public String Login { get; set; }
        public String Password { get; set; }

        public string Created { get; set; }
        [Column("Created_Date")] public DateTime CreatedDate { get; set; }
        [Column("Password_Update_Date")] public DateTime PasswordUpdateDate { get; set; }
        [Column("Agreement_Accepted_Date")] public DateTime AgreementAcceptedDate { get; set; }


        [Column("Is_Locked")]Boolean IsLocked { get; set;}

        [Column("Is_Inactive")] public Boolean IsInactive { get; set;}

        [Column("Email_Address")] public string Email_Address { get; set;}

        [Column("Phone_Number")] public string Phone_Number { get; set;}


        [Column("Full_Name")] public string Full_Name { get; set;}

        [Column("Force_Change_Password")] public Boolean ForceChangePassword { get; set;}

 

        [Column("Prefferred_Language")] public string PrefferredLanguage { get; set;}
       

        [Column("Time_Stamp")] public Byte[] TimeStamp { get; set; }












    }



}

