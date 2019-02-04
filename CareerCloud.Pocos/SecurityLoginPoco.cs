﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Security_Logins")]
    public class SecurityLoginPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        public String Login { get; set; }
        public String Password { get; set; }

       
        [Column("Created_Date")] public DateTime Created { get; set; }
        [Column("Password_Update_Date")] public DateTime? PasswordUpdate { get; set; }
        [Column("Agreement_Accepted_Date")] public DateTime? AgreementAccepted { get; set; }


        [Column("Is_Locked")] public Boolean IsLocked { get; set;}

        [Column("Is_Inactive")] public Boolean IsInactive { get; set;}

        [Column("Email_Address")] public string EmailAddress { get; set;}

        [Column("Phone_Number")] public string PhoneNumber { get; set;}


        [Column("Full_Name")] public string FullName { get; set;}

        [Column("Force_Change_Password")] public Boolean ForceChangePassword { get; set;}

 

        [Column("Prefferred_Language")] public string PrefferredLanguage { get; set;}

        [NotMapped]
        [Column("Time_Stamp")] public Byte[] TimeStamp { get; set; }






        // 1 to many relationship between applicant profiles and security login
        public virtual ICollection<ApplicantProfilePoco>  ApplicantProfiles { get; set; }
        

        //1 to many relatiosnhip between security login  and security login logs 
        public virtual ICollection<SecurityLoginsLogPoco> SecurityLoginsLogs { get; set; }


        //1 to many relationship with Securty login and security login roles 
        public virtual ICollection<SecurityLoginsRolePoco> SecurityLoginsRoles { get; set; }

    }



}

