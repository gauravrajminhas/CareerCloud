using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("Security_Logins_Roles")]
    public class SecurityLoginsRolePoco : IPoco
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("SecurityLogins")]
        public Guid Login { get; set; }

        [ForeignKey("SecurityRoles")]
        public Guid Role { get; set; }

        [NotMapped]
        [Column("Time_Stamp")] public Byte[] TimeStamp { get; set; }

        //1 to many relationship with Securty login and security login roles 
        // <<#doubt>> how to find this out ??? 
        // public virtual SecurityLoginPoco SecurityLogins { get; set; }
        public virtual SecurityLoginPoco SecurityLogins { get; set; }

        //one security login role has many security role
        public virtual SecurityRolePoco SecurityRoles { get; set; }


    }
}
