using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using FluentValidation;
using FluentValidation.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TCM.HMS.Core.Physique;

namespace TCM.HMS.Application.Physique.Dto
{
    [Validator(typeof(BootConfigValidator))]
    [AutoMapFrom(typeof(Physique_BootConfig)), AutoMapTo(typeof(Physique_BootConfig))]
    public class BootConfigDto : EntityDto<int>
    {
        /// <summary>
        /// 标题
        /// </summary>
        [DisplayName("标题")]
        public string Title { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [DisplayName("内容")]
        public string Content { get; set; }
    }

    public class BootConfigValidator : AbstractValidator<BootConfigDto>
    {
        public BootConfigValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("标题不能为空").Length(1, 20).WithMessage("名称不能超过20个字");
            RuleFor(x => x.Content).NotEmpty().WithMessage("内容不能为空").Length(1, 500).WithMessage("内容不能超过500个字");
        }
    }
}
