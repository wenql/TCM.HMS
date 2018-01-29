using System.Data.Common;
using Abp.EntityFramework;
using TCM.HMS.Core.Physique;
using System.Data.Entity;

namespace TCM.HMS.EntityFramework
{
    public class HMSDbContext : AbpDbContext
    {
        //TODO: Define an IDbSet for each Entity...
        public virtual IDbSet<Physique_BootConfig> PhysiqueBoots { get; set; }

        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public HMSDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in HMSDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of HMSDbContext since ABP automatically handles it.
         */
        public HMSDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public HMSDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public HMSDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
