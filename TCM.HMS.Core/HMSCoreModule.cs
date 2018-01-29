using System.Reflection;
using Abp.Modules;

namespace TCM.HMS.Core
{
    public class HMSCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
