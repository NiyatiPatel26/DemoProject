using DemoProject.EntityData;
using DemoProject.EntityData.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.DataService
{
    public class UserInfoDataService
    {
        private readonly DemoContext _demoContext;

        public UserInfoDataService(DemoContext demoContext)
        {
            _demoContext = demoContext;
        }

        public async Task<List<UserInfo>> GetUsers()
        {
            var res = await _demoContext.UserInfos
                .AsNoTracking()
                .ToListAsync();

            return res;
        }

        public async Task<bool> AddUsers(UserInfo users)
        {
            await _demoContext.AddAsync<UserInfo>(users);
            _demoContext.SaveChanges();
            return true;
        }
    }
}
