using System.Reflection;
using Abp.Modules;

namespace TCM.HMS
{
    [DependsOn(typeof(HMSCoreModule))]
    public class HMSApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
