using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCM.HMS.Core.Helper;
using TCM.HMS.Core.Physique;

namespace TCM.HMS.Application.Physique.Dto
{
    public class PhysiqueSubjects
    {
        public int CategoryId { get; set; }

        public string CategoryName => EnumHelper.GetDescription((SubjectCategory)this.CategoryId);

        public List<SubjectListDto> Subjects { get; set; }
    }
}
