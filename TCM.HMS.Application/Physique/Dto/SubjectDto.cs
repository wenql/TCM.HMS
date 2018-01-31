using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using FluentValidation;
using FluentValidation.Attributes;
using TCM.HMS.Core.Helper;
using TCM.HMS.Core.Physique;

namespace TCM.HMS.Application.Physique.Dto
{
    [Validator(typeof(SubjectValidator))]
    [AutoMapFrom(typeof(Physique_Subject)), AutoMapTo(typeof(Physique_Subject))]
    public class SubjectDto : EntityDto<int>
    {
        public int CategoryId { get; set; }

        public string CategoryName => EnumHelper.GetDescription((SubjectCategory) this.CategoryId);

        [DisplayName("标题")] public string Title { get; set; }

        /// <summary>
        /// 分数集合
        /// </summary>
        public string Scores { get; set; }

        /// <summary>
        /// 限定性别
        /// </summary>
        public int OnlySex { get; set; }

        public int Score1 { get; set; }

        public int Score2 { get; set; }

        public int Score3 { get; set; }

        public int Score4 { get; set; }
        public int Score5 { get; set; }
    }

    public class SubjectValidator : AbstractValidator<SubjectDto>
    {
        public SubjectValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("标题不能为空").Length(1, 20).WithMessage("名称不能超过20个字");
            RuleFor(x => x.Score1).NotEmpty().WithMessage("请输入分数");
            RuleFor(x => x.Score2).NotEmpty().WithMessage("请输入分数");
            RuleFor(x => x.Score3).NotEmpty().WithMessage("请输入分数");
            RuleFor(x => x.Score4).NotEmpty().WithMessage("请输入分数");
            RuleFor(x => x.Score5).NotEmpty().WithMessage("请输入分数");
        }
    }
}
