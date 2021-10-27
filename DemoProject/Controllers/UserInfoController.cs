using DemoProject.Manager;
using DemoProject.Models.DTO.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfoController : Controller
    {
        private readonly UserInfoManager _userInfoManager;

        public UserInfoController(UserInfoManager userInfoManager)
        {
            _userInfoManager = userInfoManager;
        }

        [HttpGet]
        public async Task<List<UsersDTO>> GetUsers()
        {
            var res = await _userInfoManager.GetUsers();
            return res;
        }

        [HttpPut]
        public async Task<bool> AddUsers(UsersDTO usersDTO)
        {
            try
            {
                var res = await _userInfoManager.AddUsers(usersDTO);
                return res;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
