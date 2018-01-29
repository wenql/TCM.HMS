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
    [Validator(typeof(DocumentValidator))]
    [AutoMapFrom(typeof(Physique_Document)), AutoMapTo(typeof(Physique_Document))]
    public class DocumentDto : EntityDto<int>
    {
        public int CategoryId { get; set; }

        public string CategoryName => EnumHelper.GetDescription((SubjectCategory)this.CategoryId);

        [DisplayName("总体特征")]
        public string Zttz { get; set; }

        [DisplayName("形体特征")]
        public string Xttz { get; set; }

        [DisplayName("常见表现")]
        public string Cjbx { get; set; }

        [DisplayName("心理特征")]
        public string Xltz { get; set; }

        [DisplayName("发病倾向")]
        public string Fbqx { get; set; }

        [DisplayName("对外界环境适应能力")]
        public string Hjsy { get; set; }

        [DisplayName("运动调养")]
        public string Ydty { get; set; }

        [DisplayName("药物调养")]
        public string Ywty { get; set; }

        [DisplayName("调养方法")]
        public string Tyff { get; set; }

        [DisplayName("健康食谱")]
        public string Jksp { get; set; }
    }
    public class DocumentValidator : AbstractValidator<DocumentDto>
    {
        public DocumentValidator()
        {

        }
    }
}
