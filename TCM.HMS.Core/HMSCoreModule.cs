using System.Reflection;
using Abp.Modules;

namespace TCM.HMS
{
    public class HMSCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
