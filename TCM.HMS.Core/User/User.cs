using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace TCM.HMS.Core.User
{
    public class User : Entity
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

        public DateTime CreateDate { get; set; }

        public string PhysiqueScores { get; set; }
    }
}
