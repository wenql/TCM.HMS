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
        Core.User.User GetUser(string openId);

        Core.User.User GetUser(int id);

        int SaveUserInfo(Core.User.User model);

        List<UserDto> GetUsers();
    }
}
