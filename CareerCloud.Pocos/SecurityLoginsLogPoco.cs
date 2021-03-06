﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Security_Logins_Log")]
    public class SecurityLoginsLogPoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("SecurityLogins")]
        public Guid Login {get; set;}

        [Column("Source_IP")] public String SourceIP { get; set; }

        [Column("Logon_Date")] public DateTime LogonDate { get; set; }

        [Column("Is_Succesful")] public Boolean IsSuccesful { get; set; }

        //1 to many relatiosnhip between security login  and security login logs 
        public virtual SecurityLoginPoco SecurityLogins { get; set; }

    }
}
