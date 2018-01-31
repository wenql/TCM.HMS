using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using TCM.HMS.Core.Physique;

namespace TCM.HMS.Application.User.Dto
{
    [AutoMapFrom(typeof(Core.User.User)), AutoMapTo(typeof(Core.User.User))]
    public class UserDto : EntityDto<int>
    {
        public string OpenId { get; set; }

        public string NickName { get; set; }

        public string Province { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string HeadImgUrl { get; set; }

        public string UserName { get; set; }

        public int Sex { get; set; }

        public string BirthDay { get; set; }

        public string Mobile { get; set; }

        public string IdCard { get; set; }

        public string PhysiqueScores { get; set; }

        public string ExamResult { get; set; }
    }
}
