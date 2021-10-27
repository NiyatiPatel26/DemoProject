using DemoProject.DataService;
using DemoProject.Models.DTO.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Manager
{
    public class UserInfoManager
    {
        private readonly UserInfoDataService _userInfoDataService;

        public UserInfoManager(UserInfoDataService userInfoDataService)
        {
            _userInfoDataService = userInfoDataService;
        }

        public async Task<List<UsersDTO>> GetUsers()
        {
            var res = await _userInfoDataService.GetUsers();
            return res
                .Select(x => UsersDTO.MapToDTO(x))
                .ToList();
        }

        public async Task<bool> AddUsers(UsersDTO usersDTO)
        {
            var user = UsersDTO.MapToEntity(usersDTO);
            var res = await _userInfoDataService.AddUsers(user);

            return res;
        }
    }
}
