using Abp.AutoMapper;
using Abp.Modules;
using System.Reflection;
using TCM.HMS.Application.Physique.Dto;
using TCM.HMS.Core;
using TCM.HMS.Core.Physique;

namespace TCM.HMS
{
    [DependsOn(typeof(HMSCoreModule), typeof(AbpAutoMapperModule))]
    public class HMSApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                cfg.CreateMap<BootConfigDto, Physique_BootConfig>();
                cfg.CreateMap<Physique_BootConfig, BootConfigDto>();
            });
        }
    }
}
