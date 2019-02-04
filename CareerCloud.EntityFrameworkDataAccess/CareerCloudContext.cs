using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using CareerCloud.Pocos;
namespace CareerCloud.EntityFrameworkDataAccess
{
    class CareerCloudContext :DbContext
    {

        //private static String connectionString = ConfigurationManager.ConnectionStrings["myHumberDB"].ConnectionString;
        //Data Source=LAPTOP-RP1PV1SH\HUMBERBRIDGING;Initial Catalog=JOB_PORTAL_DB;Integrated Security=True
        public CareerCloudContext() :base(@"Data Source=LAPTOP-RP1PV1SH\HUMBERBRIDGING;Initial Catalog=JOB_PORTAL_DB;Integrated Security=True")
        {
            Database.Log = l => System.Diagnostics.Debug.WriteLine(l);

            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            if (type == null)
                throw new Exception("Do not remove, ensures static reference to System.Data.Entity.SqlServer");
        }

        public DbSet ApplicantEducations { get; set; }
        public DbSet ApplicantJobApplications { get; set; }
        public DbSet ApplicantProfiles { get; set; }
        public DbSet ApplicantResumes { get; set; }
        public DbSet ApplicantSkills { get; set; }
        public DbSet ApplicantWorkHistorys { get; set; }

        public DbSet CompanyDescriptions { get; set; }
        public DbSet CompanyJobDescriptions { get; set; }
        public DbSet CompanyJobEducations { get; set; }
        public DbSet CompanyJobs { get; set; }
        public DbSet CompanyJobSkills { get; set; }
        public DbSet CompanyLocations { get; set; }
        public DbSet CompanyProfiles { get; set; }

        public DbSet SecurityLogins { get; set; }
        public DbSet SecurityLoginsLogs { get; set; }
        public DbSet SecurityLoginsRoles { get; set; }
        public DbSet SecurityRoles { get; set; }

        public DbSet SystemCountryCodes { get; set; }
        public DbSet SystemLanguageCodes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //<<#doubt>> After providing annotations why does this still required this defination ?
            modelBuilder.Entity<SystemCountryCodePoco>().ToTable("System_Country_Codes");

          // modelBuilder.Entity<CompanyJobPoco>().HasRequired(p => p.CompanyJobEducations).WithRequiredPrincipal(e =>e.)
        }
        

    }
}
