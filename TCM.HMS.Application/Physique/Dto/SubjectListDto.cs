using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace TCM.HMS.Application.Physique.Dto
{
    public class SubjectListDto : EntityDto<int>
    {
        public string Title { get; set; }

        public string Scores { get; set; }
    }
}
