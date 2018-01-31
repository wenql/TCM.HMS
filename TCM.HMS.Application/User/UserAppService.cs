using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using AutoMapper;
using TCM.HMS.Application.User.Dto;
using TCM.HMS.Core.Physique;

namespace TCM.HMS.Application.User
{
    public class UserAppService : IUserAppService
    {
        private readonly IRepository<Core.User.User> _userRepository;

        public UserAppService(IRepository<Core.User.User> userRepository)
        {
            this._userRepository = userRepository;
        }

        public Core.User.User GetUser(string openId)
        {
            return 
                (from c in this._userRepository.GetAll() select c).FirstOrDefault(x => x.OpenId == openId);
        }

        public Core.User.User GetUser(int id)
        {
            return this._userRepository.Get(id);
        }

        public int SaveUserInfo(Core.User.User model)
        {
            var user = Mapper.Map<Core.User.User>(model);
            if (user.Id == 0)
                user.CreateDate = DateTime.Now;

            return this._userRepository.InsertOrUpdateAndGetId(user);
        }
    }
}
