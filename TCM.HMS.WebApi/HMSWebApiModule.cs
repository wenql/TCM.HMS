using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using TCM.HMS.Application;

namespace TCM.HMS
{
    [DependsOn(typeof(AbpWebApiModule), typeof(HMSApplicationModule))]
    public class HMSWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(HMSApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
