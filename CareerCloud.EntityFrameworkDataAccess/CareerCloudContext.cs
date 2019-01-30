using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using CareerCloud.Pocos;
namespace CareerCloud.EntityFrameworkDataAccess
{
    class CareerCloudContext :DbContext
    {
        private static String connectionString = ConfigurationManager.ConnectionStrings["myHumberDB"].ConnectionString;

        public CareerCloudContext() :base(connectionString)
        {
            
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

       // public override void OnModelCreating(DbModelBuilder modelBuilder)
        

    }
}
