using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using TCM.HMS.EntityFramework;

namespace TCM.HMS
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(HMSCoreModule))]
    public class HMSDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<HMSDbContext>(null);
        }
    }
}
