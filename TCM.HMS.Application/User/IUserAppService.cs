using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using TCM.HMS.Application.User.Dto;

namespace TCM.HMS.Application.User
{
    public interface IUserAppService : IApplicationService
    {
        UserDto GetUser(string openId);

        UserDto GetUser(int id);

        int SaveUserInfo(UserDto model);
    }
}
