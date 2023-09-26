using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentForge.DL.Entities;
using TalentForge.DL.Entities.Company_User;
using TalentForge.DL.Entities.Regular_User;

namespace TalentForge.DL.DataContext
{
    public class DatabaseContext : DbContext
    {

        public class OptionsBuild
        {

            public OptionsBuild()
            {
                Settings = new AppConfiguration();
                OpsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
                OpsBuilder.UseSqlServer(Settings.SqlConnString);
                dbContextOptions = OpsBuilder.Options;
            }

            public DbContextOptionsBuilder<DatabaseContext> OpsBuilder { get; set; }

            public DbContextOptions<DatabaseContext> dbContextOptions { get; set; }

            public AppConfiguration Settings { get; set; }

        }

        public static OptionsBuild ops = new OptionsBuild();

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        //dbsets go here

        public DbSet<RegUser> RegUsers {get;set;}
        public DbSet<CompUser> CompUsers {get;set;}
        public DbSet<CVTemplates> CVTemplates {get;set;}
        public DbSet<Jobs> Jobs {get;set;}
        public DbSet<CVs> CreatedCVs {get;set;}
        public DbSet<EmployeeHistory> EmployeeHistories {get;set;}
        public DbSet<HigherEducation> HigherEducations {get;set;}
        public DbSet<JobsApplied> JobsApplied {get;set;}
        public DbSet<SchoolInfo> SchoolInfos {get;set;}
        public DbSet<Skills> RSkills {get;set;}
        public DbSet<Messages> Messages {get;set;}

}
}
