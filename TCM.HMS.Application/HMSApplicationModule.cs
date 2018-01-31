using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using TCM.HMS.Application.Physique.Dto;
using TCM.HMS.Application.User.Dto;
using TCM.HMS.Core;
using TCM.HMS.Core.Physique;

namespace TCM.HMS.Application
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
                cfg.CreateMap<Physique_Subject, SubjectDto>();
                cfg.CreateMap<SubjectDto, Physique_Subject>();
                cfg.CreateMap<Physique_Subject, SubjectListDto>();
                cfg.CreateMap<DocumentDto, Physique_Document>();
                cfg.CreateMap<Physique_Document, DocumentDto>();

                cfg.CreateMap<Core.User.User, UserDto>().ForMember(x => x.ExamResult, opt => opt.Ignore());
                cfg.CreateMap<UserDto, Core.User.User>().ForMember(x => x.CreateDate, opt => opt.Ignore());
            });
        }
    }
}
