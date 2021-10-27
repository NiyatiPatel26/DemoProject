using DemoProject.EntityData.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Models.DTO.Users
{
    public class UsersDTO
    {
        public long Uid { get; set; }
        public string Uname { get; set; }

        public static UsersDTO MapToDTO(UserInfo userInfo)
        {
            var result = new UsersDTO
            {
                Uid = userInfo.Uid,
                Uname = userInfo.Uname,

            };
            return result;
        }
        

        public static UserInfo MapToEntity(UsersDTO userDTO)
        {
            return new UserInfo
            {
                Uid = (int)userDTO.Uid,
                Uname = userDTO.Uname,
                
            };
        }

    }

}
