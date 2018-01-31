using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using System.Web.Mvc;

namespace TCM.HMS.Application.Physique.Dto
{
    public class SubjectListDto : EntityDto<int>
    {
        public int RowIndex { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }

        public string Scores { get; set; }

        public int OnlySex { get; set; }

        public int Score { get; set; }

        public List<SelectListItem> Options { get; set; }

    }
}
